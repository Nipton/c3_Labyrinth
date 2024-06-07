namespace c3_Labyrinth
{
    internal class Program
    {
        static int CountExits(int[,] arr,(int I, int J) tuple)
        {
            int count = 0;
            if (arr[tuple.I, tuple.J] == 1)
                return count;
            if(arr[tuple.I, tuple.J] == 0 && (tuple.I - 1 == -1 || tuple.I + 1 == arr.GetLength(0) || tuple.J - 1 == -1 || tuple.J + 1 == arr.GetLength(1)))
            {
                arr[tuple.I, tuple.J] = 1;
                count++;
            }
            if(tuple.I + 1 < arr.GetLength(0) && arr[tuple.I+1, tuple.J] == 0)
            {
                arr[tuple.I, tuple.J] = 1;
                count += CountExits(arr, (tuple.I + 1, tuple.J));             
            }
            if (tuple.I - 1 >= 0 && arr[tuple.I - 1, tuple.J] == 0)
            {
                arr[tuple.I, tuple.J] = 1;
                count += CountExits(arr, (tuple.I - 1, tuple.J));
            }
            if (tuple.J + 1 < arr.GetLength(1) && arr[tuple.I, tuple.J + 1] == 0)
            {
                arr[tuple.I, tuple.J] = 1;
                count += CountExits(arr, (tuple.I, tuple.J+1));
            }
            if (tuple.J - 1 >= 0 && arr[tuple.I, tuple.J - 1] == 0)
            {
                arr[tuple.I, tuple.J] = 1;
                count += CountExits(arr, (tuple.I, tuple.J - 1));
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[,] labirynth1 = new int[,]
            {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 0, 0, 0, 1 },
                {1, 0, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 0, 0 },
                {1, 1, 0, 0, 1, 0, 1 },
                {1, 1, 1, 0, 1, 0, 1 },
                {1, 1, 1, 0, 1, 1, 1 }
            };
            int reuslt = CountExits(labirynth1, (2, 5));
            Console.WriteLine(reuslt);
        }
    }
}