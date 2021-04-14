namespace Inlämningsuppgift1
{
    partial class frmAdressboken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdressboken));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtGatudress = new System.Windows.Forms.TextBox();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.txtPostOrt = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEpost = new System.Windows.Forms.TextBox();
            this.cmdRegistera = new System.Windows.Forms.Button();
            this.cmdTabort = new System.Windows.Forms.Button();
            this.cmdUppdateraNyAdress = new System.Windows.Forms.Button();
            this.txtSokning = new System.Windows.Forms.TextBox();
            this.cmdSokning = new System.Windows.Forms.Button();
            this.lsbSoka = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBringOldRow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gatudress: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postnummer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Post ort: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-post: ";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(183, 75);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(170, 27);
            this.txtNamn.TabIndex = 6;
            // 
            // txtGatudress
            // 
            this.txtGatudress.Location = new System.Drawing.Point(183, 135);
            this.txtGatudress.Name = "txtGatudress";
            this.txtGatudress.Size = new System.Drawing.Size(170, 27);
            this.txtGatudress.TabIndex = 7;
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Location = new System.Drawing.Point(183, 195);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(170, 27);
            this.txtPostnummer.TabIndex = 8;
            this.txtPostnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostnummer_KeyPress);
            // 
            // txtPostOrt
            // 
            this.txtPostOrt.Location = new System.Drawing.Point(183, 255);
            this.txtPostOrt.Name = "txtPostOrt";
            this.txtPostOrt.Size = new System.Drawing.Size(170, 27);
            this.txtPostOrt.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(183, 315);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(170, 27);
            this.txtTelefon.TabIndex = 10;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtEpost
            // 
            this.txtEpost.Location = new System.Drawing.Point(184, 369);
            this.txtEpost.Name = "txtEpost";
            this.txtEpost.Size = new System.Drawing.Size(170, 27);
            this.txtEpost.TabIndex = 11;
            // 
            // cmdRegistera
            // 
            this.cmdRegistera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdRegistera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegistera.Location = new System.Drawing.Point(72, 461);
            this.cmdRegistera.Name = "cmdRegistera";
            this.cmdRegistera.Size = new System.Drawing.Size(88, 57);
            this.cmdRegistera.TabIndex = 12;
            this.cmdRegistera.Text = "Registera";
            this.cmdRegistera.UseVisualStyleBackColor = false;
            this.cmdRegistera.Click += new System.EventHandler(this.cmdRegistera_Click);
            // 
            // cmdTabort
            // 
            this.cmdTabort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdTabort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdTabort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTabort.Location = new System.Drawing.Point(183, 461);
            this.cmdTabort.Name = "cmdTabort";
            this.cmdTabort.Size = new System.Drawing.Size(88, 57);
            this.cmdTabort.TabIndex = 13;
            this.cmdTabort.Text = "Tabort";
            this.cmdTabort.UseVisualStyleBackColor = false;
            this.cmdTabort.Click += new System.EventHandler(this.cmdTabort_Click);
            // 
            // cmdUppdateraNyAdress
            // 
            this.cmdUppdateraNyAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdUppdateraNyAdress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdUppdateraNyAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUppdateraNyAdress.Location = new System.Drawing.Point(294, 461);
            this.cmdUppdateraNyAdress.Name = "cmdUppdateraNyAdress";
            this.cmdUppdateraNyAdress.Size = new System.Drawing.Size(88, 57);
            this.cmdUppdateraNyAdress.TabIndex = 15;
            this.cmdUppdateraNyAdress.Text = "Uppdatera";
            this.cmdUppdateraNyAdress.UseVisualStyleBackColor = false;
            this.cmdUppdateraNyAdress.Click += new System.EventHandler(this.cmdUppdateraNyAdress_Click);
            // 
            // txtSokning
            // 
            this.txtSokning.Location = new System.Drawing.Point(34, 42);
            this.txtSokning.Name = "txtSokning";
            this.txtSokning.Size = new System.Drawing.Size(339, 27);
            this.txtSokning.TabIndex = 17;
            // 
            // cmdSokning
            // 
            this.cmdSokning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdSokning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSokning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSokning.Image = global::Inlämningsuppgift1.Properties.Resources.searchPic1;
            this.cmdSokning.Location = new System.Drawing.Point(379, 36);
            this.cmdSokning.Name = "cmdSokning";
            this.cmdSokning.Size = new System.Drawing.Size(34, 36);
            this.cmdSokning.TabIndex = 18;
            this.cmdSokning.UseVisualStyleBackColor = false;
            this.cmdSokning.Click += new System.EventHandler(this.cmdSokning_Click);
            // 
            // lsbSoka
            // 
            this.lsbSoka.FormattingEnabled = true;
            this.lsbSoka.ItemHeight = 19;
            this.lsbSoka.Location = new System.Drawing.Point(7, 78);
            this.lsbSoka.Name = "lsbSoka";
            this.lsbSoka.Size = new System.Drawing.Size(570, 403);
            this.lsbSoka.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBringOldRow);
            this.groupBox1.Controls.Add(this.txtSokning);
            this.groupBox1.Controls.Add(this.cmdSokning);
            this.groupBox1.Controls.Add(this.lsbSoka);
            this.groupBox1.Location = new System.Drawing.Point(483, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 503);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Söka på adress, namn eller post ort: ";
            // 
            // cmdBringOldRow
            // 
            this.cmdBringOldRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdBringOldRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdBringOldRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBringOldRow.Location = new System.Drawing.Point(419, 38);
            this.cmdBringOldRow.Name = "cmdBringOldRow";
            this.cmdBringOldRow.Size = new System.Drawing.Size(158, 35);
            this.cmdBringOldRow.TabIndex = 29;
            this.cmdBringOldRow.Text = "Hämta för ändringar";
            this.cmdBringOldRow.UseVisualStyleBackColor = false;
            this.cmdBringOldRow.Click += new System.EventHandler(this.cmdBringOldRow_Click);
            // 
            // frmAdressboken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1078, 619);
            this.Controls.Add(this.cmdUppdateraNyAdress);
            this.Controls.Add(this.cmdTabort);
            this.Controls.Add(this.cmdRegistera);
            this.Controls.Add(this.txtEpost);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtPostOrt);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.txtGatudress);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdressboken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adressboken";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtGatudress;
        private System.Windows.Forms.TextBox txtPostnummer;
        private System.Windows.Forms.TextBox txtPostOrt;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEpost;
        private System.Windows.Forms.Button cmdRegistera;
        private System.Windows.Forms.Button cmdTabort;
        private System.Windows.Forms.Button cmdUppdateraNyAdress;
        private System.Windows.Forms.TextBox txtSokning;
        private System.Windows.Forms.Button cmdSokning;
        private System.Windows.Forms.ListBox lsbSoka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBringOldRow;
    }
}

