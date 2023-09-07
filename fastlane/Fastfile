default_platform(:ios)

platform :ios do
  lane :create_and_unlock_keychain do
    create_keychain(
      name: "MyKeychain", # キーチェーンの名前を指定
      password: "MyPassword", # キーチェーンのパスワードを指定
      default_keychain: true,
      unlock: true,
      timeout: 3600,
      lock_when_sleeps: false
    )
  end
end
