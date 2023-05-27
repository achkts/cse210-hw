 public class QuoteGenerator
{
        List<string> quotes;

        public QuoteGenerator()
        {
           quotes = new List<string>()
           {
            "When you sleep under this quilt, you sleep under a blanket of love.",
            "Our lives are like quilts - bits and pieces, joy and sorrow, stitched with love.",
            "Blessed are the piecemakers.",
            "Any day spent quilting is a good day!",
            "A family stitched together with love seldom unravels.",
            "Anyone who works on a quilt, who devotes her time, energy, creativity," + 
            " and passion to the art, learns to value the work of her hands. " + 
            "And as any quilter will tell you, a quilter's quilting friends are some of the dearest, " +
            "most generous, and most supportive people she knows. == Jennifer Chiaverini"
           };

        }

        public string GetRandomQuote()
        {
            Random random = new Random();
            int index = random.Next(quotes.Count);
            return quotes[index];
        }
}