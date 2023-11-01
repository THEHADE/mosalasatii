//amir hossein hemmati
//T.4 mosalasati
long n;
long m;
long k;
long x;
string yesorno;
do
{
    Console.WriteLine("adad n,om ra vared konid:");

    n = Convert.ToInt64(Console.ReadLine());

    Console.WriteLine("adad m,om ra vared konid:");

    m = Convert.ToInt64(Console.ReadLine());

    for (k = n; k <= m; k++)
    {
        x = k * (k + 1) / 2;

        Console.WriteLine($"barabar ast ba : {x}");
    }
    Console.WriteLine("aya mikhahid edame dahid? bale/kheir");

    yesorno = Console.ReadLine();

}
while (Console.ReadLine() == "bale");