using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace To_Do_List_Creator
{
    public partial class ToDo : Form
    {
        string userName = Environment.UserName;
        string date = DateTime.Now.ToLongDateString();
        string time = DateTime.Now.ToString("hh:mm tt");

        private ListForm _form;
        private ListBox thing;

        public ToDo()
        {
            InitializeComponent();
            this.userNameBox.Text = userName;
            this.dateBox.Text = date;
            this.timeBox.Text = time;
            //this._form = frm;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            LoadTextEntryForm();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            LoadTextEntryForm(true);
        }

        private void LoadTextEntryForm(bool load = false)
        {
            if (load == true) 
            {
                ListForm form = new ListForm();
                form.mustLoad = true;
                form.Show();
                this.Create.Enabled = false;
            }
            else
            {
                ListForm form = new ListForm();
                form.Show();
                this.Create.Enabled = false;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ToDo_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
