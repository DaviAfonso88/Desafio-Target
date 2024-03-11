namespace Estagio_Ribeirao_Preto_2024.Entities.Question5
{
    internal class StringReverse
    {
        public string Input { get; set; }
        public string ReversedString { get; set; }

        public StringReverse(string input, string reversedString)
        {
            Input = input;
            ReversedString = reversedString;
        }

        public override string ToString()
        {
            return "The inverse of "
                + Input 
                + " => "
                + ReversedString;
        }
    }
}
