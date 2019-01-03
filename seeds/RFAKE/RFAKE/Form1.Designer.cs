namespace RFAKE
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.btnBut = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnFake = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.lblFeeling = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(40, 46);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(288, 277);
            this.lst1.TabIndex = 0;
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(438, 46);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(82, 86);
            this.btnQNext.TabIndex = 1;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // btnBut
            // 
            this.btnBut.BackColor = System.Drawing.Color.Lime;
            this.btnBut.Location = new System.Drawing.Point(319, 56);
            this.btnBut.Name = "btnBut";
            this.btnBut.Size = new System.Drawing.Size(167, 36);
            this.btnBut.TabIndex = 2;
            this.btnBut.Text = "But";
            this.btnBut.UseVisualStyleBackColor = false;
            this.btnBut.Visible = false;
            this.btnBut.Click += new System.EventHandler(this.btnBut_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Lime;
            this.btnCheck.Location = new System.Drawing.Point(319, 96);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(167, 36);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnFake
            // 
            this.btnFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFake.Location = new System.Drawing.Point(540, 46);
            this.btnFake.Name = "btnFake";
            this.btnFake.Size = new System.Drawing.Size(82, 86);
            this.btnFake.TabIndex = 4;
            this.btnFake.Text = "FAKE0";
            this.btnFake.UseVisualStyleBackColor = false;
            this.btnFake.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReal
            // 
            this.btnReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReal.Location = new System.Drawing.Point(628, 46);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(82, 86);
            this.btnReal.TabIndex = 5;
            this.btnReal.Text = "REAL0";
            this.btnReal.UseVisualStyleBackColor = false;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.lblFeeling);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(353, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ProgressPicture";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pic4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pic2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pic1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 120);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // pic4
            // 
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(90, 63);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(69, 46);
            this.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            this.pic4.Click += new System.EventHandler(this.pic4_Click);
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(3, 63);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(69, 46);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(90, 3);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(69, 46);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(3, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(69, 46);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click_1);
            // 
            // lblFeeling
            // 
            this.lblFeeling.AutoSize = true;
            this.lblFeeling.BackColor = System.Drawing.Color.Yellow;
            this.lblFeeling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFeeling.Location = new System.Drawing.Point(212, 31);
            this.lblFeeling.Name = "lblFeeling";
            this.lblFeeling.Size = new System.Drawing.Size(43, 15);
            this.lblFeeling.TabIndex = 8;
            this.lblFeeling.Text = "Feeling";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lime;
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Location = new System.Drawing.Point(353, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 124);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ChangingsAndAttitudes";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(22, 29);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(276, 67);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReal);
            this.Controls.Add(this.btnFake);
            this.Controls.Add(this.btnBut);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.lst1);
            this.Name = "Form1";
            this.Text = "RFAKE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.Button btnBut;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnFake;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFeeling;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txt1;
    }
}

