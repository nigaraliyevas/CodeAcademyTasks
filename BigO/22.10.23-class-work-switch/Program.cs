#region task-1
/*int grade = int.Parse(Console.ReadLine());
if (grade >= 0 && grade <= 100)
{
    if (grade >= 60 && grade <= 69)
    {
        Console.WriteLine("D");
    }
    else if (grade >= 70 && grade <= 79)
    {
        Console.WriteLine("C");
    }
    else if (grade >= 80 && grade <= 89)
    {
        Console.WriteLine("B");
    }
    else if (grade >= 90 && grade <= 100)
    {
        Console.WriteLine("A");
    }
    else
    {
        Console.WriteLine("kesildun");
    }
}
else
{
    Console.WriteLine("Not included");
}*/
#endregion
#region task-2

/*int month=int.Parse(Console.ReadLine());
if(month>=1 && month <= 12)
{
    switch (month)
    {
        case 1:
            Console.WriteLine("Janurary");
        break;
        case 2:
            Console.WriteLine("February");
            break;
        case 3:
            Console.WriteLine("March");
            break;
        case 4:
            Console.WriteLine("April");
            break;
        case 5:
            Console.WriteLine("May");
            break;
        case 6:
            Console.WriteLine("June");
            break;
        case 7:
            Console.WriteLine("July");
            break;
        case 8:
            Console.WriteLine("August");
            break;
        case 9:
            Console.WriteLine("September");
            break;
        case 10:
            Console.WriteLine("October");
            break;
        case 11:
            Console.WriteLine("November");
            break;
        case 12:
            Console.WriteLine("December");
            break;
        default:
    }
}
*/
#endregion
# region task-3
Console.WriteLine("Enter first number:");
int firstNum=int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number:");
int secondNum=int.Parse(Console.ReadLine());
Console.WriteLine("Enter sign operator:");
string operatorSign =Console.ReadLine();
if (operatorSign == "+")
{
    Console.WriteLine(firstNum + secondNum);
}
else if (operatorSign == "-")
{
    Console.WriteLine(firstNum - secondNum);
}
else if (operatorSign == "/")
{
    Console.WriteLine(firstNum / secondNum);
}
else
{
    Console.WriteLine($"The result is:{firstNum *secondNum}");
}

#endregion