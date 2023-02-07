class MockConverter :
    WriteOnlyJsonConverter<Mock>
{
    public override void Write(VerifyJsonWriter writer, Mock mock) =>
        writer.Serialize(mock.Invocations);
}