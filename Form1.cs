using System.Drawing.Imaging;

namespace CodDeBare
{
    public partial class Form1 : Form
    {
        Image img;
        Graphics g;
        Image imgS;
        String s;
        Color c = Color.Black;
        CodDeBare Cod;
        bool apasat = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(img);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.apasat = true;
            this.s = this.Text.Text;
            if (this.Negativ.Checked == true) this.c = Color.White;
            if (this.Negativ.Checked == false) this.c = Color.Black;
            this.Cod = new CodDeBare(this.s, c);

            p.Refresh();


        }

        private void p_Paint(object sender, PaintEventArgs e)
        {
            if (apasat == true)
            {
                Cod.deseneaza(this.g);

                using (Font myFont = new Font("Arial", 14))
                {
                    g.DrawString(Cod.sFinal, myFont, Brushes.Red, new Point(200, 120));

                }

                e.Graphics.DrawImage(img, 0, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                img.Save(sfd.FileName, format);
            }
        }
    }
}