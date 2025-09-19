#region Tasks 1 and 2
var random = new Random();
int[] values = new int[10];
int sum = 0;


for (int i = 0; i < values.Length; i++) // creating an array of 10 random numbers from -10 to 10 and index check
{
    values[i] = random.Next(-10, 11); 

    if (i % 2 == 0)
    {
        Console.WriteLine(values[i] );
    }

    sum += values[i];

}
Console.WriteLine();
if (sum > 0) // checking if the sum is negative or not
{
    Console.WriteLine("The amount is not negative");
}

else
{
    Console.WriteLine("The sum is negative"); 
}
Console.WriteLine();
#endregion 


#region Task 3 
int[,] table = new int[9, 9]; // Creating a multiplication table

for (int i = 0; i < 9; i++)       
{
    for (int j = 0; j < 9; j++)   
    {
        table[i, j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write($"{table[i, j],4}"); 
    }
    Console.WriteLine();
}
Console.WriteLine();
#endregion

#region Task 4
int[,] ints = new int [5, 5] //Creating a 5x5 two-dimensional array
{ 
    { 1, 2, 3, 4, 5 }, 
    { 6, 7, 8, 9, 10 }, 
    { 11, 12, 13, 14, 15 }, 
    { 16, 17, 18, 19, 20 }, 
    { 21, 22, 23, 24, 25 }
};
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{ints[i, j],4}");
    }
    Console.WriteLine();
}

int min = ints[0, 0], max = ints[0, 0];
int minRow = 0, minCol = 0;
int maxRow = 0, maxCol = 0;

for (int i = 0; i < 5; i++) //Finding the minimum and maximum elements in the array
{
    for (int j = 0; j < 5; j++)
    {
        if (ints[i, j] < min)
        {
            min = ints[i, j];
            minRow = i;
            minCol = j;
        }
        if (ints[i, j] > max)
        {
            max = ints[i, j];
            maxRow = i;
            maxCol = j;
        }
    }
}
Console.WriteLine($"Maximum element: {max} (line {maxRow}, column {maxCol})");
Console.WriteLine($"Minimal element: {min} (line {minRow}, сcolumn {minCol})");
Console.WriteLine();


#endregion

#region Task 5
Console.Write("Enter the number of days: "); //Working with enums
int dayN = int.Parse(Console.ReadLine());

WeekDays result = (WeekDays)(dayN % 7);
Console.WriteLine($" through {dayN} there will be days: {result}");
enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }


#endregion




