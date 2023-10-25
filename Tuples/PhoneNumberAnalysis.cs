using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool newYork = false;
        bool fake = false;
        string[] subStrings = phoneNumber.Split("-");
        if (subStrings[0] == "212")
        {
            newYork = true;
        }
        if (subStrings[1] == "555")
        {
            fake = true;
        }
        string local = subStrings[2];
        (bool, bool, string) resultsTuple = (newYork, fake, local);
        return resultsTuple;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        bool fake = phoneNumberInfo.IsFake;
        if (fake == true)
        {
            return true;
        }
    return false;
    }
}