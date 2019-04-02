using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Custom_LaunchPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SoundPlayer test = new SoundPlayer(@"E:\0 Clients\vitaMIND\SAA\SAA_Rppoo\Assets\Ippo sheri aakki thara.wav");// Wav File Location
            test.Play();
        }

        

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SoundPlayer test1 = new SoundPlayer(@"E:\0 Clients\vitaMIND\SAA\SAA_Rppoo\Assets\Kalanghila.wav");// Wav File Location
            test1.Play();
        }

        private void bunifuFlatButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.S))
            {                                      // Edit File Location,
                SoundPlayer test = new SoundPlayer(@"E:\0 Clients\vitaMIND\SAA\SAA_Rppoo\Assets\Ippo sheri aakki thara.wav");// Wav File Location
                test.Play();
            }
            else if (e.KeyCode == Keys.D)
                bunifuFlatButton2.Focus();
        }

        private void bunifuFlatButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.D))
            {                                      // Edit File Location,
                SoundPlayer test1 = new SoundPlayer(@"E:\0 Clients\vitaMIND\SAA\SAA_Rppoo\Assets\Kalanghila.wav");// Wav File Location
                test1.Play();
            }
            else if (e.KeyCode == Keys.S)
                bunifuFlatButton1.Focus();
        }
    }
}
