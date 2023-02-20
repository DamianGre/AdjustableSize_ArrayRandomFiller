int arraySize;
try
{
    do
    {
        Console.WriteLine("Enter array size: ");
        arraySize = Convert.ToInt32(Console.ReadLine());
        if (arraySize <= 0)
        {
            Console.WriteLine("Arrays size must be bigger then 0!");
        }
    } while (arraySize <= 0);


String[] namesArray = new String[] { "Damian", "Stanisław", "Karol", "Bartosz", "Dariusz", "Tomasz",
"Daniel", "Jakub", "Wojciech", "Piotr"};

String[] namesFilled = new String[arraySize];


Random randomNumber = new Random();



for (int i = 0; i < namesFilled.Length; i++)
{
    namesFilled[i] = namesArray[randomNumber.Next(0, namesArray.Length)];
}

foreach (String names in namesFilled)
{
    Console.WriteLine(names);
}
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}