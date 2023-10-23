#region task-1
//array in elementlerinin cemini tapan flowchart ve kod.
/*int[] numbers = { 5,7,9,6,7};
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);*/
#endregion
#region task-2
//arrayin icinden 10dan boyuk olan ededlerin sayini tapan flowchart ve kod 
/*int[] numbers = { 5, 17, 15, 6, 25, 4 };
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 10)
    {
        count++;
    }
}
Console.WriteLine(count);*/

#endregion
#region task-3
//reqemlerden ibaret arrayin elementlerinin ededi ortasin tapin..
/*int[] numbers = { 5, 1, 4, 6, 8, 4 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum / numbers.Length);*/
#endregion
#region task-4
//aylardan mes: "yanvar" ibaret array,hansi yaz aylaridisa ekrana hemin ayin "adini" ve "yaz ayi olmasini" yazdirin
string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
foreach (string month in months)
{
    if (month == "January" || month == "February" || month == "December")
    {
        Console.WriteLine(month + " Winter season");
    }
}

#endregion
