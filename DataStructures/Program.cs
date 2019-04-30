using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please array the Data Structure type to Execute:");
            var DsType = Console.ReadLine();
            switch (DsType.ToLower())
            {
                case "arrays":
                    Console.WriteLine("Selected Type:" + DsType);
                    var arrayObj = new Arrays();
                    arrayObj.printOneDimensionalIntegerArray();
                    arrayObj.printOneDimensionalStringArray();
                    arrayObj.MultiDimensionalArray();
                    arrayObj.JaggedArray();
                    break;
                default:
                    Console.WriteLine("Nothing Selected");
                    break;
            }
        }
    }
}
