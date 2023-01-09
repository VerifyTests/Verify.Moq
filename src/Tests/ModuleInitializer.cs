public static class ModuleInitializer
{
    #region Enable

    [ModuleInitializer]
    public static void Init() =>
        VerifyMoq.Enable();

    #endregion

    [ModuleInitializer]
    public static void InitOther() =>
        VerifyDiffPlex.Initialize();
}