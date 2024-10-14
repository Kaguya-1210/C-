class MyClass
{
    static double NextDouble(Random ran, double minValue, double maxValue)
    {
        return ran.NextDouble() * (maxValue - minValue) + minValue;
    }
    
    static void Main()
    {
        String P1 = "Kaguya";
        String P2 = "Monst";
        int P1Attack = 0;
        int P2Attack = 0;
        int P1Hp = 100;
        int P2Hp = 100;
        double P1命中率 = 0.3;
        double P2命中率 = 0.35;
        Random random = new Random();
        while (P1Hp > 0 && P2Hp > 0)
        {
            P1Attack = random.Next(8, 12);
            P2Attack = random.Next(5, 8);
            double 命中率1 = NextDouble(random, 0, 1);
            double 命中率2 = NextDouble(random, 0, 1);
            Console.WriteLine($"P1当前攻击概率:{命中率1},P2当前攻击概率:{命中率2}");
            if (命中率1 <= P1命中率)
            {
                P2Hp = P2Hp - P1Attack;
                if (P2Hp < 0)
                {
                    P2Hp = 0;
                    Console.WriteLine("恭喜{0}获得本局游戏的胜利", P1);
                    return;
                }
                Console.WriteLine("{0}发动攻击，伤害为:{1},当前血量:{2},敌方血量:{3}", P1, P1Attack, P1Hp, P2Hp);

            }
            else
            {
                Console.WriteLine("{0}的攻击被躲开了，当前血量{1}，敌方血量{2}", P1, P1Hp, P2Hp);
            }

            if (命中率2 <= P2命中率)
            {
                P1Hp = P1Hp - P2Attack;
                if (P1Hp < 0)
                {
                    P1Hp = 0;
                    Console.WriteLine("恭喜{0}获得本局游戏的胜利", P2);
                    return;
                }
                Console.WriteLine("{0}发动攻击，伤害为:{1},当前血量:{2},敌方血量:{3}", P2, P2Attack, P2Hp, P1Hp);
            }
            else
            {
                Console.WriteLine("{0}的攻击被躲开了，当前血量{1}，敌方血量{2}", P2, P2Hp, P1Hp);
            }
            
        }
        
    }
}