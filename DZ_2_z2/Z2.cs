System.Console.Write("Введите координату точки Х: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
        Console.Write("1");
else if (x < 0 && y < 0)
        Console.Write("3");

else if (x < 0 && y > 0)
        Console.Write("2");

else if (x > 0 && y < 0)
        Console.Write("4");


