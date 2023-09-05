fastlane_version "2.195.0"

default_platform :ios

platform :ios do
  lane :build_and_deploy do
    # Enable interactive mode
    opt_out_usage

    create_keychain(
      name: "actiontest_keychain",
      password: "meow",
      default_keychain: true,
      unlock: true,
      timeout: 3600,
      lock_when_sleeps: false
    )

    # ビルド
    gym(
  project: "youkoso.csproj",
      scheme: "com.companyname.youkoso",
      configuration: "Release",
      export_method: "app-store"   # エクスポート方法を指定
    )

    # 証明書の取得
    match(
      type: "appstore",            # 使用する証明書のタイプを指定
      readonly: is_ci,
      keychain_name: "actiontest_keychain",
      keychain_password: "meow"
    )

    # デプロイ
    hockey(
      api_token: ENV["HOCKEY_TOKEN"],  # HockeyAppのAPIトークン
      create_status: "2",             # HockeyAppで使用するステータスを指定
      ipa: "./path/to/youkoso.ipa",   # IPAファイルのパスを指定
      notes: ENV["RELEASENOTES"]       # リリースノート
    )
  end
end
