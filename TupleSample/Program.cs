(int, double) SumAndAverage(params int[] values)
{
    int sum = 0;
    double average = 0;
    foreach(int value in values)
    {
        sum += value;
        average = sum * 1.0 / values.Length;
    }
    return (sum,  average);
}

int[] values = new int[10];
void create_array(int[] values)
{
    Random rd = new Random();
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = rd.Next(100);
    }
}

void print_array(int[] values)
{
    foreach(int value in values)
    {
        Console.Write($"{value}\t");
    }
}

create_array(values);
print_array(values);
Console.WriteLine("\nThong tin Sum + Avg: ");
(int s, double avg) = SumAndAverage(values);
Console.WriteLine($"SUM = {s}");
Console.WriteLine($"AVG = {avg}");
