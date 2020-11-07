using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tarot
{
    public partial class Form1 : Form
    {
        readonly Deck d;
        Spread s;
        public Form1()
        {
            InitializeComponent();
            d = new Deck();
            d.Shuffle();
            s = new Spread(d);
        }

        private void button_shuffle_Click(object sender, EventArgs e)
        {
            d.Shuffle();
            s = new Spread(d);
        }

        private void button_deal_Click(object sender, EventArgs e)
        {
            Image img1 = Image.FromFile(s.Spreadp[0].ImagePath);
            if (s.Spreadp[0].Face)
                img1.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card1.Image = img1;
            Image img2 = Image.FromFile(s.Spreadp[1].ImagePath);
            img2.RotateFlip(RotateFlipType.Rotate90FlipNone);
            if (s.Spreadp[1].Face)
                img2.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card2.Image = img2;
            Image img3 = Image.FromFile(s.Spreadp[2].ImagePath);
            if (s.Spreadp[2].Face)
                img3.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card3.Image = img3;
            Image img4 = Image.FromFile(s.Spreadp[3].ImagePath);
            if (s.Spreadp[3].Face)
                img4.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card4.Image = img4;
            Image img5 = Image.FromFile(s.Spreadp[4].ImagePath);
            if (s.Spreadp[4].Face)
                img5.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card5.Image = img5;
            Image img6 = Image.FromFile(s.Spreadp[5].ImagePath);
            if (s.Spreadp[5].Face)
                img6.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card6.Image = img6;
            Image img7 = Image.FromFile(s.Spreadp[6].ImagePath);
            if (s.Spreadp[6].Face)
                img7.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card7.Image = img7;
            Image img8 = Image.FromFile(s.Spreadp[7].ImagePath);
            if (s.Spreadp[7].Face)
                img8.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card8.Image = img8;
            Image img9 = Image.FromFile(s.Spreadp[8].ImagePath);
            if (s.Spreadp[8].Face)
                img9.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card9.Image = img9;
            Image img10 = Image.FromFile(s.Spreadp[9].ImagePath);
            if (s.Spreadp[9].Face)
                img10.RotateFlip(RotateFlipType.Rotate180FlipNone);
            card10.Image = img10;
        }

        private void card2_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[1].Meaning;
            name_label.Text = s.Spreadp[1].Name;
            if (s.Spreadp[1].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card1_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[0].Meaning;
            name_label.Text = s.Spreadp[0].Name;
            if (s.Spreadp[0].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card3_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[2].Meaning;
            name_label.Text = s.Spreadp[2].Name;
            if (s.Spreadp[2].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card4_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[3].Meaning;
            name_label.Text = s.Spreadp[3].Name;
            if (s.Spreadp[3].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card5_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[4].Meaning;
            name_label.Text = s.Spreadp[4].Name;
            if (s.Spreadp[4].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card6_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[5].Meaning;
            name_label.Text = s.Spreadp[5].Name;
            if (s.Spreadp[5].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card7_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[6].Meaning;
            name_label.Text = s.Spreadp[6].Name;
            if (s.Spreadp[6].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card8_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[7].Meaning;
            name_label.Text = s.Spreadp[7].Name;
            if (s.Spreadp[7].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card9_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[8].Meaning;
            name_label.Text = s.Spreadp[8].Name;
            if (s.Spreadp[8].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }

        private void card10_Click(object sender, EventArgs e)
        {
            meaning_label.Text = s.Spreadp[9].Meaning;
            name_label.Text = s.Spreadp[9].Name;
            if (s.Spreadp[9].Face)
                face_label.Text = "Reversed";
            else
                face_label.Text = "Upright";
        }
    }
}
