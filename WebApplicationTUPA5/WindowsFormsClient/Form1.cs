using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    labelFeedbackForBuildings.Text = "To add a new employee, please insert an employee number.";
                }

                try 
                {
                    
                    
                    dataAccessLayer.AddBuilding(newAddress);
                    labelFeedbackForBuildings.Text = "The building with address'" + newAddress + "'\nhas been successfully added to database.";
                    UpdateBuildingData();
                        
                 
                } catch
                {

                }
            }

            if (radioButtonEditBuilding.Checked == true) //If edit building is chosen
            {
                try
                {
                    string oldEmployeeNo = comboBoxOldEmployeeNo.SelectedItem.ToString();
                    //Checks if the old address doesn't exist in the database, if so, change to address in new address textbox
                    if (dataAccessLayer.checkIfBuildingExists(oldAddress) == true)
                    {
                        if (newAddress.Equals(""))//Error message if the textbox is empty
                        {
                            labelFeedbackForBuildings.Text = "To edit a new building, please insert the new address.";
                        }
                        else
                        { //Checks if the new address doesn't exist in the database, if so, edits the old address to the new one 

                            if (dataAccessLayer.checkIfBuildingExists(newAddress) == true) // If the new address already exists it sends an error message
                            {
                                labelFeedbackForBuildings.Text = "This building with inserted new address already exists\n in our database. Please try another another address.";
                            }

                            if (dataAccessLayer.checkIfBuildingExists(newAddress) != true)
                            {
                                dataAccessLayer.EditBuilding(oldAddress, newAddress);
                                labelFeedbackForBuildings.Text = "The building with address'" + oldAddress + "' has been successfully \nchanged into '" + newAddress + "' within the database.";
                                UpdateBuildingData();

                            }

                        }


                    }

                }
                catch (NullReferenceException)
                {
                    labelFeedbackForBuildings.Text = "Please choose address to edit";

                }
            }
        }
    }
    }
}
