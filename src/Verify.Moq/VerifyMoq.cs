namespace VerifyTests;

public static class VerifyMoq
{
    public static bool Initialized {get; private set; }

    [Obsolete("Use Initialize()")]
    public static void Enable() =>
        Initialize();

    public static void Initialize()
    {
        if (Initialized)
        {
            throw new("Already Initialized");
        }

        Initialized = true;

        InnerVerifier.ThrowIfVerifyHasBeenRun();
        VerifierSettings
            .AddExtraSettings(settings =>
            {
                var converters = settings.Converters;
                converters.Add(new InvocationConverter());
                converters.Add(new MockConverter());
            });
    }
}