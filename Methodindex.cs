

class program
{
    static void Main()
    {

        int[] myarray = { 11, 12, 13, };
        int sum = SumofIndex(myarray, 1);
        Console.WriteLine(sum);


    }



    static int SumofIndex(int[] array, int index)

    {
        int sum = 0;

        int number = array[index];

        string numbertostring = number.ToString();

        for (int i = 0; i < numbertostring.Length; i++)
        {
            char chardigit = numbertostring[i];
            if (char.IsDigit(chardigit))
            {
                int digit = int.Parse(chardigit.ToString());
                sum += digit;
            }
        }
        return sum;

    }





}
