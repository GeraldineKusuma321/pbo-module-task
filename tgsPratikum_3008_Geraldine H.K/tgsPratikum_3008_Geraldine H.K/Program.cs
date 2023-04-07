using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMA : GERALDINE HENDRAESTI K.
//NIM  : 222410103008

namespace tgsPratikum_3008_Geraldine_H.K
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHODS MAIN UNTUK LAPTOP1 DENGAN METHODS NGODING(), DI BERI COMMENT UNTUK BISA MENCOBA MEMANGGIL CONSOLE SPESIFIKASI

            //Laptop laptop1 = new Laptop();
            //laptop1.merk = "ASUS";
            //laptop1.tipe = "Vivobook";
            //laptop1.tipe = "Nvidia";
            //laptop1.tipe = "Corei5";
            //laptop1.Ngoding();

            //INI CONTOH KODE PEROGRAM UNTUK BISA MENGEKSEKUSI METHODS NGODING() DENGAN TIPE DATA VIVOBOOK 

            //Vivobook vivobook = new Vivobook();
            //vivobook.merk = "ASUS";
            //vivobook.tipe = "Vivobook";
            //vivobook.tipe = "Nvidia";
            //vivobook.tipe = "Corei5";
            //vivobook.Ngoding();

            Laptop laptop2 = new Laptop();
            laptop2.merk = "Lenovo";
            laptop2.tipe = "Ideapad";
            laptop2.vga = "AMD";
            laptop2.tipe = "Ryzen";
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            Predator predator = new Predator();
            predator.merk = "ACER";
            predator.tipe = "Predator";
            predator.vga = "AMD";
            predator.tipe = "Core i7";
            //predator.BermainGame();

            //program ini tidak dapat dijalankan dikarenakan bertipe data ACER yang tidak memiliki methods BermainGame()
            ACER acer = new ACER();
            acer.merk = "ACER";
            acer.tipe = "Predator";
            //acer.BermainGame();

            //METHOD MAIN NYA UNUTK NOMER 5
            Laptop laptop1 = new Laptop();
            laptop1.tipe = "Core i5";
            laptop1.vga = "Nvidia";
            laptop1.merk = "Intel";

            laptop1.getName();



        }
    }

    abstract class Processor
    {
        public string merk;
        public string tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel"; //base digunakan untuk menunjuk pada parent
        }
    }

    class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core i3"; //base digunakan untuk menunjuk pada parent
        }
    }

    class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5"; //base digunakan untuk menunjuk pada parent
        }
    }

    class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core i7"; //base digunakan untuk menunjuk pada parent
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "Athlon";
        }
    }

    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class Amd : Vga
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }
    class Laptop
    {
        public string merk;
        public string tipe;
        public string vga;
        public string processor;


        public void LaptopDinyalakan()
        {
            Console.WriteLine($"LAPTOP {merk} {tipe} MENYALA");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine($"LAPTOP{merk} {tipe} DIMATIKAN");
        }
        //METHODS UNTUKN NOMER 5 YAITU MENAMPILKAN CONSOLE SPESIFIKASI LAPTOP1
        public void getName()
        {
            Console.WriteLine(" ===   SPESIFIKASII   ====");
            Console.WriteLine("TIPE PROCESSOR  : " + tipe);
            Console.WriteLine("MERK PROCESSOR  : " + merk);
            Console.WriteLine("MERK VGA        : " + vga);
            Console.WriteLine(" ===   thank you   ====");

        }
    }
    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine($"Laptop {merk} {tipe}  sedang Memainkan GAME");
        }

    }
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Switf";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    class Ideapad : Lenovo
    {
        public Ideapad()
        {
            base.tipe = "Ideapad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
}
