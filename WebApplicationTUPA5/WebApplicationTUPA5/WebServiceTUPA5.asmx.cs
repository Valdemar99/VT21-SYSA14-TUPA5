using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
            return dataAccessLayer.GetEmployees();
        }

        [WebMethod]
        public void AddEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            dataAccessLayer.AddEmployee(no_, first_Name, last_Name, job_Title, address, phone_No_, e_Mail);
        }

        [WebMethod]
        public void UpdateEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            dataAccessLayer.UpdateEmployee(no_, first_Name, last_Name, job_Title, address, phone_No_, e_Mail);
        }

        [WebMethod]
        public void DeleteEmployee(string no_)
        {
            dataAccessLayer.DeleteEmployee(no_);
        }

    }
}
