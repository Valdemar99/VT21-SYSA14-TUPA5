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
                    if (sqlException.Number == 2)
                    {
                        throw new SoapException("Error connecting to database. Please contact support.", SoapException.ClientFaultCode, sqlException);
                    }
                }
                else
                {
                    throw new SoapException("Unknown database error. Please contact support.", SoapException.ClientFaultCode, sqlException);
                }
            }
            catch (Exception exc)
            {
                throw new SoapException(exc.Message, SoapException.ClientFaultCode, exc);
            }
            return null;
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
                    if (sqlException.Number == 2)
                    {
                        throw new SoapException("Error connecting to database. Please contact support.", SoapException.ClientFaultCode, sqlException);
                    }
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
                throw new SoapException(entityEx.Message, SoapException.ClientFaultCode, entityEx);
            }
            catch (Exception exc)
            {
                throw new SoapException(exc.Message, SoapException.ClientFaultCode, exc);
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
                    if (sqlException.Number == 2)
                    {
                        throw new SoapException("Error connecting to database. Please contact support.", SoapException.ClientFaultCode, sqlException);
                    }
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
                throw new SoapException(entityEx.Message, SoapException.ClientFaultCode, entityEx);
            }
            catch (Exception exc)
            {
                throw new SoapException(exc.Message, SoapException.ClientFaultCode, exc);
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
                    if (sqlException.Number == 2)
                    {
                        throw new SoapException("Error connecting to database. Please contact support.", SoapException.ClientFaultCode, sqlException);
                    }
                }
                else
                {
                    throw new SoapException("Unknown database error. Please contact support.", SoapException.ClientFaultCode, sqlException);
                }
            }
            catch (ArgumentException entityEx)
            {
                throw new SoapException(entityEx.Message, SoapException.ClientFaultCode, entityEx);
            }
            catch (DbUpdateException entityEx)
            {
                throw new SoapException(entityEx.Message, SoapException.ClientFaultCode, entityEx);
            }
            catch (Exception exc)
            {
                throw new SoapException(exc.Message, SoapException.ClientFaultCode, exc);
            }
        }

    }
}
