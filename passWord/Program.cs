// See https://aka.ms/new-console-template for more information
/*
 两层循环，一层拼接一层生成
 */
using System;

string password = "+";
int passwdLen = 8;
char[] spChars = { '$', '~', '!', '@', '#','%','^','&','`','-' };
Console.WriteLine("随机生成密码");
while(passwdLen == password.Length)
{
    string passwd;
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

    if (password == "+")
    {
        passwd = Convert.ToString(lowC);
    }
    else
    {
        passwd = string.Concat(lowC);
    }

    if (password == "+")
    {
        passwd = Convert.ToString(numC);
    }
    else
    {
        passwd = string.Concat(numC);
    }
    if (password == "+")
    {
        passwd = Convert.ToString(spC);
    }
    else
    {
        passwd = string.Concat(spC);
    }

    password = passwd;
}


Console.WriteLine("选中并单击右键以复制密码\n" + password);
