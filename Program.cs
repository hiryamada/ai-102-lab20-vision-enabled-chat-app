#pragma warning disable SKEXP0070

using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

IKernelBuilder kernelBuilder = Kernel.CreateBuilder();
kernelBuilder.AddAzureAIInferenceChatCompletion(    
    modelId: Environment.GetEnvironmentVariable("AI_DEPLOY_NAME") ?? "",
    apiKey: Environment.GetEnvironmentVariable("AI_KEY") ?? "",
    endpoint: new Uri(Environment.GetEnvironmentVariable("AI_ENDPOINT") ?? "")
);
Kernel kernel = kernelBuilder.Build();
byte[] image = File.ReadAllBytes("mystery-fruit.jpeg");
ChatHistory chatHistory = [];
chatHistory.AddUserMessage([
	new ImageContent(image, "image/jpeg"),
	new TextContent("Can you describe this image?")
]);

var chatCompletion = kernel.GetRequiredService<IChatCompletionService>();
var result = await chatCompletion.GetChatMessageContentAsync(chatHistory);
Console.WriteLine(result);
