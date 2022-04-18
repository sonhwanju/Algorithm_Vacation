using System;
using static System.Console;
using System.Collections.Generic;

namespace _20220208
{
    class Program
    {
        //리스트를 이용하여 아주 간단한 텍스트 에디터를 만들어봅시다.
        //이 에디터는 라인 에디터라고 불리며 라인 단위로 입력이나 삭제를 할 수 있습니다.
        //이 라인 에디터는 고정된 수의 명령어들을 받아서 동작하며 커서를 사용하지 않습니다.


        //한 라인이 하나의 노드라고 생각하고 만들어보세요.
        public static void MainScreen(ref List<string> list)
        {
            Console.WriteLine("1: 삽입, 2: 조회, 3: 삭제");

            int.TryParse(ReadLine(), out int idx);

            switch (idx)
            {
                case 1:
                    Insert(ref list);
                    break;
                case 2:
                    Inquery(ref list);
                    break;
                case 3:
                    Delete(ref list);
                    break;
                default:
                    Console.WriteLine("그런거없음");
                    MainScreen(ref list);
                    break;
            }
        }

        public static void Insert(ref List<string> list)
        {
            Console.Write($"{list.Count}번 째 줄에 작성중입니다 > ");
            list.Add(ReadLine());

            Console.WriteLine($"1 : 더 작성, 나머지 : 메인화면으로");

            int.TryParse(ReadLine(), out int idx);

            if (idx == 1)
            {
                Insert(ref list);
            }
            else
            {
                MainScreen(ref list);
            }
        }

        public static void Inquery(ref List<string> list)
        {
            Console.WriteLine();

            if (list.Count == 0)
            {
                Console.WriteLine("비어있음");
                MainScreen(ref list);
            }

            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine($"{i} : {list[i]}");
            }
            Console.WriteLine();

            Console.WriteLine("아무키 : 메인화면으로");

            ReadLine();

            MainScreen(ref list);
        }

        public static void Delete(ref List<string> list)
        {
            Console.Write("몇번째 라인을 삭제하시겠습니까? > ");

            int.TryParse(ReadLine(), out int idx);

            if (list.Count <= idx || idx == 0)
            {
                Console.WriteLine("그런거 없다");
                MainScreen(ref list);
                return;
            }

            list.RemoveAt(idx);

            Console.WriteLine("삭제 완료");

            Console.WriteLine("1 : 더 삭제, 나머지 : 메인화면으로");

            idx = 0;
            int.TryParse(ReadLine(), out idx);

            if (idx == 1)
            {
                Delete(ref list);
            }
            else
            {
                MainScreen(ref list);
            }
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "null" };

            MainScreen(ref list);
        }
    }
}
