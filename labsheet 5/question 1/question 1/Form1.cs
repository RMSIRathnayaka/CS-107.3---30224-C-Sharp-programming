using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace question_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butsignup_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != txtcompass.Text)
            {
                MessageBox.Show("Password is not matching");
            }
            if(string.IsNullOrWhiteSpace(txtfirstname.Text)||
                string.IsNullOrWhiteSpace(txtlastname.Text)||
                string.IsNullOrWhiteSpace(txtdob.Text)||
                string.IsNullOrWhiteSpace(txtemail.Text)||
                string.IsNullOrWhiteSpace(txtusername.Text)||
                string.IsNullOrWhiteSpace(txtpassword.Text)||
                string.IsNullOrWhiteSpace(txtcompass.Text)) 
            {
                MessageBox.Show("Empty field");
            }
            if (!IsString(txtfirstname.Text)||
                !IsString(txtlastname.Text) ||
                !IsString(txtdob.Text) ||
                !IsString(txtemail.Text) ||
                !IsString(txtusername.Text) ||
                !IsString(txtpassword.Text) ||
                !IsString(txtcompass.Text))
            {
                MessageBox.Show("Enter Valid Letter");
            }

            Form2 form2 = new Form2($"{txtfirstname.Text}" +$"{txtlastname.Text}", txtusername.Text, txtemail.Text);

            form2.Show();
            this.Hide();
        }
        private bool IsString(string text)
        {
            return text.All(char.IsLetter);
        }
    }
}
