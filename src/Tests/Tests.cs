using Moq;

[UsesVerify]
public class Tests
{
    #region ReceivedCalls

    [Fact]
    public Task Test()
    {
        var mock = new Mock<ITarget>();

        mock.Setup(_ => _.Method(It.IsAny<int>(), It.IsAny<int>()))
            .Returns("response");

        var target = mock.Object;
        target.Method(1, 2);
        return Verify(mock);
    }

    #endregion
}