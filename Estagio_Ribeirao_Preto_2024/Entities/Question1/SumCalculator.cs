using Estagio_Ribeirao_Preto_2024.Entities.Exceptions.Question1;
using System;

namespace Estagio_Ribeirao_Preto_2024.Entities.Question1
{
    internal class SumCalculator
    {
        public int Index { get; set; }
        public double Sum { get; set; }
        public int K { get; set; }

        public SumCalculator(int index, double sum, int k)
        {
            Index = index;
            Sum = sum;
            K = k;
        }

        public double SumValue(int index)
        {
            if (index < 0)
            {
                throw new NegativeIndexException("Index must be a non-negative integer.");
            }

            while (K < index)
            {
                K++;
                Sum += K;
            }

            return Sum;
        }

        public override string ToString()
        {
            return "The value of the sum variable is equal to "
                + Sum;
        }
    }
}
