using System;

namespace tpzslaba5_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate A = new Calculate();
            Console.Write("Результат действия = ");
            Console.WriteLine(A.Multiplication(4, 5, "+"));
            Console.ReadKey();
        }
    }

    class Calculate
    {
        private int a;
        private int b;
        public int Multiplication( int n, int m, string s)
        {
            this.a = n;
            this.b = m;
            switch (s)
            {
                case "+": return n + m;
                case "-": return n - m;
                case "*": return n * m;
                case "/": return n / m;

            }
            return 0;
        }
    }
}
