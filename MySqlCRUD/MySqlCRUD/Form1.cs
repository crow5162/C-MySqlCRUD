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

namespace MySqlCRUD
{
    //CRUD 과제.
    // C : Create
    // R : Read
    // U : Update
    // D : Delete

    public partial class Form1 : Form
    {
        //MySql 서버와 연결할 ConnetingString
        //MySql과 정보를 교환하기 위해 서버에 접할수있게 하는 Key 입니다.
        string connectionString = @"Server=localhost;Database=crud_assignment;Uid=root;Pwd=Both7851@#";
        int userId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                //MySql 서버와 연결하고 파라메터를 업데이트 합니다.
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("NumberAddOrEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_userId", userId);
                mySqlCmd.Parameters.AddWithValue("_name", NameBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_phoneNumber", NumberBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_description", DescBox.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_group", GroupBox.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully");
                Clear();
                GridFill();
            }
        }

        void GridFill()
        {
            //DataGridView Box를 SqlData를 받아와서 채워줍니다.
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("NumberViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblNumber = new DataTable();
                sqlDa.Fill(dtblNumber);
                dgvPhoneNumber.DataSource = dtblNumber;
                dgvPhoneNumber.Columns[0].Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            //Input Box에 입력한 정보를 지워줍니다.
            NameBox.Text = NumberBox.Text = DescBox.Text = GroupBox.Text = "";
            userId = 0;
            btnSave.Text = "SAVE";
            btnDelete.Enabled = false;
        }

        private void dgvPhoneNumber_DoubleClick(object sender, EventArgs e)
        {
            //DataGridView에서 클릭한 데이터의 정보를 TextBox에 채워 주어 수정할 수있게 해줍니다.
            if(dgvPhoneNumber.CurrentRow.Index != -1)
            {
                NameBox.Text = dgvPhoneNumber.CurrentRow.Cells[1].Value.ToString();
                NumberBox.Text = dgvPhoneNumber.CurrentRow.Cells[2].Value.ToString();
                DescBox.Text = dgvPhoneNumber.CurrentRow.Cells[3].Value.ToString();
                GroupBox.Text = dgvPhoneNumber.CurrentRow.Cells[4].Value.ToString();
                userId = Convert.ToInt32(dgvPhoneNumber.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //MySql에서 저장한 DataAdapter(NumberSearchByName)를 실행시켜줍니다.
            //NumberSearchByName 이름으로 번호를 찾도록 만든 DataAdapter
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("NumberSearchByName", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_searchVal", SearchBox.Text);
                DataTable dtblNumber = new DataTable();
                sqlDa.Fill(dtblNumber);
                dgvPhoneNumber.DataSource = dtblNumber;
                dgvPhoneNumber.Columns[0].Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connectionString))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("NumberDeleteByID", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_userId", userId);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                Clear();
                GridFill();
            }
        }
    }
}
