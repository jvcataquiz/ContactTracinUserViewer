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
        string path;
        public Form1()
        {
            InitializeComponent();
            
        }
         
      
        private void btnsearch_Click(object sender, EventArgs e)
        {
           
            textfile = textBoxLN.Text + " " + textBoxFN.Text + " " + textBoxMi.Text + ".txt";
            path = @"C:\Users\Jv Cataquiz\output\" + textfile;
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
            textBoxMi.Text = "";
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
                textBoxMi.Visible = false;
                label2.Visible = false;


                buttonAll.Visible = true;
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
                textBoxMi.Visible = true; 
                label2.Visible = true;

                buttonAll.Visible = false;
                labeltextfilename.Visible = false;
                richTextBoxdisplay.Visible = false;
                buttonsearch2.Visible = false;
                panelfilehandling.Visible = false;
                textBoxsearch.Visible = false;
                this.ClientSize = new System.Drawing.Size(342, 469);
            }

        }

        private void buttonsearch2_Click(object sender, EventArgs e)
        {
            StreamReader readeroutputfile;
            readeroutputfile = File.OpenText(path);
            while (!readeroutputfile.EndOfStream)
            {
                String currentline = readeroutputfile.ReadLine();
                if (currentline.Contains(textBoxsearch.Text))
                {
                    richTextBoxdisplay.Text = currentline;
                }
                
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            string filedata = File.ReadAllText(path);
            richTextBoxdisplay.Text = filedata;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] filepath = Directory.GetFiles(@"C:\Users\Jv Cataquiz\output\", "*.txt");
            foreach (string file in filepath)
            {
                listBoxView.Items.Add(Path.GetFileName(file));

            }
           
           
        }

        private void listBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBoxView_Click(object sender, EventArgs e)
        {

            string rep = listBoxView.GetItemText(listBoxView.SelectedItem).Replace(".txt", " ");
            string[] parts = rep.Split(' ');
            textBoxLN.Text = parts[0];
            textBoxFN.Text = parts[1];
            textBoxMi.Text = parts[2];


        }
    }
}
