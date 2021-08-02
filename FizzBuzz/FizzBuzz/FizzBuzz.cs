using System;

namespace FizzBuzzMain
{
    public class FizzBuzz
    {
        private int n;
        private bool pf;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool init(int n_in)
        {
            n = n_in;
            pf = false;
            if (n_in > 0)
            {
                pf = true;
            }
            return pf;
        }

        public string[] run() 
        {
            if (!pf)
            {
                throw new Exception();
            }

            var result = new string[n];
            for (int i = 0; i < n; i++)
            {
                var value = i + 1;
                result[i] = (value).ToString();
                if ( (value % 3) == 0)
                {
                    result[i] = "Fizz";
                }
                // if (i % 5)
            }
            //result[0] = "1";

            return result;
        }
    }
}
