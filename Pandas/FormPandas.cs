using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pandas
{
    public partial class FormPandas : Form
    {
        public FormPandas()
        {
            InitializeComponent();
        }

        Image[] images = new Image[226];
        int count = 0;

        private void FormPandas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 225; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\Images\panda" + i + ".png");
            }

            //set 1st image as initial
            pictureBox1.Image = images[0];
            //set pictureBox the same size as the image
            pictureBox1.Size = pictureBox1.Image.Size;
        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = images[count];
            count++;
            if (count > 225)
                count = 0;
        }
    }
}
