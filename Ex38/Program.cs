
int [] array = new int [7];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,101);
    Console.Write(array[i] + ", "); 

}
Console.WriteLine();

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{   
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
    
}
Console.WriteLine(max - min);