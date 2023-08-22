using FluentValidation;
using FluentValidation.Results;
using System;

namespace Lms.Application.Exceptions
{
    public class CustomValidationException : Exception
    {
        public CustomValidationException() { }

        public CustomValidationException(string ex) : base(ex)
        {

        }
        public CustomValidationException(Exception ex) : base(ex.Message)
        {

        }
        public CustomValidationException(ValidationException ex) : base(ex.ToString())
        {

        }
        public CustomValidationException(ValidationResult ex) : base(ex.ToString())
        {

        }
    }

    public class InfoException : Exception
    {
        public InfoException() { }

        public InfoException(string ex) : base(ex)
        {

        }
        public InfoException(Exception ex) : base(ex.Message)
        {

        }
    }

    public class WarningException : Exception
    {
        public WarningException() { }

        public WarningException(string ex) : base(ex)
        {

        }
        public WarningException(Exception ex) : base(ex.Message)
        {

        }
    }

    public class CriticalException : Exception
    {
        public CriticalException() { }

        public CriticalException(string ex) : base(ex)
        {

        }
        public CriticalException(Exception ex) : base(ex.Message)
        {

        }
    }
}
