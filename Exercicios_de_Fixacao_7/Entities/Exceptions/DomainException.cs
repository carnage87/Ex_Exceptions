using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_de_Fixacao_7.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
