using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel
{
    
    public partial class MainPage : Form
    {
        static String iddel;
        static string num;
        static string raiting;
        static string price;
        static string state;
        static string nabor;
        static string nameGuest;
        static string phone;
        static string date;
        static string privilegii;
        static string privious;
        static string passport;
        string statistic;
        public MainPage()
        {
            InitializeComponent();
            dataGridView1.Hide();
            dataGridView2.Hide();
            AddBtn.Hide();
            DeleteBtn.Hide();
            ChangeBtn.Hide();
            label1.Hide();
            StatisticBox.Hide();
            ShowBtn.Hide();


        }
        //Загрузка данных из БД
        private void LoadDataToGuest()
        {
            List<string[]> data = new List<string[]>();
            DB db = new DB();
            data = db.LoadDataToGuest();
            foreach (string[] s in data)
                this.dataGridView1.Rows.Add(s);
        }
        private void LoadDataToRoom()
        {
            List<string[]> data = new List<string[]>();
            DB db = new DB();
            data = db.LoadDataToRoom();
            foreach (string[] s in data)
                this.dataGridView2.Rows.Add(s);
        }

        private void LoadRaiting()
        {
            List<string[]> data = new List<string[]>();
            DB db = new DB();
            data = db.LoadRaiting();
            foreach (string[] s in data)
                this.dataGridView2.Rows.Add(s);
        }

        //Обработка нажатия на кнопки
        private void AddBtn_Click(object sender, EventArgs e)
        {
            CreateGuest CreateGuestForm = new CreateGuest();
            RoomForm CreateRoomForm = new RoomForm();

            if (dataGridView1.Visible)
               
                CreateGuestForm.Show();

            if (dataGridView2.Visible)
                CreateRoomForm.Show();


        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (MessageBox.Show("Вы действительно хотите удалить запись?" +
                " Это действие нельзя будет отменить", "Удаление записи", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (dataGridView1.Visible)
                    db.deleteUser();

                if (dataGridView2.Visible)
                    db.deleteRoom();
            }
            refresh_method();
        }
        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            refresh_method();
            EditGuest EditGuestForm = new EditGuest();
            EditRoom EditRoomForm = new EditRoom();

            if (dataGridView1.Visible)
                EditGuestForm.Show();

            if (dataGridView2.Visible)
                EditRoomForm.Show();
        }


        //Обработка нажатия на вкладки сверху
        private void Guest_Click(object sender, EventArgs e)
        {
            refresh_method();
           
            dataGridView1.Show();
            dataGridView2.Hide();
            AddBtn.Show();
            DeleteBtn.Show();
            ChangeBtn.Show();
            label1.Hide();
            StatisticBox.Hide();
            ShowBtn.Hide();

        }
        private void rooms_Click(object sender, EventArgs e)
        {
            refresh_method();
            dataGridView1.Hide();
            dataGridView2.Show();
            AddBtn.Show();
            DeleteBtn.Show();
            ChangeBtn.Show();
            label1.Show();
            StatisticBox.Show();
            ShowBtn.Show();
            


        }
        private void HideBtn_Click(object sender, EventArgs e)
        {
            refresh_method();
            dataGridView1.Hide();
            dataGridView2.Hide();
            AddBtn.Hide();
            DeleteBtn.Hide();
            ChangeBtn.Hide();
            label1.Hide();
            StatisticBox.Hide();
            ShowBtn.Hide();
        }

       //Получение данных из выбранной таблички
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            iddel = selectedRow.Cells[0].Value.ToString();
            num = selectedRow.Cells[0].Value.ToString();
            state = selectedRow.Cells[1].Value.ToString();
            price = selectedRow.Cells[2].Value.ToString();
            raiting = selectedRow.Cells[3].Value.ToString();
            nabor = selectedRow.Cells[4].Value.ToString();
           


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            iddel = selectedRow.Cells[0].Value.ToString();
            nameGuest = selectedRow.Cells[1].Value.ToString();
            date = selectedRow.Cells[2].Value.ToString();
            passport = selectedRow.Cells[3].Value.ToString();
            privious = selectedRow.Cells[4].Value.ToString();
            privilegii = selectedRow.Cells[5].Value.ToString();
            phone = selectedRow.Cells[6].Value.ToString();
        }
        //Обновление всей формы
        public void refresh_method()
        {

            dataGridView1.Rows.Clear();
            LoadDataToGuest();
            dataGridView2.Rows.Clear();
            LoadDataToRoom();

        }
        //Получение id текущего выбранного элемента из таблицы
        static public String currentrow()
        {
            return iddel;
        }
       // Получение информации с таблиц для заполнения форм редактирования
        static public string[] RoomGridInfo()
        {
            string[] room = { num, state, price, raiting, nabor };
            return room;

        }
        static public string[] GuestGridInfo()
        {
            string[] guest = { iddel , nameGuest, date, passport, privious, privilegii, phone };
            return guest;

        }
        //Обновление при активации формы
        private void MainPage_Activated(object sender, EventArgs e)
        {
            refresh_method();
        }

        private void StatisticBox_SelectedIndexChanged(object sender, EventArgs e)
        {

             statistic= StatisticBox.SelectedItem.ToString();
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            if (statistic == "Самый востребованный номер")
            {
                String data;
                DB db = new DB();
                data = db.PopularRoom();
                MessageBox.Show(statistic+ ": "+ data);
            }
            if (statistic == "Рейтинг номеров")
            {
                dataGridView2.Rows.Clear();
                LoadRaiting();
            }
            if (statistic == "Стоимость проживания")
            {
                PriceForm PriceForm = new PriceForm();
                PriceForm.Show();
            }

        }
    }
}