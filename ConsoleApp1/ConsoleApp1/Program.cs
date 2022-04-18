using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
    //        [문제 01] 직사각형 별 찍기
    //이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다.별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.
    //(n과 m은 각각 1000 이하인 자연수입니다.)
    
    
    
    //[문제 02]
    //        짝수와 홀수
    //정수 num이 짝수일 경우 “Even”을 반환하고, 홀수인 경우 “Odd”를 반환하는 함수를 완성해주세요.
    //(num은 int 범위의 정수입니다. 0은 짝수입니다.)
    
    
    
    //[문제 03] 핸드폰 번호 가리기
    //개인정보 보호를 위해 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
    //전화번호가 문자열 phone_number로 주어졌을 때, 전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부* 으로 가린 문자열을 return 하는 함수를 완성해주세요.
    //(s는 길이 4 이상, 20이하인 문자열입니다.)
    
    
    
    //[문제 04]
    //        평균 구하기
    //정수를 담고 있는 배열 arr의 평균값을 return하는 함수를 완성해보세요.
    //(arr은 길이 1 이상, 100이하인 배열입니다.arr의 원소는 –10,000 이상 10,000 이하인 정수입니다.)
    


    //[문제 05] 제일 작은 수 제거하기
    //정수를 저장한 배열, arr에서 가장 작은 수를 제거한 배열을 리턴하는 함수를 완성해주세요.
    //단, return 하려는 배열이 빈 배열인 경우엔 배열에 –1을 채워 return 하세요.
    //예를 들어 arr이[4, 3, 2, 1] 인 경우는[4, 3, 2] 를 return 하고, [10] 이면[-1] 를 return 합니다.
    //(arr는 길이 1 이상인 배열입니다.인덱스 i, j에 대해 i ≠ j이면 arr[i] ≠ arr[j] 입니다.)
    //(입력된 수, num은 1 이상 8000000 미만인 정수입니다.)

        static void Main(string[] args)
        {
            //1번
            //int n = 0;
            //int m = 0;
            //do
            //{
            //    n = int.Parse(ReadLine());
            //    m = int.Parse(ReadLine());
            //} while (n > 1000 || m > 1000);

            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Write("*");
            //    }
            //    WriteLine();
            //}

            //2번
            //Two(2);

            //3번
            //Three("01000000000");

            //4번
            //int[] a = { 5, 4, 3, 2, 1 };
            //Four(a);

            //5번
            //int[] a = { 5, 4, 3, 2, 1 };
            //Five(a);
        }
        static string Two(int num)
        {
            return num % 2 == 0 ? "Even" : "Odd";
        }
        static string Three(string phone_number)
        {
            if (phone_number.Length > 20 || phone_number.Length < 4) return "";
            string s = phone_number;
            int a = phone_number.Length - 4;
            string st = phone_number.Substring(a, 4);

            for (int i = 0; i < a; i++)
            {
                s += "*";
            }
            s += st;
            return s;
        }
        static int Four(int[] arr)
        {
            int a = 0;
            int b = arr.Length;
            for (int i = 0; i < b; i++)
            {
                a += arr[i];
            }
            a /= b;
            return a;
        }
        static int[] Five(int[] arr)
        {
            List<int> a = new List<int>();
            int b = arr.Length;
            int[] c = { 0, };
            if (b == 1)
            {
                c = new int[] { -1 };
                return c;
            }
            int min = arr[0];
            for (int i = 0; i < b; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            for (int i = 0; i < b; i++)
            {
                if (arr[i] != min)
                {
                    a.Add(arr[i]);
                }

            }
            c = a.ToArray();
            return c;
        }
    }
}
