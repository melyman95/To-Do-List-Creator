namespace To_Do_List_Creator
{
    partial class ListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.ListEntryBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.ListNameBox = new System.Windows.Forms.TextBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.listViewBox = new System.Windows.Forms.ListBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListEntryBox
            // 
            this.ListEntryBox.Location = new System.Drawing.Point(95, 53);
            this.ListEntryBox.Name = "ListEntryBox";
            this.ListEntryBox.Size = new System.Drawing.Size(475, 35);
            this.ListEntryBox.TabIndex = 1;
            this.ListEntryBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListEntryBox_MouseClick);
            this.ListEntryBox.TextChanged += new System.EventHandler(this.ListEntryBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(218, 94);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(231, 48);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Location = new System.Drawing.Point(218, 148);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(231, 48);
            this.clearListButton.TabIndex = 3;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(339, 219);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(231, 48);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(102, 219);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(231, 48);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameLabel.Location = new System.Drawing.Point(278, 402);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(133, 31);
            this.ListNameLabel.TabIndex = 6;
            this.ListNameLabel.Text = "List Name";
            // 
            // ListNameBox
            // 
            this.ListNameBox.Location = new System.Drawing.Point(95, 441);
            this.ListNameBox.Name = "ListNameBox";
            this.ListNameBox.Size = new System.Drawing.Size(475, 35);
            this.ListNameBox.TabIndex = 7;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(268, 318);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(148, 35);
            this.deleteItemButton.TabIndex = 8;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // listViewBox
            // 
            this.listViewBox.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBox.FormattingEnabled = true;
            this.listViewBox.ItemHeight = 31;
            this.listViewBox.Location = new System.Drawing.Point(602, 53);
            this.listViewBox.Name = "listViewBox";
            this.listViewBox.Size = new System.Drawing.Size(526, 438);
            this.listViewBox.TabIndex = 9;
            this.listViewBox.SelectedIndexChanged += new System.EventHandler(this.listViewBox_SelectedIndexChanged);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(764, 532);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(201, 27);
            this.debugLabel.TabIndex = 10;
            this.debugLabel.Text = "Current list index:";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::To_Do_List_Creator.Properties.Resources.notebook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 568);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.listViewBox);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.ListNameBox);
            this.Controls.Add(this.ListNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ListEntryBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListForm_FormClosed);
            this.Load += new System.EventHandler(this.TextEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ListEntryBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ListNameLabel;
        private System.Windows.Forms.TextBox ListNameBox;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.ListBox listViewBox;
        private System.Windows.Forms.Label debugLabel;
    }
}