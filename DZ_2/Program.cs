Console.Write("Введите число: ");
int user_input = Convert.ToInt32(Console.ReadLine());
if (user_input % 7 == 0 && user_input % 23 == 0)
{
    System.Console.WriteLine($"{user_input} кратно 7 и 23");
}
else
{
    System.Console.WriteLine($"{user_input} не кратно 7 и 23");
}