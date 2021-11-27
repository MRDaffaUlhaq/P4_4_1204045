using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_4_1204045
{
    public partial class Form1 : Form
    {
        string jk = "";
      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void nama_Leave(object sender, EventArgs e)
        {
            
            if (nama.Text == "")
            {
                warning.SetError(nama, "Harap masukkan nama depan!");
                wrong.SetError(nama, "");
                correct.SetError(nama, "");
            }
            else if(nama.Text != nama.Text.ToUpper())
            {
                warning.SetError(nama, "");
                wrong.SetError(nama, "Masukkan nama depan menggunakan huruf kapital!");
                correct.SetError(nama, "");
            }
            else if(nama.Text.Length == 1)
            {
                warning.SetError(nama, "Harap masukkan nama depan dengan benar!");
                wrong.SetError(nama, "");
                correct.SetError(nama, "");
            }
            
            else
            {
                if ((nama.Text).All(Char.IsLetter))
                {
                
                    warning.SetError(nama, "");
                    wrong.SetError(nama, "");
                    correct.SetError(nama, "SIP MANTAP!");
                }
                else
                {
                    warning.SetError(nama, "");
                    wrong.SetError(nama, "Ups, masukkan nama dengan huruf!");
                    correct.SetError(nama, "");
                }
            }

        }
    

        private void age_Leave(object sender, EventArgs e)
        {
            if (age.Text == "")
            { 
                warning.SetError(age, "Harap masukkan umur!");
                wrong.SetError(age, "");
                correct.SetError(age, "");
            }else if (age.Text.Length > 2)
            {
                warning.SetError(age, "Ups, harap masukkan umur dengan benar!");
                wrong.SetError(age, "");
                correct.SetError(age, "");
            }
            else
            {
                if ((age.Text).All(Char.IsNumber))
                {
                    warning.SetError(age, "");
                    wrong.SetError(age, "");
                    correct.SetError(age, "SIP MANTAP!");
                }
                else
                {
                    warning.SetError(age, "");
                    wrong.SetError(age, "Ups, masukkan umur dengan angka!");
                    correct.SetError(age, "");
                }
            }
        }

        private void hp_Leave(object sender, EventArgs e)
        {
            if (hp.Text == "")
            {
                warning.SetError(hp, "Harap masukkan nomor hp!");
                wrong.SetError(hp, "");
                correct.SetError(hp, "");
            }
            else if (hp.Text.Length > 15 && hp.Text.Length > 1)
            {
                warning.SetError(hp, "Ups, masukkan nomor dengan benar!");
                wrong.SetError(hp, "");
                correct.SetError(hp, "");
            }
            else
            {
                if (Regex.IsMatch(hp.Text, @"62[8][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"))
                {
                    warning.SetError(hp, "");
                    wrong.SetError(hp, "");
                    correct.SetError(hp, "SIP MANTAP!");
                }
                else
                {
                    warning.SetError(hp, "");
                    wrong.SetError(hp, "Ups, masukkan nomor dengan angka dan sesuai format! Contoh : 62853****3456");
                    correct.SetError(hp, "");
                }
            }
        }

        private void tb_Leave(object sender, EventArgs e)
        {
            if (tb.Text == "")
            {
                warning.SetError(tb, "Harap masukkan tinggi badan !");
                wrong.SetError(tb, "");
                correct.SetError(tb, "");
                
            }
            else if ((tb.Text).All(Char.IsNumber) && tb.Text.Length == 3 && (int.Parse(bb.Text) < int.Parse(tb.Text)))
            {
                warning.SetError(tb, "");
                wrong.SetError(tb, "");
                correct.SetError(tb, "SIP MANTAP!");
            }
            else if(tb.Text.Length > 3)
            {
                warning.SetError(tb, "Ups, harap masukkan tinggi badan dengan benar!");
                wrong.SetError(tb, "");
                correct.SetError(tb, "");
            }
            else if(tb.Text != "")
            {
                if ((int.Parse(bb.Text) > int.Parse(tb.Text)))
                {
                    warning.SetError(tb, "Ups, masa berat badannya lebih besar dari tinggi badan sih WKWKWK");
                    wrong.SetError(tb, "");
                    correct.SetError(tb, "");
                }
                else { }
            }
            else
            {
                
            }
        }

        private void bb_Leave(object sender, EventArgs e)
        {
            if(bb.Text == "")
            {
                warning.SetError(bb, "Harap masukkan berat badan !");
                wrong.SetError(bb, "");
                correct.SetError(bb, "");
            }
            else if ((bb.Text).All(Char.IsNumber) && bb.Text.Length == 2 && (int.Parse(bb.Text) < int.Parse(tb.Text)))
            {
                warning.SetError(bb, "");
                wrong.SetError(bb, "");
                correct.SetError(bb, "SIP MANTAP!");
            }
            else if (bb.Text.Length > 2)
            {
                warning.SetError(bb, "");
                wrong.SetError(bb, "Gila berat banget WKWKWKWK!");
                correct.SetError(bb, "");
            }
            else if((int.Parse(bb.Text) > int.Parse(tb.Text)))
            {
             
                warning.SetError(bb, "Ups, masa berat badannya lebih besar dari tinggi badan sih WKWKWK");
                wrong.SetError(bb, "");
                correct.SetError(bb, "");

            }
            else
            {
                
            }
            
        }

        private void namab_Leave(object sender, EventArgs e)
        {
            if (namab.Text == "")
            {
                warning.SetError(namab, "Harap masukkan nama belakang!");
                wrong.SetError(namab, "");
                correct.SetError(namab, "");
            }
            else if (namab.Text != namab.Text.ToLower())
            {
                warning.SetError(namab, "");
                wrong.SetError(namab, "Masukkan nama belakang menggunakan huruf kecil!");
                correct.SetError(namab, "");
            }
            else if (namab.Text.Length == 1)
            {
                warning.SetError(namab, "Harap masukkan nama belakang dengan benar!");
                wrong.SetError(namab, "");
                correct.SetError(namab, "");
            }

            else
            {
                if ((namab.Text).All(Char.IsLetter))
                {

                    warning.SetError(namab, "");
                    wrong.SetError(namab, "");
                    correct.SetError(namab, "SIP MANTAP!");
                }
                else
                {
                    warning.SetError(namab, "");
                    wrong.SetError(namab, "Ups, masukkan nama dengan huruf!");
                    correct.SetError(namab, "");
                }
            }
        }

        private void p_CheckedChanged(object sender, EventArgs e)
        {
            jk = " Pria";
        }

        private void w_CheckedChanged(object sender, EventArgs e)
        {
            jk = " Wanita";
        }

        private void poli_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            ("Nama Pasien : " + nama.Text + " " + namab.Text +
            "\nUmur : " + age.Text + " Tahun" +
            "\nNomor HP : " + hp.Text +
            "\nTinggi Badan : " + tb.Text + " Kg" +
            "\nBerat Badan : " + bb.Text + " Cm" +
            "\nJenis Kelamin :" + jk +
            "\nPoli : " + poli.Text,
            "Informasi Pendaftaran",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
