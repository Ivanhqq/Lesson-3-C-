// Тип 1

void Method1() 
{
    Console.WriteLine("Просто выдает на печть");
}

 Method1();

// Тип 2

void Method2(string msg, int count)
{
  int i = 0;
while (i < count)
{
    Console.WriteLine(msg);
    i++;
}
}

Method2("Хасбик", 6);

//Тип 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine (year);

//Тип 4

string Method4(int count, string text)
{
int i = 0;
string result = String.Empty; //Пустая строка

while (i < count)
{
    
result = result + text;
    i++;
}
return result;

}
string res = Method4(10, "ES");
Console.WriteLine(res);





