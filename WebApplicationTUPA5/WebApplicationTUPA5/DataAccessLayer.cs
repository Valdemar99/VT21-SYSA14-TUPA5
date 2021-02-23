﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApplicationTUPA5
{
    public class DataAccessLayer
    {
        public List<CRONUS_Sverige_AB_Employee> GetEmployees()
        {
            using (TUPA5Entities entity = new TUPA5Entities())
            {
                List<CRONUS_Sverige_AB_Employee> tmpEmployee = entity.CRONUS_Sverige_AB_Employee.ToList();
                return tmpEmployee;
            }
        }
        public void AddEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            using (TUPA5Entities entity = new TUPA5Entities())
            {
                CRONUS_Sverige_AB_Employee tmpEmployee = new CRONUS_Sverige_AB_Employee()
                {
                    timestamp = default,
                    No_ = no_,
                    First_Name = first_Name,
                    Last_Name = last_Name,
                    Job_Title = job_Title,
                    Address = address,
                    Phone_No_ = phone_No_,
                };

                //Fill empty values in the rest of the properties, so that they won't be null.
                foreach (PropertyInfo prop in tmpEmployee.GetType().GetProperties())
                {
                    if (prop.GetValue(tmpEmployee) == null)
                    {
                        prop.SetValue(tmpEmployee, "");
                    }
                }

                entity.CRONUS_Sverige_AB_Employee.Add(tmpEmployee);
                entity.SaveChanges();

            }
        }
        public void UpdateEmployee(string no_, string first_Name, string last_Name, string job_Title, string address, string phone_No_, string e_Mail)
        {
            using (TUPA5Entities entity = new TUPA5Entities())
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
        }
        public void DeleteEmployee(string no_)
        {
            using (TUPA5Entities entity = new TUPA5Entities())
            {
                CRONUS_Sverige_AB_Employee tmpEmployee = entity.CRONUS_Sverige_AB_Employee.Where(e => e.No_ == no_).First();

                entity.CRONUS_Sverige_AB_Employee.Remove(tmpEmployee);
                entity.SaveChanges();

            }
        }
    }
}