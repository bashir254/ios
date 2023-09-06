platform :ios do

  lane :setup do
    setup_project
  end

  private_lane :setup_project do
    create_keychain(
      name: "actiontest_keychain",
      password: "meow",
      default_keychain: true,
      unlock: true,
      timeout: 3600,
      lock_when_sleeps: false
    )
  end

  lane :build do
    cert(
      development: "iPhone Developer: mohamed bashir (M6XQ2Z2NSJ)", # 開発用証明書名を指定
      production: "iPhone Distribution: Your Company (2DF4733AY8)" # プロダクション用証明書名を指定
    )

    sigh(
      adhoc: true, # もしくは:adhoc
      app_identifier: "com.companyname.youkoso",
      username: "mham@codeuniverse.net" # Apple Developerアカウントのユーザー名を指定
    )

    match(
      type: "appstore",
      readonly: is_ci,
      keychain_name: "actiontest_keychain",
      keychain_password: "meow"
    )

    update_project_provisioning(
      xcodeproj: ENV["XCODE_PROJ"],
      profile: ENV["sigh_com.redspace.actionstest_appstore_profile-path"],
      target_filter: "actionstest",
      build_configuration: "Release",
      code_signing_identity: "iPhone Distribution: REDspace Inc."
    )

    build_app(
      scheme: "actionstest",
      project: ENV["XCODE_PROJ"]
    )
  end

  lane :hockey_upload do
    hockey(
      api_token: ENV["HOCKEY_TOKEN"],
      create_status: "2",
      ipa: "actionstest.ipa",
      notes: ENV["RELEASENOTES"]
    )
  end
end
