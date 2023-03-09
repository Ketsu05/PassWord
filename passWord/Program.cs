using System;
using passWord;

string choice = "";
Console.WriteLine("密码是否无序？Y/n");
choice = Console.ReadLine();
if (choice != "n" || choice != "N" || choice != "y" || choice != "Y")
{
    Console.WriteLine("请输入Y或N，不区分大小写");
}
else
{
    if (choice == "Y" || choice == "y")
    {
        pwRandomBit pwr = new pwRandomBit();
        pwr.RandomBitPassWord();

    }
    else
    {
        pwDefault pwd = new pwDefault();
        pwd.DefaultPassWord();
    }
}




/* 
 * 先判断是否第一位，再生成密码；每次循环仅生成一位
 */
