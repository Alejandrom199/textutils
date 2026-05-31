namespace TextUtils;

public static class StringHelper
{
    public static string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static int CountWords(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return 0;

        return input.Split(
            new[] { ' ', '\t', '\n' },
            StringSplitOptions.RemoveEmptyEntries
        ).Length;
    }

    public static string ToSlug(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return string.Empty;

        return input
            .Trim()
            .ToLowerInvariant()
            .Replace(" ", "-");
    }

    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        var clean = input.ToLowerInvariant().Replace(" ", "");
        return clean == Reverse(clean);
    }
}