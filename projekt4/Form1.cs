using Microsoft.VisualBasic;

namespace projekt4
{
    public partial class Form1 : Form
    {
        public static class globalVars
        {
            public static string path = "";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (radioButton2.Checked)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (radioButton3.Checked)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color originalColor = bmp.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(
                        255 - originalColor.R,
                        255 - originalColor.G,
                        255 - originalColor.B
                    );
                    bmp.SetPixel(x, y, invertedColor);
                }
            }
            pictureBox1.Image = bmp;
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap greenBbm = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < greenBbm.Height; y++) 
            {
                for (int x = 0; x < greenBbm.Width; x++) 
                {
                
                    Color pixel = greenBbm.GetPixel(x,y);
                    if (pixel.G > 150 && pixel.R < 100 && pixel.B < 100) { 
                        greenBbm.SetPixel(x, y, Color.Black);
                    }
                
                }
            }
            pictureBox1.Image = greenBbm;
            Refresh();
        }
    }
}
