namespace ProiectLicitatii
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.candidatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new ProiectLicitatii.AppData();
            this.tb_prenume = new System.Windows.Forms.TextBox();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.btn_adauga = new System.Windows.Forms.Button();
            this.cb_gen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_modifica = new System.Windows.Forms.Button();
            this.btn_sterge = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btn_next = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.candidatTableAdapter = new ProiectLicitatii.AppDataTableAdapters.CandidatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Violet;
            this.label1.Location = new System.Drawing.Point(396, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "LICITAȚII ONLINE BIJUTERII DE COLECȚIE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Număr de telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Adresă";
            // 
            // tb_nume
            // 
            this.tb_nume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatBindingSource, "Nume", true));
            this.tb_nume.Location = new System.Drawing.Point(249, 156);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(203, 26);
            this.tb_nume.TabIndex = 6;
            this.tb_nume.TextChanged += new System.EventHandler(this.numeValidate);
            // 
            // candidatBindingSource
            // 
            this.candidatBindingSource.DataMember = "Candidat";
            this.candidatBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_prenume
            // 
            this.tb_prenume.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatBindingSource, "Prenume", true));
            this.tb_prenume.Location = new System.Drawing.Point(249, 212);
            this.tb_prenume.Name = "tb_prenume";
            this.tb_prenume.Size = new System.Drawing.Size(203, 26);
            this.tb_prenume.TabIndex = 7;
            this.tb_prenume.TextChanged += new System.EventHandler(this.PrenumeValidate);
            // 
            // tb_telefon
            // 
            this.tb_telefon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatBindingSource, "NumarTelefon", true));
            this.tb_telefon.Location = new System.Drawing.Point(249, 261);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(203, 26);
            this.tb_telefon.TabIndex = 8;
            this.tb_telefon.TextChanged += new System.EventHandler(this.TelefonValidate);
            this.tb_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numarTelefon_keyPress);
            // 
            // tb_adresa
            // 
            this.tb_adresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatBindingSource, "Adresa", true));
            this.tb_adresa.Location = new System.Drawing.Point(249, 312);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(203, 26);
            this.tb_adresa.TabIndex = 9;
            this.tb_adresa.TextChanged += new System.EventHandler(this.AdresaValidate);
            this.tb_adresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adresa_KeyPress);
            // 
            // btn_adauga
            // 
            this.btn_adauga.BackColor = System.Drawing.Color.Plum;
            this.btn_adauga.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adauga.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_adauga.Location = new System.Drawing.Point(43, 505);
            this.btn_adauga.Name = "btn_adauga";
            this.btn_adauga.Size = new System.Drawing.Size(307, 73);
            this.btn_adauga.TabIndex = 10;
            this.btn_adauga.Text = "Adaugă candidat";
            this.btn_adauga.UseVisualStyleBackColor = false;
            this.btn_adauga.Click += new System.EventHandler(this.btn_adauga_Click);
            // 
            // cb_gen
            // 
            this.cb_gen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatBindingSource, "Gen", true));
            this.cb_gen.FormattingEnabled = true;
            this.cb_gen.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cb_gen.Location = new System.Drawing.Point(249, 371);
            this.cb_gen.Name = "cb_gen";
            this.cb_gen.Size = new System.Drawing.Size(203, 28);
            this.cb_gen.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gen";
            // 
            // btn_modifica
            // 
            this.btn_modifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_modifica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modifica.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_modifica.Location = new System.Drawing.Point(435, 509);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(213, 65);
            this.btn_modifica.TabIndex = 16;
            this.btn_modifica.Text = "Modifică";
            this.btn_modifica.UseVisualStyleBackColor = false;
            this.btn_modifica.Click += new System.EventHandler(this.btn_modifica_Click);
            // 
            // btn_sterge
            // 
            this.btn_sterge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_sterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sterge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sterge.ForeColor = System.Drawing.Color.DarkViolet;
            this.btn_sterge.Location = new System.Drawing.Point(766, 509);
            this.btn_sterge.Name = "btn_sterge";
            this.btn_sterge.Size = new System.Drawing.Size(215, 65);
            this.btn_sterge.TabIndex = 17;
            this.btn_sterge.Text = "Șterge";
            this.btn_sterge.UseVisualStyleBackColor = false;
            this.btn_sterge.Click += new System.EventHandler(this.btn_sterge_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(475, 135);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowTemplate.Height = 28;
            this.dataGrid1.Size = new System.Drawing.Size(869, 329);
            this.dataGrid1.TabIndex = 18;
            this.dataGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid1_MouseClick);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.Blue;
            this.btn_next.Location = new System.Drawing.Point(1066, 509);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(253, 69);
            this.btn_next.TabIndex = 21;
            this.btn_next.Text = "INAINTE";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // candidatTableAdapter
            // 
            this.candidatTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 646);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btn_sterge);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_gen);
            this.Controls.Add(this.btn_adauga);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.tb_prenume);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nume;
        private System.Windows.Forms.TextBox tb_prenume;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.Button btn_adauga;
        private System.Windows.Forms.ComboBox cb_gen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_modifica;
        private System.Windows.Forms.Button btn_sterge;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private AppData appData;
        private System.Windows.Forms.BindingSource candidatBindingSource;
        private AppDataTableAdapters.CandidatTableAdapter candidatTableAdapter;
    }
}

