﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMan.forms.AccountType
{
    public partial class AddAccountTypeDialog : Form
    {
        public AdminModifyListener addAccountType { get; set; }

        public AddAccountTypeDialog()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            string type = this.type_textbox.Text;
            if(type == "")
            {
                this.stat_status.Text = "invalid type name";
                return;
            }
            if (!addAccountType(0, type, 1, 0))
            {
                this.stat_status.Text = "failed to add account type";
                return;
            }
            else
            {
                this.Hide();
            }
        }

        public void reset()
        {
            this.type_textbox.Text = "";
            this.stat_status.Text = "enter account type name";
        }
    }
}
