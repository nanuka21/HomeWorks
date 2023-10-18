

int[,] Matrix = new int[2, 2] { { 1, 3 }, { 4, 5 } };
Console.WriteLine(Matrix[0, 0] * Matrix[1, 1] - Matrix[0, 1] * Matrix[1, 0]);
foreach (int number in Matrix)
{
    Console.WriteLine(number);
}
