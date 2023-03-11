using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passWord
{
    internal class pwRollBit
    {
        public string RollBitPassWord()
        {
            string passLen = "";
            string passwd = "";
            int pwLen = 0;
            char[] spChars = { '$', '~', '!', '@', '#', '%', '^', '&', '`', '-' };
            Console.WriteLine("随机生成密码");
            Console.WriteLine("请输入需要生成的密码位数");
            passLen = Console.ReadLine();
            int passwdLen = Convert.ToInt32(passLen);
            if (passwdLen >= 8 && passwdLen <= 128)
            {
                while (passwd.Length < passwdLen)
                {
                    if (passwd.Length == passwdLen)
                    {
                        break;
                    }
                    else if (passwd.Length % 4 == 0)
                    {
                        Random rupC = new Random();
                        char upC = (char)rupC.Next(65, 90);
                        passwd += upC;

                    }
                    else if (passwd.Length % 4 == 1)
                    {
                        Random rlowC = new Random();
                        char lowC = (char)rlowC.Next(97, 122);
                        passwd += lowC;
                    }
                    else if (passwd.Length % 4 == 2)
                    {
                        Random r = new Random();
                        char numC = (char)r.Next(49, 57);
                        passwd += numC;
                    }                
                    else if (passwd.Length % 4 == 3)
                    {
                        Random r = new Random();
                        int num = r.Next(10);
                        char spC = spChars[num];
                        passwd += spC;
                    }

                }
                Console.WriteLine("选中并单击右键以复制密码\n" + passwd);
                Console.WriteLine("按任意键以退出程序");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("密码长度应至少8位，并少于129位");
            }
            return "done";
        }
    }
}
