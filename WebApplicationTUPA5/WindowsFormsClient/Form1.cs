using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsClient.ServiceReferenceTUPA5;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        private WebServiceTUPA5Soap proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new WebServiceTUPA5SoapClient();
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
                    UpdateEmployeeData();
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
                        UpdateEmployeeData();
                    }

                }
                catch (NullReferenceException)
                {
                    labelFeedback.Text = "Please choose address to edit";
                }
                catch(Exception e)
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
        private void UpdateEmployeeData()
        {
            //Do something
        }
        
        
    }
}

