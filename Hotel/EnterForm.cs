using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Hotel
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }
 
        Thread y;
        private void Login_textBox_Enter(object sender, EventArgs e)
        {
        }

        private void Login_textBox_Leave(object sender, EventArgs e)
        {
        }

        private void Password_textBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void Password_textBox_Leave(object sender, EventArgs e)
        {
          
        }


        private void EnterBtn_Click_1(object sender, EventArgs e)
        {
            DB db = new DB();
            if (Login.Text == "" || Password.Text == "")
                MessageBox.Show("Заполните все поля");
            
            
            else if (db.CheckLogin(Login.Text, Password.Text))
            {
                MessageBox.Show("Нет такого пользователя!");

            }
            else 
            {
            MainPage dlg = new MainPage();
            this.Close();
            y = new Thread(open);
            y.SetApartmentState(ApartmentState.STA);
            y.Start();
        }

        }
        public void open(object obj)
        {
            Application.Run(new MainPage());
        }
   

    }

}
