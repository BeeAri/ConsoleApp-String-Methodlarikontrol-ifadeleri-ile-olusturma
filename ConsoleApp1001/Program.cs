namespace ConsoleApp1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello World!";
            Console.WriteLine(String.IsNullOrEmpty(s));
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Trim().ToUpper());
            Console.WriteLine(s.Substring(2, 1)); //2. harften başla ve 3 karakter getir.
            Console.WriteLine(s.StartsWith(" "));
            Console.WriteLine(s.EndsWith("!"));
            Console.WriteLine(s.PadLeft(14, '*'));
            Console.WriteLine(s.Replace("Hello","Hi")); 
            Console.WriteLine(s.Contains('H'));
            Console.WriteLine(s.IndexOf('H'));
            Console.WriteLine(s.Insert(3,"H"));
            Console.WriteLine(s.Reverse());   
            Console.WriteLine(ContainsX("Araba", 'b'));
            Console.WriteLine(IndexOfX("Merhaba", 'e'));
            Console.WriteLine(PadLeftX("Merhaba",8, '*'));
            Console.WriteLine(SubstringX("Naber",2,4));

        }

        public static bool ContainsX(string s, char c)
        {
            List<Char> chars = s.ToList();
            foreach (var ch in chars)
            {
                if (ch==c)
                {
                    return true;
                }
            }
            return false;
        }

        public static int IndexOfX(string s, char c)
        {
            List<Char> ch = s.ToList();
            for (int i = 0; i < ch.Count; i++)
            {
                if (ch[i] == c)
                {
                    return i;
                }
                
            }
           
            return -1;
        }

        public static string PadLeftX(string s,int count, char c)
        {
            int harfsayısı = s.Length;
            if (harfsayısı>=count)
            {
                return s;
            }
            int fark = count - harfsayısı;
            string pad = "";
            for (int i = 0; i < fark; i++)
            {
                pad = pad + c;
            }

            return pad+s;
        }

        public static string SubstringX(string s, int start)
        {
            string sonuc = "";
            for (int i = start; i < s.Length; i++)
            {
                sonuc = sonuc + s[i];
            }
            return sonuc;

        }

        public static string SubstringX(string s, int start, int count)
        {
            string sonuc ="";
            
            if (start<=s.Length && start+count<=s.Length)
            {
                for (int i = start; i < count + start; i++)
                {
                        sonuc = sonuc + s[i];      
                }
                return sonuc;

            }
            
            return "kelimenin toplam harfinden daha fazla sayı girdin";

        }




    }


}