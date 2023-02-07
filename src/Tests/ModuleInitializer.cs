public static class ModuleInitializer
{
    #region Enable

    [ModuleInitializer]
    public static void Init() =>
        VerifyMoq.Initialize();

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifierSettings.InitializePlugins();
}