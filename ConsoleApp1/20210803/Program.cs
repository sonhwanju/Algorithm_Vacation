using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Math;

namespace _20210803
{
    class Program
    {
        //        [문제 11]
        //        자릿수 더하기
        //자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 soulution 함수를 만들어주세요.예를 들어 N이 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.



        //[문제 12] 두 정수 사이의 합
        //두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 return 하는 함수를 완성하세요.
        //예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 return 합니다.


        //[문제 13] 시저 암호
        //어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다.
        //예를 들어 “AB”는 1만큼 밀면 “BC”가 되고, 3만큼 밀면 “DE”가 됩니다. “z”는 1만큼 밀면 “a”가 됩니다.
        //문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수를 완성해보세요.
        //(공백은 아무리 밀어도 공백입니다.s는 알파벳 소문자, 대문자, 공백으로만 이루어져 있습니다.s의 길이는 8000 이하입니다.n은 1 이상, 25 이하인 자연수입니다.)



        //[문제 14] 문자열을 정수로 바꾸기
        //문자열 s를 숫자로 변환한 결과를 반환하는 함수를 완성하세요.
        //(s의 길이는 1 이상 5 이하입니다.s의 맨 앞에는 부호(+,-)가 올 수 있습니다.s는 부호와 숫자로만 이루어져 있습니다. s는 “0”으로 시작하지 않습니다.)



        //[문제 15]
        //        수박수박수박수박수박수?
        //길이가 n이고, “수박수박수박수…”와 같은 패턴을 유지하는 문자열을 return 하는 함수를 완성하세요.
        //예를 들어 n이 4이면 “수박수박”을 return하고 3이라면 “수박수”를 return 하면 됩니다.
        static void Main(string[] args)
        {
            Console.WriteLine(Func(123));

            //Console.WriteLine(Func(3,5));

            //Console.WriteLine(Func("AB",1));

            //Console.WriteLine(Func("-1234"));

            //Console.WriteLine(Func2(3));
        }

        //11
        static int Func(int n)
        {
            char[] ch = n.ToString().ToCharArray();
            int a = 0;

            for (int i = 0; i < ch.Length; i++)
            {
                a += int.Parse(ch[i].ToString());
            }
            return a;
        }

        //12
        static int Func(int a, int b)
        {
            int sum = 0;

            for (int i = Min(a, b); i <= Max(a, b); i++)
            {
                sum += i;
            }

            return sum;
        }

        //13
        static string Func(string s, int n)
        {
            if (s.Length > 8000 || n < 1 || n > 25)
            {
                return "";
            }

            string str = "";
            char[] ch = s.ToCharArray();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == ' ')
                {
                    continue;
                }

                int a = (Convert.ToInt32(ch[i]) + n) > 'z' ? Convert.ToInt32(ch[i]) + n - 26 : Convert.ToInt32(ch[i]) + n;

                ch[i] = Convert.ToChar(a);
            }

            str = new string(ch);

            return str;
        }

        //14
        static int Func(string s)
        {
            if (s.Length > 5 || s.Length < 1)
            {
                return 0;
            }
            return Convert.ToInt32(s);
        }
        //15
        static string Func2(int a)
        {
            string s = "";

            for (int i = 0; i < a; i++)
            {
                s += i % 2 == 0 ? "수" : "박";
            }

            return s;
        }
    }
}
