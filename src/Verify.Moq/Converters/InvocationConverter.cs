class InvocationConverter :
    WriteOnlyJsonConverter<IInvocation>
{
    public override void Write(VerifyJsonWriter writer, IInvocation invocation)
    {
        writer.WriteStartObject();
        writer.WriteMember(invocation, invocation.Method, "Method");
        var parameters = invocation.Method.GetParameters();
        var arguments = new Dictionary<string, object?>(parameters.Length);
        for (var index = 0; index < parameters.Length; index++)
        {
            var parameter = parameters[index];
            arguments.Add(parameter.Name!, invocation.Arguments[index]);
        }

        writer.WriteMember(invocation, new MoqArguments(arguments), "Arguments");
        writer.WriteMember(invocation, invocation.ReturnValue, "ReturnValue");
        writer.WriteMember(invocation, invocation.Exception, "Exception");
        writer.WriteEndObject();
    }
}