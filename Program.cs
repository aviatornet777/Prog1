//Console.WriteLine("Введите число  ");
//int num=Convert.ToInt32(Console.ReadLine()); 

//Console.WriteLine("Введите число  ");
//int num2=Convert.ToInt32(Console.ReadLine());
//newRandom().Next(num,num2);
//{
 //   Console.WriteLine();
//}

//Написатьт программу котрая выводит случайноое число из отрезка(10,99)
// и показывает наибольшую цыфру числа


//int num = new Random().Next(10,100); //выбираем случайное число от 10 до 99, присваеваем его переменной num
//Console.WriteLine(num);//выводим это число
 
// int num1=num/10; //определяем сколько десятков
 //int num2=num%10; //определяем количество единиц

 //if(num1>num2)// ставим условие
//{
 //   Console.WriteLine(num1);//если num1 больше, то выводим его
//}

//else
//{
 //   Console.WriteLine(num2);// если нет выводим num2 
//}


//          Задача 2
//  Написать программу которая выводит
// случайное трехзначное число и удаляет вторую цифру этого числа

//int num = new Random().Next(100,1000); //выбираем случайное число от 10 до 99, присваеваем его переменной num
//Console.WriteLine(num);

//int num1=num/100; //определяем сколько сотен
// int num2=num%10; //определяем количество единиц

// int result=num1*10+num2; // вводим переменную result количество сотен умножаем на 10, получаем десятки и прибавляем количество единиц
// Console.WriteLine(result); //выводим результат

//



//          Задача 3
// написать программу которая будет принимать на вход два числа и  
// выводить является ли второе число кратным первому
// если число 2 не кратно числу 1, то выводится остаток от деления


//Console.WriteLine("Введите число");
//int num1=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число");
//int num2=Convert.ToInt32(Console.ReadLine());

//if (num1 % num2 == 0)
//{
  //  Console.WriteLine("кратны");

//}
//else
//{
    //Console.WriteLine("Остаток о деления");можно записать Console.WriteLine("Остаток о деления"+ num1 % num2); Канкатинация
    // так же можно записать Console.WriteLine($"Остаток о деления{num1 % num2}"); Интерполяция
   // Console.WriteLine(num1/num2);
//}


//          Задача 4
//          Напишите программу котрая принимает на вход
//         число и проверяет, кратно ли оно одновременно
//          7 и 23
//
//
//Console.WriteLine("Введите большое число");
//int num1=Convert.ToInt32(Console.ReadLine());

//if ((num1 % 7 == 0) && (num1 % 23 == 0))   //стоит && значит выполняется & первое условие & второе
//{
 //   Console.WriteLine("Да");
//}
//else
//{
  //    Console.WriteLine("Нет");
//}

//          3адача 5
//      Написать программу, которая  принимает на вход
//      два числа и проверяет явлется одно число 
//      квадратом другого.
//      
        Console.WriteLine("Введите число");
        int num1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число");
        int num2=Convert.ToInt32(Console.ReadLine());

        if ((num1 == num2*num2) || (num2 == num1*num1))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }