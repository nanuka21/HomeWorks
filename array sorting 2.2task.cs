int[] array = { 9, 3, 5, 7, 1 };
int temp = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = i+1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    Console.WriteLine(array[i]);
}
