using System;

namespace Bank_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Profit(10, 5);
            CostPrice(500, 10);
            DepreciationValue(100, 0.55, 2);
            Console.Read();
        }
        public static int Profit (int sales,int cost)
        {
            return sales - cost;
        }
        public static int CostPrice (int sellingPrice, int loss)
        {
            return sellingPrice + loss;
        }
        public static double DepreciationValue (int initVal, double interest, int years)
        {
            return initVal*(1+ interest)*years;
        }
    }
}
