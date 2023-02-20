int arraySize;
int foundNameCounter = 0;
String nameToFound;
String againFounder;

Boolean foundNameAgain = true;

String[] namesArray = new String[] { "damian", "stanisław", "karol", "bartosz", "dariusz", "tomasz",
                "daniel", "jakub", "wojciech", "piotr"};

try
{
    do
    {
        Console.Write("Enter array size: ");
        arraySize = Convert.ToInt32(Console.ReadLine());
        if (arraySize <= 0)
        {
            Console.WriteLine("Arrays size must be bigger then 0!");
        }
    } while (arraySize <= 0);

    String[] namesFilled = new String[arraySize];

    Random randomNumber = new Random();

    for (int i = 0; i < namesFilled.Length; i++)
    {
        namesFilled[i] = namesArray[randomNumber.Next(0, namesArray.Length)];
    }

    Console.WriteLine("This are all names that has been generated:");
    int nameNumber = 1;
    foreach (String names in namesFilled)
    {
        Console.WriteLine("Name number " + nameNumber + " is: " + names);
        nameNumber++;
    }
    do
    {
        foundNameCounter = 0;
        foundNameAgain = true;

        Console.Write("Enter name to found and I will count how many times it has been found in random names array: ");
        nameToFound = Console.ReadLine();
        nameToFound = nameToFound.ToUpper();

        for (int i =0; i< namesFilled.Length;i++) {
            namesFilled[i] = namesFilled[i].ToUpper();
        }
        
        foreach (String names in namesFilled)
        {             
            if (names == nameToFound)
            {
                foundNameCounter++;
            }
        }

        Console.WriteLine("Name " + nameToFound + " has been found: " + foundNameCounter + " times in all generated names.");
        Console.Write("Do You want to found other name? (Y/N)");
        againFounder = Console.ReadLine();
        againFounder = againFounder.ToUpper();
        if (againFounder == "N")
        {
            foundNameAgain = false;
        }
    } while (foundNameAgain == true);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}