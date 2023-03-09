using System;
using passWord;

string choice = "Y";
Console.WriteLine("是否需要乱序密码？Y/n");
choice = Console.ReadLine();


if (choice == "N" || choice == "n")
{ 
    pwDefault pwd = new pwDefault();
    pwd.DefaultPassWord();
}
else 
{
    pwRandomBit pwr = new pwRandomBit();
    pwr.RandomBitPassWord();
}

/* 
 * 先判断是否第一位，再生成密码；每次循环仅生成一位
 */
