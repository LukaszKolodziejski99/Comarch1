namespace ComarchCwiczenia
{
    internal class Program
    {
        /// <summary>
        /// Metoda startowa aplikacji.
        /// </summary>
        /// <param name="args">Argumenty startowe aplikacji.</param>
        static void Main(string[] args)
        {
            Intro();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    PrzedstawSie();
                    break;

                case "2":
                    Sortowanie();
                    break;
                default:
                    break;
            }


        }

        private static void Intro()
        {
            Console.WriteLine("KALKULATOR 1.0");
            Console.WriteLine("1. Przedstaw się");
            Console.WriteLine("2. Sortowanie");

            Console.Write("Wybierz funkcję: ");
        }

        private static void PrzedstawSie()
        {
            Console.Write("Podaj imię: ");
            string firstName = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string lastName = Console.ReadLine();

            Console.Write("Ile masz lat: ");
            string sAge = Console.ReadLine();

            int age = 0;
            bool isAgeCorrect = int.TryParse(sAge, out age);

            Console.WriteLine($"Witaj {firstName} {lastName}! Miło Cię widzieć. Masz {age} lat.");
        }

        private static void Sortowanie()
        {
            string wholeInput = "";
            Console.WriteLine("Wypisz 10 elementów do posortowania");

            for (int i = 1; i <= 10; i++)
            {
                string input;
                do
                {
                    Console.Write($"Element nr {i}: ");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out int num));

                wholeInput += input;

                if (i < 10)
                {
                    wholeInput += ",";
                }
            }

            string[] sElements = wholeInput.Split(",");
            int[] iElements = new int[10];

            for (int i = 0; i < sElements.Length; i++)
            {
                int.TryParse(sElements[i], out iElements[i]);
            }

            int[] sortedArray = BubbleSort(iElements);

            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (i < sortedArray.Length - 1)
                {
                    Console.Write($"{sortedArray[i]}, ");
                }
                else
                {
                    Console.Write($"{sortedArray[i]}");
                }
            }
        }

        private static int[] BubbleSort(int[] array)
        {
            var n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        var tempVar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempVar;
                    }
            return array;
        }
    }
}
