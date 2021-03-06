﻿namespace FinMan.forms
{
    partial class AddAccountDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.balance_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.balance_textbox = new System.Windows.Forms.TextBox();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.stat_label = new System.Windows.Forms.Label();
            this.stat_status = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.desc_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(29, 19);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(78, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "account name:";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(29, 55);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(72, 13);
            this.type_label.TabIndex = 1;
            this.type_label.Text = "account type:";
            // 
            // balance_label
            // 
            this.balance_label.AutoSize = true;
            this.balance_label.Location = new System.Drawing.Point(29, 106);
            this.balance_label.Name = "balance_label";
            this.balance_label.Size = new System.Drawing.Size(89, 13);
            this.balance_label.TabIndex = 2;
            this.balance_label.Text = "opening balance:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(123, 16);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(100, 20);
            this.name_textbox.TabIndex = 3;
            // 
            // balance_textbox
            // 
            this.balance_textbox.Location = new System.Drawing.Point(123, 103);
            this.balance_textbox.Name = "balance_textbox";
            this.balance_textbox.Size = new System.Drawing.Size(100, 20);
            this.balance_textbox.TabIndex = 4;
            // 
            // type_combo
            // 
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Location = new System.Drawing.Point(123, 52);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(100, 21);
            this.type_combo.TabIndex = 5;
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(234, 320);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(75, 23);
            this.done_btn.TabIndex = 6;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(153, 320);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // stat_label
            // 
            this.stat_label.AutoSize = true;
            this.stat_label.Location = new System.Drawing.Point(30, 295);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(38, 13);
            this.stat_label.TabIndex = 8;
            this.stat_label.Text = "status:";
            // 
            // stat_status
            // 
            this.stat_status.AutoSize = true;
            this.stat_status.Location = new System.Drawing.Point(74, 295);
            this.stat_status.Name = "stat_status";
            this.stat_status.Size = new System.Drawing.Size(106, 13);
            this.stat_status.TabIndex = 9;
            this.stat_status.Text = "enter account details";
            // 
            // desc_label
            // 
            this.desc_label.AutoSize = true;
            this.desc_label.Location = new System.Drawing.Point(33, 159);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(61, 13);
            this.desc_label.TabIndex = 10;
            this.desc_label.Text = "description:";
            // 
            // desc_textbox
            // 
            this.desc_textbox.Location = new System.Drawing.Point(33, 175);
            this.desc_textbox.Multiline = true;
            this.desc_textbox.Name = "desc_textbox";
            this.desc_textbox.Size = new System.Drawing.Size(190, 92);
            this.desc_textbox.TabIndex = 11;
            // 
            // AddAccountDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 356);
            this.Controls.Add(this.desc_textbox);
            this.Controls.Add(this.desc_label);
            this.Controls.Add(this.stat_status);
            this.Controls.Add(this.stat_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.balance_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.balance_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAccountDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label balance_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox balance_textbox;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label stat_label;
        private System.Windows.Forms.Label stat_status;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.TextBox desc_textbox;
    }
}