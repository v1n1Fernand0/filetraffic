using FileTraffic.Domain.Entity;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTraffic.Domain.Tests
{
    public class SystemReferenceTests
    {
        [Fact(DisplayName = "Create SystemReference With Valid State")]
        public void CreateSystemReference_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Folder(1,"FileTraffic");
            action.Should()
                 .NotThrow<FileTraffic.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create SystemReference With Missing Id")]
        public void CreateSystemReference_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Folder(-1, "FileTraffic");
            action.Should()
                 .Throw<FileTraffic.Domain.Validation.DomainExceptionValidation>()
                 .WithMessage("Invalid Id. id is required");
                 ;
        }

        [Fact(DisplayName = "Create SystemReference With Invalid Name")]
        public void CreateSystemReference_WithInvalidName_ResultObjectValidState()
        {
            Action action = () => new Folder(1, "");
            action.Should()
                 .Throw<FileTraffic.Domain.Validation.DomainExceptionValidation>()
                 .WithMessage("Invalid Name. name is required");
            ;
        }

    }
}
