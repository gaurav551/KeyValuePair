namespace KeyValue.GetValueFromKey
{
    public static class StringUtilities
    {
        public static string GetLast(this string source, int lastCharLength)
        {
            if (lastCharLength >= source.Length)
                return source;
            return source.Substring(source.Length - lastCharLength);
        }
    }
}