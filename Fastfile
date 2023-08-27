default_platform(:ios)

lane :upload_to_app_store do
  gym(
    scheme: "com.companyname.youkoso",
    export_method: "app-store"
  )
  deliver(
    username: ENV["APPLE_ID"],
    app_identifier: "com.companyname.youkoso",
    ipa: "./bin/publish/youkoso.dll"
  )
end
