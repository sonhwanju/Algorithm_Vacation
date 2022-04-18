using System;
using System.Collections.Generic;

namespace _20220207
{
    class Program
    {
        //프로그램에서는 여러 가지 타입의 괄호들이 같은 타입으로 쌍으로 존재하여야 한다.
        //프로그램에서는 대괄호[,], 중괄호 {, }, 소괄호(, ) 등이 사용된다.괄호의 검사 조건은 다음의 3가지이다.


        //조건 1: 왼쪽 괄호의 개수와 오른쪽 괄호의 개수가 같아야 한다.
        //조건 2: 같은 타입의 괄호에서 왼쪽 괄호는 오른쪽 괄호보다 먼저 나와야 한다.
        //조건 3: 서로 다른 타입의 왼쪽 괄호와 오른쪽 괄호 쌍은 서로를 교차하면 안 된다.



        //괄호가 일치하지 않으면 잘못된 프로그램이기 때문에 컴파일러가 이것을 검사하여야 한다.


        //<예시>
        //{ A[(i + 1)] = 0; }
        //        오류없음
        //if((i==0) && (j==0) 오류: 조건 1 위반
        //A[(i + 1])=0; 오류 : 조건 3 위반
        public static string Solution(string s)
        {
            Stack<char> stack = new Stack<char>();
            char c, ch = ' ';
            int idx = 0;

            while (idx < s.Length)
            {
                c = s[idx++]; //(()()

                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(c);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (stack.Count > 0)
                        {
                            ch = stack.Pop();
                        }
                        else
                        {
                            return "오류 : 조건 2 위반";
                        }

                        if ((ch == '(' && c != ')') || (ch == '{' && c != '}') || (ch == '[' && c != ']'))
                        {
                            return "오류 : 조건 3 위반";
                        }

                        break;
                    default:
                        break;
                }
            }

            return stack.Count > 0 ? "오류 : 조건 1 위반" : "오류없음";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solution("{ A [(i+1)]=0;}"));
            Console.WriteLine(Solution("if((i==0) && (j==0)"));
            Console.WriteLine(Solution("A[(i+1])=0;"));
        }
    }
}
