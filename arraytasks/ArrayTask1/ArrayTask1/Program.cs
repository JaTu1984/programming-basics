using System;
using System.Globalization;

namespace ArrayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("sv-SV");
            CultureInfo.CurrentCulture = culture;
            Console.WriteLine(DateTime.Now);

            culture = new CultureInfo("fi-FI");
            CultureInfo.CurrentCulture = culture;
            Console.WriteLine(DateTime.Now);

            culture = new CultureInfo("us-US");
            CultureInfo.CurrentCulture = culture;
            Console.WriteLine(DateTime.Now);

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hinnasto");
            
            

            decimal[] productPrice = new decimal[] { 7.96m, 72.0m, 99.90m };
            int[] productAmount = new int[] {1,3,2};
            decimal[] productTotalPrice = new decimal[3];

            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                productTotalPrice[i] = productAmount[i] * productPrice[i];
                Console.WriteLine($"Tuote {i + 1}. {productTotalPrice[i]:c}");
            }
        }
    }
}
