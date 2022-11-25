// Задание 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли это день выходным.

// ПЕРВЫЙ ВАРИАНТ ОФОРМЛЕНИЯ РЕШЕНИЯ С ВЫВОДОМ ДНЯ НЕДЕЛИ
// try
// {
//     Console.WriteLine ("Введите день недели");
//     var days = Convert.ToInt32(Console.ReadLine());
    
//     switch(days)
//     {
//         case 1:
//             Console.WriteLine("Понедельник не выходной день!");
//             break;
//         case 2:
//             Console.WriteLine("Вторник не выходной день!");
//             break;
//         case 3:
//             Console.WriteLine("Среда не выходной день!");
//             break;
//         case 4:
//             Console.WriteLine("Четверг не выходной день!");
//             break;
//         case 5:
//             Console.WriteLine("Пятница выходной день!");
//             break;
//         case 6:
//             Console.WriteLine("Суббота выходной день!");
//             break;
//         case 7:
//             Console.WriteLine("Воскресенье выходной день!");
//             break;
//     }
    
// }
// catch
// {
    
// }
// ВТОРОЙ ВАРИАНТ ОФРМЛЕНИЯ РЕШЕНИЯ БЕЗ ВЫВОДА ДНЯ НЕДЕЛИ, НО С ЗАЩИТОЙ ОТ НЕПРАВИЛЬНОГО ВВОДА
try
{
    Console.WriteLine ("Введите день недели");
    var days = Convert.ToInt32(Console.ReadLine());
    if (days >= 8)
    {
    Console.WriteLine("Учите дни недели!");
    }
    else
    {
    switch(days)
    	{
        	case 1 or 2 or 3 or 4 or 5:
            		Console.WriteLine("Не выходной день!");
            		break;
        
        	case 6 or 7:
            		Console.WriteLine("Выходной день!");
            		break;
    	}
    }
}
catch
{
    Console.WriteLine ("Введено неверное значение!");
}

