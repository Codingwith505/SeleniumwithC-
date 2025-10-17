

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);


/*****************************************************************/

// Create decision logic with if statements

Random dice = new Random();

int roll = dice.Next(1, 7);
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);

int total = roll + roll1 + roll2;



if ((roll == roll1) || (roll1 == roll2) || (roll2 == roll))
{
    if (roll == roll1 && roll1 == roll2)
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }

    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

Console.WriteLine($"{roll}+{roll1}+{roll2} = {total}");


// Improve renewal rate of subscriptions

/*****************************************************************/


Random day = new Random();
int daysUntilExpiration = day.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration > 10)
{
    Console.WriteLine("");

}
else if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired.");

}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage>0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}


/**************************************************************************************/

//Report the Order IDs that need further investigation

String[] orderIds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (String orderId in orderIds)
{
    if (orderId.StartsWith("B"))
    {
        Console.WriteLine($"Further investigation order Id: {orderId}");
    }
}





/**********************************************************************************************/


string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] charMessage = str.ToCharArray();

Console.WriteLine(charMessage);
// Reverse the chars
Array.Reverse(charMessage);
Console.WriteLine(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage)
{
    if (i == 'o')
    {
        x++;
    } 
}
// convert it back to a string
string new_message = new String(charMessage);

// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");






