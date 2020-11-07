namespace Tarot
{
    class Spread
    {
        private Card[] spread = new Card[10];
        public Card[] Spreadp { get => spread; set => spread = value; }
        public Spread(Deck d)
        {
            Spreadp[0] = new Card(d.Deckp[0]);
            Spreadp[1] = new Card(d.Deckp[1]);
            Spreadp[2] = new Card(d.Deckp[2]);
            Spreadp[3] = new Card(d.Deckp[3]);
            Spreadp[4] = new Card(d.Deckp[4]);
            Spreadp[5] = new Card(d.Deckp[5]);
            Spreadp[6] = new Card(d.Deckp[6]);
            Spreadp[7] = new Card(d.Deckp[7]);
            Spreadp[8] = new Card(d.Deckp[8]);
            Spreadp[9] = new Card(d.Deckp[9]);
        }
    }
}
