using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passWord
{
    internal class pwDefault
    {
        public string DefaultPassWord()
        {


            string passLen = "";
            string passwd = "";
            char[] spChars = { '$', '~', '!', '@', '#', '%', '^', '&', '`', '-' };
            Console.WriteLine("随机生成密码\n请输入需要生成的密码位数");
            passLen = Console.ReadLine();
            int passwdLen = Convert.ToInt32(passLen);
            Random r = new Random();


            if (passwdLen >= 8 && passwdLen <= 128)
            {
                while (passwd.Length < passwdLen)
                {
                    switch (passwd.Length % 4)
                    {
                        case 0:
                            char upC = (char)r.Next(65, 90);
                            passwd += upC;
                            break;

                        case 1:
                            
                            char lowC = (char)r.Next(97, 122);
                            passwd += lowC;
                            break;

                        case 2:
                            
                            char numC = (char)r.Next(49, 57);
                            passwd += numC;
                            break;

                        case 3:
                            int num = r.Next(10);
                            char spC = spChars[num];
                            passwd += spC;
                            break;
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
