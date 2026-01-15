Console.Write("ders sayınısı girin =");
int ders_sayısı = int.Parse(Console.ReadLine());
Console.Clear();
int[] kredisi_hesaplanmış_puan = new int[ders_sayısı];
int toplam_kredi = 0;
for (int i = 0; i < ders_sayısı; i++)
{
    Console.Write(" ders adını girin = ");
    string ders_adi =Console.ReadLine();
    Console.Write("kredinizi ve ders ortalamanızı girin \nkrediniz = ");
    int kredi = int.Parse(Console.ReadLine());
    Console.Write(ders_adi+" vize notunuz = ");
    int vize_notu = int.Parse(Console.ReadLine());
    Console.Write(ders_adi+" final notunuz = ");
    int final_notu = int.Parse(Console.ReadLine());
    double ders_notu = (vize_notu * 40 / 100) + (final_notu * 60 / 100);
    Console.Clear();
    Console.WriteLine(ders_adi+" ders notunuz = " + ders_notu);
    Console.WriteLine("********************************* \n ");
    kredisi_hesaplanmış_puan[i] = (int)(kredi * ders_notu);
    toplam_kredi += kredi;
    
}
double ortalama = (double)kredisi_hesaplanmış_puan.Sum() / toplam_kredi;
double GNO_puanı = ortalama / 25;
Console.WriteLine("GNO'nuz = " + GNO_puanı);
Console.ReadKey();

