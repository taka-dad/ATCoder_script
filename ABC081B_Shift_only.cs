using System;
class Program
{
        static void Main(string[] args)
        {
        //数値の読み込み
        int? SumNumber = int.Parse(Console.ReadLine());
        string[]? AllNumber = Console.ReadLine().Split(' ');

        
        int Count = 0;
        for (int i = 0; (int.Parse(AllNumber[i])) % 2 == 0&(i < SumNumber); i++)
        {
            AllNumber[i] = ((int.Parse(AllNumber[i])) / 2).ToString();
            if (i == SumNumber - 1)
            {
                Count += 1;
                i = 0;
            }
        }
        

        Console.WriteLine(Count);
        Console.ReadLine();

    }

}
