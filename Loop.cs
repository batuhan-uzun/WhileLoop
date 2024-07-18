// i ilk sorunun sayacıdır
int i = 0;
while (i < 5)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
Console.WriteLine("");

// k ikinci sorunun sayacıdır
int k = 2;
while (k < 20)
{
    Console.Write(k + " ");
    k++;
}
Console.WriteLine("\n");

// l üçüncü sorunun sayacıdır
int l = 2;
while (l < 20)
{
    if (l % 2 == 0) Console.Write(l + " ");
    l++;
}
Console.WriteLine("\n");

// m dördüncü sorunun sayacıdır, toplam sum değişkeninde tutulur
int m = 51;
int sum = 0;
while (m < 150)
{
    sum += m;
    m++;
}
Console.WriteLine(sum + "\n");

// n beşinci sorunun sayacıdır, evenSum çift oddSum tek sayıların toplamını tutar
int n = 2;
int evenSum = 0;
int oddSum = 0;
while (n < 120)
{
    if (n % 2 == 0) evenSum += n;
    else oddSum += n;
    n++;
}
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenSum + "\n" + "1 ile 120 arasındaki tek sayıların toplamı: " + oddSum);