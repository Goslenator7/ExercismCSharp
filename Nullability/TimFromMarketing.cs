using System;
static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null && department == null) { return $"{name} - OWNER"; }
        else if (department == null) { return $"[{id}] - {name} - OWNER"; }
        else if (id == null) { return $"{name} - {department.ToUpper()}"; }
        else return $"[{id}] - {name} - {department.ToUpper()}";
    }
}