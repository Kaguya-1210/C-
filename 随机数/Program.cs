class MyClass
{
    static void Main()
    {
        int Attack = 0;
        int MonstHp = 10;
        int MonstFangyuli = 10;
        String Monst = "防御力";
        while (MonstHp > 0)
        {
            Attack = new Random().Next(2, 14);
            String s = MonstFangyuli > 0 ? "防御力" : "生命值";
            if (s == "防御力")
            {
                if (MonstFangyuli > 0 )
                {
                    if ((MonstFangyuli - Attack) < 0)
                    {
                        int temp = Attack;
                        temp = temp - MonstFangyuli;
                        MonstHp = MonstHp - temp;
                        MonstFangyuli = 0;
                    }
                    else
                    {
                        MonstFangyuli = MonstFangyuli - Attack;
                    }
                }
            }
            else
            {
                if (MonstHp > 0)
                {
                    if ((MonstHp - Attack) < 0)
                    {
                        MonstHp = 0;
                        Console.WriteLine("你发动了攻击，伤害为:{0}，怪物剩余{1}点{2},生命值为:{3}", Attack, s == "防御力" ? MonstFangyuli : MonstHp,
                            s == "防御力" ? "防御力" : "生命值", MonstHp);
                        Console.WriteLine("恭喜你击杀了怪物");
                        return;
                    }
                    else
                    {
                        MonstHp = MonstHp - Attack;
                    }
                }
            }
            if (Attack < 5)
            {
                Console.WriteLine("你发动了攻击，伤害为:{0}，怪物剩余{1}点{2},生命值为:{3}", Attack, s == "防御力" ? MonstFangyuli : MonstHp,
                    s == "防御力" ? "防御力" : "生命值", MonstHp);
            }
            else
            {
                Console.WriteLine("你发动了攻击，暴击伤害为:{0}，怪物剩余{1}点{2},生命值为:{3}", Attack, s == "防御力" ? "防御力" : "生命值",
                    s == "防御力" ? MonstFangyuli : MonstHp, MonstHp);
            }
        }
    }
}