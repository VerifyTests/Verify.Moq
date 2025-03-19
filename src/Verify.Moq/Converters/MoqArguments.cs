namespace VerifyTests;

public class MoqArguments(IReadOnlyDictionary<string, object?> arguments)
{
    public IReadOnlyDictionary<string, object?> Arguments { get; } = arguments;
}