//Методы
// ВИД 1
/*void Metod1()
{
    Console.WriteLine("Автор ...");
}
Metod1();*/

// ВИД 2
/*void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2(msg: "Текст сообщения");

void Metod21(string msg, int count)
{
    int i = 0;
    while (i< count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod21("Текст", 4);*/

// ВИД 3

/*int Metod3()
{
    return DateTime.Now.Year;
}

int year = Metod3();
Console.WriteLine(year);*/

// ВИД 4

/*string Metod4 (int count, string text)
{
     int i = 0;
     string result = String.Empty;
     while (i < count)
     {
         result = result + text;
         i++;
     }
     return result;
}
string res = Metod4 (10, "asdf");
Console.WriteLine(res);*/

// ЦИКЛ for
/*string Metod4 (int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
     return result;
}
string res = Metod4 (10, "asdf");
Console.WriteLine(res);*/

// ЦИКЛ В ЦИКЛЕ
/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine(" ");
}*/

// ЦИКЛ. РАБОТА С ТЕКСТОМ
// Дан текст. В тексте все пробелы нужно заменить черточками,
// маленькие "к" заменить на "К",
// а большие "С" заменить на "с".

/*string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винцегегроде,"
            + "ва бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace (string text, char oldValue, char newValue) 
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
       if(text[i] == oldValue) result = result + $"{newValue}";
       else result = result + $"{text[i]}";
    }
    return result;
}       
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);  
Console.WriteLine(); 
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);  
Console.WriteLine(); 
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);  */

// СОРТИРОВКА МЕТОДОМ МИНИМАКСА.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArrey (int [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
 {   
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1 ; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i]= array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArrey(arr);
SelectionSort(arr);
PrintArrey(arr);