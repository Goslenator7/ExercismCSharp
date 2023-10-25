using System;

public static class Bob
{
    private static bool IsEmpty(string statement) => string.IsNullOrWhiteSpace(statement);
    private static bool IsQuestion(string statement) => statement.TrimEnd().EndsWith("?");
    private static bool IsYelling(string statement) => statement.ToUpper() == statement && statement.ToLower() != statement;
    
    public static string Response(string statement)
    {
        if (IsEmpty(statement))
        {
            return "Fine. Be that way!";
        }
        if (IsQuestion(statement) && IsYelling(statement))
        {
            return "Calm down, I know what I'm doing!";
        }        
        if (IsYelling(statement))
        {
            return "Whoa, chill out!";
        }
        if (IsQuestion(statement))
        {
            return "Sure.";
        }
        else 
        {
            return "Whatever.";
        }
    }
}