

int[] array = new int [7];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99,1000);
    Console.Write(array[i] + " "); 

}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] % 2;
    Console.Write(array[i]+ " ");
    if (array[i] == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine(count);
