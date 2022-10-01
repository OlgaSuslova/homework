Console.WriteLine ("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

if (userNumber%2 == 0)
{
    Console.WriteLine ("Число чётное");
}
else
{
    Console.WriteLine ("Число нечётное ");
}