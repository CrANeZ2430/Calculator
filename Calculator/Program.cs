string expression = Console.ReadLine();
decimal coefficient = 0;
decimal number = 0;

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == 'x')
    {
        coefficient = decimal.Parse(expression[i - 1].ToString());
        Console.WriteLine(coefficient);
    }
    else if (expression[i + 1] == ' ' && (expression[i] == '1' || expression[i] == '2' ||
                                          expression[i] == '3' || expression[i] == '4' || expression[i] == '5' ||
                                          expression[i] == '6' || expression[i] == '7' || expression[i] == '8' ||
                                          expression[i] == '9'))
    {
        number = decimal.Parse(expression[i].ToString());
        Console.WriteLine(number);
    }
}

Console.WriteLine($"Your result is: {number / coefficient}");