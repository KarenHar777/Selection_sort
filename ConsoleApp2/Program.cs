internal class Program
{
    private static void Main(string[] args)
    {
        int[] num = new int[] { 7, 2, 3, 5, 9, 1, 4 };

        foreach (int j in num)
        {
            Console.Write(j + "\t");
        }

        int sort=0;
        int cloud;
        while (sort < num.Length)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (num[sort] > num[i])
                {
                    cloud = num[sort];
                    num[sort] = num[i];
                    num[i] = cloud;
                }

            }
            sort++;
        }
        Console.WriteLine();

        foreach (int j in num)
            {
                Console.Write(j+"\t");
            }
    }
}