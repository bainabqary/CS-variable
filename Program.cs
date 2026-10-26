// See https://aka.ms/new-console-template for more information

int angka = 1;
long angkaSayaLong = 19000000L;
float angkaSayaFloat = 1.2f;
double angkaFloating = 1.2;
string name = "Bain";
char golonganDarah = 'A';
bool isMenikah = true;

Console.WriteLine(angka);
Console.WriteLine(angkaSayaLong);
Console.WriteLine(angkaSayaFloat);
Console.WriteLine(angkaFloating);
Console.WriteLine(name);
Console.WriteLine(golonganDarah);
Console.WriteLine(isMenikah);

Console.WriteLine("Siapa nama anda?");
Console.WriteLine("Masukkan nama anda");
string? nama = Console.ReadLine();
Console.WriteLine("Hello " + nama);
