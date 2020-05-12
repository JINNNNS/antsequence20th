using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            //인터넷 참고 했습니당 ㅠㅠ..어려워요
            string s = "1";
            int num = 1;

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(num + "번째 수열:" + s);
                char c = s[0];
                int cnt = 0;
                string temp = "";

                for (int j = 0; j < s.Length; j++)
                {
                    if (c == s[j])
                        cnt++;
                    else
                    {
                        temp += "" + c + cnt;
                        cnt = 0;
                        c = s[j];
                        cnt++;
                    }
                    if (j + 1 == s.Length)
                        temp += "" + c + cnt;
                }

                s = temp;
                num++;

            }
        }
    }

        }
   