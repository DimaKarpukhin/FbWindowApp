namespace ChuckNorris
{
    using System.Collections.Generic;

    public class ChuckNorrisData
    {
        public int Id { get; set; }

        public string Joke { get; set; } = string.Empty;

        public List<object> Ctegories { get; set; }
    }
}
