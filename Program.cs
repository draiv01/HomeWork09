// Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.


// void ShowNumbers(int n)
// {
//     Console.Write(n+ " ");
//     while(n>0)
//     if (n % 2 == 0){
//      ShowNumbers(n/=2);
//      n=0;}
//      else
//      ShowNumbers(n/=2);
//      n=1;

// }

// Console.Write("Enter your number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// int CountSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + CountSum(m, n - 1);
// }
// Console.Write("Введите N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите M:");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма элементов от {m} до {n} = {CountSum(m, n)}");
