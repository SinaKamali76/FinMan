﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinMan.forms.IncomeType
{
    public partial class EditIncomeTypeDialog : Form
    {
        public AdminModifyListener updateIncType { get; set; }

        private int id;

        public EditIncomeTypeDialog()
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
            if (type == "")
            {
                this.stat_status.Text = "invalid type name";
                return;
            }
            if (!updateIncType(1, type, 0, id))
            {
                this.stat_status.Text = "failed to update income type";
                return;
            }
            else
            {
                this.Hide();
            }
        }

        public void reset(string type, int id)
        {
            this.id = id;

            this.type_textbox.Text = type;
            this.stat_status.Text = "enter income type name";
        }
    }
}
