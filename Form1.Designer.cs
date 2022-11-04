namespace SampaldemoFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnCreateDirectory = new System.Windows.Forms.Button();
            this.BtnCreateFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnWriteStream = new System.Windows.Forms.Button();
            this.btnReadStream = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Location";
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(331, 317);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(75, 23);
            this.BtnWrite.TabIndex = 3;
            this.BtnWrite.Text = "Write";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(689, 326);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 4;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnCreateDirectory
            // 
            this.BtnCreateDirectory.Location = new System.Drawing.Point(345, 445);
            this.BtnCreateDirectory.Name = "BtnCreateDirectory";
            this.BtnCreateDirectory.Size = new System.Drawing.Size(107, 53);
            this.BtnCreateDirectory.TabIndex = 5;
            this.BtnCreateDirectory.Text = "Create Directory";
            this.BtnCreateDirectory.UseVisualStyleBackColor = true;
            this.BtnCreateDirectory.Click += new System.EventHandler(this.BtnCreateDirectory_Click);
            // 
            // BtnCreateFile
            // 
            this.BtnCreateFile.Location = new System.Drawing.Point(695, 443);
            this.BtnCreateFile.Name = "BtnCreateFile";
            this.BtnCreateFile.Size = new System.Drawing.Size(149, 44);
            this.BtnCreateFile.TabIndex = 6;
            this.BtnCreateFile.Text = "Create File";
            this.BtnCreateFile.UseVisualStyleBackColor = true;
            this.BtnCreateFile.Click += new System.EventHandler(this.BtnCreateFile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(620, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(615, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(347, 26);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(620, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 26);
            this.textBox3.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1055, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 125);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // btnWriteStream
            // 
            this.btnWriteStream.Location = new System.Drawing.Point(1028, 244);
            this.btnWriteStream.Name = "btnWriteStream";
            this.btnWriteStream.Size = new System.Drawing.Size(209, 45);
            this.btnWriteStream.TabIndex = 11;
            this.btnWriteStream.Text = "Write using Stream";
            this.btnWriteStream.UseVisualStyleBackColor = true;
            this.btnWriteStream.Click += new System.EventHandler(this.btnWriteStream_Click);
            // 
            // btnReadStream
            // 
            this.btnReadStream.Location = new System.Drawing.Point(1032, 314);
            this.btnReadStream.Name = "btnReadStream";
            this.btnReadStream.Size = new System.Drawing.Size(204, 48);
            this.btnReadStream.TabIndex = 12;
            this.btnReadStream.Text = "Read Using Stream";
            this.btnReadStream.UseVisualStyleBackColor = true;
            this.btnReadStream.Click += new System.EventHandler(this.btnReadStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 499);
            this.Controls.Add(this.btnReadStream);
            this.Controls.Add(this.btnWriteStream);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnCreateFile);
            this.Controls.Add(this.BtnCreateDirectory);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnCreateDirectory;
        private System.Windows.Forms.Button BtnCreateFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnWriteStream;
        private System.Windows.Forms.Button btnReadStream;
    }
}

