
namespace WindowsFormsClient
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.comboBoxOldEmployeeNo = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxDelete = new System.Windows.Forms.ComboBox();
            this.labelOldNo = new System.Windows.Forms.Label();
            this.labelEmpNo = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(157, 398);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 26);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete Employee";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(157, 308);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 25);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(295, 11);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 62;
            this.dataGridViewEmployee.RowTemplate.Height = 28;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(304, 423);
            this.dataGridViewEmployee.TabIndex = 4;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(157, 59);
            this.textBoxNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(106, 20);
            this.textBoxNo.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(157, 91);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(106, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(93, 279);
            this.radioButtonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(93, 17);
            this.radioButtonAdd.TabIndex = 7;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add Employee";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Checked = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(188, 279);
            this.radioButtonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(92, 17);
            this.radioButtonEdit.TabIndex = 8;
            this.radioButtonEdit.TabStop = true;
            this.radioButtonEdit.Text = "Edit Employee";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(157, 122);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(106, 20);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(157, 154);
            this.textBoxJobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(106, 20);
            this.textBoxJobTitle.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(157, 186);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(106, 20);
            this.textBoxAddress.TabIndex = 11;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(157, 217);
            this.textBoxPhoneNo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(106, 20);
            this.textBoxPhoneNo.TabIndex = 12;
            // 
            // comboBoxOldEmployeeNo
            // 
            this.comboBoxOldEmployeeNo.FormattingEnabled = true;
            this.comboBoxOldEmployeeNo.Location = new System.Drawing.Point(157, 30);
            this.comboBoxOldEmployeeNo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOldEmployeeNo.Name = "comboBoxOldEmployeeNo";
            this.comboBoxOldEmployeeNo.Size = new System.Drawing.Size(106, 21);
            this.comboBoxOldEmployeeNo.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(157, 249);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(106, 20);
            this.textBoxEmail.TabIndex = 14;
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(157, 363);
            this.comboBoxDelete.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(106, 21);
            this.comboBoxDelete.TabIndex = 15;
            // 
            // labelOldNo
            // 
            this.labelOldNo.AutoSize = true;
            this.labelOldNo.Location = new System.Drawing.Point(15, 33);
            this.labelOldNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOldNo.Name = "labelOldNo";
            this.labelOldNo.Size = new System.Drawing.Size(112, 13);
            this.labelOldNo.TabIndex = 16;
            this.labelOldNo.Text = "Old Employee Number";
            // 
            // labelEmpNo
            // 
            this.labelEmpNo.AutoSize = true;
            this.labelEmpNo.Location = new System.Drawing.Point(15, 58);
            this.labelEmpNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmpNo.Name = "labelEmpNo";
            this.labelEmpNo.Size = new System.Drawing.Size(118, 13);
            this.labelEmpNo.TabIndex = 17;
            this.labelEmpNo.Text = "New Employee Number";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(44, 88);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 18;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(44, 121);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 19;
            this.labelLastName.Text = "Last Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(56, 187);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 20;
            this.labelAddress.Text = "Address";
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(56, 155);
            this.labelJobTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(47, 13);
            this.labelJobTitle.TabIndex = 21;
            this.labelJobTitle.Text = "Job Title";
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Location = new System.Drawing.Point(25, 214);
            this.labelPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNo.TabIndex = 22;
            this.labelPhoneNo.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(70, 246);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Email";
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(12, 431);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 13);
            this.labelFeedback.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 453);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.labelJobTitle);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelEmpNo);
            this.Controls.Add(this.labelOldNo);
            this.Controls.Add(this.comboBoxDelete);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.comboBoxOldEmployeeNo);
            this.Controls.Add(this.textBoxPhoneNo);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxJobTitle);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.radioButtonEdit);
            this.Controls.Add(this.radioButtonAdd);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxNo);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.ComboBox comboBoxOldEmployeeNo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxDelete;
        private System.Windows.Forms.Label labelOldNo;
        private System.Windows.Forms.Label labelEmpNo;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelFeedback;
    }
}

