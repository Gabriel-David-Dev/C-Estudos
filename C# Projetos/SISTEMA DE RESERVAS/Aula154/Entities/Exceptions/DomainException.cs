using System;

namespace Aula154.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
