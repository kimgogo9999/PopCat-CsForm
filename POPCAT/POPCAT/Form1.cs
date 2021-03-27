using System;
using System.Media;
using System.Windows.Forms;

namespace POPCAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.cat_open;
            click_count++;
            this.Text = $"POPCAT! - {click_count.ToString()}";
            SoundPlayer s = new SoundPlayer(Properties.Resources.pop);
            s.Play();
        }

        int click_count = 0;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackgroundImage = Properties.Resources.cat_close;
        }
    }
}
