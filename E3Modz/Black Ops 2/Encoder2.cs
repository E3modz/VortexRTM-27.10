
using System.Text;

internal static class Encoder2
{
    private static Encoding DefEncoding = Encoding.GetEncoding("iso-8859-1");

    public static string GetString(byte[] value)
    {
        return Encoder2.GetString(value, Encoder2.DefEncoding);
    }

    public static string GetString(byte[] value, Encoding encoding)
    {
        return encoding.GetString(value);
    }

    public static byte[] GetBytes(string value)
    {
        return Encoder2.GetBytes(value, Encoder2.DefEncoding);
    }

    public static byte[] GetBytes(string value, Encoding encoding)
    {
        return encoding.GetBytes(value);
    }
}
