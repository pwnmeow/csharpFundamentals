namespace inheritance
{
    public class Text : PresentatinObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We add linmk to " + url);
        }
    }

}
