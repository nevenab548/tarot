namespace Tarot
{
    class Card
    {
        private string name;
        private bool face; //false-upright true-reverse
        private string meaning;
        private string imagePath;
        public Card(string s)
        {
            name = s;
            face = false;
            meaning = null;
        }
        public Card(Card c)
        {
            name = c.name;
            face = c.face;
            meaning = c.meaning;
            imagePath = c.ImagePath;
        }
        public string Meaning
        {
            get
            {
                return meaning;
            }
            set
            {
                meaning = value;
            }
        }
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }
        public bool Face
        {
            get { return face; }
            set { face = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
