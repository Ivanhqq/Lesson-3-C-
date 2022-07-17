// Нужно заменить несколько символов в тексте
// пробелы на черточки, маленькие к на  большие К, а большие С на маленькие с

string text = "Деньги пахнут pussy, а Сумка Birkin, только нал Сумка Birkin, только нал";
              


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
            
    }
    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace(newText, 'м', 'М');
Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace(newText, ',', '!');
Console.WriteLine (newText);
