Console.Write("ders sayınısı girin =");
int ders_sayısı = int.Parse(Console.ReadLine());
int[] kredisi_hesaplanmış_puan = new int[ders_sayısı];
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
    int ders_notu = (vize_notu * 40 / 100) + (final_notu * 60 / 100);
    Console.WriteLine(ders_adi+" ders notunuz = " + ders_notu);
    Console.WriteLine("*********************************");
    kredisi_hesaplanmış_puan[i] = kredi * ders_notu;
}
Console.Write("toplam kredinizi girin = ");
float toplam_kredi = int.Parse(Console.ReadLine());
Console.WriteLine("GNO'nuz = " + (kredisi_hesaplanmış_puan.Sum() / toplam_kredi)/25);
