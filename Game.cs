Console.WriteLine("Hello this is Number Guessing Game you have 3 Attemps , good luck");
int attemps = 0;
int maxattemps = 3;
bool won = false;


Random random = new Random();
int randomnumber = random.Next(0, 10);

while (attemps<maxattemps)
{
    Console.WriteLine("Enter th number");
    int customernumber = int.Parse(Console.ReadLine());

    if (customernumber == randomnumber)
    {
        Console.WriteLine("Congretulation you Won");
        break;
    }

    if (customernumber!=randomnumber)
        {
            Console.WriteLine("Your Number is not Correct");
       
        }
   
    attemps++;
     
}
if (!won)
{
    Console.WriteLine("Sorry you Lose");
}