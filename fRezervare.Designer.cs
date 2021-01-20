namespace ProiectHotel
{
    partial class fRezervare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRezervare));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataCazare = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDecazare = new System.Windows.Forms.DateTimePicker();
            this.cbEtaj = new System.Windows.Forms.ComboBox();
            this.cbTipCamera = new System.Windows.Forms.ComboBox();
            this.cbNumarCamera = new System.Windows.Forms.ComboBox();
            this.btConfirma = new System.Windows.Forms.Button();
            this.btAnuleaza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEtaj = new System.Windows.Forms.Label();
            this.lblTipCamera = new System.Windows.Forms.Label();
            this.lblNumarCamera = new System.Windows.Forms.Label();
            this.btCauta = new System.Windows.Forms.Button();
            this.btIntroduceAltaData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rbRezervare = new System.Windows.Forms.RadioButton();
            this.rbCazare = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalii Camera ";
            // 
            // dtpDataCazare
            // 
            this.dtpDataCazare.CustomFormat = "dd-MM-yyyy";
            this.dtpDataCazare.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dtpDataCazare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCazare.Location = new System.Drawing.Point(117, 90);
            this.dtpDataCazare.MinDate = new System.DateTime(2020, 4, 23, 0, 0, 0, 0);
            this.dtpDataCazare.Name = "dtpDataCazare";
            this.dtpDataCazare.Size = new System.Drawing.Size(112, 21);
            this.dtpDataCazare.TabIndex = 1;
            this.dtpDataCazare.Value = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            // 
            // dtpDataDecazare
            // 
            this.dtpDataDecazare.CustomFormat = "dd-MM-yyyy";
            this.dtpDataDecazare.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dtpDataDecazare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDecazare.Location = new System.Drawing.Point(117, 131);
            this.dtpDataDecazare.Name = "dtpDataDecazare";
            this.dtpDataDecazare.Size = new System.Drawing.Size(112, 21);
            this.dtpDataDecazare.TabIndex = 2;
            this.dtpDataDecazare.Value = new System.DateTime(2020, 4, 23, 0, 0, 0, 0);
            // 
            // cbEtaj
            // 
            this.cbEtaj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEtaj.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cbEtaj.FormattingEnabled = true;
            this.cbEtaj.Location = new System.Drawing.Point(357, 227);
            this.cbEtaj.Name = "cbEtaj";
            this.cbEtaj.Size = new System.Drawing.Size(71, 24);
            this.cbEtaj.TabIndex = 3;
            this.cbEtaj.Visible = false;
            this.cbEtaj.SelectedIndexChanged += new System.EventHandler(this.cbNumarCamera_SelectedIndexChanged);
            // 
            // cbTipCamera
            // 
            this.cbTipCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipCamera.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cbTipCamera.FormattingEnabled = true;
            this.cbTipCamera.Location = new System.Drawing.Point(107, 227);
            this.cbTipCamera.Name = "cbTipCamera";
            this.cbTipCamera.Size = new System.Drawing.Size(150, 24);
            this.cbTipCamera.TabIndex = 4;
            this.cbTipCamera.Visible = false;
            this.cbTipCamera.SelectedIndexChanged += new System.EventHandler(this.cbEtaj_SelectedIndexChanged1);
            // 
            // cbNumarCamera
            // 
            this.cbNumarCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumarCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumarCamera.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.cbNumarCamera.FormattingEnabled = true;
            this.cbNumarCamera.Location = new System.Drawing.Point(107, 258);
            this.cbNumarCamera.Name = "cbNumarCamera";
            this.cbNumarCamera.Size = new System.Drawing.Size(112, 24);
            this.cbNumarCamera.TabIndex = 5;
            this.cbNumarCamera.Visible = false;
            this.cbNumarCamera.SelectedIndexChanged += new System.EventHandler(this.cbNumarCamera_A1);
            // 
            // btConfirma
            // 
            this.btConfirma.BackColor = System.Drawing.Color.White;
            this.btConfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirma.FlatAppearance.BorderSize = 0;
            this.btConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirma.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btConfirma.Location = new System.Drawing.Point(10, 355);
            this.btConfirma.Name = "btConfirma";
            this.btConfirma.Size = new System.Drawing.Size(209, 23);
            this.btConfirma.TabIndex = 7;
            this.btConfirma.Text = "Confirma";
            this.btConfirma.UseVisualStyleBackColor = false;
            this.btConfirma.Visible = false;
            this.btConfirma.Click += new System.EventHandler(this.btConfirma_Click);
            // 
            // btAnuleaza
            // 
            this.btAnuleaza.BackColor = System.Drawing.Color.White;
            this.btAnuleaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnuleaza.FlatAppearance.BorderSize = 0;
            this.btAnuleaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnuleaza.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btAnuleaza.Location = new System.Drawing.Point(357, 355);
            this.btAnuleaza.Name = "btAnuleaza";
            this.btAnuleaza.Size = new System.Drawing.Size(75, 23);
            this.btAnuleaza.TabIndex = 8;
            this.btAnuleaza.Text = "Anuleaza";
            this.btAnuleaza.UseVisualStyleBackColor = false;
            this.btAnuleaza.Click += new System.EventHandler(this.btAnuleaza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Cazare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label4.Location = new System.Drawing.Point(14, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data decazare";
            // 
            // lblEtaj
            // 
            this.lblEtaj.AutoSize = true;
            this.lblEtaj.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblEtaj.Location = new System.Drawing.Point(303, 235);
            this.lblEtaj.Name = "lblEtaj";
            this.lblEtaj.Size = new System.Drawing.Size(28, 16);
            this.lblEtaj.TabIndex = 12;
            this.lblEtaj.Text = "Etaj";
            this.lblEtaj.Visible = false;
            // 
            // lblTipCamera
            // 
            this.lblTipCamera.AutoSize = true;
            this.lblTipCamera.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblTipCamera.Location = new System.Drawing.Point(7, 235);
            this.lblTipCamera.Name = "lblTipCamera";
            this.lblTipCamera.Size = new System.Drawing.Size(71, 16);
            this.lblTipCamera.TabIndex = 13;
            this.lblTipCamera.Text = "Tip Camera";
            this.lblTipCamera.Visible = false;
            // 
            // lblNumarCamera
            // 
            this.lblNumarCamera.AutoSize = true;
            this.lblNumarCamera.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblNumarCamera.Location = new System.Drawing.Point(7, 266);
            this.lblNumarCamera.Name = "lblNumarCamera";
            this.lblNumarCamera.Size = new System.Drawing.Size(90, 16);
            this.lblNumarCamera.TabIndex = 14;
            this.lblNumarCamera.Text = "Numar camera";
            this.lblNumarCamera.Visible = false;
            // 
            // btCauta
            // 
            this.btCauta.BackColor = System.Drawing.Color.White;
            this.btCauta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCauta.FlatAppearance.BorderSize = 0;
            this.btCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCauta.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btCauta.Location = new System.Drawing.Point(256, 132);
            this.btCauta.Name = "btCauta";
            this.btCauta.Size = new System.Drawing.Size(176, 23);
            this.btCauta.TabIndex = 15;
            this.btCauta.Text = "Cauta";
            this.btCauta.UseVisualStyleBackColor = false;
            this.btCauta.Click += new System.EventHandler(this.btCauta_Click);
            // 
            // btIntroduceAltaData
            // 
            this.btIntroduceAltaData.BackColor = System.Drawing.Color.White;
            this.btIntroduceAltaData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIntroduceAltaData.FlatAppearance.BorderSize = 0;
            this.btIntroduceAltaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIntroduceAltaData.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btIntroduceAltaData.Location = new System.Drawing.Point(260, 90);
            this.btIntroduceAltaData.Name = "btIntroduceAltaData";
            this.btIntroduceAltaData.Size = new System.Drawing.Size(176, 23);
            this.btIntroduceAltaData.TabIndex = 16;
            this.btIntroduceAltaData.Text = "Introduce alta data";
            this.btIntroduceAltaData.UseVisualStyleBackColor = false;
            this.btIntroduceAltaData.Visible = false;
            this.btIntroduceAltaData.Click += new System.EventHandler(this.btIntroduceAltaData_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(407, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbRezervare
            // 
            this.rbRezervare.AutoSize = true;
            this.rbRezervare.Location = new System.Drawing.Point(256, 180);
            this.rbRezervare.Name = "rbRezervare";
            this.rbRezervare.Size = new System.Drawing.Size(74, 17);
            this.rbRezervare.TabIndex = 18;
            this.rbRezervare.TabStop = true;
            this.rbRezervare.Text = "Rezervare";
            this.rbRezervare.UseVisualStyleBackColor = true;
            // 
            // rbCazare
            // 
            this.rbCazare.AutoSize = true;
            this.rbCazare.Location = new System.Drawing.Point(107, 180);
            this.rbCazare.Name = "rbCazare";
            this.rbCazare.Size = new System.Drawing.Size(58, 17);
            this.rbCazare.TabIndex = 19;
            this.rbCazare.TabStop = true;
            this.rbCazare.Text = "Cazare";
            this.rbCazare.UseVisualStyleBackColor = true;
            this.rbCazare.CheckedChanged += new System.EventHandler(this.rbCazare_CheckedChanged);
            // 
            // fRezervare
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(448, 420);
            this.Controls.Add(this.rbCazare);
            this.Controls.Add(this.rbRezervare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btIntroduceAltaData);
            this.Controls.Add(this.btCauta);
            this.Controls.Add(this.lblNumarCamera);
            this.Controls.Add(this.lblTipCamera);
            this.Controls.Add(this.lblEtaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAnuleaza);
            this.Controls.Add(this.btConfirma);
            this.Controls.Add(this.cbNumarCamera);
            this.Controls.Add(this.cbTipCamera);
            this.Controls.Add(this.cbEtaj);
            this.Controls.Add(this.dtpDataDecazare);
            this.Controls.Add(this.dtpDataCazare);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fRezervare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervare";
            this.Load += new System.EventHandler(this.fRezervare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataCazare;
        private System.Windows.Forms.DateTimePicker dtpDataDecazare;
        private System.Windows.Forms.ComboBox cbEtaj;
        private System.Windows.Forms.ComboBox cbTipCamera;
        private System.Windows.Forms.ComboBox cbNumarCamera;
        private System.Windows.Forms.Button btConfirma;
        private System.Windows.Forms.Button btAnuleaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEtaj;
        private System.Windows.Forms.Label lblTipCamera;
        private System.Windows.Forms.Label lblNumarCamera;
        private System.Windows.Forms.Button btCauta;
        private System.Windows.Forms.Button btIntroduceAltaData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbRezervare;
        private System.Windows.Forms.RadioButton rbCazare;
    }
}