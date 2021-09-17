using System;

namespace CsharpAssignment1
{
    class subass1
    {
        static void Main(string[] args)
        {
            int num_of_units;
            double total_sum;
            Console.WriteLine("Number of units::");
            num_of_units = int.Parse(Console.ReadLine());
            if(num_of_units<=100)
            {
                total_sum = num_of_units * 1.20;
            }
            else if(num_of_units>100 && num_of_units<= 300)
            {
                total_sum =120+ (num_of_units-100)*2;
            }
            else
            {
                total_sum = 520+ (num_of_units - 300) * 3;
            }

            Console.WriteLine($"Total amout : {total_sum}");

            


        }
    }
}
