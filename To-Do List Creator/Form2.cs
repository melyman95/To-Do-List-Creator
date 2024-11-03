using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace To_Do_List_Creator
{
    public partial class ListForm : Form
    {
        int selectedItemIndex = 0;

        int flagDoneOnce = 0;

        public bool mustLoad = false;

        bool debugMode = true;

        private ToDo _todo;

        List<string> toDoList = new List<string>();
        private ListForm form;

        string listName = string.Empty;

        public ListForm()
        {
            InitializeComponent();
            //this._todo = form;
        }

        private void TextEntry_Load(object sender, EventArgs e)
        {
            this.AddButton.Enabled = false;
            this.deleteItemButton.Enabled = false;
            this.ListEntryBox.Text = "Enter list item here";
            this.Activate();
            this.ListEntryBox.Select();
            this.listViewBox.Height = (this.Height - 50);

            if (this.mustLoad == true)
            {
                LoadOpenFileDialog();
            }

            if (debugMode == true)
            {
                debugLabel.Visible = true;
            }
            else
            {
                debugLabel.Visible = false;
            }

        }

        private void ListEntryBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ListEntryBox.Text == String.Empty)
            {
                this.AddButton.Enabled = false;
            }
            else 
            {
                this.AddButton.Enabled = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var entry = this.ListEntryBox.Text;
            toDoList.Add(entry);
            listViewBox.Items.Add(entry);
            listViewBox.Refresh();
            clearListButton.Enabled = true;
            //deleteItemButton.Enabled = true;
            ListEntryBox.Text = String.Empty;
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            toDoList.Clear();
            listViewBox.Items.Clear();
            listViewBox.Refresh();
            listViewBox.Text = String.Empty;
            clearListButton.Enabled = false;
            deleteItemButton.Enabled = false;
        }

        private void SaveListToFile(List<string> list, string filename)
        {
            File.WriteAllLines(filename + ".txt", list.ToArray());
        }

        private void LoadListFromFile(List<string> items, ListBox box, bool debug = false)
        {
            foreach (string line in items)
            {
                box.Items.Add(line);
            }
            box.Refresh();
        }

        private void LoadOpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listName = openFileDialog.FileName;
                listName = Path.GetFileName(listName);
                List<string> lines = new List<string>(File.ReadAllLines(openFileDialog.FileName));
                foreach (string line in lines) 
                {
                    toDoList.Add(line);
                }
                LoadListFromFile(lines, listViewBox);
                RefreshControl(listViewBox);
                ListNameBox.Text = listName;
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadOpenFileDialog();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string defaultName = Environment.UserName + "'s list";
            if (ListNameBox.Text == String.Empty)
            {
                SaveListToFile(toDoList, defaultName);
            }
            else
            {
                SaveListToFile(toDoList, ListNameBox.Text);
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            DeleteFromList(toDoList, selectedItemIndex);

            if (toDoList.Count <= 0)
            {
                deleteItemButton.Enabled = false;
            }

            selectedItemIndex = 0;
        }

        private void DeleteFromList(List<string> list, int index)
        {
            if (IsValidIndex(index, list.Count))
            {
                list.RemoveAt(index);
                listViewBox.Items.RemoveAt(index);
                listViewBox.Refresh();
            }
            else
            {
                MessageBox.Show(index + " is an invalid index.");
            }
        }

        private void listViewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItemIndex = listViewBox.SelectedIndex;

            if (debugMode == true)
            {
                debugLabel.Text = "Selected index: " + selectedItemIndex;
            }

            if (selectedItemIndex.ToString() != null)
            {
                deleteItemButton.Enabled = true;
            }
        }

        private void ListEntryBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (flagDoneOnce == 0) 
            {
                ListEntryBox.Text = string.Empty;
                flagDoneOnce = 1;
            }
        }

        private void RefreshControl(Control control)
        {
            if (control == null)
            {
                return;
            }
            else
            {
                if (control.InvokeRequired)
                {
                    control.Invoke((MethodInvoker)delegate
                    {
                        control.Refresh();
                    });
                }
                else
                {
                    control.Refresh();
                }
            }
        }

        private bool IsValidIndex(int index, int size)
        {
            bool valid = false;

            if (index >= 0 && index < size)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           // _todo.Create.Enabled = true;
        }
    }
}
