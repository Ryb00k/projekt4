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
            if (radioButton1.Checked) {
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
    }
}
