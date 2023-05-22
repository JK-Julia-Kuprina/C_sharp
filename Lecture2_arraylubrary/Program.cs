void FillArray(int[] collection);
{
    int length = collection.Length;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index++;

    }
}

void RrintArray(int[] col);
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
