/* Створити калькулятор.   
Під кожну операцію створити свій метод, і викликами його в Головному методі, коли це потрібно. 
Приймаймо від користувача перший операнд, другий, і операцію + - * / - даємо результат 
y = x * 2;
int y = Function(x); 
int Function(int x) => x * 2; 
*/

namespace MyProgram
{
    internal class Program
    {

        static double Add(double parsed1, double parsed2)
        {
            double dodavania = parsed1 + parsed2;
            return dodavania;
        }
        static double Multiply(double parsed1, double parsed2)
        {
            double mnozhennia = parsed1 * parsed2;
            return mnozhennia;
        }
        static double Substract(double parsed1, double parsed2)
        {
            double vidnimania = parsed1 - parsed2;
            return vidnimania;
        }

        static double Divide(double parsed1, double parsed2)
        {
             if (parsed2 == 0)
                    {
                    Console.WriteLine("на нуль ділити не можна");
                    return -1;
                    }
            double dilenia = parsed1/ parsed2;
            return dilenia;
        }
        
        static void Main()
        {
           Console.WriteLine("Введіть перше число");
            string number1 = Console.ReadLine();
            if (!double.TryParse(number1, out double parsed1))        
            {   
                Console.WriteLine("значення один не валідне");
                return;
            }

            Console.WriteLine("Введіть друге число");
            string number2 = Console.ReadLine();
            if (!double.TryParse(number2, out double parsed2))
            {
              Console.WriteLine("значення два не валідне");  
              return;
            }
            Console.WriteLine("Введіть операцію +, *, /, -"); 

             string operation = (Console.ReadLine());
             double result = 0;
                switch(operation)
                {
                case "+":
                    result = Add(parsed1, parsed2);   
                    break;
                case "*":
                    result = Multiply(parsed1, parsed2);
                    break;
                case "/":
                    result = Divide(parsed1, parsed2);
                    break; 
                case "-":
                    result = Substract(parsed1, parsed2);
                    break;
                default:
                    Console.WriteLine("Ви ввели не валідний символ");
                    return;
                }
                Console.WriteLine($"Дорівнює = {result}"); 
            }
        }
}