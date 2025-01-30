namespace WinformTodo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblDueDate = new Label();
            txtDueDate = new TextBox();
            lblTaskBoxLabel = new Label();
            txtTaskDescription = new TextBox();
            gbTaskList = new GroupBox();
            lbTaskList = new ListBox();
            groupBox1.SuspendLayout();
            gbTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lblDueDate);
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(lblTaskBoxLabel);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 105);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(184, 74);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(265, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Todo";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += submitForm;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(6, 48);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "Due Date";
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(67, 45);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "2025-01-20";
            txtDueDate.Size = new Size(273, 23);
            txtDueDate.TabIndex = 2;
            txtDueDate.KeyPress += Form1_KeyPress;
            // 
            // lblTaskBoxLabel
            // 
            lblTaskBoxLabel.AutoSize = true;
            lblTaskBoxLabel.Location = new Point(6, 19);
            lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            lblTaskBoxLabel.Size = new Size(30, 15);
            lblTaskBoxLabel.TabIndex = 1;
            lblTaskBoxLabel.Text = "Task";
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(67, 16);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(273, 23);
            txtTaskDescription.TabIndex = 0;
            txtTaskDescription.KeyPress += Form1_KeyPress;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(lbTaskList);
            gbTaskList.Location = new Point(12, 123);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(346, 473);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            // 
            // lbTaskList
            // 
            lbTaskList.FormattingEnabled = true;
            lbTaskList.Location = new Point(6, 22);
            lbTaskList.Name = "lbTaskList";
            lbTaskList.Size = new Size(334, 439);
            lbTaskList.TabIndex = 0;
            lbTaskList.SelectedIndexChanged += lbTaskList_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 608);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Todo App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTaskList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTaskBoxLabel;
        private TextBox txtTaskDescription;
        private Button btnAdd;
        private Label lblDueDate;
        private TextBox txtDueDate;
        private Button btnClear;
        private GroupBox gbTaskList;
        private ListBox lbTaskList;
    }
}
