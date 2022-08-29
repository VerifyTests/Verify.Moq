public static class ModuleInitializer
{
    #region Enable

    [ModuleInitializer]
    public static void Init()
    {
        VerifyMoq.Enable();

        #endregion

        VerifyDiffPlex.Initialize();
    }
}