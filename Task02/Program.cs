Console.WriteLine ("Введите первое число: ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.WriteLine ("Введите второе число: ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

Console.WriteLine ("Введите третье число: ");
string userInput3 = Console.ReadLine() ?? "";
int userNumber3 = int.Parse(userInput3);

int max1 = 0;
int max2 = 0;

if (userNumber1>userNumber2)
{
    max1 = userNumber1;
}
else 
{
    max1 = userNumber2;
}

if (userNumber2>userNumber3)
{
    max2 = userNumber2;
}
else 
{
    max2 = userNumber3;
}

if (max1>max2)
{
  Console.WriteLine ("Максимальное число -> " + max1);  
}
else
{
   Console.WriteLine ("Максимальное число -> " + max2); 
}


