namespace To_Do_List_Creator
{
    partial class ToDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDo));
            this.Create = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.loadedFileBox = new System.Windows.Forms.MaskedTextBox();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(197, 13);
            this.Create.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(291, 123);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create List";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(578, 13);
            this.Load.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(291, 123);
            this.Load.TabIndex = 1;
            this.Load.Text = "Load List";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // loadedFileBox
            // 
            this.loadedFileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadedFileBox.Location = new System.Drawing.Point(197, 360);
            this.loadedFileBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.loadedFileBox.Name = "loadedFileBox";
            this.loadedFileBox.Size = new System.Drawing.Size(649, 35);
            this.loadedFileBox.TabIndex = 2;
            this.loadedFileBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // userNameBox
            // 
            this.userNameBox.Enabled = false;
            this.userNameBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameBox.Location = new System.Drawing.Point(275, 195);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(523, 33);
            this.userNameBox.TabIndex = 3;
            // 
            // dateBox
            // 
            this.dateBox.Enabled = false;
            this.dateBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(277, 239);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(523, 33);
            this.dateBox.TabIndex = 4;
            // 
            // timeBox
            // 
            this.timeBox.Enabled = false;
            this.timeBox.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.Location = new System.Drawing.Point(275, 288);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(523, 33);
            this.timeBox.TabIndex = 5;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::To_Do_List_Creator.Properties.Resources.notebookcover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 504);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.loadedFileBox);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Create);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ToDo";
            this.Text = "TO-DO";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDo_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.MaskedTextBox loadedFileBox;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox timeBox;
        public System.Windows.Forms.Button Create;
    }
}

