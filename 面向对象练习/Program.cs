namespace 面向对象练习;

class Program
{
    class Person
    {
        private int attack;
        private int def;
        private int hp;
        private Weapon weapona;

        public Person(int attack, int def, int hp, Weapon weapona)
        {
            this.attack = attack;
            this.def = def;
            this.hp = hp;
            this.weapona = weapona;
        }

        public int Attack
        {
            get => attack;
            set => attack = value;
        }

        public int Def
        {
            get => def;
            set => def = value;
        }

        public int Hp
        {
            get => hp;
            set => hp = value;
        }

        public Weapon Weapona
        {
            get => weapona;
            set => weapona = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    class Weapon
    {
        private String name;
        private int durability;
        private int attackBonus;

        public Weapon(string name, int durability, int attackBonus)
        {
            this.name = name;
            this.durability = durability;
            this.attackBonus = attackBonus;
        }

        public string Name
        {
            get => name;
            set => name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public int Durability
        {
            get => durability;
            set => durability = value;
        }

        public int AttackBonus
        {
            get => attackBonus;
            set => attackBonus = value;
        }
    }
    
    class Monst
    {
        private int attack;
        private int def;
        private int hp;

        public Monst(int attack, int def, int hp)
        {
            this.attack = attack;
            this.def = def;
            this.hp = hp;
        }

        public int Attack
        {
            get => attack;
            set => attack = value;
        }

        public int Def
        {
            get => def;
            set => def = value;
        }

        public int Hp
        {
            get => hp;
            set => hp = value;
        }
    }
    static void Main(string[] args)
    {
        Weapon weapon = new Weapon("RE", 10, 5);
        Person person = new Person(10, 10, 100, weapon);
        Monst monst = new Monst(10, 10, 100);
        
    }
}