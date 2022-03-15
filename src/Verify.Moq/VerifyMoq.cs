namespace VerifyTests;

public static class VerifyMoq
{
    public static void Enable() =>
        VerifierSettings.ModifySerialization(settings =>
        {
            settings.AddExtraSettings(serializerSettings =>
            {
                var converters = serializerSettings.Converters;
                converters.Add(new InvocationConverter());
                converters.Add(new MockConverter());
            });
        });
}