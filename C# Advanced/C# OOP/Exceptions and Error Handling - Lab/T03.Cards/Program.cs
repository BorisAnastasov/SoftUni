namespace T03.Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr =Console.ReadLine().Split(", ").ToArray();
            List<Card> list = new List<Card>(); 
            for (int i = 0; i < arr.Length; i++)
            {
                string[] info = arr[i].Split(" ");
                string face = info[0];
                string suit = info[1];
                try
                {
                    Card card = CreateCard(face, suit);
                    list.Add(card);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach (var item in list)
            {
                Console.Write($"[{item.Face}{item.Suit}] ");
            }
        }
        public static Card CreateCard(string face,string suit)
        {
            switch (suit)
            {
                case "S":
                    suit = "\u2660";
                    break;
                case "H":
                    suit = "\u2665";
                    break;
                case "D":
                    suit = "\u2666";
                    break;
                case "C":
                    suit = "\u2663";
                    break;
                default:
                    throw new Exception("Invalid card!");
            }
            switch (face)//2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    break;
                    default:
                    throw new Exception("Invalid card!");
            }
            Card card = new(face,suit);
            return card;
        }
        public class Card
        {
            private string face;
            private string suit;
            public Card(string face, string suit)
            {
                Face = face;
                Suit = suit;
            }

            public string Face { get; set; }
            public string Suit { get; set; }
        }
    }
}