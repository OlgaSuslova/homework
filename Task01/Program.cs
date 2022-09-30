Console.WriteLine ("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.WriteLine ("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);


if (userNumber1 == userNumber2)
{
    Console.WriteLine ("Числа равны");
}

else if (userNumber1>userNumber2)
{
    Console.WriteLine (userNumber1 + " -> max");
    Console.WriteLine (userNumber2 + " -> min");
}
else if (userNumber1<userNumber2)
{
    Console.WriteLine (userNumber1 + " -> min");
    Console.WriteLine (userNumber2 + " -> max");
}