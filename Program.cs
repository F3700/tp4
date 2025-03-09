using static doormachine;

class doormachine {
    public enum DoorState { 
        TERKUNCI,
        TERBBUKA
    };
    public enum Trigger {
        KunciPintu,
        BukaPintu
    };
}


class KodePos {
    public enum kelurahan {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }
    private int[] kodepos = {40266,
        40287,
        40267,
        40256,
        40287,
        40286,
        40286,
        40286,
        40272,
        40274,
        40273
    };

    public int getKodePost(kelurahan x) {
        return this.kodepos[(int)x];
    }
}
class Program
{
    static void Main()
    {
        /*
        KodePos kodePos = new KodePos();


        DoorState state = DoorState.TERKUNCI;
        Console.Write("Pintu Terkunci");
        string cmd = "";

        while (cmd != "ext")
        {
            Console.Write(" \n \"ext\" to Exit \n Enter Command : ");
            cmd = Console.ReadLine();

            switch (state)
            {
                case DoorState.TERKUNCI:
                    if (cmd == "BukaPintu")
                    {
                        state = DoorState.TERBBUKA;
                        Console.Write("Pintu Terbuka");
                    }
                    else if (cmd == "KunciPintu") {
                        state = DoorState.TERKUNCI;
                        Console.Write("Pintu Terkunci");
                    }
                    else if (cmd == "ext")
                    {
                    }
                    else {
                        Console.WriteLine("Pintu Terbuka");
                        Console.WriteLine("Masukkan salah");
                    }
                    break;
                case DoorState.TERBBUKA:
                    if (cmd == "BukaPintu")
                    {
                        state = DoorState.TERBBUKA;
                        Console.Write("Pintu Terbuka");
                    }
                    else if (cmd == "KunciPintu")
                    {
                        state = DoorState.TERKUNCI;
                        Console.Write("Pintu Terkunci");
                    }
                    else if (cmd == "ext")
                    {
                    }
                    else
                    {
                        Console.WriteLine("Pintu Terbuka");
                        Console.WriteLine("Masukkan salah");
                    }
                    break;
            }
            Console.WriteLine("");
        }
        */
        KodePos kodePos = new KodePos();

        Console.WriteLine("Daftar Kode Pos kelurahan:\n");

        Console.WriteLine("Kode Pos Batununggal: " + kodePos.getKodePost(KodePos.kelurahan.Batununggal));
        Console.WriteLine("Kode Pos Kujangsari: " + kodePos.getKodePost(KodePos.kelurahan.Kujangsari));
        Console.WriteLine("Kode Pos Mengger: " + kodePos.getKodePost(KodePos.kelurahan.Mengger));
        Console.WriteLine("Kode Pos Wates: " + kodePos.getKodePost(KodePos.kelurahan.Wates));
        Console.WriteLine("Kode Pos Cijaura: " + kodePos.getKodePost(KodePos.kelurahan.Cijaura));
        Console.WriteLine("Kode Pos Jatisari: " + kodePos.getKodePost(KodePos.kelurahan.Jatisari));
        Console.WriteLine("Kode Pos Margasari: " + kodePos.getKodePost(KodePos.kelurahan.Margasari));
        Console.WriteLine("Kode Pos Sekejati: " + kodePos.getKodePost(KodePos.kelurahan.Sekejati));
        Console.WriteLine("Kode Pos Kebonwaru: " + kodePos.getKodePost(KodePos.kelurahan.Kebonwaru));
        Console.WriteLine("Kode Pos Maleer: " + kodePos.getKodePost(KodePos.kelurahan.Maleer));
        Console.WriteLine("Kode Pos Samoja: " + kodePos.getKodePost(KodePos.kelurahan.Samoja));
    }
}