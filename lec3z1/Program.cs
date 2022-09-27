// вид 1
void Method1()
{
    Console.WriteLine("Автор Я");
}
//Method1();



// вид2
//void Method2(string msg)
//{
  //  Console.WriteLine(msg);
//}
//Method2(msg: "текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "текст сообщения", count: 4);
//Method21(count: 4, msg: "тек сооб");

//Вид3

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
// Console.WriteLine(Year);


//Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, " gena ");
Console.WriteLine(res);