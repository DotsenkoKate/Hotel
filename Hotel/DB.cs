using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace Hotel
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=4815162342;database=hotel_db");

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
     
        //Проверка на входе в программу 
        public bool CheckLogin(string login, string password)
        {
            bool result = true;
            if (login == "admin" && password == "admin")
                result = false;
            return result;
        }
        //Загрузка данных из БД
        public List<string[]> LoadDataToGuest()
        {
            openConnection();

            string query = "SELECT * FROM гость ";

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }

            reader.Close();
            closeConnection();

            return data;
        }
        public List<string[]> LoadDataToRoom()
        {
            openConnection();

            string query2 = "SELECT `Номер`,`Состояние`,`Цена за ночь`,`Оценка номера`,`id_набора особенностей` FROM номер ";

            MySqlCommand command = new MySqlCommand(query2, connection);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();

            }

            reader.Close();
            closeConnection();

            return data;

        }
        public List<string[]> LoadDataToNobori()
        {
            openConnection();
            
            string query = "SELECT * FROM `набор особенностей` ";

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[9]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();


            }

            reader.Close();
            closeConnection();

            return data;

        }
        public List<string[]> LoadRaiting()
        {
            openConnection();

            string query2 = "SELECT * FROM `номер` WHERE `Оценка номера` ORDER BY `Оценка номера`DESC";

            MySqlCommand command = new MySqlCommand(query2, connection);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();

            }

            reader.Close();
            closeConnection();

            return data;

        }


        //Удаление строки из БД
        public void deleteUser()
        {

            String id = MainPage.currentrow();

            string query11 = "DELETE FROM гость WHERE idГость =" + id;

            MySqlCommand command = new MySqlCommand(query11, connection);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                // Succesfully deleted
                connection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteRoom()
        {

            String id = MainPage.currentrow();


            string query2 = "DELETE FROM  номер WHERE Номер =" + id;
            MySqlCommand command = new MySqlCommand(query2, connection);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                // Succesfully deleted
                connection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
        //Создание строки в БД
        public void createGuest()
        {

            string[] guest = CreateGuest.Create();
            MessageBox.Show(guest[1].ToString());

            string query = "INSERT INTO гость (`ФИО`, `Дата рождения`, `Паспортные данные`, `Информация о прошлых заездах`," +
                "`Привилегии`, `Номер телефона`) VALUES ('" + guest[0] + "','" + guest[1] + "','" + guest[2] + "','" + guest[3] + "','" + guest[4] + "','" + guest[5] + "')";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                // Succesfully deleted
                connection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
        public void createRoom()
        {

            string[] room = RoomForm.Create();
           
           string query = "INSERT INTO номер (`Номер`,`Состояние`,`Цена за ночь`,`Оценка номера`,`id_набора особенностей`) VALUES ('" + room[0] + "','" + room[1] + "','" + room[2] + "','" + room[3] + "','" + room[4] + "')";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                // Succesfully deleted
                connection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
        //Редактирование строки в БД
        public void editRoom()
        {

            string[] room = EditRoom.Edit();
           
            string query = "UPDATE `номер` SET `Состояние` = '" + room[1] + "',`Цена за ночь` = '" + room[2] + "',`Оценка номера` = '" + room[3] + "',`id_набора особенностей` = '" + room[4] + "' WHERE(`Номер` = '" + room[0] + "')";
          
            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                // Succesfully deleted
                connection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
        public void editGuest()
        {
            String id = MainPage.currentrow();
            string[] guest = EditGuest.Edit();
            
            string query = "UPDATE `гость` SET `ФИО` = '" + guest[0] + "',`Дата рождения` = '" + guest[1] + "',`Паспортные данные` = '" + guest[2] + "',`Информация о прошлых заездах` = '" + guest[3] + "',`Привилегии` = '" + guest[4] + "',`Номер телефона` = '" + guest[5] + "' WHERE(`idГость` = '" + id + "')";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                // Succesfully deleted
                connection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
        // Аналитические запросы
        public String PopularRoom()
        {
            openConnection();

            string query = "SELECT `Номер` FROM `запись о заселении` GROUP BY `Номер` ORDER BY count(*) DESC LIMIT 1";

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            String data="";

            while (reader.Read())
            {
               
                data = reader[0].ToString();

            }

            reader.Close();
            closeConnection();
            return data;
        }
        public String PriceCurrentRoom()
        {
            openConnection();

            String id = PriceForm.num();

            string query = "SELECT `Цена за ночь` FROM `номер` WHERE Номер ="+id;

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            String data = "";

            while (reader.Read())
            {

                data = reader[0].ToString();

            }

            reader.Close();
            closeConnection();
            return data;
        }
        public List<string[]> ValidatorRoom()
        {
            openConnection();

            string query = "SELECT `Номер` FROM `номер`";

            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[1]);

                data[data.Count - 1][0] = reader[0].ToString();
            }

            reader.Close();
            closeConnection();

            return data;
        }

       
    }
}
