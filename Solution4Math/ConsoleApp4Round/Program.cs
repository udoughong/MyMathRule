using System;

namespace ConsoleApp4Round
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入原始數值：");
            Double thisDouble = Double.Parse(Console.ReadLine());
            Console.Write("請輸入四捨五入位置(小數點以後為正)：");
            int thisInteger = int.Parse(Console.ReadLine());
            Double thisResult = Round(thisDouble,thisInteger);
            Console.WriteLine("四捨五入結果：{0}",thisResult);
            Console.ReadLine();
        }

        #region LOOK>>https://dotblogs.com.tw/larry/2008/08/13/4878
        public static Double Round(Double a_Value, int a_Places)
        {
            Double l_RT, l_XS;
            l_XS = 1;
            if (a_Places >= 0)
            {
                for (int i = 1; i <= a_Places; i++)
                {
                    l_XS = l_XS * 10;
                }
            }
            else
            {
                for (int i = a_Places; i < 0; i++)
                {
                    l_XS = l_XS * 0.1;
                }
            }
            l_RT = Math.Floor(Math.Abs(a_Value) * l_XS + 0.5) / l_XS;

            if (a_Value >= 0)
                return l_RT;
            else return 0 - l_RT;
        }
        #endregion
    }
}
