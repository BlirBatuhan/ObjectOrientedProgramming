namespace StringLib;

public class StringLib
{
    string kelime = "Samsun Üniversitesi";
    int boşluk;
    int BoşlukBul()
    {
        foreach (var c in kelime)
        {
            if(c.Equals(' '))
            boşluk += 1 ;
        }
        return boşluk;
    }
}
