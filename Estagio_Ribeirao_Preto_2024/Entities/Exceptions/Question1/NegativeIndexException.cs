using System;

namespace Estagio_Ribeirao_Preto_2024.Entities.Exceptions.Question1
{
    internal class NegativeIndexException : Exception
    {
        public NegativeIndexException(string message) : base(message)
        {
        }

    }
}
