Random random = new Random();

// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);


/*
int monsterHealth = 50;
int heroHealth = 50;



do
{
    int hero = random.Next(1, 11);
    monsterHealth -= hero;
    Console.WriteLine($"Monster was damaged and lost {hero} health and now has {monsterHealth} health.");
    if (monsterHealth <= 0) continue;
    int monster = random.Next(1, 11);
    heroHealth -= monster;
    Console.WriteLine($"Hero was damaged and lost {monster} health and now has {heroHealth} health.");
} while (heroHealth > 0 && monsterHealth > 0);
Console.WriteLine(heroHealth>monsterHealth? "Hero wins!":"Monster wins!");

*/

// how to take input from user and put some condition 

/*
String? readResult;
bool validString = false;
Console.WriteLine("Enter a string at least 3 character");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validString = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validString == false);
Console.WriteLine($"your input is: {readResult}.");

*/
//write code that validates integer input

int numericValue = 0;
bool validNumber = false;
String? readNUmberResult;



Console.WriteLine("Enter an integer value between 5 and 10");

do
{
   readNUmberResult = Console.ReadLine();
    validNumber = int.TryParse(readNUmberResult, out numericValue);
    if(validNumber)
    {
        if (numericValue >=5 && numericValue <=10)
        {
            Console.WriteLine($"Your input value {numericValue} has been accepted.");
            validNumber = true;
        }
        else
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            validNumber = false;
        }
    }
    else{
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validNumber == false);






