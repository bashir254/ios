# Fastlaneの基本設定
default_platform(:ios)

# ビルド設定
platform :ios do
  lane :build_and_upload do
    # ここにビルド前の前処理を追加できます

    # Xcodeプロジェクトのパス
    project = "youkoso.xcodeproj"

    # ターゲット名とスキーマ名
    target = "youkoso"
    scheme = "youkoso"

    # ビルド
    build_app(
      workspace: project,
      scheme: scheme,
      export_method: "app-store", # ディストリビューション方法を指定
      export_options: { 
        method: "app-store",
        uploadBitcode: true,
        uploadSymbols: true
      }
    )

    # App Store Connectにアップロード
    upload_to_app_store(
      skip_waiting_for_build_processing: true, # ビルド処理が完了するまで待たない
      username: ENV["FASTLANE_USERNAME"],     # 環境変数からApple IDを取得
      app_identifier: "com.example.youkoso",  # アプリのバンドルIDを指定
      team_id: "YOUR_TEAM_ID",                # 開発チームのIDを指定
      skip_binary_upload: true                # バイナリのアップロードをスキップ（ipaファイルは手動で用意する場合）
    )
  end
end
