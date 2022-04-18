using System;
using System.Collections.Generic;
using System.Linq;

namespace _20210809
{
    class Program
    {
        //        [문제 21] 두 개 뽑아서 더하기
        //정수 배열 numbers가 주어집니다.
        //numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 더해서 만들 수 있는 모든 수를 배열에 오름차순으로 담아 return 하도록 함수를 완성해주세요.
        //(numbers의 길이는 2 이상 100이하이며, 모든 수는 0 이상 100 이하입니다.)



        //[문제 22] 이상한 문자 만들기
        //문자열 s는 한 개 이상의 단어로 구성되어 있습니다.각 단어는 하나 이상의 공백 문자로 구분되어 있습니다.
        //각 단어의 짝수번째 알파벳은 대문자로, 홀수번째 알파벳은 소문자로 바꾼 문자열을 return 하는 함수, solution을 완성하세요.
        //(문자열 전체의 짝/홀수 인덱스가 아니라, 단어(공백을 기준) 별로 짝/홀수 인덱스를 판단해야 합니다.
        //첫 번째 글자는 0번째 인덱스로 보아 짝수번째 알파벳으로 처리해야 합니다.)



        //[문제 23] 2024년
        //2024년 1월 1일은 월요일입니다. 2024년 a월 b일은 무슨 요일일까요? 두 수 a, b를 입력받아 2024년 a월 b일이 무슨 요일인지 리턴하는 함수를 완성하세요.
        //요일의 이름은 일요일부터 토요일까지 각각 SUN, MON, TUE, WED, THU, FRI, SAT입니다.예를 들어 a = 6, b = 5 라면 6월 5일은 수요일이므로 문자열 “WED”를 반환하세요.
        //(2024년은 윤년입니다. 2024년 a월 b일은 실제로 있는 날입니다. 13월 26이나 2월 45일 같은 날짜는 주어지지 않습니다.)



        //[문제 24]
        //        모의고사
        //수포자 삼인방은 모의고사에 수학 문제를 전부 찍으려 합니다.수포자는 1번 문제부터 마지막 문제까지 다음과 같이 찍습니다.
        //1번 수포자: 1,2,3,4,5,1,2,3,4,5,…
        //2번 수포자: 2,1,2,3,2,4,2,5,2,1,2,3,2,4,2,5,…
        //3번 수포자: 3,3,1,1,2,2,4,4,5,5,3,3,1,1,2,2,4,4,5,5,…
        //1번 문제부터 마지막 문제까지의 정답이 순서대로 있는 배열 answers가 주어졌을 때, 가장 많은 문제를 맞힌 사람이 누구인지 배열에 담아 return 하는 함수를 작성해주세요.
        //(제한조건) - 시험은 최대 10,000 문제로 구성되어 있습니다.
        //- 문제의 정답은 1,2,3,4,5 중 하나입니다.
        //- 가장 높은 점수를 받은 사람이 여럿일 경우, return 하는 값을 오름차순 정렬해주세요.

        //[문제 25] 체육복
        //점심시간에 도둑이 들어, 일부 학생이 체육복을 도난당했습니다. 다행히 여벌 체육복이 있는 학생이 이들에게 체육복을 빌려주려 합니다.
        //학생들의 번호는 체격 순으로 매겨져 있어, 바로 앞번호의 학생이나 바로 뒷번호의 학생에게만 체육복을 빌려줄 수 있습니다.
        //예를 들어, 4번 학생은 3번 학생이나 5번 학생에게만 체육복을 빌려줄 수 있습니다.
        //체육복이 없으면 수업을 들을 수 없기 때문에 체육복을 적절히 빌려 최대한 많은 학생이 체육 수업을 들어야 합니다.

        //전체 학생의 수 n, 체육복을 도난당한 학생들의 번호가 담긴 배열 lost, 여벌의 체육복을 가져온 학생들의 번호가 담긴 배열 reserve가 매개변수로 주어질 때,
        //체육수업을 들을 수 있는 학생의 최댓값을 return 하도록 solution 함수를 작성해주세요.
        //(제한사항) - 전체 학생의 수는 2명 이상 30명 이하입니다.
        //- 체육복을 도난당한 학생의 수는 1명 이상 n명 이하이고 중복되는 번호는 없습니다.
        //- 여벌의 체육복을 가져온 학생의 수는 1명 이상 n명 이하이고 중복되는 번호는 없습니다.
        //- 여벌 체육복이 있는 학생만 다른 학생에게 체육복을 빌려줄 수 있습니다.
        //- 여벌 체육복을 가져온 학생이 체육복을 도난당했을 수 있습니다.
        //이때 이 학생은 체육복을 하나만 도난당했다고 가정하며, 남은 체육복이 하나이기에 다른 학생에게는 체육복을 빌려줄 수 없습니다.
        //(입력은 n, lost, reserve를 받습니다.)

        //[문제 26] 2021 카카오 채용연계형 인턴쉽 기출문제


        //마지막 문제는 사진 파일로 제공합니다.
        static void Main(string[] args)
        {
            //Console.WriteLine(Solution22("try hello world"));

            //Console.WriteLine(Solution23(6,5));

            //Console.WriteLine(Solution25(5,new int[2] {2,4},new int[3] {1,3,5 }));

            //Console.WriteLine(Solution26("one4seveneight"));
        }

        static int[] Solution21(int[] numbers)
        {
            List<int> lists = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (!lists.Contains(numbers[i] + numbers[j]))
                    {
                        lists.Add(numbers[i] + numbers[j]);
                    }
                }
            }

            lists.Sort();

            return lists.ToArray();
        }

        static string Solution22(string s)
        {
            string[] st = s.Split(new char[] { ' ' });
            string ans = "";

            for (int j = 0; j < st.Length; j++)
            {
                for (int i = 0; i < st[j].Length; i++)
                {
                    ans += i % 2 == 0 ? st[j][i].ToString().ToUpper() : st[j][i].ToString().ToLower();
                }

                ans += " ";
            }

            return ans;
        }

        static string Solution23(int a, int b)
        {
            return new DateTime(2024, a, b).DayOfWeek.ToString().Substring(0, 3).ToUpper();
        }

        static int[] Solution24()
        {
            return new int[] { };
        }

        static int Solution25(int n, int[] lost, int[] reverse)
        {
            int count = 0;

            for (int i = 0; i < lost.Length; i++)
            {
                if (reverse.Contains(lost[i]))
                {
                    lost.Where(x => x != lost[i]).ToArray();
                    reverse.Where(x => x != lost[i]).ToArray();
                    break;
                }
            }

            bool[] b = new bool[reverse.Length];

            for (int i = 0; i < lost.Length; i++)
            {
                for (int j = 0; j < reverse.Length; j++)
                {
                    if ((lost[i] - 1 == reverse[j] || lost[i] + 1 == reverse[j]) && !b[j])
                    {
                        b[j] = true;
                        count++;
                        break;
                    }
                }
            }

            return n - lost.Length + count;
        }

        static int Solution26(string s)
        {
            string[] str = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            for (int i = 0; i < str.Length; i++)
            {
                s = s.Replace(str[i], i.ToString());
            }

            return int.Parse(s);
        }

    }
}
