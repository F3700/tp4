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
        KodePos kodePos = new KodePos();

    }
}