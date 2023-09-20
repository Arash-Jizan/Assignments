
using System;
using System.Diagnostics;       //for the stopwatch function
//.net build        builds the code without running it
class Program
{
    static void Main()
    {
       
        int n = 800000;
        double[,] numbers;                          //comas are how you make 2D arrays
        int[,]  AdditionalNumbers;                         //ADDED WORK FOR ASSIGNMENT (int version of numbers)
        Stopwatch timer = new Stopwatch();          //class name then object name = a new function thats called stopwatch with nothing in it

        numbers = GenerateRandomNumbers(n);
        AdditionalNumbers = GenerateRandomNumbersForInt(n);

        timer.Start();                              //starts the stopwatch
        AddNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Additions");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms   " + timer.ElapsedTicks + "  ticks\n");           //timer.Elapsed desplays the stopwatch data, the miliseconds is just a description
        float addTicks  =(float)timer.ElapsedTicks;        //this is how you cast, aka change variable types 

        timer.Restart();
        MultiplyNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Multiplications");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms   " + timer.ElapsedTicks + "  ticks\n");
        float multTicks = (float)timer.ElapsedTicks;

        Console.WriteLine("Ratio = " + addTicks/multTicks);
        Console.WriteLine("\n \n");

                                //  /   /   /   /ADDED WORK FOR ASSIGNMENT


        timer.Start();                              //starts the stopwatch
        AddIntegerNumbers(AdditionalNumbers, n);
        timer.Stop();
        Console.WriteLine("Additions with integers");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms   " + timer.ElapsedTicks + "  ticks\n");           //timer.Elapsed desplays the stopwatch data, the miliseconds is just a description
        float addIntTicks  =(float)timer.ElapsedTicks;        //this is how you cast, aka change variable types 

        timer.Restart();
        MultiplyIntegerNumbers(AdditionalNumbers, n);
        timer.Stop();
        Console.WriteLine("Multiplications with integers");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms   " + timer.ElapsedTicks + "  ticks\n");
        float multIntTicks = (float)timer.ElapsedTicks;

        Console.WriteLine("Ratio = " + addIntTicks/multIntTicks);
        Console.WriteLine("\n \n");







        timer.Start();                              //starts the stopwatch
        PowerDoubleNumbers(numbers, n);
        timer.Stop();
        Console.WriteLine("Math.pow function used to raise a number");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms   " + timer.ElapsedTicks + "  ticks\n");           //timer.Elapsed desplays the stopwatch data, the miliseconds is just a description
        float PowerFunctionTicks  =(float)timer.ElapsedTicks;        //this is how you cast, aka change variable types 

        timer.Restart();
        PowerDoubleNumbersWithoutMathFunction(numbers, n);
        timer.Stop();
        Console.WriteLine("MAth.pow function not used to raise a number");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms   " + timer.ElapsedTicks + "  ticks\n");
        float PowerTicks = (float)timer.ElapsedTicks;

        Console.WriteLine("Ratio = " + PowerTicks/PowerFunctionTicks);
        Console.WriteLine("\n \n");




                                //  /   /   /   /   /   /   /   /   /   /   /



    }   








     
    
       static double[,] GenerateRandomNumbers(int count)
    {
        
        Random rand = new Random();
        double[,] num = new double[count,3];

        for(int i=0;i<count; ++i)
        {
           num[i,0] = 10000.0*rand.NextDouble();
           num[i,1] = 10000.0*rand.NextDouble();
        }

        return num;
    }
    
                                        ////////// ADDED WORK FOR ASSIGNMENT



    static int[,] GenerateRandomNumbersForInt(int count)
    {
        
        Random rand = new Random();
        int [,] integernumber = new int[count,3];

        for(int i=0;i<count; ++i)
        {
           integernumber[i,0] = rand.Next();
           integernumber[i,1] = rand.Next();
        }

        return integernumber;
    }


                                    //    /   /   /   /   /   /   /   /   /   /   /   /   END OF WORK










    static void AddNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0;i<count;++i)
        {
            nums[i,2] = nums[i,0] +nums[i,1];
        }
    }

    static void MultiplyNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0;i<count;++i)
        {
            nums[i,2] = nums[i,0] * nums[i,1];
        }
    }

                                //  /   /   /   /   /   /   /   ADDED WORK FOR ASSIGNMENT
    static void AddIntegerNumbers(int[,] AdditionalNumbers, int count)
    {
        int i;
        for(i=0;i<count;++i)
        {
            AdditionalNumbers[i,2] = AdditionalNumbers[i,0] + AdditionalNumbers[i,1];
        }
    }

    static void MultiplyIntegerNumbers(int[,] AdditionalNumbers, int count)
    {
        int i;
        for(i=0;i<count;++i)
        {
            AdditionalNumbers[i,2] = AdditionalNumbers[i,0] * AdditionalNumbers[i,1];
        }
    }

    static void PowerDoubleNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0;i<count;++i)
        {
            nums[i,2] = Math.Pow(nums[i,0], nums[i,1]);
        }
    }

    static void PowerDoubleNumbersWithoutMathFunction(double[,] nums, int count)
    {
        int i;
        double b;
        for(i=0;i<count;++i)
        {
            for(b=0;b<nums[i,1];++b)
            {
            nums[i,2] *= nums[i,0];
            }
        }
    }

}


