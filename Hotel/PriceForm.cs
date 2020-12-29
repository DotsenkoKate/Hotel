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
    public partial class PriceForm : Form
    {
        static string room;
        static int days;

        
        public PriceForm()
        {
            InitializeComponent();
        }

        private void RoomBox_TextChanged(object sender, EventArgs e)
        {
            room=RoomBox.Text.ToString();
        }

        private void DaysBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            days = Convert.ToInt32(DaysBox.Text.ToString());
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            List<string[]> data = new List<string[]>();
            bool isFound= false;
            data = db.ValidatorRoom();
            int count = data.Count;

            for (int i = 0; i < count; i++)
            {
                if (data[i][0].ToString() == room)
                {
                 
                    isFound = true;

                };
            }
            if ((RoomBox.Text.ToString() == "") || (DaysBox.Text.ToString()=="")) {

                MessageBox.Show("Ошибка! Заполните все поля!");
            }
            else 
                if (isFound == true)
            {
                int price = Convert.ToInt32(db.PriceCurrentRoom());
                string itog = Convert.ToString(price * days);
                MessageBox.Show("Стоимость проживания = " + itog);
            }
                 else  MessageBox.Show("Такого номера нет в базе ");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        static public String num()
        {
            return room;
        }

        private void RoomBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number != '\b'))
                e.Handled = true;
        }

        private void DaysBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
                e.Handled = true;
        }
    }
}
