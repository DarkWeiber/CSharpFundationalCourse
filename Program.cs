/*
Code to reverse a string and count the number of times
a particular character (in this execution the character "o")
appears in a string
*/
/*
string originalMessage = "The quick brown fox jumps over the lazy dog.";


char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o') 
    { 
        letterCount++; 
    } 
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
*/

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);

//string myValue = "a";
//Console.WriteLine(myValue != "a");

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(!pangram.Contains("fox"));
//Console.WriteLine(!pangram.Contains("cow"));


//int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount :{(saleAmount > 1000 ? 100 : 50)}");

//using System.Security.Cryptography;

//int number = new Random().Next(1, 11);
//string coinFlip = (number % 2 == 0) ? "Heads" : "Tails";
//Console.WriteLine(coinFlip); 

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    Console.WriteLine((level > 55)? "Welcome, Super Amin user." : "Welcome, Admin user.");
}

else if (permission.Contains("Manager"))
{
    Console.WriteLine((level > 20) ? "Contact an Admin for access." : "You do not have sufficient privileges" );
}
else
{
    Console.WriteLine("You do not have sufficient privileges");
}


