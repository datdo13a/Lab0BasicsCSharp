/*
 * CPRG 211 B Lab 0
 * Author: Jolanta
 * When: Winter 2025
 */

using Lab0;
using System.Data;
using System.Runtime.InteropServices.Marshalling;

int low, high;
int diff; // difference between low and  high

// get positive low number 
// get high number that is greater than low

low = Utilities.GetPositiveInt("low number");
high = Utilities.GetIntInRange("high number", low + 1, Int32.MaxValue);

// calculate and print difference between low and high
diff = high - low;
Console.WriteLine($"Difference between {low} and {high} is {diff}");

// create an array and store number between low and high (inclusive)
int[] numbers = new int[diff + 1];
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = low + i;
}

Console.WriteLine("Numbers in the array");
foreach( int num in numbers )
    Console.WriteLine(num);

// create a file "numbers.txt" and write to it the numbers from the array in reverse order
StreamWriter streamWriter = File.CreateText("numbers.txt");
for(int i = numbers.Length -1; i >= 0; i--)
{
    streamWriter.WriteLine(numbers[i]);
}
streamWriter.Close(); // important to finalize the writing
Console.WriteLine("File written");

// read the numbers back from the file and print out the sum of the numbers
StreamReader streamReader = File.OpenText("numbers.txt");
string nextLine;
for(int i = 0; i < numbers.Length; i++)
{
    nextLine = streamReader.ReadLine() ?? "";
    numbers[i] = Convert.ToInt32(nextLine);
}
streamReader.Close();

Console.WriteLine("Values from file");
foreach(int num in numbers )
    Console.WriteLine(num);

//print prime numbers between low and high

Console.WriteLine($"Prime numbers in range {low} - {high}");
Utilities.GetPrime("Prime numbers in the range:", low, high);

//create a list instead of an array

List<int> numberList = new List<int>();
for (int i = 0; i < diff+1; i++)
{
    numberList.Add(low + i);
}

Console.WriteLine("Numbers in the list");
foreach (int num in numberList)
    Console.WriteLine(num);


