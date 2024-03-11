namespace Estagio_Ribeirao_Preto_2024.Services.Question2
{
    internal class FibonacciService : IFibonacciService
    {
        public bool CheckBelongsToSequence(int number)
        {
            if (number < 0)
                return false;

            int a = 0;
            int b = 1;

            while (b <= number)
            {
                if (b == number)
                    return true;

                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}
