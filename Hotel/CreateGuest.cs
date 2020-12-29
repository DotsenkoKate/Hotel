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
    public partial class CreateGuest : Form
    {
        static string name;
        static string phone;
        static string date;
        static string privilegii;
        static string privious;
        static string passport;
        public CreateGuest()
        {
            InitializeComponent();
        }
        static public string[] Create()
        {
            string[] guest = { name, date, passport,  privious, privilegii,phone };
            return  guest;

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

            date =dateTimePicker.Text;
            
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
        //Обработка нажатия на кнопки
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CreateGuestBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.createGuest();
            this.Close();
        }

        private void PassportBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number != ' ') && (number != '\b'))
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
