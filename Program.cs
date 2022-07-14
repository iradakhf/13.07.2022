using System;
namespace ConsoleApp41
{
    class Program
    {
        public static void Main(string[] args)
        { int number1 = 70;
            int number2 = 7;
            Subtraction subtraction = new Subtraction();
           int additionResult =  subtraction.Operate(number1, number2);
            Console.WriteLine($" Subtraction : first number = {number1} , second number = {number2} , result = {additionResult} ");

            Addition addition = new Addition();
            int subResult = addition.Operate(number1, number2);
                Console.WriteLine($" Addition : first number = {number1} , second number = {number2} , result = {subResult} ");

            Multiplication multiplication = new Multiplication();
            int multiResult = multiplication.Operate(number1, number2);
            Console.WriteLine($" Multiplication : first number = {number1} , second number = {number2} , result = {multiResult} ");

            Devision devision = new Devision();
            int devResult = devision.Operate(number1, number2);
            Console.WriteLine($" Devision : first number = {number1} , second number = {number2} , result = {devResult} ");
        }

    }

    abstract class Calculation
    {
        public abstract int Operate(int number1, int number2);
    }
    sealed class Addition : Calculation
    {
        public override int Operate(int number1, int number2)
        {
            return number1 + number2;
        }
    }
    sealed class Subtraction : Calculation
    {
        public override int Operate(int number1, int number2)
        {
            return number1 - number2;
        }
    }
    sealed class Multiplication : Calculation
    {
        public override int Operate(int number1, int number2)
        {
            return number1 * number2;
        }
    }
    sealed class Devision : Calculation
    {
        public override int Operate(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}