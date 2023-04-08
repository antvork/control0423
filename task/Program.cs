// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] myArray = { "apple", "oil", "a1", "table", "fruit", "l2", "2344" };
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

Console.WriteLine(string.Join(", ", myNewArray));
