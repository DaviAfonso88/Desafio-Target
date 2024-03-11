namespace Estagio_Ribeirao_Preto_2024.Entities.Question2
{
    internal class Fibonacci
    {
        public int Number { get; set; }
        public bool Belongs { get; set; }

        public Fibonacci(int number, bool belongs)
        {
            Number = number;
            Belongs = belongs;
        }
    }

}
