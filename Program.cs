using System;
class Program
{
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        string Number = input;
        int Count = 0;
        int Firstnum = Number.IndexOf("1", 0);
        int Secondnum = Number.IndexOf("1", 1);
        int Thirdnum = Number.IndexOf("1", 2);


        if (Firstnum == 0)
        {
            Count++;
        }
        else
        { }
        if (Secondnum == 1)
        {
            Count++;
            
        }
        else
        { }
        if (Thirdnum == 2)
        {
            Count++;
        }
        else 
        { }

            Console.WriteLine(Count);
        Console.ReadLine();

    }

}
