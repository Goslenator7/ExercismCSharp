using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation)
    {
        string result = "";

        switch (operation)
        {
            case "+":
                result = $"{operand1} + {operand2} = {operand1 + operand2}";
                break;
            case "*":
                result = $"{operand1} * {operand2} = {operand1 * operand2}";
                break;
            case "/":
                if (operand1 == 0  || operand2 == 0)
                {
                    return "Division by zero is not allowed.";
                }
                result = $"{operand1} / {operand2} = {operand1 / operand2}";
                break;
            case "":
                throw new ArgumentException();
            case null:
                throw new ArgumentNullException();
            default:
                throw new ArgumentOutOfRangeException();
            }
        return result;
    }
}
