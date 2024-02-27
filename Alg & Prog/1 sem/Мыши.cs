Console.WriteLine("Введите количество мышей");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию белой мыши");
int white_position = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int[] mice = new int[count];
    for (int j = 0; j < count; j++)
    {
        mice[j] = 1;
    }
    int steps = k;
    int l = (i + 1) % count;
    int mice_alive = count;
    while (true)
    {
        if (mice[l] != -1)
        {
            steps--;
        }
        if (steps == 0)
        {
            mice[l] = -1;
            mice_alive--;
            steps = k;

            if (mice_alive >= 1 && l == white_position)
            {
                break;
            }

            if (mice_alive == 1)
            {
                Console.WriteLine("Позиция, с которой нужно начать съедать мышей ради выживания белой:");
                Console.WriteLine(i);
                break;
            }
        }
        l = (l + 1) % count;
    }
}
