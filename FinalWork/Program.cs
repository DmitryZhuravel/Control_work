/* Написать программу, которая из имеющегося массива строк формирует массив
из строк, длина которых меньше либо равно 3 символа. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
решении не рекоммендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами. */

string[] array = new string[8] { "Hello", "2", "world", "Russia", "computer", ":-)", "123", "Hi"};
string[] newArray = new string[array.Length];

FillArray(array, newArray);
PrintArray(newArray);

void FillArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}"+"   ");
    }
}
