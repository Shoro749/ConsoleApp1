using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач з клавіатури вводить до рядка арифметичний вираз. Додаток має підрахувати його результат.
                Необхідно дотримуватися лише двох операцій: + і –.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть арифметичний вираз(5+1-3): ");
                string ?str = Convert.ToString(Console.ReadLine());
                str = str.Trim();
                string[] op = new string[2];
                int temp = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '+' || str[i] == '-')
                    {
                        op[temp] = Convert.ToString(str[i]);
                        temp++;
                    }
                }

                string[] words = str.Split('+', '-');
                int[] arr = new int[words.Length];
                for (int i = 0; i < words.Length; i++)
                {
                    arr[i] = Convert.ToInt32(words[i]);
                }

                int answer = 0;

                switch (op[0])
                {
                    case "+":
                        answer = arr[0] + arr[1];
                        if (op[1] == "-")
                        {
                            answer = answer - arr[2];
                        }
                        else
                        {
                            answer = answer + arr[2];
                        }

                        break;

                    case "-":
                        answer = arr[0] - arr[1];
                        if (op[1] == "-")
                        {
                            answer = answer - arr[2];
                        }
                        else
                        {
                            answer = answer + arr[2];
                        }

                        break;
                }

                Console.Write("\n");

                foreach (var item in str)
                {
                    Console.Write(item);
                }
                Console.WriteLine($"={answer}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Помилка! {ex.Message}");
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}