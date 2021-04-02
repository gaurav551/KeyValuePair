namespace KeyValue.GetValueFromKey
{
    public static class StringUtilities
    {
        public static string GetLast(this string source, int lastCharLenght)
        {
            if (lastCharLenght >= source.Length)
                return source;
            return source.Substring(source.Length - lastCharLenght);
        }
    }
}