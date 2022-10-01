Console.WriteLine ("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);

int count = 2;

while (count<=userNumber)
{
    Console.Write (count + " ");
    count = count + 2;
}
