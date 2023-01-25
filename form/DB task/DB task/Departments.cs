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
        public Departments()
        {
            InitializeComponent();
            Con= new Functions();
            listerDepartment();
        }

        private void listerDepartment()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Functions GetCon()
        {
            return Con;
        }

        private void listerDepartment(Functions con)
        {
            string Query = "select * from Departmenttbl";
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
                    string Query = "insert into Departmenttble values('{0}')";
                }
            }
            catch (Exception EX) 
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
