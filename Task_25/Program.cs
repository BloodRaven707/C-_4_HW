namespace Console_Program
{
    class C_4
    {
            // Проверка: Содержит ли строка 2-а числа, записанных через запятую
            public static string[] ReadInputArray(string message = "Введите список чисел, через запятую:"){
            string[] result; 

            while ( true ) {
                Console.WriteLine(message);

                try {
                    result = (Console.ReadLine() ?? "").Split(",");

                    foreach (string item in result)
                        int.Parse(item);

                    if (result.Length == 2)
                        break;
                    Console.WriteLine("[!] Вы ввели не верные данные!\n");
                }
                catch {
                    Console.WriteLine("[!] Вы ввели не верные данные!\n");
                }
            }

            return result; 
        }
        

        /// <summary>
        /// Принимает: 2-а числа (A, B) типа int32
        /// Возвращает: числа A в степени B
        /// </summary>
        public static int Exponentiation(int number, int degree) {
            int result = number;
            for (int i = 1; i < degree; i++) {
                result *= number;
            }
            return result;
        }


        private static void Main(string[] args) {
			int a, b;
            // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\n");
	        // 3, 5 -> 243 (3⁵)
   	        // 2, 4 -> 16

            string[] someArray = ReadInputArray("Введите два целых натуральных числа, через запятую, например: 3, 5");
            a = int.Parse(someArray[0]);
            b = int.Parse(someArray[1]);

            Console.WriteLine($"Число A = {a} в степени B = {b} -> {Exponentiation(a, b)} ({a}^{b})\n");
		}
    }
}