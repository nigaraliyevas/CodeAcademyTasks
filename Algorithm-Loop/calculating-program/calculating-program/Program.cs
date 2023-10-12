#region task-1
//Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.
/*int n = 13;
int m = 22;
int count = 0;
for (int i = n; i <= m; i++)
{
    if (i % 2 != 0)
    {
        count++;
    }
}
Console.WriteLine(count);
*/
#endregion
#region task-2
//Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.
/*int n = 44;
if (n == 1)
{
    Console.WriteLine($"{n} hem sade hemde murekkeb ededdir");
}
else if( n==2 || n == 3)
{
    Console.WriteLine($"{n} sade ededdir");
}
else if(n%2==0 || n % 3 == 0)
{
    Console.WriteLine($"{n} murekkeb ededdir");
}
else
{
    Console.WriteLine($"{n} sade ededdir");
}
*/
#endregion
#region task-3
//Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın
#region solution-1
/*int n =12;
int b =1;
for (int i=0; i<n;i++)
{
    if (n >= b) { 
        if(n==1 || n == 2)
        {
            Console.WriteLine("yes");
            break;
        }
        b*=b;
        if (n % b == 0)
        {
            n /= b;
            Console.WriteLine("yes");
            break;
        }  
        else {
            Console.WriteLine("no");
            break;
        }
    }

}*/
#endregion
#region solution-2
int n = 0;
int i = n;
if (i > 0)
{
    while(i%2 == 0)
    {
        i /= 2;
    }
}
if (i == 1)
{
    Console.WriteLine($"{n} ededi 2-nin quvvetidir.");
}
else
{
    Console.WriteLine($"{n} ededi 2-nin quvveti deyil.");
}

#endregion
#endregion
#region task-4
//Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5
#region with-while
/*int n = 125;
int count = 0;
while (n > 0)
{
    n /= 10;
    count++;
}
Console.WriteLine(count);
*/
#endregion
#region with-for
/*
int n = 1253485;
int count = 0;
for (int i = 0; i<n; n/=10)
{
    count++;
}
Console.WriteLine(count);
*/
#endregion
#endregion