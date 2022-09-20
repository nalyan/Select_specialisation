/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/

string[] ArrayLimitChar(string[] array, int limitChar)
{
    int length = 0;
    for(int i=0; i<array.Length; i++) 
    {
        if(array[i].Length <= limitChar) length++;
    }
    string[] newArray = new string[length];
    int k = 0;
    for(int j=0; j<array.Length; j++)
    {
        if(array[j].Length <= limitChar) newArray[j-k] = array[j];
        else k++;
    }
    return newArray;
}
void PrintArray(string[] array)
{
    for(int i=0; i<array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}
Console.Clear();
int limitChar = 3;
string[] array = {"Hello", "2", "world", ":-)"};
string[] newArray = ArrayLimitChar(array, limitChar);
PrintArray(array);
PrintArray(newArray);