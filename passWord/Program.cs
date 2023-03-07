using System;


string passLen = "";
string passwd = "";
char[] spChars = { '$', '~', '!', '@', '#','%','^','&','`','-' };
Console.WriteLine("随机生成密码");
Console.WriteLine("请输入需要生成的密码位数");
passLen = Console.ReadLine();
int passwdLen = Convert.ToInt32(passLen);
while (passwd.Length < passwdLen)
{
    if (passwd.Length % 4 == 0)
    {
        Random rupC = new Random();
        char upC = (char)rupC.Next(65, 90);
        passwd += upC;
    }

    if (passwd.Length % 4 == 1)
    {
        Random rlowC = new Random();
        char lowC = (char)rlowC.Next(97, 122);
        passwd += lowC;
    }

    if (passwd.Length % 4 == 2)
    {
        Random r = new Random();
        int num = r.Next(10);
        string numC = num.ToString();
        passwd += numC;
    }
    if (passwd.Length % 4 == 3)
    {
        Random r = new Random();
        int num = r.Next(10);
        char spC = spChars[num];
        passwd += spC;
    }

} 


Console.WriteLine("选中并单击右键以复制密码\n" + passwd);
/*
 先判断是否第一位，再生成密码；每次循环仅生成一位
 */
