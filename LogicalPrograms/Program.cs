namespace LogicalPrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            int Problem = Convert.ToInt32(Console.ReadLine());

            switch(Problem)
            {
                case 1:
                    FibonacciSeries obj = new FibonacciSeries();
                    obj.Fibonacci();
                    break;
                case 2:
                    PrimeNumber primenum = new PrimeNumber();
                        primenum.Prime();
                    break;
                case 3:
                   ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.Calculation();
                    break;
                case 4:
                    simulateStopwatch simulateStopwatch = new simulateStopwatch();
                    simulateStopwatch.Calculate();
                    break;


            }
        }
    }
}
