namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRefill = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.richTextBoxQueue = new System.Windows.Forms.RichTextBox();
            this.labelTitleQueue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefill
            // 
            this.buttonRefill.Location = new System.Drawing.Point(12, 12);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(567, 46);
            this.buttonRefill.TabIndex = 0;
            this.buttonRefill.Text = "Перезаполнить";
            this.buttonRefill.UseVisualStyleBackColor = true;
            this.buttonRefill.Click += new System.EventHandler(this.buttonRefill_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Location = new System.Drawing.Point(12, 64);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(260, 47);
            this.richTextBoxInfo.TabIndex = 11;
            this.richTextBoxInfo.Text = "";
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Location = new System.Drawing.Point(12, 117);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.ReadOnly = true;
            this.richTextBoxOut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxOut.Size = new System.Drawing.Size(260, 70);
            this.richTextBoxOut.TabIndex = 12;
            this.richTextBoxOut.Text = "";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(12, 193);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(260, 106);
            this.buttonGet.TabIndex = 1;
            this.buttonGet.Text = "Взять";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // richTextBoxQueue
            // 
            this.richTextBoxQueue.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxQueue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxQueue.Location = new System.Drawing.Point(278, 84);
            this.richTextBoxQueue.Name = "richTextBoxQueue";
            this.richTextBoxQueue.ReadOnly = true;
            this.richTextBoxQueue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxQueue.Size = new System.Drawing.Size(194, 215);
            this.richTextBoxQueue.TabIndex = 13;
            this.richTextBoxQueue.Text = "";
            // 
            // labelTitleQueue
            // 
            this.labelTitleQueue.BackColor = System.Drawing.SystemColors.Window;
            this.labelTitleQueue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitleQueue.Location = new System.Drawing.Point(316, 64);
            this.labelTitleQueue.Name = "labelTitleQueue";
            this.labelTitleQueue.Size = new System.Drawing.Size(119, 20);
            this.labelTitleQueue.TabIndex = 14;
            this.labelTitleQueue.Text = "Очередь автомата:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(479, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitleQueue);
            this.Controls.Add(this.richTextBoxQueue);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.richTextBoxOut);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.buttonRefill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомат сладостей";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonRefill;
        private RichTextBox richTextBoxInfo;
        private RichTextBox richTextBoxOut;
        private Button buttonGet;
        private RichTextBox richTextBoxQueue;
        private Label labelTitleQueue;
        private PictureBox pictureBox1;
    }
}