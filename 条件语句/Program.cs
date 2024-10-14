// See https://aka.ms/new-console-template for more information

class MyClass
{
    static void Main()
    {
        // String a = Console.ReadLine();
        // String b = Console.ReadLine();
        // int a1 = Convert.ToInt32(a);
        // int b1 = Convert.ToInt32(b);
        //
        // Console.WriteLine(a1 > b1 ? "a大" : "b小");
        Console.Write("请输入你的年龄:");
        String inputAge = Console.ReadLine();
        var age = Convert.ToInt32(inputAge);
        if (age > 18)
        {
            Console.WriteLine("查看成功");
        }
        else
        {
            Console.WriteLine("未满18岁禁止进入🤣");
        }
    }
}