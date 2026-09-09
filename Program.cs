using Methods;

Console.WriteLine( "\v\tHELLO, METHODS\n" );

#endregion
Months months = new();
#region FIRST NUMBER
Console.Write( "Enter first month's number: " );
string? monthNumberStart = Console.ReadLine();

int num1 = 0;
int num2 = 0;

while ( string.IsNullOrEmpty( monthNumberStart ) )
{
    Console.WriteLine( "\nNo number was entered. Try again.\n" );
    Console.Write( "Enter first month's number: " );
    monthNumberStart = Console.ReadLine();
}
bool flag = false;
while ( !flag )
{
    try
    {
        if ( !int.TryParse( monthNumberStart, out int number1 ) )
            throw new ArgumentException( $"{monthNumberStart} " +
                $"is not a valid number." );

        if ( number1 < 1 || number1 > 12 )
            throw new ArgumentOutOfRangeException( $"{monthNumberStart} " +
                $"is outside the valid month range (1–12).", nameof( number1 ) );
        num1 = number1;
        Console.WriteLine( months.PrintMonthTitle( number1 ) );
        flag = true;
    }
    catch ( Exception ex ) when ( ex is ArgumentException ||
        ex is ArgumentOutOfRangeException )
    {
        Console.WriteLine( $"{ex.Message}" );
        Console.Write( "\nEnter first month's number: " );
        monthNumberStart = Console.ReadLine();
    }
}
#endregion

#region SECOND NUMBER
Console.Write( "\nEnter second month's number: " );
string? monthNumberEnd = Console.ReadLine();

while ( string.IsNullOrEmpty( monthNumberEnd ) )
{
    Console.WriteLine( "\nNo number was entered. Try again." );
    Console.Write( "Enter second month's number: " );
    monthNumberEnd = Console.ReadLine();
}
flag = false;
while ( !flag )
{
    try
    {
        if ( !int.TryParse( monthNumberEnd, out int number2 ) )
        {
            throw new ArgumentException( $"{monthNumberEnd} " +
                $"is not a valid number." );
        }
        if ( number2 < 1 || number2 > 12 )
            throw new ArgumentOutOfRangeException( $"{monthNumberEnd} " +
                $"is outside the valid month range (1–12)." );

        num2 = number2;
        Console.WriteLine( months.PrintMonthTitle( number2 ) );
        flag = true;
    }
    catch ( Exception ex ) when ( ex is ArgumentException ||
         ex is ArgumentOutOfRangeException )
    {
        Console.WriteLine( $"{ex.Message}" );
        Console.Write( "\nEnter second month's number: " );
        monthNumberEnd = Console.ReadLine();
    }
}
months.CalculatedNumberOfMonths( num1, num2 );
#endregion
