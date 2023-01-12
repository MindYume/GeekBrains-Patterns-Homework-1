class Program
{
    /// <summary>
    /// Находит и возвращает факториал числа
    /// </summary>
    static int Factorial(int number)
    {
        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }

        return factorial;
    }

    /// <summary>
    /// Находит и возвращает сумму всех чисел от 0 до введённго числа number
    /// </summary>
    static int SumAll(int number)
    { 
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }

        return sum;
    }

    /// <summary>
    /// Находит и возвращает максимальное чётноче число, которое меньше числа введённого числа number
    /// </summary>
    static int MaxEvenNumber(int number)
    { 
        int even_num = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0 && i < number)
            {
                even_num = i;
            }
        }

        return even_num;
    }

    static void Main(string[] args)
    {
        // Включение Кириллицы в консоли
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine(
            "Здравствуйте, вас приветствует математическая программа\n\n" +
            "Данная программа находит факториал введённого числа N,\n" +
            "сумму числел от 1 до N, " +
            "а также максимальное четное число, которое меньше N\n"
            );

        Console.Write("Введите число N: ");
        string num_str = Console.ReadLine();

        if (num_str == "q")
        {
            return;
        }


        int num_int = int.Parse(num_str);

        Console.WriteLine("Факториал числа N равен " + Factorial(num_int));
        Console.WriteLine("Сумма от 1 до N равна " + SumAll(num_int));
        Console.WriteLine("Максимальное четное число, которое меньше N равно " + MaxEvenNumber(num_int));
        Console.ReadLine();
    }
}