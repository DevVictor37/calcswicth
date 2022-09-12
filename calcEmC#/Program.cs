using System;

namespace Calculadora
{
    class Program
    {
        enum Calculadora {
            Adição = 1, Subtração, Multiplicação, Dividir, Porcentagem
        }
        static void Main(string[] args)
        {
            double num1, num2;

            string tm;

           
         Console.WriteLine("Selecione uma das opções abaixo: ");
         Console.WriteLine("1-Adição\n2-Subtração\n3-Multiplicação\n4-Dividir\n5-Porcentagem\n(Ex: 1, 4");
         int index = int.Parse(Console.ReadLine());
         Calculadora somar = (Calculadora)index;

         switch (somar)
         {
            case Calculadora.Adição:

            Console.WriteLine("Digite um valor");
            tm = Console.ReadLine();
            num1 = int.Parse(tm);

            Console.WriteLine("Digite outro número");
            Console.ReadLine();
            num2 = int.Parse(tm);

            double resultado;

            resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado);
            Console.WriteLine("Soma: "+ num1 + " + " + num2 +" = "+ resultado);
            break;

            case Calculadora.Subtração:
            Console.WriteLine("Você está em subtração");
              Console.WriteLine("Digite um valor");
            tm = Console.ReadLine();
            num1 = int.Parse(tm);

            Console.WriteLine("Digite outro número");
            Console.ReadLine();
            num2 = int.Parse(tm);

            resultado = num1 - num2;
            Console.WriteLine("Soma: "+ num1 + " - " + num2 +" = "+ resultado);
            break;

            case Calculadora.Multiplicação:
             
             Console.WriteLine("Você está em multiplicação!");
             Console.WriteLine("Digite um valor");
            tm = Console.ReadLine();
            num1 = int.Parse(tm);

            Console.WriteLine("Digite outro número");
            Console.ReadLine();
            num2 = int.Parse(tm);

            resultado = num1 * num2;
            Console.WriteLine("Soma: "+ num1 + " × " + num2 +" = "+ resultado);
            break;

            case Calculadora.Dividir:
              
              Console.WriteLine("Você está em divisão!");
              Console.WriteLine("Digite um valor");
            tm = Console.ReadLine();
            num1 = int.Parse(tm);

            Console.WriteLine("Digite outro número");
            Console.ReadLine();
            num2 = int.Parse(tm);

            resultado = num1 / num2;
            Console.WriteLine("Soma: "+ num1 + " ÷ " + num2 +" = "+ resultado);

            break;

            case Calculadora.Porcentagem:
              
              Console.WriteLine("Você está na porcentagem!");
              Console.WriteLine("Digite um valor");
            tm = Console.ReadLine();
            num1 = int.Parse(tm);

            Console.WriteLine("Digite outro número");
            Console.ReadLine();
            num2 = int.Parse(tm);

            resultado = num1 % num2;
            Console.WriteLine("Soma: "+ num1 + " % " + num2 +" = "+ resultado);

            break;
            
         } 
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
    }
}