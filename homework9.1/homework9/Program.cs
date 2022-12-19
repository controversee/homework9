using System;
using System.Threading;

namespace homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }//Verilmiş string dəyərindəki bütün sözlərin arasında bir boşluq qalacaq vəziyyətə salan metod.
         //(Metoda "  Men   rusca    bilmirem" dəyəri göndərilərsə onu "Men rusca bilmirem" halına gətirməlidir.
        static int FindFirstNonSpace(string str)
        {
            var result = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ')
                    result = str[i];



            }
            return result;

        }
        static int FindLastNonSpace(string str)
        {
            var result = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {

                if (str[i] != ' ')
                    result = str[i];
            }
            return result;


        }
        static void Trim(string str)
        {
            string newStr = "";
            for (int i = FindFirstNonSpace(str); i <= FindLastNonSpace(str); i++)
                newStr += str[i];
            Console.WriteLine(newStr);

        }


    }//Verilmiş string dəyərdəki sözlərin sayını tapan metod (boşluqlarla ayrılmış bütün ifadələr)
    static int CountofWords(string str)
    {
        var count = 0;

        for (int i = 0; i < str.Length; i++)

        {
            if (str[i] == ' ')
                count++;
        }
        return count;


    }

    //Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.
    //Fullname arrayinin icindeki butun value-lar ad+" "+soyad formatindadir.Misalcun "Hikmet Abbasov".
    //Misalcun gelen arraydeki deyerler { "Hikmet Abbasov","Abdulla Qulamov","Cemile Hikmetova"}
    //olarsa return olunan arraydeki deyerler {"Hikmet","Abdulla","Cemile"} olmalidir
    static string[] FullName(string[] names)
    {
        string[] newnames = FindLastNonSpace(names);
        return newnames;
    }// Verilmiş string dəyərin bir fullname olub olmadığını yoxlayan metod.
     // (Dəyərin fullname olma şərti daxilində yalnız hərflərin ola bilməsi,
     // yalnız 2 sözdən ibarət olması və hər bir sözün böyük hərfə başlayıb kiçik hərflərlə davam etməsidir.
    static bool IsFullName(string str)
    {
        bool IsDigit = false;
        int[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        {
            for (int i = 0; i < str.Length; i++)
            {
                if
                    (str[i] != digits[i])
                    return true;
            }
            return false;
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if
                        (str[i] == ' ')
                        return true;
                }
                return false;
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (char.IsUpper([0])
                            
                    }
                }

            }
        }
    }
}
        
            

    




