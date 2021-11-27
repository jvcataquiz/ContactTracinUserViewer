using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_User_Viewer
{
    public partial class Form1 : Form
    {
        string textfile;
        public Form1()
        {
            InitializeComponent();
            
        }
         
      
        private void btnsearch_Click(object sender, EventArgs e)
        {
            StreamReader outputfile;
            textfile = textBoxLN.Text + " " + textBoxFN.Text + ".txt";
            string path = @"C:\Users\Jv Cataquiz\output\" + textfile;
            if (File.Exists(path))
            {
                textBoxResult.Text = textfile + " ✓";
                textBoxResult.ForeColor = System.Drawing.Color.Green;
                buttonNext.Visible = true;
            }
            else
            {
                textBoxResult.Text = textfile + " X";
                textBoxResult.ForeColor = System.Drawing.Color.Red;
                buttonNext.Visible = false;
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            textBoxFN.Text = "";
            textBoxLN.Text = "";
            buttonNext.Visible = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
           
            if (buttonNext.Text == "Next")
            {
                buttonNext.Text = "Home";
                buttonclear.Visible = false;
                labelfn.Visible = false;
                labelln.Visible = false;
                labelresult.Visible = false;
                textBoxFN.Visible = false;
                textBoxLN.Visible = false;
                textBoxResult.Visible = false;
                btnsearch.Visible = false;

                labeltextfilename.Visible = true;
                richTextBoxdisplay.Visible = true;
                buttonsearch2.Visible = true;
                panelfilehandling.Visible = true;
                textBoxsearch.Visible = true;
                labeltextfilename.Text = textfile;
            }
            else
            {
                buttonNext.Text = "Next";
                buttonclear.Visible = true;
                labelfn.Visible = true;
                labelln.Visible = true;
                labelresult.Visible = true;
                textBoxFN.Visible = true;
                textBoxLN.Visible = true;
                textBoxResult.Visible = true;
                btnsearch.Visible = true;

                labeltextfilename.Visible = false;
                richTextBoxdisplay.Visible = false;
                buttonsearch2.Visible = false;
                panelfilehandling.Visible = false;
                textBoxsearch.Visible = false;
                this.ClientSize = new System.Drawing.Size(342, 469);
            }

        }
    }
}
