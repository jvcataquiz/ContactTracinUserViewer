
namespace Contact_Tracing_User_Viewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxdisplay = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.labelln = new System.Windows.Forms.Label();
            this.labelfn = new System.Windows.Forms.Label();
            this.labelresult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.panelfilehandling = new System.Windows.Forms.Panel();
            this.labeltextfilename = new System.Windows.Forms.Label();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.buttonsearch2 = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            this.panelfilehandling.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxdisplay
            // 
            this.richTextBoxdisplay.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBoxdisplay.Location = new System.Drawing.Point(342, 0);
            this.richTextBoxdisplay.Name = "richTextBoxdisplay";
            this.richTextBoxdisplay.Size = new System.Drawing.Size(281, 469);
            this.richTextBoxdisplay.TabIndex = 10;
            this.richTextBoxdisplay.Text = "";
            this.richTextBoxdisplay.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Tracing User Viewer";
            // 
            // textBoxLN
            // 
            this.textBoxLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxLN.Location = new System.Drawing.Point(13, 194);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(122, 23);
            this.textBoxLN.TabIndex = 1;
            this.textBoxLN.TabStop = false;
            // 
            // textBoxFN
            // 
            this.textBoxFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxFN.Location = new System.Drawing.Point(141, 194);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(107, 23);
            this.textBoxFN.TabIndex = 2;
            this.textBoxFN.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(254, 194);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.TabStop = false;
            this.btnsearch.Text = "Check";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // labelln
            // 
            this.labelln.AutoSize = true;
            this.labelln.Location = new System.Drawing.Point(11, 222);
            this.labelln.Name = "labelln";
            this.labelln.Size = new System.Drawing.Size(68, 13);
            this.labelln.TabIndex = 4;
            this.labelln.Text = "LAST NAME";
            // 
            // labelfn
            // 
            this.labelfn.AutoSize = true;
            this.labelfn.Location = new System.Drawing.Point(139, 222);
            this.labelfn.Name = "labelfn";
            this.labelfn.Size = new System.Drawing.Size(72, 13);
            this.labelfn.TabIndex = 5;
            this.labelfn.Text = "FIRST NAME";
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult.Location = new System.Drawing.Point(12, 53);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(73, 18);
            this.labelresult.TabIndex = 7;
            this.labelresult.Text = "RESULT";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.textBoxResult.Location = new System.Drawing.Point(15, 80);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(313, 46);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.TabStop = false;
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(253, 132);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 23);
            this.buttonclear.TabIndex = 9;
            this.buttonclear.TabStop = false;
            this.buttonclear.Text = "CLEAR";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(252, 418);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(76, 39);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.TabStop = false;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.Aquamarine;
            this.panelWelcome.Controls.Add(this.buttonNext);
            this.panelWelcome.Controls.Add(this.panelfilehandling);
            this.panelWelcome.Controls.Add(this.buttonclear);
            this.panelWelcome.Controls.Add(this.textBoxResult);
            this.panelWelcome.Controls.Add(this.labelresult);
            this.panelWelcome.Controls.Add(this.labelfn);
            this.panelWelcome.Controls.Add(this.labelln);
            this.panelWelcome.Controls.Add(this.btnsearch);
            this.panelWelcome.Controls.Add(this.textBoxFN);
            this.panelWelcome.Controls.Add(this.textBoxLN);
            this.panelWelcome.Controls.Add(this.label1);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(342, 469);
            this.panelWelcome.TabIndex = 9;
            // 
            // panelfilehandling
            // 
            this.panelfilehandling.Controls.Add(this.buttonsearch2);
            this.panelfilehandling.Controls.Add(this.textBoxsearch);
            this.panelfilehandling.Controls.Add(this.labeltextfilename);
            this.panelfilehandling.Location = new System.Drawing.Point(0, 29);
            this.panelfilehandling.Name = "panelfilehandling";
            this.panelfilehandling.Size = new System.Drawing.Size(342, 440);
            this.panelfilehandling.TabIndex = 11;
            this.panelfilehandling.Visible = false;
            // 
            // labeltextfilename
            // 
            this.labeltextfilename.AutoSize = true;
            this.labeltextfilename.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltextfilename.Location = new System.Drawing.Point(12, 13);
            this.labeltextfilename.Name = "labeltextfilename";
            this.labeltextfilename.Size = new System.Drawing.Size(76, 20);
            this.labeltextfilename.TabIndex = 0;
            this.labeltextfilename.Text = "textfile";
            this.labeltextfilename.Visible = false;
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBoxsearch.Location = new System.Drawing.Point(8, 184);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(320, 31);
            this.textBoxsearch.TabIndex = 1;
            this.textBoxsearch.Visible = false;
            // 
            // buttonsearch2
            // 
            this.buttonsearch2.Location = new System.Drawing.Point(8, 222);
            this.buttonsearch2.Name = "buttonsearch2";
            this.buttonsearch2.Size = new System.Drawing.Size(75, 23);
            this.buttonsearch2.TabIndex = 2;
            this.buttonsearch2.Text = "Search";
            this.buttonsearch2.UseVisualStyleBackColor = true;
            this.buttonsearch2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(342, 469);
            this.Controls.Add(this.richTextBoxdisplay);
            this.Controls.Add(this.panelWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelfilehandling.ResumeLayout(false);
            this.panelfilehandling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxdisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label labelln;
        private System.Windows.Forms.Label labelfn;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Panel panelfilehandling;
        private System.Windows.Forms.Button buttonsearch2;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label labeltextfilename;
    }
}

