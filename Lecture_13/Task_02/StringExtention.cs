namespace Task_02
{
    public static class StringExtensions
    {
        public static string CutString(this string str)
        {
            return str.Substring(0, 5) + "...";
        }
    }
}