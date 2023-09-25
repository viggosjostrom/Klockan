using System;

int hour = 00;
int min = 00;
int time;
time = hour + min;

while (hour <= 23 && min <= 59)
{
    min++;
    Console.WriteLine(hour + ":" + min);
    
    if (hour < 10)
    {
        Console.Write("0");
    }
    if (min < 9)
    {
        time.ToString();
        

        Console.Write("0");
    }
    


    if (min == 59)
    {

        min = 00;
        hour++;



    }
    


}

/*
if (min < 10 && hour < 10)
{
    Console.WriteLine("0" + hour + ":0" + min);
}
if (min > 10 && hour > 10)
{
    Console.WriteLine(hour + ":" + min);
}
*/



// Fungerande 
for (int hour = 0; hour < 24; hour++)
{
    for (int minute = 0; minute < 60; minute++)
    {
        for (int second = 0; second < 60; second++)
        {
            Console.WriteLine(FormatTime(hour) + ":" + FormatTime(minute) + ":" + FormatTime(second));
        }
    }
}


string FormatTime(int number)
{
    if (number < 9)
    {
        return "0" + number;

    }
    else
    {
        return number.ToString();
    }
}