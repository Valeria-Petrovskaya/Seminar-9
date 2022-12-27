int SumNM(int minNum, int maxNum)
{
    if (minNum < maxNum)
    {
        return maxNum + SumNM(minNum, (maxNum-1));
    }
    else
    {
        return maxNum;
    }
}
Console.WriteLine("Введите меньшее число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите большее число:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNM(m, n));