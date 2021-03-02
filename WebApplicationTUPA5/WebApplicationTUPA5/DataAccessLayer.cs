using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Services.Protocols;

namespace WebApplicationTUPA5
{
    public class DataAccessLayer
    {
        public List<CRONUS_Sverige_AB_Employee> GetEmployees()
        {
            using (EmployeeEntities entity = new EmployeeEntities())
            {
                try
                {
                    List<CRONUS_Sverige_AB_Employee> employeeList = new List<CRONUS_Sverige_AB_Employee>();
                    employeeList = entity.CRONUS_Sverige_AB_Employee.ToList();
                    //Make all picture properties null before sending
                    foreach (CRONUS_Sverige_AB_Employee tmpEmployee in employeeList)
                    {
                        tmpEmployee.Picture = null;
                    }
                    return employeeList;
                }
                catch (EntityException entityEx)
                {
                    throw entityEx;
                }
                catch(Exception exc)
                {
                    throw exc;
                }
                
            }
        }
        public void AddEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            using (EmployeeEntities entity = new EmployeeEntities())
            {
                if (no_.Trim().Equals("") || first_Name.Trim().Equals("") || last_Name.Trim().Equals("") || job_Title.Trim().Equals("")
                        || address.Trim().Equals("") || phone_No_.Trim().Equals("") || e_Mail.Trim().Equals(""))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    try
                    {
                        CRONUS_Sverige_AB_Employee tmpEmployee = new CRONUS_Sverige_AB_Employee()
                        {
                            timestamp = new byte[1],
                            No_ = no_,
                            First_Name = first_Name,
                            Last_Name = last_Name,
                            Job_Title = job_Title,
                            Address = address,
                            Phone_No_ = phone_No_,
                            E_Mail = e_Mail

                        };



                        //Fill empty values in the rest of the properties, so that they won't be null.
                        foreach (PropertyInfo prop in tmpEmployee.GetType().GetProperties())
                        {
                            if (prop.GetValue(tmpEmployee) == null)
                            {
                                if (prop.PropertyType == typeof(string))
                                {
                                    prop.SetValue(tmpEmployee, " ", null);
                                }

                            }
                            else if (prop.PropertyType == typeof(DateTime))
                            {
                                prop.SetValue(tmpEmployee, DateTime.Now);
                            }
                        }


                        entity.CRONUS_Sverige_AB_Employee.Add(tmpEmployee);
                        entity.SaveChanges();
                    }
                    catch (EntityException entityEx)
                    {
                        throw entityEx;
                    }
                    catch (ArgumentException entityEx)
                    {
                        throw entityEx;
                    }
                    catch (DbUpdateException entityEx)
                    {
                        throw entityEx;
                    }
                    catch (Exception exc)
                    {
                        throw exc;
                    }
                }
            }
        }
        public void UpdateEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            using (EmployeeEntities entity = new EmployeeEntities())
            {
                if (no_.Trim().Equals("") || first_Name.Trim().Equals("") || last_Name.Trim().Equals("") || job_Title.Trim().Equals("")
                        || address.Trim().Equals("") || phone_No_.Trim().Equals("") || e_Mail.Trim().Equals(""))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    try
                    {
                        CRONUS_Sverige_AB_Employee tmpEmployee = entity.CRONUS_Sverige_AB_Employee.Where(e => e.No_ == no_).First();

                        tmpEmployee.First_Name = first_Name;
                        tmpEmployee.Last_Name = last_Name;
                        tmpEmployee.Job_Title = job_Title;
                        tmpEmployee.Address = address;
                        tmpEmployee.Phone_No_ = phone_No_;
                        tmpEmployee.E_Mail = e_Mail;

                        entity.SaveChanges();

                    }
                    catch (EntityException entityEx)
                    {
                        throw entityEx;
                    }
                    catch (ArgumentException entityEx)
                    {
                        throw entityEx;
                    }
                    catch (DbUpdateException entityEx)
                    {
                        throw entityEx;
                    }
                    catch (Exception exc)
                    {
                        throw exc;
                    }
                }
            }
        }
        public void DeleteEmployee(string no_)
        {
            using (EmployeeEntities entity = new EmployeeEntities())
            {
                try
                {
                    CRONUS_Sverige_AB_Employee tmpEmployee = entity.CRONUS_Sverige_AB_Employee.Where(e => e.No_ == no_).First();

                    entity.CRONUS_Sverige_AB_Employee.Remove(tmpEmployee);
                    entity.SaveChanges();
                }
                catch (EntityException entityEx)
                {
                    throw entityEx;
                }
                catch (ArgumentNullException entityEx)
                {
                    throw entityEx;
                }
                catch (DbUpdateException entityEx)
                {
                    throw entityEx;
                }
                catch (Exception exc)
                {
                    throw exc;
                }
            }
            
           
        }
    }
}