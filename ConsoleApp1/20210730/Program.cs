using System;
using System.Collections.Generic;

namespace _20210730
{
    class Program
    {
        //        [문제 06]
        //        최대공약수와 최소공배수
        //두 수를 입력받아 두 수의 최대공약수와 최소공배수를 반환하는 함수를 완성해보세요.배열의 맨 앞에 최대공약수, 그다음 최소공배수를 넣어 반환하면 됩니다.예를 들어 두 수 3, 12의 최대공약수는 3, 최소공배수는 12이므로 solution(3, 12)는 3, 12를 반환해야 합니다.
        //(두 수는 1 이상 1000000이하의 자연수입니다.)



        //[문제 07] x만큼 간격이 있는 n개의 숫자
        //함수 solution은 정수 x와 자연수 n을 입력받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 return 해야 합니다.다음 제한조건을 보고, 조건을 만족하는 함수 solution을 완성해주세요.
        //(제한조건) – x는 -10000000 이상, 10000000 이하인 정수입니다.
        //- n은 1000 이하인 자연수입니다.



        //[문제 08] 콜라츠 추측
        //1937년 Collatz란 사람에 의해 제기된 이 추측은, 주어진 수가 1이 될 때까지 다음 작업을 반복하면, 모든 수를 1로 만들 수 있다는 추측입니다.작업은 다음과 같습니다.


        //1-1. 입력된 수가 짝수라면 2로 나눕니다.
        //1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더합니다.
        //2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다.

        //예를 들어, 입력된 수가 6이라면 6 → 3 → 10 → 5 → 16 → 8 → 4 → 2 →1 이 되어 총 8번 만에 1이 됩니다. 위 작업을 몇 번이나 반복해야 하는지 반환하는 함수 solution을 완성해주세요. 단, 작업을 500번을 반복해도 1이 되지 않는다면 –1을 반환해 주세요.



        //[문제 09] 정수 내림차순으로 배치하기
        //함수 solution은 정수 n을 매개변수로 입력받습니다. n의 각 자릿수를 큰 것부터 작은 순으로 정렬한 새로운 정수를 return 해 주세요. 예를 들어, n이 118372면 873211을 return 하면 됩니다.
        //(n은 1 이상 8000000000 이하인 자연수입니다.)



        //[문제 10] 자연수 뒤집어 배열로 만들기
        //자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 return 해 주세요.예를 들어 n이 12345이면[5, 4, 3, 2, 1] 을 리턴합니다.

        static void Main(string[] args)
        {
            //6
            //int[] a;

            //a = Six(5, 10);

            //foreach (var item in a)
            //{
            //    Console.WriteLine(item);
            //}

            //7
            //List<int> list = Seven(5, 5);
            //Console.WriteLine(list.Count);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //8
            //int a = Eight(6);
            //Console.WriteLine(a);

            //9
            //Console.WriteLine(Nine(1579));

            //10
            //int[] a = Ten(1578);
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
        }

        static int[] Six(int x, int y)
        {
            int a = x;
            int b = y;
            int temp = a;

            if (x < y)
            {
                temp = a;
                a = b;
                b = temp;
            }

            while (true)
            {
                temp = b % a;
                b = a;

                if (temp == 0) break;

                a = temp;
            }
            return new int[] { a, x * y / a };
        }

        static List<int> Seven(int x, int n)
        {
            if (x < -10000000 || x > 10000000 || n > 1000) return new List<int>();

            List<int> list = new List<int>();
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                temp += x;
                list.Add(temp);
            }


            return list;
        }
        private static int count = 0;
        static int Eight(int x)
        {
            count++;
            if (x % 2 == 0)
            {
                x /= 2;
            }
            else
            {
                x = (x * 3) + 1;
            }
            //Console.WriteLine(x);
            return x == 1 ? count : Eight(x);
        }
        static long Nine(long n)
        {
            if (n < 1 || n > 8000000000) return 0;
            //string s = n.ToString();
            //List<long> list = new List<long>();
            //long l = 0;
            //foreach (long item in s)
            //{
            //    list.Add(item);
            //}
            //list.Sort();
            //list.Reverse();
            char[] a = n.ToString().ToCharArray();
            string s = "";

            Array.Sort(a);
            Array.Reverse(a);
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            return long.Parse(s);
        }
        static int[] Ten(int n)
        {
            char[] ch = n.ToString().ToCharArray();
            int[] a = new int[ch.Length];

            Array.Reverse(ch);

            for (int i = 0; i < ch.Length; i++)
            {
                a[i] = int.Parse(ch[i].ToString());
            }
            return a;
        }
    }
}
