using System;
using System.Text;

namespace Estagio_Ribeirao_Preto_2024.Services.Question5
{
    internal class StringReverserService : IStringReverser
    {
        public string ReverseString(string input)
        {
            // Check for null input
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Input string cannot be null.");
            }

            char[] charArray = input.ToCharArray();
            StringBuilder reverseBuilder = new StringBuilder(input.Length);



            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reverseBuilder.Append(charArray[i]);

            }

            // Convert StringBuilder to string
            return reverseBuilder.ToString();

        }
    }
}
