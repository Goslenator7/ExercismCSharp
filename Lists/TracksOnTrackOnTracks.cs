using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        var languageList = new List<string>();
        return languageList;
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> existingLanguages = new List<string> {"C#", "Clojure", "Elm"};
        return existingLanguages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language)
    {
        foreach (string Languageslanguage in languages)
        {
            if (Languageslanguage == language)
            {
                return true;
            }
        }
    return false;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count > 0 && languages.Count < 4)
        {
           if (languages[0] == "C#" || languages[1] == "C#")
           {
               return true;
           }
        }
    return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        languages.Sort();
        for (int i = 0; i < languages.Count - 1; i++)
        {
            if (languages[i] == languages[i + 1])
            {
                return false;
            }
        }
    return true;
    }
}
