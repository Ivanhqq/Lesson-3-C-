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


