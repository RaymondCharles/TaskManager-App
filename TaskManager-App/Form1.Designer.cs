namespace TaskManagerApp
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lstTasks1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(60, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(330, 23);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(145, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(330, 86);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(145, 79);
            this.txtDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(60, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(975, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnView.Location = new System.Drawing.Point(975, 178);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(171, 33);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View Tasks";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.Location = new System.Drawing.Point(975, 250);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(171, 33);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit Task";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Location = new System.Drawing.Point(975, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.SpringGreen;
            this.btnComplete.Location = new System.Drawing.Point(975, 392);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(171, 39);
            this.btnComplete.TabIndex = 8;
            this.btnComplete.Text = "Mark Task Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lstTasks1
            // 
            this.lstTasks1.FormattingEnabled = true;
            this.lstTasks1.ItemHeight = 16;
            this.lstTasks1.Location = new System.Drawing.Point(330, 336);
            this.lstTasks1.Name = "lstTasks1";
            this.lstTasks1.Size = new System.Drawing.Size(377, 212);
            this.lstTasks1.TabIndex = 9;
            this.lstTasks1.SelectedIndexChanged += new System.EventHandler(this.lstTasks1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(60, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tasks that are added in the List";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1342, 670);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstTasks1);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Task Manager App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ListBox lstTasks1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

