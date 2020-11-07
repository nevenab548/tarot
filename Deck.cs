using System;
using System.IO;

namespace Tarot
{
    class Deck
    {
        private Card[] deck = new Card[78];
        public Card[] Deckp { get => deck; set => deck = value; }
        public Deck()
        {
            StreamReader sr = new StreamReader("cardnames.txt");
            for (int i = 0; i < 78; i++)
            {
                deck[i] = new Card(sr.ReadLine());
            }
            sr.Close();
            StreamReader sr1 = new StreamReader("imagenames.txt");
            for (int i = 0; i < 78; i++)
                deck[i].ImagePath = sr1.ReadLine();
            sr1.Close();
            StreamReader sr2 = new StreamReader("carddescription.txt");
            for (int i = 0; i < 78; i++)
                deck[i].Meaning = sr2.ReadLine();
            sr2.Close();

        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 77; i++)
            {
                int j = rand.Next(i, 78);
                Card temp = Deckp[i];
                Deckp[i] = Deckp[j];
                Deckp[j] = temp;
                Deckp[i].Face = rand.Next(2) == 0;
            }
        }
    }
}
