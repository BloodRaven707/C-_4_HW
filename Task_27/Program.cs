namespace Console_Program
{
    class C_4
    {
        // Проверка: Введено ли число типа int 
        public static int ReadInputNumber(string message = "Введите число:"){
            int result = 0; 

            while ( true ) {
                Console.WriteLine(message);

                if (int.TryParse(Console.ReadLine(), out result))
                    break;
                Console.WriteLine("[!] Вы ввели не верные данные!\n");
            }

            return result; 
        }


        /// <summary>
        /// Принимает: Целое число
        /// Возвращает: Сумму чисел в строке
        /// </summary>
        public static int SumDigitInRow(int someDigit) {
            string someString = Convert.ToString(Math.Abs(someDigit));
            int result = 0;
            
            for (int i = 0; i < someString.Length; i++) {
                result += int.Parse(someString[i].ToString());
            }
            return result;
        }


        private static void Main(string[] args) {
            int someDigit;
			// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
	        // 452 -> 11
	        // 82 -> 10
	        // 9012 -> 12

            Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\n");

            someDigit = ReadInputNumber("Введите целое число:");
            Console.WriteLine($"Сумма чисел в строке {someDigit} -> {SumDigitInRow(someDigit)}\n");
		}
    }
}