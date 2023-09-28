namespace AUTH.Backend.Utilities;

public static class DateTimeUtilities
{
    public static DateTime CurrentDateTime()
    {
        DateTime utcNow = DateTime.UtcNow;
        DateTime bangladeshTime = utcNow.AddHours(6);
        return bangladeshTime;
    }
}
