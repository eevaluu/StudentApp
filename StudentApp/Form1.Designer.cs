namespace StudentApp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbtnq = new System.Windows.Forms.RadioButton();
            this.rbtnm = new System.Windows.Forms.RadioButton();
            this.rbtmbx = new System.Windows.Forms.RadioButton();
            this.rbtnbn = new System.Windows.Forms.RadioButton();
            this.rbtnst = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rbtnq
            // 
            this.rbtnq.AutoSize = true;
            this.rbtnq.Location = new System.Drawing.Point(12, 236);
            this.rbtnq.Name = "rbtnq";
            this.rbtnq.Size = new System.Drawing.Size(62, 17);
            this.rbtnq.TabIndex = 3;
            this.rbtnq.Text = "Queens";
            this.rbtnq.UseVisualStyleBackColor = true;
            this.rbtnq.CheckedChanged += new System.EventHandler(this.rbtnq_CheckedChanged);
            // 
            // rbtnm
            // 
            this.rbtnm.AutoSize = true;
            this.rbtnm.Location = new System.Drawing.Point(80, 236);
            this.rbtnm.Name = "rbtnm";
            this.rbtnm.Size = new System.Drawing.Size(76, 17);
            this.rbtnm.TabIndex = 4;
            this.rbtnm.Text = "Manhattan";
            this.rbtnm.UseVisualStyleBackColor = true;
            this.rbtnm.CheckedChanged += new System.EventHandler(this.rbtnm_CheckedChanged);
            // 
            // rbtmbx
            // 
            this.rbtmbx.AutoSize = true;
            this.rbtmbx.Location = new System.Drawing.Point(12, 259);
            this.rbtmbx.Name = "rbtmbx";
            this.rbtmbx.Size = new System.Drawing.Size(52, 17);
            this.rbtmbx.TabIndex = 5;
            this.rbtmbx.Text = "Bronx";
            this.rbtmbx.UseVisualStyleBackColor = true;
            this.rbtmbx.CheckedChanged += new System.EventHandler(this.rbtmbx_CheckedChanged);
            // 
            // rbtnbn
            // 
            this.rbtnbn.AutoSize = true;
            this.rbtnbn.Location = new System.Drawing.Point(80, 259);
            this.rbtnbn.Name = "rbtnbn";
            this.rbtnbn.Size = new System.Drawing.Size(66, 17);
            this.rbtnbn.TabIndex = 6;
            this.rbtnbn.Text = "Brooklyn";
            this.rbtnbn.UseVisualStyleBackColor = true;
            this.rbtnbn.CheckedChanged += new System.EventHandler(this.rbtnbn_CheckedChanged);
            // 
            // rbtnst
            // 
            this.rbtnst.AutoSize = true;
            this.rbtnst.Location = new System.Drawing.Point(12, 282);
            this.rbtnst.Name = "rbtnst";
            this.rbtnst.Size = new System.Drawing.Size(87, 17);
            this.rbtnst.TabIndex = 7;
            this.rbtnst.Text = "Staten Island";
            this.rbtnst.UseVisualStyleBackColor = true;
            this.rbtnst.CheckedChanged += new System.EventHandler(this.rbtnst_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(342, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 154);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(342, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 148);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 367);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtnst);
            this.Controls.Add(this.rbtnbn);
            this.Controls.Add(this.rbtmbx);
            this.Controls.Add(this.rbtnm);
            this.Controls.Add(this.rbtnq);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbtnq;
        private System.Windows.Forms.RadioButton rbtnm;
        private System.Windows.Forms.RadioButton rbtmbx;
        private System.Windows.Forms.RadioButton rbtnbn;
        private System.Windows.Forms.RadioButton rbtnst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

