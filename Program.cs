// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine ("Start");
int value = 549;

int a = value / 100;
int b = (value / 10) % 10;
int c = value % 10;

int result = a + b + c;
Console.WriteLine (result); 
Console.WriteLine ("End");

