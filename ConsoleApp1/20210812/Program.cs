using System;

namespace _20210812
{
    class Program
    {
        //        [문제 01] JadenCase 문자열 만들기
        //JadenCase란 모든 단어의 첫 문자가 대문자이고, 그 외의 알파벳은 소문자인 문자열입니다.
        //문자열 s가 주어졌을 때, s를 JadenCase로 바꾼 문자열을 return 하는 함수를 완성해주세요.
        //(s는 길이 1 이상인 문자열입니다.s는 알파벳과 공백문자로 이루어져 있습니다. 첫 문자가 영문이 아닐 때는 이어지는 영문은 소문자로 씁니다.)



        //[문제 03]
        //        주식 가격
        //초 단위로 기록된 주식가격이 담긴 배열 prices가 매개변수로 주어질 때, 가격이 떨어지지 않은 기간은 몇 초인지를 return 하도록 solution 함수를 완성하세요.
        //(prices의 각 가격은 1 이상 10,000 이하인 자연수입니다. prices의 길이는 2 이상 100,000 이하입니다.)
        static void Main(string[] args)
        {
            //Console.WriteLine(Solution1(" jaD enC aSe"));

            //foreach (var item in Solution3(new int[5] { 1,2,3,2,3 }))
            //{
            //    Console.WriteLine(item);
            //}
        }

        static string Solution1(string s)
        {
            if (s.Length < 1)
            {
                return "";
            }

            return s[0] != ' ' ? s.Substring(0, 1).ToUpper() + s.Substring(1).ToLower() : " " + s.ToLower();
        }

        static int[] Solution3(int[] prices)
        {
            if (prices.Length < 2 || prices.Length > 100000)
            {
                return new int[] { };
            }

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < 1 || prices[i] > 10000)
                {
                    return new int[] { };
                }
            }

            int[] a = new int[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] > prices[j] || j == prices.Length - 1)
                    {
                        a[i] = j - i;
                        break;
                    }

                    //a[i] = prices[i] > prices[j] || j == prices.Length - 1 ? j - i : a[i];
                }
            }

            return a;
        }

    }
}
