namespace Latihan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Menghitung Nilai Rata-rata");
            Console.WriteLine("==============================================");

            string nama;
            int harian, uas, uts, rata;

            Console.Write("Masukkan Nama Anda : ");
            nama = Console.ReadLine();

            Console.Write("Masukkan Nilai Harian : ");
            harian = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai UAS : ");
            uas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai UTS : ");
            uts = Convert.ToInt32(Console.ReadLine());

            rata = (harian + uas + uts) / 3;

            Console.WriteLine("==============================================");
            Console.WriteLine("Nama Siswa : " + nama);
            Console.WriteLine("Nilai Harian : " + harian);
            Console.WriteLine("Nilai UAS : " + uas);
            Console.WriteLine("Nilai UTS : " + uts);
            Console.WriteLine("Nilai Rata-rata : " + rata);

            if(rata >= 80)
            {
                Console.WriteLine("Predikat : A");
            } else if(rata >= 70 && rata < 80)
            {
                Console.WriteLine("Predikat : B");
            } else if (rata >= 60 && rata < 70)
            {
                Console.WriteLine("Predikat : C");
            } else if (rata >= 50 && rata < 60)
            {
                Console.WriteLine("Predikat : D");
            } else
            {
                Console.WriteLine("Predikat : E");
            }

            Console.ReadKey();
        }
    }
}
