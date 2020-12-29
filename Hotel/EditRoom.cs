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
    public partial class EditRoom : Form
    {
        static string num;
        static string raiting;
        static string price;
        static string state;
        static string nabor;

        public EditRoom()
        {
            InitializeComponent();
           

        }

        static public string[] Edit()
        {
            string[] room = { num, state, price, raiting, nabor };
            return room;

        }
        //Получение данных с элементов формы
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
        //Обработка кнопок
        private void EditBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.editRoom();
            this.Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
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

        //Заполнение формы уже имеющимися данными
        private void EditRoom_Load(object sender, EventArgs e)
        {
            string[] room = MainPage.RoomGridInfo();
            NumBox.Text = room[0];
            StateBox.SelectedItem = room[1];
            PriceBox.Value = Convert.ToDecimal(room[2]);
            RaitingBox.SelectedItem = room[3];
            NaborBox.Text = room[4];

        }

        private void RaitingBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
                e.Handled = true;
        }
    }
}
