using System;

namespace test22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(NUMbert1(42));  
            //Console.WriteLine(NMsumt2(90,30));
            //Console.WriteLine(NMcountt3(1, 8));
            //Nmsumt4(0, 6);
            //int[] array = { 2,1,3,4,5,7,6,8,10,14,11,9,12};
            //Console.WriteLine(Arrayt5(array));
            //int[] array = { 1, 2, 3, 4,12, 5, 6, 7, 8, 9, 10,22 };
            //Arrayt6(array);
            //Nsingcompt7(5);
            //int[] array = { 1, 2, 38, 40, 6, 10,3, 100 };
            //Console.WriteLine(Arayt9(array));
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8,10 };
            //Arrayt10(array);
            Ncheckt8(3, 8);
        }
        //static bool NUMbert1(int c)
        //{
        //    return c % 3 == 0 &&c % 7 == 0;
        //}
        //static int NMsumt2(int n, int m)
        //{
        //    if (n % 2 == 0 && m % 2 == 0)
        //    {
        //        return n + m;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //static int NMcountt3(int n, int m)
        //{
        //  int count = 0;
        //  for (int i = n+1; i < m; i++)
        //  {
        //    if (i%2!=0 && n<m)
        //    {
        //        count++;
        //    }
        //  }
        //return count;
        //}
        //static void Nmsumt4(int n, int m)
        //{
        //    int sum = 0;
        //      for (int i = n+1; i < m; i++)
        //      {
        //        if (i % 2 != 0)
        //        {
        //            sum += i;
        //        }
        //      }
        //    Console.WriteLine(sum);
        //}
        //static int Arrayt5(int[]array)
        //{
        //   int sum = 0;
        //  for (int i = 0; i < array.Length; i++)
        //  {
        //    int a = array[i];
        //    if (a%2!=0)
        //    {
        //        sum += a;
        //    }
        //  }
        //    return (sum);
        //}
        //static void Arrayt6(int[] array)
        //{
        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] % 2 == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}
        //static void Nsingcompt7(int n)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (n%1==0&&n%i!=0)
        //        {
        //            Console.WriteLine("singular");
        //        }
        //        else
        //        {
        //            Console.WriteLine("complex");
        //        }
        //    }
        //}

        //static int Arayt9(int[] array)
        //{
        //    int result = 1;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int a = array[i];
        //        if (a>=1 && a<=20)
        //        {
        //            result *= a;
        //        }
        //    }
        //    return (result);
        //}
        //static void Arrayt10(int[] array)
        //{
        //    int sum = 0;
        //    int result = 1;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int b = array[i];
        //        if (b%2==0)
        //        {
        //            sum += b;
        //            result = sum * sum;
        //        }
        //    }
        //    Console.WriteLine(result);
        //}
        static int  Ncheckt8(int m,int n)
        {
            for (int i = 1; i <= m; i++)
            {
                if (m==2*i &&n==m)
                {
                    
                    Console.WriteLine("oke");
                    
                }
                else
                {
                    Console.WriteLine("not"); 
                }
            }
            return n;
            
        }
            
        
    }    
    
    
    
    
}
