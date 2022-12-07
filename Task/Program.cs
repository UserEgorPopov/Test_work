Console.Write("Желаемое кол-во элементов:");
int size = Convert.ToInt32(Console.ReadLine());
int item = 0;
int length = 3;

string[] arrayEnter = new string[size];
for(int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите элемент №{i+1}:");
    string element = Convert.ToString(Console.ReadLine());
    arrayEnter[i] = element;
}

string[] arrayExit = new string[size];

for(int j = 0; j < size; j++)
{
    if(arrayEnter[j].Length <= length)
    {
        arrayExit[item] = arrayEnter[j];
        item++;
    }
}

Console.WriteLine("Итоговый массив:");
PrintArray(arrayExit);


void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}




