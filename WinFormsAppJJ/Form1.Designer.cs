namespace WinFormsAppJJ
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
            txtDueDate = new TextBox();
            txtTaskDescription = new TextBox();
            lblTaskBoxLabel = new Label();
            lblDueDate = new Label();
            btnClear = new Button();
            btnAdd = new Button();
            gbTaskList = new GroupBox();
            FpTasks = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            gbTaskList.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Controls.Add(lblTaskBoxLabel);
            groupBox1.Controls.Add(lblDueDate);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(4, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(69, 48);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "2025-02-15";
            txtDueDate.Size = new Size(228, 23);
            txtDueDate.TabIndex = 5;
            txtDueDate.TextChanged += txtDueDate_TextChanged;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(69, 18);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(228, 23);
            txtTaskDescription.TabIndex = 4;
            txtTaskDescription.TextChanged += txtTaskDescription_TextChanged;
            // 
            // lblTaskBoxLabel
            // 
            lblTaskBoxLabel.AutoSize = true;
            lblTaskBoxLabel.Location = new Point(10, 21);
            lblTaskBoxLabel.Name = "lblTaskBoxLabel";
            lblTaskBoxLabel.Size = new Size(29, 15);
            lblTaskBoxLabel.TabIndex = 3;
            lblTaskBoxLabel.Text = "Task";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(8, 51);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(55, 15);
            lblDueDate.TabIndex = 2;
            lblDueDate.Text = "Due Date";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(141, 120);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(222, 120);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Todo";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += submitForm;
            // 
            // gbTaskList
            // 
            gbTaskList.Controls.Add(FpTasks);
            gbTaskList.Location = new Point(7, 173);
            gbTaskList.Name = "gbTaskList";
            gbTaskList.Size = new Size(317, 399);
            gbTaskList.TabIndex = 1;
            gbTaskList.TabStop = false;
            gbTaskList.Text = "Task List";
            gbTaskList.Enter += gbTaskList_Enter;
            // 
            // FpTasks
            // 
            FpTasks.AutoScroll = true;
            FpTasks.Location = new Point(0, 15);
            FpTasks.Name = "FpTasks";
            FpTasks.Size = new Size(317, 384);
            FpTasks.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 575);
            Controls.Add(gbTaskList);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbTaskList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDueDate;
        private TextBox txtTaskDescription;
        private Label lblTaskBoxLabel;
        private Label lblDueDate;
        private Button btnClear;
        private Button btnAdd;
        private GroupBox gbTaskList;
        private FlowLayoutPanel FpTasks;
    }
}
