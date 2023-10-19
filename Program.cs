
int[] array = { 5, 2, 4, 1 };

int n = array.Length;

for (int i = 1; i < n; i++)
{
    int key = array[i];
    int j = i - 1;
    while (j >= 0 && array[j] > key) 
    {
        array[j + i] = array[j];
        j--;
    }
    array[j + 1] = key;
}
foreach (int element in array)
    {
    Console.WriteLine(element + " ");
}
Console.WriteLine();


