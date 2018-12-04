using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace day2 {
    class Program {
        static string[] puzzleInput = new string[] { "mgdsdwqulhrinkatfjoyzxcbvq", "megsdwpulhrinkasfjdyzxcbvk", "megsdwpulhmibkatfjoyzccbvq", "megsdwtuohrinkatfjoyzecbvq", "megsdwpulhdinkatfyoyzxcbvb", "megszwpulhrirkatfjoyexcbvq", "eegsdwpulhzinkatfjoyzxdbvq", "megsdwpulhginkatfjoyqucbvq", "leqsdwpulhrinkatfeoyzxcbvq", "megsdwpblhrandatfjoyzxcbvq", "megrdwpudhrinvatfjoyzxcbvq", "mlgsdwpulhrinkatfuoyzxcbyq", "mensdwpunhrinsatfjoyzxcbvq", "megsdwpnlhrinqatfjoyzxcbuq", "megsdwpnlhrinkatfqoysxcbvq", "megsdwpulhrinkjtfjoywxobvq", "megsdwpclhbinkaffjoyzxcbvq", "mersdwpulhrinkattjoyzxcbdq", "megsddpwohrinkatfjoyzxcbvq", "mejsdwpulhrinratfjoyzxcbvl", "megsdwpujhrinkatfjkbzxcbvq", "megsdwpujhrinkatfjoyircbvq", "megsdwgulhrinkatojoyzxcbvm", "qegsdwpulhrinkatfjoyzxggvq", "megsdwpflhrinkatfjsazxcbvq", "megsdwpulhridkagfjoyzzcbvq", "mejsdwpulhriykatfjoyyxcbvq", "measdwpulhriakatfjoyzacbvq", "mebsdwpulhrinkatfjoyzxmyvq", "megsdwpflnrinkatfjoyzxcbxq", "megsdwpulhxinuatfjoytxcbvq", "megsdwsflhrinkatfjoyzxcmvq", "megsdwpuuhritkarfjoyzxcbvq", "megsdwpulhrinkazfjoyexcjvq", "megsdwpulhrifkatfjokzxcbvc", "megsdwmulvrinkatfjoyzxcblq", "meggdwpulhrfnkatfjoybxcbvq", "megsdwptlhrindatyjoyzxcbvq", "megsdwpulhrinkauqjoyzxibvq", "megsdwddlhrifkatfjoyzxcbvq", "megddwpulhrinkagfjoyzxcbva", "messdupulhrinkatfjoyzxqbvq", "megsdwpuahrinkatfjotzxchvq", "megsewpulhrankathjoyzxcbvq", "megsdwpulhrinkatfjoynqcbvv", "megsdwpulhrifkatfjotzxcbtq", "megsdjpulcrinkitfjoyzxcbvq", "fefsowpulhrinkatfjoyzxcbvq", "megsdwpulapinkatfjoyzvcbvq", "mejsdwpularinkatfjonzxcbvq", "megsxwpllrrinkatfjoyzxcbvq", "megsdlpulxvinkatfjoyzxcbvq", "megsdwpulhriekztfjoyzxxbvq", "megspwpulhrinuatfjoyzxcgvq", "megqdwpulhrinkatfjoyzujbvq", "megsdtpuehrinkatfjoyzxtbvq", "megsdwjulhrmnmatfjoyzxcbvq", "megjdwpulhrinkztfjoyzpcbvq", "megsdwpuljrinkawfjlyzxcbvq", "mewsdwpulhtinkatfjodzxcbvq", "megsdwpulhrinkatfcoizxcmvq", "meisdwpulhrinkatawoyzxcbvq", "megshwpulhrinkatfjoyzxcbtz", "megsdwpulhfinkatfjowzxcbvj", "megodwpulhrcskatfjoyzxcbvq", "megydxpulhrinkatfjofzxcbvq", "megsdwpulhrinkatljoytxdbvq", "mwgsdwpulyrinkatfjoyzxvbvq", "meesdwpulhrinkatfjcwzxcbvq", "cegsdwpwlhrinkatfioyzxcbvq", "megsdwpulhrinkatfqhyxxcbvq", "megsrrpulhrxnkatfjoyzxcbvq", "megsdgpulhrinkatfjoypxcbnq", "xegsdwpulhrinkaxkjoyzxcbvq", "mngsdwpulhrenkatfjofzxcbvq", "mecsdwpulhrinkabfjoozxcbvq", "pegsdkpulhrinkatfuoyzxcbvq", "megpdwpughrinkatfjoyzxzbvq", "mxgrdwpulhrinyatfjoyzxcbvq", "megsdwpulhpigkatfjoyzxcbfq", "mhgsdwpulhrinkagfjoxzxcbvq", "megsdwpblhtinkatfjqyzxcbvq", "megsawvulhrinkatfjoyzxcfvq", "metsuwpulhrinkatfjowzxcbvq", "mexsdwpulhrinkatsjoyzxvbvq", "megtdwpulhrinkatfjoizxcpvq", "megidwpjlhrinkatfdoyzxcbvq", "megsdwpuljrivkatfjoyqxcbvq", "mespdppulhrinkatfjoyzxcbvq", "megsdcpulhminkatftoyzxcbvq", "megsdwpulhriskatfjayzlcbvq", "mejsdwpulhrinkatfvoyzxibvq", "megfdwputhriykatfjoyzxcbvq", "megsdwparhrinkbtfjoyzxcbvq", "mtgsdwpulhmingatfjoyzxcbvq", "megsdwjulhrinkatfjtyzxtbvq", "megsvwpulhrinkatfjoyzecbvf", "megsdwpulprinkatyqoyzxcbvq", "zegsdwpulhwinkatfjoyzxcfvq", "megsdwiulhrinkatfjoyzxcjcq", "aegsdwpulirinkatfjoyvxcbvq", "mepsdwculbrinkatfjoyzxcbvq", "msgsdcpulhrinkctfjoyzxcbvq", "megsdwpulhrinkatfjoozxfevq", "megscwpulhrinkatmjoyzxcbsq", "megsdwpulhrinkltfjoyzxtmvq", "megsddpulhrixkatfjyyzxcbvq", "megsdwpulhrinkctfjoqzhcbvq", "megsbapblhrinkatfjoyzxcbvq", "megsdwpulhrinkatfjoyyxgpvq", "mwpsdwpulhrinkutfjoyzxcbvq", "megsdwpulhrinvnlfjoyzxcbvq", "megsdwsulorinkakfjoyzxcbvq", "mbgsdwpulhrinkktfjoyzxcbvg", "megddwpulhrindatfjoyzxcbvr", "memsdwpulhrinkatqjoyzxcbvo", "megsdwpulbrinkarfjoyzxcbxq", "megsdwpulhrilkatfjoynxcgvq", "mxgsdzpulhrinkatfjoydxcbvq", "megsawpulhrinkotfjoyzacbvq", "measdwpulhrinkctvjoyzxcbvq", "medsdwpulhtinkaqfjoyzxcbvq", "megsdwsulhrknkatfjoylxcbvq", "megadwpulhrinkatfjkyzxcbvh", "mygsdwpulhrinkatfboyzxcavq", "megsdwpulhrinkaufjxyzccbvq", "mtgsdwpulhrunkatfkoyzxcbvq", "megsdwpulhrinkamfwryzxcbvq", "meesdwpulhrgnkatnjoyzxcbvq", "megddwpolhrinkatfjoyixcbvq", "megsdwpulhrinsatfjoyzicwvq", "mmgsdwpulhrinkltfjoyzxcgvq", "meisdwpulhhinkatfjoyzxubvq", "megpdwpulhrinkatfroyzxcbkq", "megszwpuhhrinkatfjoyzxcbzq", "mersdwpulhrikcatfjoyzxcbvq", "mjgsdwpulhrinratfjoyzxcbvl", "megsdwnulkxinkatfjoyzxcbvq", "megsdwpulhrinkatlaoyzxpbvq", "megsdwpulhribkitfjjyzxcbvq", "megsdwpzlhrinkalfjoyzkcbvq", "megsdwpulhrinkutfjoyzxcdnq", "mfgpdwputhrinkatfjoyzxcbvq", "oegshwpclhrinkatfjoyzxcbvq", "megvdwxulhrinkatfjowzxcbvq", "mrgydwpulhrinkatfjoyzxcbvl", "megsdwpuqhrinkaxfjoyzxcbfq", "megsdwpughrinixtfjoyzxcbvq", "megsdwpslxrinkatfjoyzxcbvl", "megsdwpukhrinkatfjovzxnbvq", "megsdwpulnrinkrtojoyzxcbvq", "megsdwpuvhrinkatfjjyzxclvq", "vegrdwpulhrinzatfjoyzxcbvq", "melsdwwulvrinkatfjoyzxcbvq", "megsdwpulhrizkbtfjoyzjcbvq", "megsdwpulhrinlatfjoyzkcbvr", "megsdweulhrinkaofqoyzxcbvq", "megsdcpulhrifkatfdoyzxcbvq", "negsdwpulhainkztfjoyzxcbvq", "megsdwpklhrinkttfjoyzxvbvq", "megsdwpothrdnkatfjoyzxcbvq", "megsdwpulvrinkatfaoyzxcbvr", "mewsdwpulhrinkatfooyzxtbvq", "megtdwpulhrinkatfxoyzxcbvy", "zegsdwpulhrinkamljoyzxcbvq", "mkgodwpulhrcnkatfjoyzxcbvq", "megsdepularinkatfjoyzxybvq", "segsdwpulhrinkatfmoyzycbvq", "mbgsdwpulhrsnkztfjoyzxcbvq", "megsdwpmlhrinkatfjxyzhcbvq", "megsdwpulhrinkatfboyqxmbvq", "megsdwpulhrinkadtpoyzxcbvq", "megsdmpulhrjnkatfjoyzxwbvq", "megsdwpulhrivkatfroywxcbvq", "megsdwdulhrinkatpjwyzxcbvq", "megsdwpylhrdrkatfjoyzxcbvq", "megsdwpulhrvnkptfjoyzlcbvq", "megsdwpuihridkatfjuyzxcbvq", "megsdwpulhbiikatfjxyzxcbvq", "meggdwpulurinkatfjoyaxcbvq", "mehsnwpulcrinkatfjoyzxcbvq", "megsdwpulhrinkatfjoczdclvq", "megsdwjulhrinkatfhkyzxcbvq", "megsdwpulhrinoatfjoyzxcwvy", "megpdwpelhrfnkatfjoyzxcbvq", "megsjwpulhrwnkatfjdyzxcbvq", "megsdwpulhrbniatfjoyzxcbpq", "megsdwpulhrwnkatfjoydxcpvq", "megsdwrulhrinkatfjvyixcbvq", "yegvdwpulhtinkatfjoyzxcbvq", "meosdwpulhrinkatfjhyzxsbvq", "mjgsdwpulhrinkatfjoyyxcjvq", "megsdwpulhrinkatfnoyzlmbvq", "mehsdfkulhrinkatfjoyzxcbvq", "megsdwpuahrinkatfyoyzxcwvq", "megsdwpulhyinkatfjobzkcbvq", "megsdwpjlhrinkatfnoyzscbvq", "megsdwiulhrinqatfjoyzxcavq", "megsdwpulurinkatfjoykxcbmq", "megsdwpmlhvinkatfjotzxcbvq", "megswwpulhrinfatfjoytxcbvq", "mxgsdwpulhrrnkatfjoyhxcbvq", "megubwpulhrinkaafjoyzxcbvq", "megsdwpulhrdnsztfjoyzxcbvq", "megsdwpulhronkgtfjhyzxcbvq", "megsdwzulhfinratfjoyzxcbvq", "megsdwpulhrinkrtfjqyixcbvq", "megspwpulhrinkatfjoywxcavq", "megmfjpulhrinkatfjoyzxcbvq", "lelsdwpulhrinsatfjoyzxcbvq", "megsdwnultrinkatfjoyzxybvq", "megsdwpulhdnnkatfjpyzxcbvq", "megsdwpulhzinkatfjoyzhcpvq", "megoddpulhrilkatfjoyzxcbvq", "megsdvpulhrwnkatfjoyzxcbdq", "megsdwpulhmikkatfjoyzxcbvr", "meesdwpulhrinkaofjoazxcbvq", "megndwhulhrinfatfjoyzxcbvq", "megsdwpulhjihkatfjoyzxcbvb", "jegsdwpulhrinkattjoszxcbvq", "megsdwpulhrenkatfjodzxcbvp", "mefsdwpulhrinkatfjoyzxcczq", "megsdwpulhrknkatfjovzxcbvb", "megytwpulhrinkatfjoyzxcbvo", "csgsdwpulhrinkatdjoyzxcbvq", "megsbwpulhrinkazfjtyzxcbvq", "mrgsdwpulhjinkatfjoyzxcbvm", "megsywzulhrinkatfjofzxcbvq", "megxdwpulhrndkatfjoyzxcbvq", "mcgsdwpuphrixkatfjoyzxcbvq", "megsdlpulxvinkatfvoyzxcbvq", "megsdwpulhrinfatfjoyzicbvo", "megwgwpulhrinpatfjoyzxcbvq", "mggsdwpulhrinkatfjtrzxcbvq", "msgsdwpulirinkatfjoyzxcbaq", "megsdwpulhrineatfeoyzxcbvl", "megsdnpulhrinkatojoyzxcbvb", "mfgsdwpulhdinkatmjoyzxcbvq", "megsdwpulhrinkawfjuyzxcbvg", "megsdwpulhrincatfjoyzxcxvu", "mevsdwzplhrinkatfjoyzxcbvq", "megskweulhfinkatfjoyzxcbvq", "mebsdvpulhrinkatfjoyzxcbkq", "megddwiulhrinkatfioyzxcbvq", "mygsdwpulhqinkatfooyzxcbvq", "megsdweulhrfnkatfjoybxcbvq", "mrgsdhpulmrinkatfjoyzxcbvq", "megsdwkukhrinkatftoyzxcbvq", "megsdwpulhriskanfjoyzxctvq", "megsqwpulhrinfatfjoyzxebvq" };
        static int puzzleLength = 26;

        static string[] exampleInputs = new string[] { "abcde", "fghij", "klmno", "pqrst", "fguij", "axcye", "wvxyz" };
        static int exampleLength = 5;

        static void Main(string[] args) {
            GetMostFrequentChars(false);
        }

        private static void GetMostFrequentChars(bool useExample) {
            List<string> sortedInput = (useExample ? exampleInputs : puzzleInput).OrderBy(c => c).ToList();
            int length = (useExample ? exampleLength : puzzleLength);
            Dictionary<string, Dictionary<string, int>> distances = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < sortedInput.Count; i++) {
                string input = sortedInput[i];

                for (int x = 0; x < sortedInput.Count; x++) {
                    string testInput = sortedInput[x];
                    int levDist = CalcLevenshteinDistance(input, testInput);

                    if (levDist == 1) {
                        if (distances.ContainsKey(input)) {
                            distances[input].Add(testInput, levDist);
                        } else {
                            Dictionary<string, int> newDict = new Dictionary<string, int>();
                            newDict.Add(testInput, levDist);
                            distances.Add(input, newDict);
                        }
                    }
                }

                //Console.WriteLine(input);
            }

            string a = distances.First().Key;
            string b = distances.Last().Key;

            List<char> chars = new List<char>();
            foreach (char c in a) {
                if (b.Contains(c)) {
                    chars.Add(c);
                }
            }

            string answer = string.Concat(chars);
            Console.WriteLine($"Answer: {answer}");
        }

        private static int CalcLevenshteinDistance(string a, string b) {
            if (String.IsNullOrEmpty(a) && String.IsNullOrEmpty(b)) {
                return 0;
            }
            if (String.IsNullOrEmpty(a)) {
                return b.Length;
            }
            if (String.IsNullOrEmpty(b)) {
                return a.Length;
            }
            int lengthA = a.Length;
            int lengthB = b.Length;
            var distances = new int[lengthA + 1, lengthB + 1];
            for (int i = 0; i <= lengthA; distances[i, 0] = i++);
            for (int j = 0; j <= lengthB; distances[0, j] = j++);

            for (int i = 1; i <= lengthA; i++)
                for (int j = 1; j <= lengthB; j++) {
                    int cost = b[j - 1] == a[i - 1] ? 0 : 1;
                    distances[i, j] = Math.Min(
                        Math.Min(distances[i - 1, j] + 1, distances[i, j - 1] + 1),
                        distances[i - 1, j - 1] + cost
                    );
                }
            return distances[lengthA, lengthB];
        }

        private static void CalculateChecksum() {
            int twos = 0;
            int threes = 0;
            foreach (string input in puzzleInput) {
                string sortedInput = String.Concat(input.OrderBy(c => c));
                MatchCollection matches = Regex.Matches(sortedInput, @"(.)\1+");
                if (matches.Count > 0) {
                    int twosCount = matches.Where(m => m.Length == 2).Count();
                    if (twosCount > 0) {
                        twos += 1;
                    }

                    int threesCount = matches.Where(m => m.Length == 3).Count();
                    if (threesCount > 0) {
                        threes += 1;
                    }
                }
            }

            int checksum = twos * threes;
            Console.WriteLine($"Checksum: {checksum}");
        }
    }
}
