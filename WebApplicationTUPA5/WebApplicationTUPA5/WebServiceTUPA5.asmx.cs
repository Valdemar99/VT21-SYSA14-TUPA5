using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebApplicationTUPA5
{
    /// <summary>
    /// Summary description for WebServiceTUPA5
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceTUPA5 : System.Web.Services.WebService
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        //failed login 18456
        [WebMethod]
        public List<CRONUS_Sverige_AB_Employee> GetEmployees()
        {
            try
            {
                return dataAccessLayer.GetEmployees();
            }
            catch (EntityException entityEx)
            {
                SqlException sqlException = entityEx.InnerException as SqlException;
                if (sqlException != null)
                {
                    string errorMessage = HandleSqlException(sqlException);
                    throw new SoapException(errorMessage, SoapException.ClientFaultCode, sqlException);
                }
                else
                {
                    throw new SoapException("Unknown database error. Please contact support.", SoapException.ClientFaultCode, sqlException);
                }
            }
            catch (Exception exc)
            {
                throw new SoapException("Unknown error. Please contact support.", SoapException.ClientFaultCode, exc);
            }
        }

        [WebMethod]
        public void AddEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            try
            {
                dataAccessLayer.AddEmployee(no_, first_Name, last_Name, job_Title, address, phone_No_, e_Mail);
            }
            catch (EntityException entityEx)
            {
                SqlException sqlException = entityEx.InnerException as SqlException;
                if (sqlException != null)
                {
                    string errorMessage = HandleSqlException(sqlException);
                    throw new SoapException(errorMessage, SoapException.ClientFaultCode, sqlException);
                }
                else
                {
                    throw new SoapException("Unknown database error. Please contact support.", SoapException.ClientFaultCode, sqlException);
                }
            }
            catch (ArgumentException entityEx)
            {
                throw new SoapException(entityEx.ParamName + " cannot be blank. Please enter a valid value.", SoapException.ClientFaultCode, entityEx);
            }
            catch (DbUpdateException entityEx)
            {
                SqlException sqlException = entityEx.InnerException.InnerException as SqlException;
                if (sqlException != null)
                {
                    string errorMessage = HandleSqlException(sqlException);
                    throw new SoapException(errorMessage, SoapException.ClientFaultCode, sqlException);
                }
                else
                {
                    throw new SoapException("Could not update data while adding. Please contact support.", SoapException.ClientFaultCode, entityEx);
                }
            }
            catch (Exception exc)
            {
                throw new SoapException("Unknown error. Please contact support.", SoapException.ClientFaultCode, exc);
            }
        }   

        [WebMethod]
        public void UpdateEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            try
            {
                dataAccessLayer.UpdateEmployee(no_, first_Name, last_Name, job_Title, address, phone_No_, e_Mail);
            }
            catch (EntityException entityEx)
            {
                SqlException sqlException = entityEx.InnerException as SqlException;
                if (sqlException != null)
                {
                    string errorMessage = HandleSqlException(sqlException);
                    throw new SoapException(errorMessage, SoapException.ClientFaultCode, sqlException);
                }
                else
                {
                    throw new SoapException("Unknown database error. Please contact support.", SoapException.ClientFaultCode, sqlException);
                }
            }
            catch (ArgumentException entityEx)
            {
                throw new SoapException(entityEx.ParamName + " cannot be blank. Please enter a valid value.", SoapException.ClientFaultCode, entityEx);
            }
            catch (DbUpdateException entityEx)
            {
                throw new SoapException("Could not update data while editing. Please contact support.", SoapException.ClientFaultCode, entityEx);
            }
            catch (InvalidOperationException invEx)
            {
                throw new SoapException("No such employee exists. Please select a valid employee number.", SoapException.ClientFaultCode, invEx);
            }
            catch (Exception exc)
            {
                throw new SoapException("Unknown error. Please contact support.", SoapException.ClientFaultCode, exc);
            }
        }

        [WebMethod]
        public void DeleteEmployee(string no_)
        {
            try
            {
                dataAccessLayer.DeleteEmployee(no_);
            }
            catch (EntityException entityEx)
            {
                SqlException sqlException = entityEx.InnerException as SqlException;
                if (sqlException != null)
                {
                    string errorMessage = HandleSqlException(sqlException);
                    throw new SoapException(errorMessage, SoapException.ClientFaultCode, sqlException);
                }
                else
                {
                    throw new SoapException("Unknown database error. Please contact support.", SoapException.ClientFaultCode, sqlException);
                }
            }
            catch (InvalidOperationException invEx)
            {
                throw new SoapException("No such employee exists. Please select a valid employee number.", SoapException.ClientFaultCode, invEx);
            }
            catch (ArgumentNullException argEx)
            {
                throw new SoapException("No employee selected. Please select a valid employee number.", SoapException.ClientFaultCode, argEx);
            }
            catch (DbUpdateException entityEx)
            {
                throw new SoapException("Could not update data while deleting. Please contact support.", SoapException.ClientFaultCode, entityEx);
            }
            catch (Exception exc)
            {
                throw new SoapException("Unknown error. Please contact support.", SoapException.ClientFaultCode, exc);
            }
        }

        //Method to return an error message string for a given SqlException.
        public string HandleSqlException(SqlException sqlException)
        {
            if (sqlException.Number == 2) //No database connection.
            {
                return "Error connecting to database. Please contact support.";
            }
            else if (sqlException.Number == 18456) //Failed login
            {
                return "Login to database failed. Please contact support.";
            }
            else if (sqlException.Number == 2627)//If the employee number already exists.
            {
                return "Employee already exists. Please use another employee number.";
            }
            else if (sqlException.Number == 4060)//If the employee number already exists.
            {
                return "Cannot access database with current login. Please contact support.";
            }
            else
            {
                return "Error connecting to database. Please contact support";
            }
        }

    }
}
