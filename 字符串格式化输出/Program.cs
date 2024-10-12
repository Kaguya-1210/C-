// See https://aka.ms/new-console-template for more information

class MyClass
{
    static void Main()
    {
        // Console.Write("请输入用户名:");
        // String name = Console.ReadLine();
        // Console.Write("请输入密码:");
        // String pass = Console.ReadLine();
        // Console.WriteLine("您的用户名是:{0},密码是:{1}", name, pass);
        /*
         * 练习·1
         */
        Console.Write("请输入姓名");
        string name = Console.ReadLine();
        Console.Write("请输入语文成绩:");
        string yuwen = Console.ReadLine();
        Console.Write("请输入英语成绩:");
        string yingyu = Console.ReadLine();
        Console.Write("请输入数学成绩:");
        string shuxue = Console.ReadLine();
        Console.Write("{0}，你的成绩总分为:{1},平均分为:{2}", name, Convert.ToSingle(yuwen) + Convert.ToSingle(yingyu) + Convert.ToSingle(shuxue), (Convert.ToSingle(yuwen) + Convert.ToSingle(yingyu) + Convert.ToSingle(shuxue)) / 3);
    }
}