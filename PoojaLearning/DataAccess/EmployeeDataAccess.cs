using PoojaLearning.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PoojaLearning.DataAccess
{
    public class EmployeeDataAccess
    {
        public void UpsertEmployee(Employee emp)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=WIN-KP5IGXUEZZ;Initial Catalog=AdventureWorks2019;Integrated Security=SSPI");
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("dbo.UpsertEmployee", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@FirstName", emp.Firstname);
            sqlCmd.Parameters.AddWithValue("@LastName", emp.Lastname);
            sqlCmd.Parameters.AddWithValue("@Gender", emp.Gender);
            sqlCmd.Parameters.AddWithValue("@Age", emp.Age);
            sqlCmd.Parameters.AddWithValue("@Race", emp.Race);
            sqlCmd.Parameters.AddWithValue("@BirthDate", emp.DateOfBirth);
            sqlCmd.ExecuteNonQuery();
            sqlConn.Close();
        }
        public Employee GetEmployee(int empId)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=WIN-KP5IGXUEZZ;Initial Catalog=AdventureWorks2019;Integrated Security=SSPI");
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("dbo.GetEmployeeById", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@EmpId", empId);
            SqlDataReader sdr = sqlCmd.ExecuteReader();
            Employee emp;
            if (sdr.Read())
            {
                emp = new Employee();
                if (sdr["FirstName"] != DBNull.Value)
                {
                    emp.Firstname = sdr["FirstName"].ToString();
                }
                if (sdr["LastName"] != DBNull.Value)
                {
                    emp.Lastname = sdr["LastName"].ToString();
                }
                if (sdr["Gender"] != DBNull.Value)
                {
                    emp.Gender = sdr["Gender"].ToString();
                }
                if (sdr["Age"] != DBNull.Value)
                {
                    emp.Age = (int)sdr["Age"];
                }
                if (sdr["Race"] != DBNull.Value)
                {
                    emp.Race = sdr["Race"].ToString();
                }
                if (sdr["DateOfBirth"] != DBNull.Value)
                {
                    emp.DateOfBirth = (DateTime)sdr["DateOfBirth"];
                }
                sqlConn.Close();
                sdr.Close();
                return emp;
            }
            else
            {
                sqlConn.Close();
                sdr.Close();
                return null;
            }




        }


        public Employee GetEmployeeByName(string empName)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=WIN-KP5IGXUEZZ;Initial Catalog=AdventureWorks2019;Integrated Security=SSPI");
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("dbo.GetEmployeeByName", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@EmpName", empName);
            SqlDataReader sdr = sqlCmd.ExecuteReader();
            Employee emp;
            if (sdr.Read())
            {
                emp = new Employee();
                if (sdr["FirstName"] != DBNull.Value)
                {
                    emp.Firstname = sdr["FirstName"].ToString();
                }
                if (sdr["LastName"] != DBNull.Value)
                {
                    emp.Lastname = sdr["LastName"].ToString();
                }
                if (sdr["Gender"] != DBNull.Value)
                {
                    emp.Gender = sdr["Gender"].ToString();
                }
                if (sdr["Age"] != DBNull.Value)
                {
                    emp.Age = (int)sdr["Age"];
                }
                if (sdr["Race"] != DBNull.Value)
                {
                    emp.Race = sdr["Race"].ToString();
                }
                if (sdr["DateOfBirth"] != DBNull.Value)
                {
                    emp.DateOfBirth = (DateTime)sdr["DateOfBirth"];
                }
                sqlConn.Close();
                sdr.Close();
                return emp;
            }
            else
            {
                sqlConn.Close();
                sdr.Close();
                return null;
            }




        }



    }
}