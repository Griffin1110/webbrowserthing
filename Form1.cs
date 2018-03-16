using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_web_browser_I_made
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This function is called whent the exit menu item is selected.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple program made by Ali aka Griffin. Nothing much to it, yankai if you're reading this hello, if this is jordan hello, if anyone else is readinf this hello. ok bye");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NavigateToPage();
        }

        private void button1_Click(object sender, EventArgs e) { 
        
            webBrowser1.Navigate(textBox1.Text);
        }

        //This is the function that will perform all navigation 
        private void NavigateToPage()
        {
            webBrowser1.Navigate(textBox1.Text);
            button1.Enabled = true;
            textBox1.Enabled = true;
        }


        //This will fire every single time a key is pushed an released
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {   
            //if the key was enter then do somehthing
            if( e.KeyChar == (char)ConsoleKey.Enter )
            {
                NavigateToPage();
            }
        }

        //When the page has finished loading this fires
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
        }
        
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 & e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
