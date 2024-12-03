namespace prezentyBlok
{
    internal class Program
    {
        static private int zliczaniePietr(string plusyMinusy)
        {
            int pietro = 0;
            foreach(char c in plusyMinusy)
            {
                if (c == '+')
                    pietro++;
                else if (c == '-')
                    pietro--;
            }

            return pietro;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            List<int> wyniki = new List<int>();

            for (int i = 0; i < n; i++) {
                wyniki.Add(zliczaniePietr(Console.ReadLine()));
            }

            for(int i = 0; i < n; i++) {
                Console.WriteLine(wyniki[i]);
            }

        }
    }
}
