namespace proje
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
            title = new Label();
            label1 = new Label();
            hesapla = new Button();
            tekneTurCB = new ComboBox();
            tekneUzunluguCB = new ComboBox();
            label2 = new Label();
            baslangicDTP = new DateTimePicker();
            bitisDTP = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            title.Location = new Point(79, 26);
            title.Name = "title";
            title.Size = new Size(589, 36);
            title.TabIndex = 0;
            title.Text = "Tekne Kiralama Ücreti Hesaplayıcı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 83);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Tekne Türü";
            // 
            // hesapla
            // 
            hesapla.Location = new Point(79, 395);
            hesapla.Name = "hesapla";
            hesapla.Size = new Size(134, 29);
            hesapla.TabIndex = 3;
            hesapla.Text = "Ücreti Hesapla";
            hesapla.UseVisualStyleBackColor = true;
            hesapla.Click += hesapla_Click;
            // 
            // tekneTurCB
            // 
            tekneTurCB.FormattingEnabled = true;
            tekneTurCB.Items.AddRange(new object[] { "Gulet", "Motoryat" });
            tekneTurCB.Location = new Point(79, 106);
            tekneTurCB.Name = "tekneTurCB";
            tekneTurCB.Size = new Size(205, 28);
            tekneTurCB.TabIndex = 4;
            tekneTurCB.SelectedIndexChanged += tekneTurCB_SelectedIndexChanged;
            // 
            // tekneUzunluguCB
            // 
            tekneUzunluguCB.FormattingEnabled = true;
            tekneUzunluguCB.Items.AddRange(new object[] { "14", "15", "16" });
            tekneUzunluguCB.Location = new Point(79, 180);
            tekneUzunluguCB.Name = "tekneUzunluguCB";
            tekneUzunluguCB.Size = new Size(113, 28);
            tekneUzunluguCB.TabIndex = 5;
            tekneUzunluguCB.SelectedIndexChanged += tekneUzunluguCB_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 157);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 6;
            label2.Text = "Tekne Uzunluğu";
            // 
            // baslangicDTP
            // 
            baslangicDTP.Location = new Point(79, 247);
            baslangicDTP.Name = "baslangicDTP";
            baslangicDTP.Size = new Size(250, 27);
            baslangicDTP.TabIndex = 7;
            // 
            // bitisDTP
            // 
            bitisDTP.Location = new Point(79, 328);
            bitisDTP.Name = "bitisDTP";
            bitisDTP.Size = new Size(250, 27);
            bitisDTP.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 224);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 9;
            label3.Text = "Başlangıç Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 305);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 10;
            label4.Text = "Bitiş Tarihi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(bitisDTP);
            Controls.Add(baslangicDTP);
            Controls.Add(label2);
            Controls.Add(tekneUzunluguCB);
            Controls.Add(tekneTurCB);
            Controls.Add(hesapla);
            Controls.Add(label1);
            Controls.Add(title);
            Name = "Form1";
            Text = "Yapısal Projesi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label label1;
        private Button hesapla;
        private ComboBox tekneTurCB;
        private ComboBox tekneUzunluguCB;
        private Label label2;
        private DateTimePicker baslangicDTP;
        private DateTimePicker bitisDTP;
        private Label label3;
        private Label label4;
    }
}
