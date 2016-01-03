using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ReverseConsole.Common;
using ReverseConsole.Core;

namespace ReverseConsole.Test
{
    [TestFixture]
    public class ReferseServiceTest
    {
        private IReverseService _sut;

        [SetUp]
        public void TestSetup()
        {
            _sut = new ReverseService();
        }

        [Test]
        public void Reverse_WhenNameIsGiven_ThenTheNameShouldBeReversed()
        {
            _sut.Reverse("david").Should().Be("divad");
        }

        [Test]
        public void Reverse_WhenPalindromIsGiven_ThenNothingShouldChange()
        {
            _sut.Reverse("tacocat").Should().Be("tacocat");
        }

        [Test]
        public void Reverse_WhenStringHasUpperCaseLetters_TheyShouldBeMentionedInResult()
        {
            _sut.Reverse("Tacocat").Should().Be("tacocaT");
        }
    }
}
