using System;

namespace FibonacciKata
{
    public class Fibonacci
    {
        public int ValueOf(int position)
        {

            var arrayLength = position + 1;
            var fibonacciArray = new int[arrayLength]; 

            int fibonacciArrayPosition;

            for ( fibonacciArrayPosition = 0; fibonacciArrayPosition < fibonacciArray.Length; fibonacciArrayPosition++)
            {
                switch (fibonacciArrayPosition)
                {
                    case 0:
                        fibonacciArray[0] = 0;
                        continue;
                    case 1:
                        fibonacciArray[1] = 1;
                        continue;
                }

                var fibonacciArrayPositionMinus2 = fibonacciArrayPosition - 2;
                var fibonacciArrayPositionMinus1 = fibonacciArrayPosition - 1;

                var valueOfPosition = fibonacciArray[fibonacciArrayPositionMinus2] + fibonacciArray[fibonacciArrayPositionMinus1];

                fibonacciArray[fibonacciArrayPosition] = valueOfPosition;


            }

            return fibonacciArray[position];

        }

        
    }

    
}
