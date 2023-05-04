using FluentAssertions;
using MySocialSelf.API.Models;

namespace MySocialSelf.Tests;

public class ContactTests
{
    [Fact]
    public void Constructor_GivenBlankParams_CreatesInstance()
    {
        
        var sut = new Contact();

        sut.Should().BeOfType<Contact>();

    }
}