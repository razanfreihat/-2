//The first question :
int[] array = { 34, 23, 45, 67, 89, 12, 90, 77, 88 };
int sum = 0;
int average = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
    average = sum / array.Length;
}
for (int i = 0; i < array.Length; i++)
{

    if (array[i] > average)
    {
        Console.WriteLine(array[i]);
    }

}
Console.WriteLine("     ");
//The second question:
Console.WriteLine("Enter the number of element:");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Enter element {i}:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = arrayLength - 1; i >= 0; i--)
{
    Console.WriteLine($"NUMBER[{i}]={numbers[i]}");
}
// The third questionn:write a program that finds the first character in a text (string) that does not repeat anywhere else in the string.
Console.WriteLine("Enter a string:");
string text = Console.ReadLine();
char n = '0';// to hold the first non-repeating character
for (int i = 0; i < text.Length; i++)
{
    char currentChar = text[i];
    if (text.IndexOf(currentChar) == text.LastIndexOf(currentChar))
    {
        n = currentChar;
        break;
    }
}

if (n != '0')
{
    Console.WriteLine($"The first non-repeating character is: {n}");
}