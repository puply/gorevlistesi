namespace GorevLıst
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_gorev_ekleme = new System.Windows.Forms.Button();
            this.gorevCıkar = new System.Windows.Forms.Button();
            this.button_yukariGit = new System.Windows.Forms.Button();
            this.button_asagiGit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_degistir = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_goBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(97, 217);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 124);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button_gorev_ekleme
            // 
            this.button_gorev_ekleme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_gorev_ekleme.Location = new System.Drawing.Point(165, 101);
            this.button_gorev_ekleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_gorev_ekleme.Name = "button_gorev_ekleme";
            this.button_gorev_ekleme.Size = new System.Drawing.Size(109, 52);
            this.button_gorev_ekleme.TabIndex = 2;
            this.button_gorev_ekleme.Text = "Görev Ekle";
            this.button_gorev_ekleme.UseVisualStyleBackColor = true;
            this.button_gorev_ekleme.Click += new System.EventHandler(this.button_gorev_ekleme_Click);
            // 
            // gorevCıkar
            // 
            this.gorevCıkar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gorevCıkar.Location = new System.Drawing.Point(165, 352);
            this.gorevCıkar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gorevCıkar.Name = "gorevCıkar";
            this.gorevCıkar.Size = new System.Drawing.Size(109, 52);
            this.gorevCıkar.TabIndex = 3;
            this.gorevCıkar.Text = "Görev Çıkar";
            this.gorevCıkar.UseVisualStyleBackColor = true;
            this.gorevCıkar.Click += new System.EventHandler(this.gorevCıkar_Click);
            // 
            // button_yukariGit
            // 
            this.button_yukariGit.Location = new System.Drawing.Point(12, 234);
            this.button_yukariGit.Name = "button_yukariGit";
            this.button_yukariGit.Size = new System.Drawing.Size(75, 23);
            this.button_yukariGit.TabIndex = 4;
            this.button_yukariGit.Text = "^";
            this.button_yukariGit.UseVisualStyleBackColor = true;
            this.button_yukariGit.Click += new System.EventHandler(this.button_yukariGit_Click);
            // 
            // button_asagiGit
            // 
            this.button_asagiGit.Location = new System.Drawing.Point(12, 286);
            this.button_asagiGit.Name = "button_asagiGit";
            this.button_asagiGit.Size = new System.Drawing.Size(75, 23);
            this.button_asagiGit.TabIndex = 5;
            this.button_asagiGit.Text = "v";
            this.button_asagiGit.UseVisualStyleBackColor = true;
            this.button_asagiGit.Click += new System.EventHandler(this.button_asagiGit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(97, 165);
            this.label1.MinimumSize = new System.Drawing.Size(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "YAPILACAK GÖREVLER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(130, 28);
            this.label2.MinimumSize = new System.Drawing.Size(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yeni Görev Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Cascadia Code", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(476, 217);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(225, 124);
            this.listBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(476, 165);
            this.label3.MinimumSize = new System.Drawing.Size(225, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "YAPILAN GÖREVLER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_degistir
            // 
            this.button_degistir.Location = new System.Drawing.Point(365, 234);
            this.button_degistir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_degistir.Name = "button_degistir";
            this.button_degistir.Size = new System.Drawing.Size(78, 72);
            this.button_degistir.TabIndex = 10;
            this.button_degistir.Text = " Yapıldı  √";
            this.button_degistir.UseVisualStyleBackColor = true;
            this.button_degistir.Click += new System.EventHandler(this.button_degistir_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clear.Location = new System.Drawing.Point(596, 352);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(105, 52);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Tümünü Temizle";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_goBack
            // 
            this.button_goBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_goBack.Location = new System.Drawing.Point(480, 352);
            this.button_goBack.Name = "button_goBack";
            this.button_goBack.Size = new System.Drawing.Size(110, 52);
            this.button_goBack.TabIndex = 12;
            this.button_goBack.Text = "Geri Al";
            this.button_goBack.UseVisualStyleBackColor = true;
            this.button_goBack.Click += new System.EventHandler(this.button_goBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(502, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_gorev_ekleme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(756, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_goBack);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_degistir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_asagiGit);
            this.Controls.Add(this.button_yukariGit);
            this.Controls.Add(this.gorevCıkar);
            this.Controls.Add(this.button_gorev_ekleme);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Görev Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button button_gorev_ekleme;
        private Button gorevCıkar;
        private Button button_yukariGit;
        private Button button_asagiGit;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Button button_degistir;
        private Button button_clear;
        private Button button_goBack;
        private PictureBox pictureBox1;
    }
}