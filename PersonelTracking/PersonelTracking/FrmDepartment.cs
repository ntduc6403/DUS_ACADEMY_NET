﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the name field !");
            }
            else
            {
                DEPARTMENT department = new DEPARTMENT();
                department.DepartmentName = txtDepartment.Text;
                BLL.DepartmentBLL.AddDepartment(department);
                MessageBox.Show("Department was added");
                txtDepartment.Clear();
            }

        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
