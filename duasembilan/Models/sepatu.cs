namespace duasembilan.Models
{
    public class sepatu
    {
        public jenisSepatu Kumpulan { get; set; }

        public sepatu(jenisSepatu kumpulan)
        {

            Kumpulan = kumpulan;
        }
    }
}
