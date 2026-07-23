
// -- Unidad 3/8

// Testing a change to the message.
// int widgetSold = 7;
// Console.WriteLine($"{firstName} sold {widgetSold} widgets.");
/*
string firstName = "Bob";
int widgetsPurchased = 10;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*//*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*//*
Random random = new Random();
string[] orderIDs = new string[5];

for(int i=0; i<orderIDs.Length; i++)
{
    int prefixValue = random.Next(65,70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (string orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// -- Unidad 4/8

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
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

*/

// -- Unidad 5/8

/*
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') {x++;}}
// convert it back to a string
string new_message = new string(charMessage);
// prrint it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/

/*
string message = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = message.ToCharArray();

int timesThatOAppears = 0;
foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    {
        timesThatOAppears++;
    }
}

Array.Reverse(charMessage);
string reversedMessage = new string(charMessage);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {timesThatOAppears} times.");

*/