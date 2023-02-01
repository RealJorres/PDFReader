namespace PDFReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.btn_readFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbox = new System.Windows.Forms.RichTextBox();
            this.btnControl = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openFile.Location = new System.Drawing.Point(12, 12);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(75, 23);
            this.btn_openFile.TabIndex = 0;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // btn_readFile
            // 
            this.btn_readFile.Enabled = false;
            this.btn_readFile.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readFile.Location = new System.Drawing.Point(12, 41);
            this.btn_readFile.Name = "btn_readFile";
            this.btn_readFile.Size = new System.Drawing.Size(75, 23);
            this.btn_readFile.TabIndex = 1;
            this.btn_readFile.Text = "Read File";
            this.btn_readFile.UseVisualStyleBackColor = true;
            this.btn_readFile.Click += new System.EventHandler(this.btn_readFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(93, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(324, 21);
            this.textBox1.TabIndex = 2;
            // 
            // tbox
            // 
            this.tbox.BackColor = System.Drawing.Color.Gainsboro;
            this.tbox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox.Location = new System.Drawing.Point(93, 42);
            this.tbox.Name = "tbox";
            this.tbox.ReadOnly = true;
            this.tbox.Size = new System.Drawing.Size(324, 23);
            this.tbox.TabIndex = 3;
            this.tbox.Text = "";
            this.tbox.Visible = false;
            // 
            // btnControl
            // 
            this.btnControl.Enabled = false;
            this.btnControl.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.Location = new System.Drawing.Point(211, 71);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(75, 23);
            this.btnControl.TabIndex = 5;
            this.btnControl.Text = "II";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(382, 81);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 103);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.tbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_readFile);
            this.Controls.Add(this.btn_openFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF to Voice 1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.Button btn_readFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox tbox;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

