[TestFixture]
public class Tests
{
    #region ReceivedCalls

    [Test]
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

    #region ScrubArguments

    [Test]
    public Task ScrubArguments()
    {
        var mock = new Mock<ITarget>();

        mock.Setup(_ => _.Method(It.IsAny<int>(), It.IsAny<int>()))
            .Returns("response");

        var target = mock.Object;
        target.Method(1, 2);
        return Verify(mock)
            .ScrubMember("a");
    }

    #endregion
}