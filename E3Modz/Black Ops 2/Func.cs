using PS3Lib;
using System.Threading;

namespace E3Modz.Black_Ops_2
{
    class Funcs
    {
        public class ModdedList
        {
            public static void E3PrivateNotify(string textHeader, string text, string Shader)
            {
                BO2.PS3.SetMemory(29490803u, new byte[]
                {
                40
                });
                BO2.PS3.Extension.WriteString(29490277u, textHeader);
                BO2.PS3.Extension.WriteString(29490789u, Shader);
                BO2.PS3.Extension.WriteString(29490533u, text);
                BO2.PS3.SetMemory(29491046u, new byte[]
                {
                0,
                0,
                0,
                0,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                0,
                0,
                0,
                0,
                0,
                0,
                1,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
                });
                BO2.PS3.SetMemory(13959205u, new byte[]
                {
                32
                });
                Thread.Sleep(2500);
                PS3API ps = BO2.PS3;
                uint offset = 29491046u;
                byte[] array = new byte[32];
                array[21] = 1;
                ps.SetMemory(offset, array);
                BO2.PS3.Extension.WriteString(29490533u, "");
            }
            public static void ChangeString(bool ChangeStrOn)
            {
                if (ChangeStrOn)
                {
                    Functions.WriteStr(814597042u, "^2Back by ^2VortexRTM");
                    Functions.WriteStr(814883216u, "^6Project Vortex");
                    Functions.WriteStr(814940829u, "^1Bitches");
                    Functions.WriteStr(814664634u, "^3E3 Modz is ^1Developer");
                    Functions.WriteStr(814854250u, "^5Thank you for Using ^1Project^2Vortex");
                    Functions.WriteStr(815010189u, "^1Project^2Vortex");
                    Functions.WriteStr(814763917u, "^1Project^2Vortex");
                    Functions.WriteStr(814628014u, "^1Project^2Vortex");
                    Functions.WriteStr(814764525u, "^1Project^2Vortex");
                    Functions.WriteStr(815031426u, "^6E3Modz");
                    Functions.WriteStr(814948233u, "^1Project^2Vortex");
                    Functions.WriteStr(814971936u, "^1YouTube.com/^5user/^2E3MoDz");
                    Functions.WriteStr(814818239u, "YT=^6E3Modz");
                    Functions.WriteStr(814971163u, "^1E3Modz");
                    Functions.WriteStr(814628014u, "^1Vortex^2RTM");
                    Functions.WriteStr(814970517u, "^1E3Modz");
                    Functions.WriteStr(814626107u, "^5E3Modz Best Developer");
                    Functions.WriteStr(814626011u, "^1This was Developed by E3 Modz!");
                    Functions.WriteStr(814803688u, "^3E3Modz");
                    Functions.WriteStr(9419060u, "popup_xboxlive_partyended");
                    Functions.WriteStr(9411252u, "popup_xboxlive_partyended");
                    Functions.WriteStr(814934907u, "^1Project^2Vortex");
                    Functions.WriteStr(814934907u, "^1Project^2Vortex");
                    Functions.WriteStr(814645448u, "^1Developed by ^5E3 MoDz");
                    Functions.WriteStr(814988772u, "^5E3Modz");
                    Functions.WriteStr(806742908u, "^1E3Modz");
                    Functions.WriteStr(13959151u, "^1MultiTool");
                    Functions.WriteStr(9890924u, "menu_div_pro");
                    Functions.WriteStr(9890956u, "^2E3Modz");
                    Functions.WriteStr(9890924u, "menu_div_pro");
                    Functions.WriteStr(9890956u, "^1YouTube/^2E3 MoDz");
                    Functions.WriteStr(814934907u, "^1E3Modz");
                    Functions.WriteStr(814645448u, "^2E3ModzV5 ^1By YouTube/E3Modz");
                    Functions.WriteStr(814988772u, "^1You^0Tube^5/E3Modz");
                    Functions.WriteStr(806742908u, "^2Developed by ^1E3MoDz");
                    Functions.WriteStr(9890924u, "menu_div_pro");
                    Functions.WriteStr(9890956u, "^2E3^1MoDz");
                    Functions.WriteStr(9890924u, "^1Project^2Vortex");
                    Functions.WriteStr(9890956u, "@^1VortexMultiTool^7@");
                    E3PrivateNotify("^1Project^2Vortex", "^2Loaded ", "menu_div_pro");
                    Functions.WriteStr(814948233u, "^1You^0Tube ^2E3MoDz/0");
                    Functions.WriteStr(814808680u, "->^1Project^2Vortex\0");
                    Functions.WriteStr(814663927u, "->^1Project Vortex");
                    Functions.WriteStr(814595131u, "->^2E3MoDz");
                    E3PrivateNotify("^2www.^1YouTube^9/^5E3MoDz^6<3^7\0", "^2Subscribe<3\0", "lui_loader_no_offset");
                    Functions.WriteStr(806735748u, "->^1E3>MoDz");

                }
                else
                {
                    Functions.WriteStr(814639716u, "^2E3 Modz ^6RTM");
                    Functions.WriteStr(814764525u, "^1YouTube.com/^5user/AG|T");
                    Functions.WriteStr(815010189u, "||- ^1Best ^2R^1T^2M ^5Tool!");
                    Functions.WriteStr(814971163u, "Developed by E3 Modz!");
                    Functions.WriteStr(814626107u, "^1E3Modz!");
                    Functions.WriteStr(814626011u, "Would you join AGM|T?");
                    Functions.WriteStr(813502096u, "^2Best RTM Tool!");
                }
            }
        }
    }
}

