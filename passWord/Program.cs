// See https://aka.ms/new-console-template for more information
/*
 先判断是否第一位，再生成密码；每次循环仅生成一位
 */
using System;

string password = "+";
int passwdLen = 8;
string passwd;
char[] spChars = { '$', '~', '!', '@', '#','%','^','&','`','-' };
Console.WriteLine("随机生成密码");
while(passwdLen == passwd.Length)
{
    if (passwd.Length % 4 == 0)
    {
        Random rupC = new Random();
        char upC = (char)rupC.Next(65, 90);

    Random rlowC = new Random();
    char lowC = (char)rlowC.Next(97, 122);

    Random r = new Random();   
    int num = r.Next(10);

    string numC = num.ToString();
    char spC = spChars[num];
    
    if (password == "+")
    {
        passwd = Convert.ToString(upC);
    }
    else
    {
        passwd = string.Concat(upC);
    }

    if (passwd.Length % 4 == 0)
    {
        Random rlowC = new Random();
        char lowC = (char)rlowC.Next(97, 122);
        passwd = string.Concat(lowC);
    }

    if (passwd.Length % 4 == 0)
    {
        Random r = new Random();
        int num = r.Next(10);
        string numC = num.ToString();
        passwd = string.Concat(numC);
    }
    if (passwd.Length % 4 == 0)
    {
        Random r = new Random();
        int num = r.Next(10);
        char spC = spChars[num];
        passwd = string.Concat(spC);
    }

    


Console.WriteLine("选中并单击右键以复制密码\n" + passwd);
