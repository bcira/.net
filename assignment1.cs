using System;

namespace ConsoleApp4
{
    internal class Program //finding min,max,sum,average values of an array using for loop
    {
        static void Main(string[] args)
        {
            int[] numbers = {15,21,55,11,23};

            int MaxNum = numbers[0];
            int MinNum = numbers[1];
            int sum=0;
            int average=0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > MaxNum)
                {
                    MaxNum = numbers[i];
                }
            }

            Console.WriteLine("the max value is: " + MaxNum);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < MinNum)
                {
                    MinNum = numbers[i];
                }
                    

            }
            Console.WriteLine("the min value is:" + MinNum);

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];   
            }
            Console.WriteLine("the sum of the values is: " +sum);

            for (int i = 0; i < numbers.Length; i++)
            {
                average = sum / numbers.Length;
                       
            }
            Console.WriteLine("the average of the array is: " + average);
        }
    }
}
