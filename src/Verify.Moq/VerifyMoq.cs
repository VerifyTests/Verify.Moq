namespace VerifyTests;

public static class VerifyMoq
{
    public static void Enable() =>
        VerifierSettings
            .AddExtraSettings(settings =>
            {
                var converters = settings.Converters;
                converters.Add(new InvocationConverter());
                converters.Add(new MockConverter());
            });
}