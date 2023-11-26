Console.Write("Введите число из отрезка [10, 99]: ");
int user_input = Convert.ToInt32(Console.ReadLine());
int num_1 = user_input / 10;
int num_2 = user_input % 10;
if (num_1 > num_2)
    System.Console.WriteLine(num_1);
    else {
System.Console.WriteLine(num_2);
    }
