using Moq;

class InvocationConverter :
    WriteOnlyJsonConverter<IInvocation>
{
    public override void Write(VerifyJsonWriter writer, IInvocation invocation)
    {
        writer.WriteStartObject();
        writer.WriteProperty(invocation, invocation.Method, "Method");
        writer.WriteProperty(invocation, invocation.Arguments, "Arguments");
        writer.WriteProperty(invocation, invocation.ReturnValue, "ReturnValue");
        writer.WriteProperty(invocation, invocation.Exception, "Exception");
        writer.WriteEndObject();
    }
}