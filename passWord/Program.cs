using System;
using passWord;

string selection = "";
Boolean b = false;
int choice;


while (b != true)
{
    Console.WriteLine("请选择需要生成的密码类型\n1.有序 Ab1!Cd2@\n2.无序 Uj3uz0*&n\n3.滚动 Ab1!c2@\n\n请输入需要的类型编号");
    if (selection.All(char.IsDigit)){
        selection = Console.ReadLine();
        choice = Convert.ToInt32(selection);
        switch(choice)
        {
            case 1 : 
                pwDefault pwd = new pwDefault();
                pwd.DefaultPassWord();
                break;
            case 2 :
                pwRandomBit pwr = new pwRandomBit();
                pwr.RandomBitPassWord();   
                break;
            case 3 :
                pwRollBit rollBit = new pwRollBit();
                rollBit.RollBitPassWord();
                break;
        }
        break;
    }
    else
    {
        Console.WriteLine("请输入数字编号");
    }
}








/* 
 * 先判断是否第一位，再生成密码；每次循环仅生成一位
 */
