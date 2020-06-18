using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000033 RID: 51
internal class FileLS
{
    // Token: 0x060000F7 RID: 247 RVA: 0x000047C0 File Offset: 0x000029C0
    public static string Decyt(string text)
    {
        ICryptoTransform cryptoTransform = DES.Create().CreateDecryptor(FileLS.k, FileLS.v);
        byte[] array = Convert.FromBase64String(text);
        byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
        return Encoding.Unicode.GetString(bytes);
    }

    // Token: 0x060000F8 RID: 248 RVA: 0x00004808 File Offset: 0x00002A08
    public static string Encyt(string text)
    {
        ICryptoTransform cryptoTransform = DES.Create().CreateEncryptor(FileLS.k, FileLS.v);
        byte[] bytes = Encoding.Unicode.GetBytes(text);
        return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
    }

    // Token: 0x060000F9 RID: 249 RVA: 0x0000484C File Offset: 0x00002A4C
    public static string GetValueFile(string TextData, int DataNum)
    {
        return TextData.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[DataNum].Split("=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1];
    }

    // Token: 0x060000FA RID: 250 RVA: 0x00004884 File Offset: 0x00002A84
    public static decimal LoadNum(string Data, int Loc)
    {
        return Convert.ToDecimal(FileLS.GetValueFile(Data, Loc));
    }

    // Token: 0x060000FB RID: 251 RVA: 0x000048A4 File Offset: 0x00002AA4
    public static string ReadText(string FileNa)
    {
        string result;
        try
        {
            result = FileLS.Decyt(Encoding.ASCII.GetString(File.ReadAllBytes(FileNa + ".E3Modz").Reverse<byte>().ToArray<byte>()));
        }
        catch
        {
            result = "";
        }
        return result;
    }

    // Token: 0x060000FC RID: 252 RVA: 0x000048FC File Offset: 0x00002AFC
    public static bool WriteText(string FileNa, string Text)
    {
        byte[] array = Encoding.ASCII.GetBytes(FileLS.Encyt(Text)).Reverse<byte>().ToArray<byte>();
        bool result;
        try
        {
            FileStream fileStream = new FileStream(FileNa + ".E3Modz", FileMode.Create, FileAccess.Write);
            fileStream.Write(array, 0, array.Length);
            fileStream.Close();
            result = true;
        }
        catch
        {
            result = false;
        }
        return result;
    }

    // Token: 0x040000C9 RID: 201
    private static byte[] k = new byte[]
    {
        8,
        2,
        5,
        6,
        3,
        6,
        7,
        4
    };

    // Token: 0x040000CA RID: 202
    private static byte[] v = new byte[]
    {
        5,
        1,
        9,
        4,
        0,
        6,
        3,
        4
    };
}
