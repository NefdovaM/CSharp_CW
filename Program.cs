string[] myArray = new string[7] { "I", "-233", "7777", "<3", "my", "46-7", "BF!" };
string[] myArray2 = new string[myArray.Length];
void newArray(string[] myArray, string[] myArray2)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            myArray2[count] = myArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}
newArray(myArray, myArray2);
PrintArray(myArray2);
