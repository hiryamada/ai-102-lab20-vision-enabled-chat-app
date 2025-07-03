# AI-102 ラボ15

## 概要

- サンプルの画像ファイル [mystery-fruit.jpeg](mystery-fruit.jpeg) を生成AIモデルに送信し、画像を伴う質問を行う。
  - なおこの画像は [ドラゴンフルーツ](https://ja.wikipedia.org/wiki/%E3%83%89%E3%83%A9%E3%82%B4%E3%83%B3%E3%83%95%E3%83%AB%E3%83%BC%E3%83%84) の写真。
- 生成AIとして マイクロソフトの`Phi-4-multimodal-instruct`を使用。このモデルはマルチモーダルモデルでありテキストだけではなく画像などのデータを入力することができる
- Chat Completion APIに、テキストに加えて画像も送る。
- ChatGPTなどのチャットで、画像ファイルをアップロードして「この画像について説明して」といった指示をするのに相当

## 手順

- ラボ20を起動
- ターミナルを開き、本リポジトリを git clone
- .NET SDK 10 インストール https://dotnet.microsoft.com/ja-jp/download/dotnet/10.0
- VSCode インストール  https://code.visualstudio.com/
- Azure AI Foundryにサインイン、プロジェクトを作成、`Phi-4-multimodal-instruct`をデプロイ。
- 以下の環境変数をセット
  - `AI_DEPLOY_NAME` : モデルID（デプロイ名）、例: `Phi-4-multimodal-instruct`
  - `AI_ENDPOINT` エンドポイント、例: `https://project52667194-resource.services.ai.azure.com/models` 末尾に models が付く点に注意
    - Chat Playground の「View code」で確認できる
  - `AI_KEY`: キー（キー1）
    - Chat Playground の「View code」で確認できる
- クローンしたフォルダをVSCodeで開く
- VSCode内のターミナルで `Get-ChildItem Env:` を実行し、環境変数が読み取れるかを確認。
- VSCode内のターミナルで `dotnet run`

## 実行結果例

以下のような応答が得られる（応答は毎回変わる）

```
This is an image of a dragon fruit.
The fruit has a vibrant pink interior with black and white seeds, and it also has green patches with green tendrils extending from the skin.
The skin is rough and has a glossy appearance.
```

参考訳
```
これはドラゴンフルーツの画像です。
果実は鮮やかなピンク色で、黒と白の種子が入っています。また、皮からは緑色の巻きひげが伸び、緑色の斑点も見られます。
皮はざらざらしていて、光沢のある外観です。
```

## 参考

オリジナルのラボ手順書

https://microsoftlearning.github.io/mslearn-ai-language/Instructions/Labs/09-audio-chat.html
