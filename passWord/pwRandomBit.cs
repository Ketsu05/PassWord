using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passWord
{
    internal class pwRandomBit
    {
        public string RandomBitPassWord()
        {
            string passLen = "";
            string passwd = "";
            char[] spChars = { '$', '~', '!', '@', '#', '%', '^', '&', '`', '-' };
            Console.WriteLine("随机生成无序密码\n请输入需要生成的密码位数");
            passLen = Console.ReadLine();
            int passwdLen = Convert.ToInt32(passLen);
            Random rabbit = new Random();


            if (passwdLen >= 8 && passwdLen <= 128)
            {
                while (passwd.Length < passwdLen)
                {
                   
                    
                    if (passwd.Length == passwdLen)
                    {
                        break;
                    }
                    else 
                    {
                        Random r = new Random();
                        char rChar = (char)r.Next(33,126);
                        passwd += rChar;
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
