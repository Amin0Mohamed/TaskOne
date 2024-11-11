namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Task one =========");
            Console.WriteLine("Estimate for carpet cleaning service");

            Console.Write("Number of small carpets:");
            int small = int.Parse(Console.ReadLine());
            Console.Write("Number of large carpets:");
            //int large = int.Parse(Console.ReadLine());
            int large = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small room : $25");
            Console.WriteLine("Price per large room : $35");
           
             // start arithmetic operations
            double PriceOfSmall = small * 25;
            double PriceOfLarge = large * 35;
            double cost = PriceOfSmall + PriceOfLarge;
            double total = cost + (cost * 0.06);
            // end arithmetic operations
            Console.WriteLine($"Cost is : {cost:C}");
            Console.WriteLine($"tax rate is 6% : {cost*0.06:C}");
            Console.WriteLine("=========================================");
            Console.WriteLine($"Total estimate : {total:C}");
            Console.WriteLine($"This estimate is valid for 30 days");

            Console.ReadLine();

        }
    }
}
