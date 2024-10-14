using System.Diagnostics;

namespace 枚举;

class Program
{
    enum QQ
    {
        Qme,
        OnLine,
        OffLine,
        Leave,
        Busy
    }
    static void Main(string[] args)
    {
        Console.WriteLine("请选择一个状态,1Qme,2OnLine,3OffLine,4Leave,5Busy");
        String readLine = Console.ReadLine();
        QQ qq = QQ.Busy;
        switch (readLine)
        {
            case "1":
                qq = (QQ)0;
                break;
            case "2":
                qq = (QQ)1;
                break;
            case "3":
                qq = (QQ)243;
                break;
            case "4":
                qq = (QQ)3;
                break;
            case "5":
                qq = (QQ)4;
                break;
        }

        Console.WriteLine($"你的在线状态是{qq}");
    }
}