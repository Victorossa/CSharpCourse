using System;
namespace C3_BuildInTypesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
            Console.WriteLine("Min = {0}", float.MinValue);
            Console.WriteLine("Max = {0}", float.MaxValue);
            
            string Name = "One\nTwo\nThree";
            Console.WriteLine(Name);


            bool? aaa = null;
            if (aaa == true)
            {

            }
            else if (!aaa.Value)
            {

            }


            Console.ReadLine();
        }
    }
}
