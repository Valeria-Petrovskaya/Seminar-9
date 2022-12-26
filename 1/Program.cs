int rec (int M, int N)
{
    if (M > N)
    return N;
    return ((M + N) * (N - M + 1))/2;
}
Console.Clear();
Console.Write("Введите M и N: ");
int [] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine(rec(numbers[0], numbers [1]));
