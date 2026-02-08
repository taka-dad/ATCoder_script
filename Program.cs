using System;
class Program
{
    static void Main(string[] args)
    {
        //数値の読み込み
        string[]? Number = Console.ReadLine().Split();
        int N = int.Parse(Number[0]);
        int K = int.Parse(Number[1]);
        string Str_N = Number[0];
        int N_Length = Str_N.Length -1;

        int Count = 0;
        for(int i = 0;i <= N;i++)
        {
            int Sum_Num = 0;
            int Rest_Num = i;
            for (int j = N_Length; j >= 0; j--)
            {
                int Sho_Num = Rest_Num / (int)(Math.Pow(10, j));
                Sum_Num += Sho_Num;
                Rest_Num = (int)(Rest_Num - (Math.Pow(10, j)) * Sho_Num);
            }
            if(Sum_Num == K)
            {
                Count += 1;
            }
            else
            {
            }
        }


            Console.WriteLine(Count);

        Console.ReadLine();

    }
}
