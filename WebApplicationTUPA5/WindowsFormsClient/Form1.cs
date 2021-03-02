using System;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using WindowsFormsClient.ServiceReference1;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private WebServiceTUPA5SoapClient proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new WebServiceTUPA5SoapClient();
            this.RefreshEmployeeData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newEmployeeNumber = textBoxNo.Text; //retrieves text from textbox
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string jobTitle = textBoxJobTitle.Text;
            string address = textBoxAddress.Text;
            string phoneNumber = textBoxPhoneNo.Text;
            string email = textBoxEmail.Text;


            if (radioButtonAdd.Checked == true)
            {
                try
                {
                    proxy.AddEmployee(newEmployeeNumber, firstName, lastName, jobTitle, address, phoneNumber, email);
                    labelFeedback.Text = "The employee has been successfully added to database.";
                    RefreshEmployeeData();
                }
                catch (EndpointNotFoundException ex)
                {
                    labelFeedback.Text = "Please check your connection and try again.";
                }
                catch (FaultException soapEx)
                {
                    labelFeedback.Text = CleanErrorMessage(soapEx.Message);
                }
                catch (Exception exe)
                {
                    labelFeedback.Text = "Unknown error. Please contact support. ";
                }
            }

            if (radioButtonEdit.Checked == true) //If edit building is chosen
     
            {
                try
                {
                    textBoxFirstName.Clear();
                    CRONUS_Sverige_AB_Employee employeeToEdit = comboBoxOldEmployeeNo.SelectedItem as CRONUS_Sverige_AB_Employee;
                    
                    if (comboBoxOldEmployeeNo.SelectedItem == null)//Error message if the textbox is empty
                    {
                        labelFeedback.Text = "To edit an employee, please insert the new employee number.";
                    } 
                   
                    else
                    {
                        
                        string oldEmployeeNo = comboBoxOldEmployeeNo.SelectedItem.ToString(); 
                        //Checks if the new address doesn't exist in the database, if so, edits the old address to the new one
                        proxy.UpdateEmployee(oldEmployeeNo, firstName, lastName, jobTitle, address, phoneNumber, email);
                        labelFeedback.Text = "The employee has been successfully updated within the database.";
                        RefreshEmployeeData();
                    }

                }
                catch (EndpointNotFoundException ex)
                {
                    labelFeedback.Text = "Please check your connection and try again.";
                }
                catch (FaultException soapEx)
                {
                    labelFeedback.Text = CleanErrorMessage(soapEx.Message);
                }
                catch (Exception exe)
                {
                        labelFeedback.Text = "Unknown error. Please contact support. ";
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDelete.SelectedItem != null)
                {

                    CRONUS_Sverige_AB_Employee employeeToDelete = comboBoxDelete.SelectedItem as CRONUS_Sverige_AB_Employee;
                    string employeeNumberToDelete = employeeToDelete.No_;
                    proxy.DeleteEmployee(employeeNumberToDelete);
                    this.RefreshEmployeeData();

                }
                else
                {
                    labelFeedback.Text = "Please choose employee to delete.";
                }
            }
            catch (EndpointNotFoundException ex)
            {
                labelFeedback.Text = "Please check your connection and try again.";
            }
            catch (FaultException soapEx)
            {
                labelFeedback.Text = CleanErrorMessage(soapEx.Message);
            }
            catch (Exception exe)
            {
                labelFeedback.Text = "Unknown error. Please contact support. ";
            }

        }
        private void RefreshEmployeeData()
        {

            try
            {
                this.RefreshComboBoxWithEmployees();
                this.RefreshEmployeeTable();

                this.ChangeVisibleColumns();
            }
            catch (EndpointNotFoundException ex)
            {
                labelFeedback.Text = "Please check your connection and try again.";
            }
            catch (FaultException soapEx)
            {
                labelFeedback.Text = CleanErrorMessage(soapEx.Message);
            }
            catch (Exception exe)
            {
                labelFeedback.Text = "Unknown error. Please contact support. ";
            }

        }

        private void RefreshEmployeeTable()
        {
            try { 
                CRONUS_Sverige_AB_Employee[] employees = proxy.GetEmployees();
                dataGridViewEmployee.DataSource = employees;
            } catch(Exception ex)
            {
                throw ex;
            }

}

        private void ChangeVisibleColumns()
        {
            DataGridViewColumnCollection columnList = dataGridViewEmployee.Columns;
            columnList.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            this.dataGridViewEmployee.Columns["No_"].Visible = true;
            this.dataGridViewEmployee.Columns["First_Name"].Visible = true;
            this.dataGridViewEmployee.Columns["Last_Name"].Visible = true;
            this.dataGridViewEmployee.Columns["Job_Title"].Visible = true;
            this.dataGridViewEmployee.Columns["Address"].Visible = true;
            this.dataGridViewEmployee.Columns["Phone_No_"].Visible = true;
            this.dataGridViewEmployee.Columns["E_Mail"].Visible = true;


        }

        private void RefreshComboBoxWithEmployees()
        {
            try
            {
                CRONUS_Sverige_AB_Employee[] emp = proxy.GetEmployees();
                comboBoxOldEmployeeNo.DataSource = emp;
                comboBoxOldEmployeeNo.DisplayMember = "No_";
                comboBoxOldEmployeeNo.ValueMember = "No_";

                comboBoxDelete.DataSource = emp;
                comboBoxDelete.DisplayMember = "No_";
                comboBoxDelete.ValueMember = "No_";
            } catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void radioButtonAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAdd.Checked)
            {
                comboBoxOldEmployeeNo.Enabled = false;
                textBoxNo.Enabled = true;
            }
            else
            {
                comboBoxOldEmployeeNo.Enabled = true;
                textBoxNo.Enabled = false;
            }
        }
        public string CleanErrorMessage(string fullErrorMessage)
        {
            return fullErrorMessage.Split(':', '-')[1].Trim();
        }

      
    }
}

