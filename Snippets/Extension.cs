namespace Ansien.Lab
{
    public static class Extension
    {
        public static int? ParseInt(this string text)
        {
            if (int.TryParse(text, out int number))
                return number;
            else
                return null;
        }
    }
}
