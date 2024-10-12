// See https://aka.ms/new-console-template for more information

class MyClass
{
    static void Main()
    {
        Console.Write("请输入用户名:");
        String name = Console.ReadLine();
        Console.Write("请输入密码:");
        String pass = Console.ReadLine();
        Console.WriteLine("您的用户名是:{0},密码是:{1}", name, pass);
    }
}