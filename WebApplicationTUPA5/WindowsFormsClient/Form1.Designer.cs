
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(187, 608);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 40);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.Text = "Delete Employee";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(187, 469);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 38);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(395, 12);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 62;
            this.dataGridViewEmployee.RowTemplate.Height = 28;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(456, 651);
            this.dataGridViewEmployee.TabIndex = 4;
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(187, 86);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.Size = new System.Drawing.Size(157, 26);
            this.textBoxNo.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(187, 135);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(157, 26);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(91, 425);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(137, 24);
            this.radioButtonAdd.TabIndex = 7;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add Employee";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(234, 425);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(136, 24);
            this.radioButtonEdit.TabIndex = 8;
            this.radioButtonEdit.TabStop = true;
            this.radioButtonEdit.Text = "Edit Employee";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(187, 183);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(157, 26);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(187, 232);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(157, 26);
            this.textBoxJobTitle.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(187, 281);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(157, 26);
            this.textBoxAddress.TabIndex = 11;
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(187, 330);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(157, 26);
            this.textBoxPhoneNo.TabIndex = 12;
            // 
            // comboBoxOldEmployeeNo
            // 
            this.comboBoxOldEmployeeNo.FormattingEnabled = true;
            this.comboBoxOldEmployeeNo.Location = new System.Drawing.Point(187, 41);
            this.comboBoxOldEmployeeNo.Name = "comboBoxOldEmployeeNo";
            this.comboBoxOldEmployeeNo.Size = new System.Drawing.Size(157, 28);
            this.comboBoxOldEmployeeNo.TabIndex = 13;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(187, 378);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(157, 26);
            this.textBoxEmail.TabIndex = 14;
            // 
            // comboBoxDelete
            // 
            this.comboBoxDelete.FormattingEnabled = true;
            this.comboBoxDelete.Location = new System.Drawing.Point(187, 554);
            this.comboBoxDelete.Name = "comboBoxDelete";
            this.comboBoxDelete.Size = new System.Drawing.Size(157, 28);
            this.comboBoxDelete.TabIndex = 15;
            // 
            // labelOldNo
            // 
            this.labelOldNo.AutoSize = true;
            this.labelOldNo.Location = new System.Drawing.Point(12, 44);
            this.labelOldNo.Name = "labelOldNo";
            this.labelOldNo.Size = new System.Drawing.Size(167, 20);
            this.labelOldNo.TabIndex = 16;
            this.labelOldNo.Text = "Old Employee Number";
            // 
            // labelEmpNo
            // 
            this.labelEmpNo.AutoSize = true;
            this.labelEmpNo.Location = new System.Drawing.Point(12, 89);
            this.labelEmpNo.Name = "labelEmpNo";
            this.labelEmpNo.Size = new System.Drawing.Size(174, 20);
            this.labelEmpNo.TabIndex = 17;
            this.labelEmpNo.Text = "New Employee Number";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(56, 135);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 18;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(56, 186);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 19;
            this.labelLastName.Text = "Last Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(74, 287);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 20;
            this.labelAddress.Text = "Address";
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(74, 238);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(68, 20);
            this.labelJobTitle.TabIndex = 21;
            this.labelJobTitle.Text = "Job Title";
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Location = new System.Drawing.Point(27, 330);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(115, 20);
            this.labelPhoneNo.TabIndex = 22;
            this.labelPhoneNo.Text = "Phone Number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(94, 378);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Email";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 697);
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
    }
}

