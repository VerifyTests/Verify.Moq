using Moq;

[UsesVerify]
public class Tests
{
    #region ReceivedCalls

    [Fact]
    public Task Test()
    {
        var mock = new Mock<ITarget>();

        mock.Setup(library => library.Method(1,2))
            .Returns("response");

        var target = mock.Object;
        target.Method(1, 2);
        return Verify(mock);
    }

    #endregion
}