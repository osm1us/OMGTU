class Menu<T>
{
    public static void showSecondmenu()
    {
        Console.WriteLine(@"
                1) Сложение
                2) Вычитание
                3) Умножение
                4) Деление");
    }
    public static MathOperations<T> numCreate()
    {
        T a = (T)Convert.ChangeType(0, typeof(T));
        T b = (T)Convert.ChangeType(0, typeof(T));
        if (typeof(T) == typeof(int))
        {
            Console.WriteLine("Введите первое число: ");
            a = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
            Console.WriteLine("Введите второе число: ");
            b = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
        }
        if (typeof(T) == typeof(double))
        {
            Console.WriteLine("Введите первое число: ");
            a = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
            Console.WriteLine("Введите второе число: ");
            b = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
        }
        MathOperations<T> numbers = new MathOperations<T>(a, b);
        return numbers;
    }
    public T ChooseOperation(MathOperations<T> numbers, string choose)
    {
        switch (choose)
        {
            case "1":
                numbers = Menu<T>.numCreate();
                return numbers.GetSumm();
            case "2":
                numbers = Menu<T>.numCreate();
                return numbers.GetSubtraction();
            case "3":
                numbers = Menu<T>.numCreate();
                return numbers.GetMultiplication();
            case "4":
                numbers = Menu<T>.numCreate();
                return numbers.GetDivision();
            default:
                return (T)Convert.ChangeType(-1, typeof(T));
        }
    }
}
class MathOperations<T>
{
    public T a;
    public T b;
    public MathOperations(T a, T b)
    {
        this.a = a;
        this.b = b;
    }

    public T GetSumm()
    {
        dynamic dynamic_a = a;
        dynamic dynamic_b = b;
        Console.Write($"{a} + {b} = ");
        return dynamic_a + dynamic_b;
    }
    public T GetSubtraction()
    {
        dynamic dynamic_a = a;
        dynamic dynamic_b = b;
        Console.Write($"{a} - {b} = ");
        return dynamic_a - dynamic_b;
    }
    public T GetMultiplication()
    {
        dynamic dynamic_a = a;
        dynamic dynamic_b = b;
        Console.Write($"{a} * {b} = ");
        return dynamic_a * dynamic_b;
    }
    public T GetDivision()
    {
        dynamic dynamic_a = a;
        dynamic dynamic_b = b;
        Console.Write($"{a} / {b} = ");
        try
        {
            return dynamic_a / dynamic_b;
        }
        catch (DivideByZeroException) { Console.WriteLine("Деление на ноль невозможно"); }
        return a;
    }
}
class Program
{
    public static void Main()
    {

        Console.WriteLine(@"
                1) Работа с целыми числами
                2) Работа с вещественными числами
                3) Выход");
        string choice1 = Console.ReadLine();
        if (choice1 == "1")
        {
            Menu<int> menu = new Menu<int>();
            Menu<int>.showSecondmenu();
            MathOperations<int> numbers = new MathOperations<int>(0, 0);
            Console.WriteLine(menu.ChooseOperation(numbers, Console.ReadLine()));
        }
        if (choice1 == "2")
        {
            Menu<double> menu = new Menu<double>();
            Menu<double>.showSecondmenu();
            MathOperations<double> numbers = new MathOperations<double>(0, 0);
            Console.WriteLine(menu.ChooseOperation(numbers, Console.ReadLine()));
        }
        if (choice1 == "3") System.Environment.Exit(0);

    }
}
