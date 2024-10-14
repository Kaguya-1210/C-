namespace 数组练习;

struct num
{
    private int Max;
    private int Min;
    private int Count;

    public int Max1
    {
        get => Max;
        set => Max = value;
    }

    public int Min1
    {
        get => Min;
        set => Min = value;
    }

    public int Count1
    {
        get => Count;
        set => Count = value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // int[] arr1 = new int[] { 1, 3, 4, 5, 6, 7 };
        // int[] arr2 = new int[arr1.Length];
        // for (int i = 0; i < arr1.Length; i++)
        // {
        //     arr2[i] = arr1[i] * 2;
        // }
        //
        // for (int i = 0; i < arr2.Length; i++)
        // {
        //     Console.WriteLine(arr2[i]);
        // }

        // int[] arr = new int[10];
        // Random random = new Random();
        //
        // for (int j = 0; j < arr.Length; j++)
        // {
        //     arr[j] = random.Next(1, 101);
        // }
        //
        // foreach (var VARIABLE in arr)
        // {
        //     Console.WriteLine(VARIABLE);
        // }
        // num n = new num();
        // int temp = 0;
        // int temp2 = 100;
        // foreach (int i in arr)
        // {
        //     if (temp < i)
        //     {
        //         temp = i;
        //         n.Max1 = temp;
        //     }
        //
        //     if (i < temp2)
        //     {
        //         temp2 = i;
        //         n.Min1 = temp2;
        //     }
        //
        //     n.Count1 = n.Count1 + i;
        // }
        //
        // Console.WriteLine($"最大值是{n.Max1},最小值是:{n.Min1},总合:{n.Count1},平均值:{n.Count1 / arr.Length}");

        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.Write("正序:");
        foreach (int i in arr)
        {
            Console.Write(i + ",");
        }

        Console.WriteLine("-");
        
        for (int i = 0; i < arr.Length /2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 -i];
            arr[arr.Length - 1 - i] = temp;
        }
        
        Console.Write("倒序:");
        foreach (int i in arr)
        {
            Console.Write(i + ",");
        }
    }
}