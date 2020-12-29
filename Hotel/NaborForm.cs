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
    public partial class NaborForm : Form
    {
        static string id;
        static bool ok = false;
        public NaborForm()
        {
            InitializeComponent();
            LoadDataToRoom();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void LoadDataToRoom()
        {
            List<string[]> data = new List<string[]>();
            DB db = new DB();
            data = db.LoadDataToNobori();
            foreach (string[] s in data)
                this.Nabori.Rows.Add(s);
        }

        private void Nabori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;// get the Row Index
            DataGridViewRow selectedRow = Nabori.Rows[index];
            id = selectedRow.Cells[0].Value.ToString();
        }
        static public string naborchik()
        {
            return id;
        }
        static public bool okay()
        {
            return ok;
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }
    }
}

