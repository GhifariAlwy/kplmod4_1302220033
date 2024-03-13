// See https://aka.ms/new-console-template for more information
namespace KPL_MOD4_1302220033_MGHIFARI
{
    public class KodeBuah
    {
        public string getKodeBuah(string namaBuah)
        {

            if (namaBuah == "Apel")
            {
                return "A00";
            }
            else if (namaBuah == "Aprikot")
            {
                return "B00";
            }
            else if (namaBuah == "Alpukat")
            {
                return "C00";
            }
            else if (namaBuah == "Pisang")
            {
                return "D00";
            }
            else if (namaBuah == "Paprika")
            {
                return "E00";
            }
            else if (namaBuah == "Kurma")
            {
                return "K00";
            }
            else if (namaBuah == "Durian")
            {
                return "L00";
            }
            else if (namaBuah == "Anggur")
            {
                return "M00";
            }
            else if (namaBuah == "Melon")
            {
                return "N00";
            }
            else if (namaBuah == "Semangka")
            {
                return "O00";
            }
            else
            {
                return "null";
            }
        }
        public class Move
        {
            public enum Button
            {
                JONGKOK, BERDIRI, TENGKURAP, TERBANG
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan Perintah :");
            string command = Console.ReadLine();
            Move.Button button = Move.Button.JONGKOK;
            while (command != "STOP")
            {
                switch (button)
                {
                    case Move.Button.JONGKOK:
                        if (command == "S")
                        {
                            button = Move.Button.TENGKURAP;
                            Console.WriteLine("tombol arah bawah ditekan");
                        }
                        break;

                    case Move.Button.TENGKURAP:
                        if (command == "W")
                        {
                            button = Move.Button.JONGKOK;
                            Console.WriteLine("tombol arah atas ditekan");
                        }
                        break;

                }
                Console.WriteLine("Masukan Perintah : ");
                command = Console.ReadLine();
            }
            KodeBuah kodebuahNO = new KodeBuah();

            string kode1 = kodebuahNO.getKodeBuah("Apel");
            string kode2 = kodebuahNO.getKodeBuah("Aprikot");
            string kode3 = kodebuahNO.getKodeBuah("Alpukat");
            string kode4 = kodebuahNO.getKodeBuah("Pisang");
            string kode5 = kodebuahNO.getKodeBuah("Paprika");
            string kode6 = kodebuahNO.getKodeBuah("Blackberry");
            string kode7 = kodebuahNO.getKodeBuah("Ceri");
            string kode8 = kodebuahNO.getKodeBuah("Kelapa");
            string kode9 = kodebuahNO.getKodeBuah("Jagung");

            Console.WriteLine("Kode Buah Apel: " + kode1);
            Console.WriteLine("Kode Buah Aprikot: " + kode2);
            Console.WriteLine("Kode Buah Alpukat: " + kode3);
            Console.WriteLine("Kode Buah Pisang: " + kode4);
            Console.WriteLine("Kode Buah Paprika: " + kode5);
            Console.WriteLine("Kode Buah Blackberry: " + kode6);
            Console.WriteLine("Kode Buah Ceri: " + kode7);
            Console.WriteLine("Kode Buah Kelapa: " + kode8);
            Console.WriteLine("Kode Buah Jagung: " + kode9);
        }
    }
}

