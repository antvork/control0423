// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
int GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(string[]array)
{
    for(int i= 0; i<array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}


string[] GetNewArray(string[]myArray)
{
string[] myNewArray = { };
for (int i = 0, j = 0; i < myArray.Length; i++)
{
    if (myArray[i].Length <= 3)
    {
        Array.Resize(ref myNewArray, myNewArray.Length + 1);
        myNewArray[j] = myArray[i];
        j++;
    }
}
return myNewArray;
}

string[] text = new string[GetNumber("Введите длинну массива: ")];
Console.WriteLine("Заполните массив: ");
FillArray(text);
string[]newText = GetNewArray(text);
Console.WriteLine(string.Join(", ", newText));
