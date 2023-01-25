using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_task
{
    public partial class Departments : Form
    {
        Functions Con;

        public object Deplist { get; private set; }

        public Departments()
        {
            InitializeComponent();
            Con= new Functions();
            ShowDepartments();
        }

        private void ShowDepartments()
        {
            string Query = "SELECT * FROM Departmenttbl";
            deplist.DataSource = Con.GetData(Query);
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Depnametb.Text == "")
                {
                    MessageBox.Show("Missing  daata");
                }
                else
                {
                    string Dep = Depnametb.Text;
                    string Query = "insert into Departmenttbl values('{0}')";
                    Query = string.Format(Query,Depnametb.Text);
                    Con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department added");
                    Depnametb.Text = "";

                }
            }
            catch (Exception EX) 
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }
    }
}
