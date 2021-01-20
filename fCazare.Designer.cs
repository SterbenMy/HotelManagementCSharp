namespace ProiectHotel
{
    partial class fCazare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCazare));
            this.label1 = new System.Windows.Forms.Label();
            this.btAnulare = new System.Windows.Forms.Button();
            this.btCazeazaAcum = new System.Windows.Forms.Button();
            this.btCazeaza = new System.Windows.Forms.Button();
            this.lbxRezervari = new System.Windows.Forms.ListBox();
            this.dtpSelectData = new System.Windows.Forms.DateTimePicker();
            this.lblSelectData = new System.Windows.Forms.Label();
            this.btSelectData = new System.Windows.Forms.Button();
            this.lblRezervare = new System.Windows.Forms.Label();
            this.txtRezervare = new System.Windows.Forms.TextBox();
            this.btAltaData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(238, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cazeaza persoane";
            // 
            // btAnulare
            // 
            this.btAnulare.BackColor = System.Drawing.Color.White;
            this.btAnulare.FlatAppearance.BorderSize = 0;
            this.btAnulare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnulare.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btAnulare.Location = new System.Drawing.Point(602, 447);
            this.btAnulare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAnulare.Name = "btAnulare";
            this.btAnulare.Size = new System.Drawing.Size(155, 58);
            this.btAnulare.TabIndex = 4;
            this.btAnulare.Text = "Anulare";
            this.btAnulare.UseVisualStyleBackColor = false;
            this.btAnulare.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCazeazaAcum
            // 
            this.btCazeazaAcum.BackColor = System.Drawing.Color.White;
            this.btCazeazaAcum.FlatAppearance.BorderSize = 0;
            this.btCazeazaAcum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCazeazaAcum.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btCazeazaAcum.Location = new System.Drawing.Point(603, 359);
            this.btCazeazaAcum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCazeazaAcum.Name = "btCazeazaAcum";
            this.btCazeazaAcum.Size = new System.Drawing.Size(155, 80);
            this.btCazeazaAcum.TabIndex = 5;
            this.btCazeazaAcum.Text = "Cazeaza pe cineva venit";
            this.btCazeazaAcum.UseVisualStyleBackColor = false;
            this.btCazeazaAcum.Click += new System.EventHandler(this.btCazeazaAcum_Click);
            // 
            // btCazeaza
            // 
            this.btCazeaza.BackColor = System.Drawing.Color.White;
            this.btCazeaza.Enabled = false;
            this.btCazeaza.FlatAppearance.BorderSize = 0;
            this.btCazeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCazeaza.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btCazeaza.Location = new System.Drawing.Point(602, 233);
            this.btCazeaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCazeaza.Name = "btCazeaza";
            this.btCazeaza.Size = new System.Drawing.Size(154, 68);
            this.btCazeaza.TabIndex = 6;
            this.btCazeaza.Text = "Cazeaza";
            this.btCazeaza.UseVisualStyleBackColor = false;
            this.btCazeaza.Visible = false;
            this.btCazeaza.Click += new System.EventHandler(this.btCazeaza_Click);
            // 
            // lbxRezervari
            // 
            this.lbxRezervari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxRezervari.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lbxRezervari.FormattingEnabled = true;
            this.lbxRezervari.ItemHeight = 16;
            this.lbxRezervari.Location = new System.Drawing.Point(20, 233);
            this.lbxRezervari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxRezervari.Name = "lbxRezervari";
            this.lbxRezervari.Size = new System.Drawing.Size(562, 272);
            this.lbxRezervari.TabIndex = 7;
            this.lbxRezervari.SelectedIndexChanged += new System.EventHandler(this.lbxRezervari_SelectedIndexChanged);
            // 
            // dtpSelectData
            // 
            this.dtpSelectData.CustomFormat = "dd/MM/yyyy";
            this.dtpSelectData.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dtpSelectData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelectData.Location = new System.Drawing.Point(260, 81);
            this.dtpSelectData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSelectData.Name = "dtpSelectData";
            this.dtpSelectData.Size = new System.Drawing.Size(208, 21);
            this.dtpSelectData.TabIndex = 9;
            this.dtpSelectData.Value = new System.DateTime(2020, 4, 24, 0, 0, 0, 0);
            // 
            // lblSelectData
            // 
            this.lblSelectData.AutoSize = true;
            this.lblSelectData.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblSelectData.Location = new System.Drawing.Point(15, 81);
            this.lblSelectData.Name = "lblSelectData";
            this.lblSelectData.Size = new System.Drawing.Size(140, 21);
            this.lblSelectData.TabIndex = 10;
            this.lblSelectData.Text = "Selectati data ";
            // 
            // btSelectData
            // 
            this.btSelectData.BackColor = System.Drawing.Color.White;
            this.btSelectData.FlatAppearance.BorderSize = 0;
            this.btSelectData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelectData.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btSelectData.Location = new System.Drawing.Point(489, 78);
            this.btSelectData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSelectData.Name = "btSelectData";
            this.btSelectData.Size = new System.Drawing.Size(134, 28);
            this.btSelectData.TabIndex = 11;
            this.btSelectData.Text = "Selecteaza";
            this.btSelectData.UseVisualStyleBackColor = false;
            this.btSelectData.Click += new System.EventHandler(this.btSelectData_Click);
            // 
            // lblRezervare
            // 
            this.lblRezervare.AutoSize = true;
            this.lblRezervare.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblRezervare.Location = new System.Drawing.Point(12, 137);
            this.lblRezervare.Name = "lblRezervare";
            this.lblRezervare.Size = new System.Drawing.Size(211, 21);
            this.lblRezervare.TabIndex = 12;
            this.lblRezervare.Text = "Ati selectat rezervarea";
            this.lblRezervare.Visible = false;
            // 
            // txtRezervare
            // 
            this.txtRezervare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRezervare.Enabled = false;
            this.txtRezervare.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtRezervare.Location = new System.Drawing.Point(260, 144);
            this.txtRezervare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRezervare.Name = "txtRezervare";
            this.txtRezervare.Size = new System.Drawing.Size(321, 14);
            this.txtRezervare.TabIndex = 13;
            this.txtRezervare.Visible = false;
            // 
            // btAltaData
            // 
            this.btAltaData.BackColor = System.Drawing.Color.White;
            this.btAltaData.Enabled = false;
            this.btAltaData.FlatAppearance.BorderSize = 0;
            this.btAltaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAltaData.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btAltaData.Location = new System.Drawing.Point(630, 78);
            this.btAltaData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAltaData.Name = "btAltaData";
            this.btAltaData.Size = new System.Drawing.Size(127, 28);
            this.btAltaData.TabIndex = 14;
            this.btAltaData.Text = "Alta Data";
            this.btAltaData.UseVisualStyleBackColor = false;
            this.btAltaData.Click += new System.EventHandler(this.btAltaData_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(729, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fCazare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(772, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAltaData);
            this.Controls.Add(this.txtRezervare);
            this.Controls.Add(this.lblRezervare);
            this.Controls.Add(this.btSelectData);
            this.Controls.Add(this.lblSelectData);
            this.Controls.Add(this.dtpSelectData);
            this.Controls.Add(this.lbxRezervari);
            this.Controls.Add(this.btCazeaza);
            this.Controls.Add(this.btCazeazaAcum);
            this.Controls.Add(this.btAnulare);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fCazare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cazare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAnulare;
        private System.Windows.Forms.Button btCazeazaAcum;
        private System.Windows.Forms.Button btCazeaza;
        private System.Windows.Forms.ListBox lbxRezervari;
        private System.Windows.Forms.DateTimePicker dtpSelectData;
        private System.Windows.Forms.Label lblSelectData;
        private System.Windows.Forms.Button btSelectData;
        private System.Windows.Forms.Label lblRezervare;
        private System.Windows.Forms.TextBox txtRezervare;
        private System.Windows.Forms.Button btAltaData;
        private System.Windows.Forms.Button button1;
    }
}