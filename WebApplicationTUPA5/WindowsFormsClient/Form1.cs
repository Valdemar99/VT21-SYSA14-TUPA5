using System;
using System.Linq;
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
            string newEmployeeNumber = textBoxAddress.Text; //retrieves text from textbox
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string jobTitle = textBoxJobTitle.Text;
            string address = textBoxAddress.Text;
            string phoneNumber = textBoxPhoneNo.Text;
            string email = textBoxEmail.Text;


            if (radioButtonAdd.Checked == true)
            {
                if (newEmployeeNumber.Equals(""))//Error message if the textbox is empty
                {
                    labelFeedback.Text = "To add a new employee, please insert an employee number.";
                }

                try 
                {
                    proxy.AddEmployee(newEmployeeNumber, firstName, lastName, jobTitle, address, phoneNumber, email);

                    labelFeedback.Text = "The employee has been successfully added to database.";
                    RefreshEmployeeData();
                } catch
                {

                }
            }

            if (radioButtonEdit.Checked == true) //If edit building is chosen
            {
                try
                {
                    string oldEmployeeNo = comboBoxOldEmployeeNo.SelectedItem.ToString();                   
                    if (newEmployeeNumber.Equals(""))//Error message if the textbox is empty
                    {
                        labelFeedback.Text = "To edit an employee, please insert the new employee number.";
                    }
                    else
                    { //Checks if the new address doesn't exist in the database, if so, edits the old address to the new one
                        proxy.UpdateEmployee(oldEmployeeNo, firstName, lastName, jobTitle, address, phoneNumber, email);
                        labelFeedback.Text = "The employee has been successfully updated within the database.";
                        RefreshEmployeeData();
                    }

                }
                catch (NullReferenceException)
                {
                    labelFeedback.Text = "Please choose address to edit";
                }
                catch(Exception)
                {
                    // If the new address already exists it sends an error message
                    labelFeedback.Text = "This building with inserted new address already exists\n in our database. Please try another another address.";

                    //Generic error handling.
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeNumberToDelete = comboBoxDelete.SelectedItem.ToString();
                proxy.DeleteEmployee(employeeNumberToDelete);
            }
            catch (NullReferenceException)
            {
                labelFeedback.Text = "Please choose employee to delete.";

            }
        }
        private void RefreshEmployeeData()
        {

            try
            {
                this.RefreshComboBoxWithEmployees();

                this.ChangeVisibleColumns();
            } catch(Exception ex)
            {
                labelFeedback.Text = ex.Message;
                Console.WriteLine(ex.Message);
            }
            
        }

        private void ChangeVisibleColumns()
        {
            DataGridViewColumnCollection columnList = dataGridViewEmployee.Columns;
            columnList.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            this.dataGridViewEmployee.Columns["No_"].Visible = true;
            this.dataGridViewEmployee.Columns["First Name"].Visible = true;
            this.dataGridViewEmployee.Columns["Last Name"].Visible = true;
            this.dataGridViewEmployee.Columns["Job Title"].Visible = true;
            this.dataGridViewEmployee.Columns["Address"].Visible = true;
            this.dataGridViewEmployee.Columns["Phone No_"].Visible = true;
            this.dataGridViewEmployee.Columns["E-Mail"].Visible = true;


        }

        private void RefreshComboBoxWithEmployees()
        {
            CRONUS_Sverige_AB_Employee[] emp = proxy.GetEmployees();
            comboBoxOldEmployeeNo.DataSource = emp; 
            comboBoxOldEmployeeNo.DisplayMember = "No_";
            comboBoxOldEmployeeNo.ValueMember = "No_";
        }
    }
}

