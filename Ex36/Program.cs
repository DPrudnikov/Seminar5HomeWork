
int [] array = new int [7];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine(sum);