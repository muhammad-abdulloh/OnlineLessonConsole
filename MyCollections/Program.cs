namespace MyCollections
{
    internal class Program
    {
        public delegate void MyDelegate(int x);       

        public static void Main(string[] args)
        {

            // native delegate with anonym method
            MyDelegate del2 = delegate (int z)
            {
                // logic section
                Console.WriteLine("Delegate ishlavotti");
                Console.WriteLine("davay davay");
            };

            del2(45);

            // func with anonym method
            Func<int, double> myDel = delegate (int number)
            {
                Console.WriteLine("Func sihlavotti");
                return number * number;
            };

            double value = myDel(5);
            Console.WriteLine(value);

            // Action with Anonym method
            Action<string, int> myAct = delegate (string x, int z)
            {
                Console.WriteLine("Action Ishlavotti");
                Console.WriteLine(x + " " + z);
            };

            myAct("Imtihonga shuncha bor kun ", 4);

            // Predicate with anonym method
            Predicate<int> myPredicate = delegate (int number)
            {
                Console.WriteLine("Predicate ishlavotti");
                return true;
            };

            Console.WriteLine(myPredicate.Invoke(3));

        }

        public static bool IsOdd(int x)
        {
            // Trusy, Falsy
            // 0, null, undefined
            return x % 2 == 1 ? true : false;
        }
    }
}
