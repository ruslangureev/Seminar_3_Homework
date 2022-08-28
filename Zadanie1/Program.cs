Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length > 5 || number.Length < 4)
{
    Console.WriteLine("Число не является пятизначным");
}
else
{

if(number[0] == number[4] && number[1] == number [3])
{
    Console.WriteLine(number + " является палиндромом");
}
else
{
    Console.WriteLine(number + " не является палиндромом");
}
}
