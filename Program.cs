using System;
namespace PracticeCsharp
{
    //class trial
    //{
    //     static void Main(string[] args)
    //    {
    //        Console.WriteLine(  "Hello World");
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] a)
    //    {
    //        Console.Write("Enter number:");
    //        int num =Int32.Parse(Console.ReadLine());
            
    //        if (num % 2 == 0)
    //        {
    //            Console.WriteLine("Enter number is even");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Enter number is odd");
    //        }
            
    //    }
    //}


    //class test
    //{
    //    static void Main (string[] args)
    //    {
    //        Console.WriteLine("Enter number:");
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        int store=1;
    //        for (int i = 2; i<=num/2; i++)
    //        {
    //            if(num%2==0)
    //            store =0;
    //            break;
    //        }
    //            if (store == 1)
    //            {
    //                Console.WriteLine("Enter number is prime ");
    //            }
    //            else
    //            { 
    //            Console.WriteLine("Enter number is not prime ");
    //            }  
    //    }
    //}

    //class test
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.Write("Enter number");
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        int i = 1;
    //        int t;
           
    //        while(i <= 10)
    //        {
    //            t=  num* i;
    //            Console.WriteLine(num+"x"+ i +" is " +t);
    //            i++;
    //        }
            
    //    }
    //}

   /* class test
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int  store ;
            int t = 0;
            int c = num;
            for(int i=num; i >0;i=i+0)
            {
                store = i % 10;
                t = t * 10 + store;
                i = i / 10;

            }
            if (t == c)
            {
                Console.WriteLine("Enter number is plaindrome number");
            }
            else
            {
                Console.WriteLine("Enter number is not a plaindrome number");
            }
        }
    }*/


    class test
    {
        static void Main(string[] args)
        {
            int ctr=1, ptr;
            while (ctr<=5)
            {
                ptr = 5;
                while (ptr >=ctr)
                {
                    Console.Write(ptr);
                    ptr--;
                }
                Console.WriteLine();
                ctr++;
            }
            Console.ReadLine();
        }
    }
}