using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerView
{
    public partial class ManagerView : Form
    {
        TestContext context = new TestContext(); //DataBase connection is done on globally....Because more than one methods will use this connection
        public ManagerView()
        {
            InitializeComponent();
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {
            
            this.Init();

        }

        //All Page Refresh Code

        private void Init()
        {
            txtSearch.Text = txtId.Text = txtName.Text = txtContact.Text = txtDesignation.Text = txtSalary.Text = txtJoiningDate.Text = txtPassword.Text = txtSalary.Text = ""; //Empty All The Text Box
            this.LoadDetails();
        }


        //Load Details Method
        private void LoadDetails(string key="")
        {
            var employee = context.Employees.ToList();//Get All employee list form DB employee Table

            if(key!="") //if Search
            {
                employee = employee.Where(c => c.EmpName.ToUpper().Contains(key.ToUpper())).ToList();  //Use ALL UPPER key to search.
            }

            dgvEmpDetails.DataSource = employee.ToList();
            dgvEmpDetails.Refresh();

            if(employee.Count>0)
                this.LoadDetail(employee.First().EmpId);

        }


        //Logout
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadDetails(txtSearch.Text);
        }

        //lOADdATAINTextBox

        private void LoadDetail(int id)
        {
            var employee = context.Employees.FirstOrDefault(c => c.EmpId == id); //Search by ID

            if(employee==null)
            {
                txtId.Text = txtName.Text = txtContact.Text = txtDesignation.Text = txtSalary.Text = txtJoiningDate.Text = txtPassword.Text = txtSalary.Text = "";

            }
            else
            {
                txtId.Text = employee.EmpId.ToString();
                txtName.Text = employee.EmpName;
                txtContact.Text = employee.EmpContact;
                txtDesignation.Text = employee.Designation;
                txtSalary.Text = employee.Salary;
                txtPassword.Text = employee.Password;
                txtJoiningDate.Text = employee.JoiningDate.ToString();
                txtStatus.Text = employee.Status.ToString();
            }
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }


        //cel click
        private void dgvEmpDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                string id = dgvEmpDetails.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.LoadDetail(Int32.Parse(id));
            }
        }


        //New Button
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.LoadDetail(-5); //
            dgvEmpDetails.ClearSelection();
        }


        //delete

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="")
            {
                MessageBox.Show("Select a ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id=Int32.Parse(txtId.Text);

            var employee = context.Employees.FirstOrDefault(c => c.EmpId == id);
            

            if(employee==null) 
            {
                this.Init();
                return;
            }

            context.Employees.Remove(employee);
            context.SaveChanges();
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btngid_Click(object sender, EventArgs e)
        {
            string a = txtb1.Text;
            string b = txtb2.Text;
            txtr.Text = a + "_" + b;
        }
    }
}
