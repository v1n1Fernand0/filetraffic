using FileTraffic.Domain.Entity;
using FileTraffic.Domain.Validation;
using FluentAssertions;

namespace FileTraffic.Domain.Tests
{
    public class ArchiveUnitTest
    {
        [Fact(DisplayName = "Create Archive With Valid State")]
        public void CreateArchive_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Archive(1,"teste.txt", 20000, ".txt");
            action.Should()
                 .NotThrow<FileTraffic.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateArchive_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Archive(-1, "teste.txt", 20000, ".txt");
            action.Should()
                .Throw<FileTraffic.Domain.Validation.DomainExceptionValidation>()
                 .WithMessage("Invalid Id. Id is required");
        }

        [Fact]
        public void CreateArchive_MissingNameValue_DomainExceptionRequiredName()
        {
            Action action = () => new Archive(-1, "", 20000, ".txt");
            action.Should()
                .Throw<FileTraffic.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Name.Name is required");
        }



    }
}