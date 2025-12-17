Console.WriteLine("Выбери:");
Console.WriteLine("1)Камень");
Console.WriteLine("2)Ножницы:");
Console.WriteLine("3)Бумага:");
Console.Write("Выбор:");
Console.ReadLine();


if(Random.Shared.Next() % 3 == 0)
    Console.WriteLine("Ты победил!");

else
    Console.WriteLine("Ты проиграл");