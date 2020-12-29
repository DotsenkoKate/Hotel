using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class EditGuest : Form
    {    
        
        static string name;
        static string phone;
        static string date;
        static string privilegii;
        static string privious;
        static string passport;
        public EditGuest()
        {
            InitializeComponent();
            

        }
        static public string[] Edit()
        {
            string[] guest = { name, date, passport, privious, privilegii, phone };
            return guest;

        }

        //Получение данных с элементов формы
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            name = NameBox.Text;

        }
        private void PassportBox_TextChanged(object sender, EventArgs e)
        {
            passport = PassportBox.Text;

        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker.Text;

        }
        private void phoneBox_TextChanged(object sender, EventArgs e)
        {
            phone = phoneBox.Text;

        }
        private void PrivilegiiBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            privilegii = PrivilegiiBox.SelectedItem.ToString();

        }
        private void PriviousBox_TextChanged(object sender, EventArgs e)
        {
            privious = PriviousBox.Text;

        }

        //Обработка нажатия на кнопку
        private void EditBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.editGuest();
            this.Close();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Заполнение элементов формы данными из выбранной строки грида
        private void EditGuest_Load(object sender, EventArgs e)
        {
            string[] guest1 = MainPage.GuestGridInfo();
            NameBox.Text = guest1[1];
            dateTimePicker.Value = Convert.ToDateTime(guest1[2]);
            PassportBox.Text = guest1[3];
            PriviousBox.Text = guest1[4];
            PrivilegiiBox.Text = guest1[5];
            phoneBox.Text = guest1[6];
        }

        private void PassportBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number != ' ' ) && (number != '\b'))
                e.Handled = true;
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number != '\b'))
                e.Handled = true;
        }

        private void PriviousBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number != '\b') && (number != ' ') && (number != '.') && (number != ','))
                e.Handled = true;
        }

        private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number < 'А' || number > 'я') && (number != '\b') && (number != ' ') && (number < 'A' || number > 'z'))
                e.Handled = true;
        }
    }
}
