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
            bool close = false;
            do
            {
                Console.Clear();
                ShowMenu();
                string option;

                do
                {
                    Console.Write("Wybierz funkcję: ");
                    option = Console.ReadLine();

                    Calculator calculator = new Calculator();

                    int x = 0;
                    int y = 0;

                    switch (option)
                    {
                        case "1":
                            PrzedstawSie();
                            close = Closing();
                            break;
                        case "2":
                            Sortowanie();
                            close = Closing();
                            break;
                        case "3":
                            GetXY(out x, out y);
                            int addResult = calculator.Add(x, y);
                            Console.WriteLine($"Wynik dodawania {x} i {y} to {addResult}.");
                            close = Closing();
                            break;
                        case "4":
                            GetXY(out x, out y);
                            int subResult = calculator.Substraction(x, y);
                            Console.WriteLine($"Wynik odejmowania {x} i {y} to {subResult}.");
                            close = Closing();
                            break;
                        case "5":
                            GetXY(out x, out y);
                            int multiResult = calculator.Multiply(x, y);
                            Console.WriteLine($"Wynik możenia {x} i {y} to {multiResult}.");
                            close = Closing();
                            break;
                        case "6":
                            GetXY(out x, out y);
                            float divResult = calculator.Divide(x, y);
                            Console.WriteLine($"Wynik dzielenia {x} i {y} to {divResult}.");
                            close = Closing();
                            break;
                        case "7":
                            GetXY(out x, out y);
                            int modResult = calculator.Modulo(x, y);
                            Console.WriteLine($"Wynik reszty z dzielenia {x} i {y} to {modResult}.");
                            close = Closing();
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy wybór.");
                            break;
                    }
                } while (!int.TryParse(option, out int value) || value > 7 || value < 1);
            } while(!close);
        }

        private static bool Closing()
        {
            Console.Write("\nCzy chcesz zamknąć program? (t/n): ");
            string decision = Console.ReadLine();
            if (decision == "t")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void GetXY(out int x, out int y)
        {
            Console.Write("Podaj x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Podaj y: ");
            y = int.Parse(Console.ReadLine());
        }

        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("KALKULATOR 1.0");
            Console.WriteLine("1. Przedstaw się");
            Console.WriteLine("2. Sortowanie");
            Console.WriteLine("3. Dodawanie");
            Console.WriteLine("4. Odejmowanie");
            Console.WriteLine("5. Mnożenie");
            Console.WriteLine("6. Dzielenie");
            Console.WriteLine("7. Modulo");
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
