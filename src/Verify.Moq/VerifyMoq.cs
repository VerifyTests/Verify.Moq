namespace VerifyTests;

public static class VerifyMoq
{
    public static void Enable()
    {
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