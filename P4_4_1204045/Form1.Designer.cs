
namespace P4_4_1204045
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.hp = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.TextBox();
            this.warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.wrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.correct = new System.Windows.Forms.ErrorProvider(this.components);
            this.jeniskelamin = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.RadioButton();
            this.w = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.namab = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.poli = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrasi Pendaftaran Klinik X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama  Depan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Umur              :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nomor HP      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tinggi Badan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Berat Badan   :";
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(243, 119);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(100, 20);
            this.nama.TabIndex = 6;
            this.nama.Leave += new System.EventHandler(this.nama_Leave);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(243, 163);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(29, 20);
            this.age.TabIndex = 7;
            this.age.Leave += new System.EventHandler(this.age_Leave);
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(243, 206);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(100, 20);
            this.hp.TabIndex = 8;
            this.hp.Leave += new System.EventHandler(this.hp_Leave);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(244, 250);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(36, 20);
            this.tb.TabIndex = 9;
            this.tb.Leave += new System.EventHandler(this.tb_Leave);
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(244, 295);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(36, 20);
            this.bb.TabIndex = 10;
            this.bb.Leave += new System.EventHandler(this.bb_Leave);
            // 
            // warning
            // 
            this.warning.ContainerControl = this;
            this.warning.Icon = ((System.Drawing.Icon)(resources.GetObject("warning.Icon")));
            // 
            // wrong
            // 
            this.wrong.ContainerControl = this;
            this.wrong.Icon = ((System.Drawing.Icon)(resources.GetObject("wrong.Icon")));
            // 
            // correct
            // 
            this.correct.ContainerControl = this;
            this.correct.Icon = ((System.Drawing.Icon)(resources.GetObject("correct.Icon")));
            // 
            // jeniskelamin
            // 
            this.jeniskelamin.AutoSize = true;
            this.jeniskelamin.Location = new System.Drawing.Point(166, 336);
            this.jeniskelamin.Name = "jeniskelamin";
            this.jeniskelamin.Size = new System.Drawing.Size(80, 13);
            this.jeniskelamin.TabIndex = 11;
            this.jeniskelamin.Text = "Jenis Kelamin  :";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(253, 334);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(43, 17);
            this.p.TabIndex = 12;
            this.p.TabStop = true;
            this.p.Text = "Pria";
            this.p.UseVisualStyleBackColor = true;
            this.p.CheckedChanged += new System.EventHandler(this.p_CheckedChanged);
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(315, 334);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(59, 17);
            this.w.TabIndex = 13;
            this.w.TabStop = true;
            this.w.Text = "Wanita";
            this.w.UseVisualStyleBackColor = true;
            this.w.CheckedChanged += new System.EventHandler(this.w_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(315, 415);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 14;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nama Belakang :";
            // 
            // namab
            // 
            this.namab.Location = new System.Drawing.Point(464, 119);
            this.namab.Name = "namab";
            this.namab.Size = new System.Drawing.Size(100, 20);
            this.namab.TabIndex = 16;
            this.namab.Leave += new System.EventHandler(this.namab_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Pilih Poli          :";
            // 
            // poli
            // 
            this.poli.FormattingEnabled = true;
            this.poli.Items.AddRange(new object[] {
            "Poli Umum",
            "Poli Gigi"});
            this.poli.Location = new System.Drawing.Point(244, 369);
            this.poli.Name = "poli";
            this.poli.Size = new System.Drawing.Size(121, 21);
            this.poli.TabIndex = 18;
            this.poli.SelectedIndexChanged += new System.EventHandler(this.poli_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 489);
            this.Controls.Add(this.poli);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.namab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.w);
            this.Controls.Add(this.p);
            this.Controls.Add(this.jeniskelamin);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.age);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Registrasi Pendaftaran Klinik X";
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correct)).EndInit();
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
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox hp;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.ErrorProvider warning;
        private System.Windows.Forms.ErrorProvider wrong;
        private System.Windows.Forms.ErrorProvider correct;
        private System.Windows.Forms.Label jeniskelamin;
        private System.Windows.Forms.RadioButton w;
        private System.Windows.Forms.RadioButton p;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox namab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox poli;
        private System.Windows.Forms.Label label8;
    }
}

