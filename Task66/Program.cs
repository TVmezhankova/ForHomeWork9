// Задайте значения A и B.
// Напишите программу, которая найдет сумму натуральных элементов в промежутке от A до B.


Console.Write("Введите значение переменной а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)    Console.WriteLine("Ошибка! Переменная а > b"); 
else{          
            int i, sum = 0;
            for (i = a; b >= i; i++)
            sum += i;
            Console.WriteLine("Сумма чисел равна: " + sum);
}
          
