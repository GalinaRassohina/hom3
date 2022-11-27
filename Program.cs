// Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, и проверяет, является ли этот 
//день выходным. 6 -> да 7 -> да 1 -> нет

int day = 6;
if(day > 1 && day < 6)
{
    Console.Write(day);
    Console.WriteLine( "нет");
}
if(day == 6 && day == 7)
{
    Console.Write(day);
    Console.WriteLine ("да");
}