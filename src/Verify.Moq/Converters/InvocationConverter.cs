using Moq;

class InvocationConverter :
    WriteOnlyJsonConverter<IInvocation>
{
    public override void Write(VerifyJsonWriter writer, IInvocation invocation)
    {
        writer.WriteStartObject();
        writer.WriteMember(invocation, invocation.Method, "Method");
        writer.WriteMember(invocation, invocation.Arguments, "Arguments");
        writer.WriteMember(invocation, invocation.ReturnValue, "ReturnValue");
        writer.WriteMember(invocation, invocation.Exception, "Exception");
        writer.WriteEndObject();
    }
}