# <img src="/src/icon.png" height="30px"> Verify.Moq

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/07apa0wm0lxulr5o?svg=true)](https://ci.appveyor.com/project/SimonCropp/Verify-Moq)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.Moq.svg)](https://www.nuget.org/packages/Verify.Moq/)

Adds [Verify](https://github.com/VerifyTests/Verify) support for verifying [Moq](https://github.com/moq/moq4) types.

**See [Milestones](../../milestones?state=closed) for release notes.**


## NuGet package

https://nuget.org/packages/Verify.Moq/


## Usage

<!-- snippet: Enable -->
<a id='snippet-enable'></a>
```cs
[ModuleInitializer]
public static void Init() =>
    VerifyMoq.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L3-L9' title='Snippet source file'>snippet source</a> | <a href='#snippet-enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Given an interface:

<!-- snippet: ITarget.cs -->
<a id='snippet-ITarget.cs'></a>
```cs
public interface ITarget
{
    string Method(int a, int b);
}
```
<sup><a href='/src/Tests/ITarget.cs#L1-L4' title='Snippet source file'>snippet source</a> | <a href='#snippet-ITarget.cs' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

The Mock and its invocations can then be verified:

<!-- snippet: ReceivedCalls -->
<a id='snippet-receivedcalls'></a>
```cs
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
```
<sup><a href='/src/Tests/Tests.cs#L5-L20' title='Snippet source file'>snippet source</a> | <a href='#snippet-receivedcalls' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Will result in:

<!-- snippet: Tests.Test.verified.txt -->
<a id='snippet-Tests.Test.verified.txt'></a>
```txt
[
  {
    Method: ITarget.Method(int a, int b),
    Arguments: [
      1,
      2
    ],
    ReturnValue: response
  }
]
```
<sup><a href='/src/Tests/Tests.Test.verified.txt#L1-L10' title='Snippet source file'>snippet source</a> | <a href='#snippet-Tests.Test.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
