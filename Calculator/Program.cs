decimal coefficient = 0;
decimal number = 0;

Console.Write("Write your expression (ax + bx +... = c: ");
string expression = Console.ReadLine()!;

for (int i = 0; i < expression.Length; i++)
{
    if (expression[i] == 'x')
    {
        decimal temp = decimal.Parse(expression[i - 1].ToString());
        coefficient += temp;
        Console.WriteLine(temp);
    }

    bool isNumber = expression[i] == '1' || expression[i] == '2' || expression[i] == '3' || 
                    expression[i] == '4' || expression[i] == '5' || expression[i] == '6' || 
                    expression[i] == '7' || expression[i] == '8' || expression[i] == '9';
    if (i + 1 >= expression.Length)
    {
        if (isNumber)
        {
            number = decimal.Parse(expression[i].ToString());
            Console.WriteLine(number);
        }
    }
    else
    {
        if (expression[i + 1] == ' ' && isNumber)
        {
            number = decimal.Parse(expression[i].ToString());
            Console.WriteLine(number);
        }
    }
}

Console.WriteLine($"Your result: {number / coefficient}");