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
    public partial class RoomForm : Form
    {
        static string num;
        static string raiting;
        static string price;
        static string state;
        static string nabor;

        public RoomForm()
        {
            InitializeComponent();
        }
       static public string[] Create()
        {
            string[] room = {num, state, price, raiting, nabor};
            return room;

        }
        //Получение данных с элементов
        private void NumBox_TextChanged(object sender, EventArgs e)
        {
            num = NumBox.Text;
        }
        private void StateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            state = StateBox.SelectedItem.ToString();
        }
        private void NaborBox_TextChanged(object sender, EventArgs e)
        {
            nabor = NaborBox.Text;
        }
        private void RaitingBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            raiting = RaitingBox.SelectedItem.ToString();
        }
        private void PriceBox_ValueChanged(object sender, EventArgs e)
        {
            price = PriceBox.Value.ToString();
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.createRoom();
            this.Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


        //Открытие формы списка наборов особенностей
        private void Pbtn_Click(object sender, EventArgs e)
        {
            NaborForm naborform = new NaborForm();
            naborform.Show();
           

        }
        private void Pbtn_MouseMove(object sender, MouseEventArgs e)
        {
            string id = NaborForm.naborchik();
            bool ok = NaborForm.okay();
            if (ok == true)
            {
                NaborBox.Text = id;
            }
        }

        private void NumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number != '\b'))
                e.Handled = true;
        }
    }
}
