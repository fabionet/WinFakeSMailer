using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Fake_SMailer
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void chiudiTutto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void impostaServer_Click(object sender, EventArgs e)
        {

        }

        private void resettaTutto1_Click(object sender, EventArgs e)
        {
            mittente1.Text = ("");
            destinatario1.Text = ("");
            oggetto1.Text = ("");
            serverPop1.Text = ("");
            serverSmtp1.Text = ("");
            testomessaggio1.Text = (".... inserisci il testo qui ....");
        }

        private void testomessaggio1_Click(object sender, EventArgs e)
        {
            testomessaggio1.Text = ("");
        }

        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programma liberamente distribuibile creato da FabioNET v.1.0 - BLAT version 0.1.2 GNU General Public License 3.0");
            System.Console.Beep();
        }

        private void consoleMsdos_CheckedChanged(object sender, EventArgs e)
        {
            bool check = true;
           // bool check2 = false;
            if (check == consoleMsdos.Checked)
            {
                System.Diagnostics.Process.Start("c:/windows/system32/cmd.exe");  //Apre la directory principale dell'applicazione sotto MS DOS.
            }
        }
    }
}