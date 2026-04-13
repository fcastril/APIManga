namespace BibliotecaMangasAPI.models
{
    public class Manga
    {
        public int  Id {  get; set; }
        public string titulo { get; set; }
        public string autor {  get; set; }
        public int NumeroTomo { get; set; }
        public double precio { get; set; }
    }
}
