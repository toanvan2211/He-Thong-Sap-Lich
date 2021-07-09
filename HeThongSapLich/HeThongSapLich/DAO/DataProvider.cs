using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongSapLich.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = @"Data Source=.\sqlexpress;Initial Catalog=SapLich;Integrated Security=True";

        public void createConnectSTR(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                connectionSTR = @"Data Source=.\SQLEXPRESS; AttachDbFilename=" + filePath + ";Integrated Security=True;Connect Timeout=30;User Instance=True";
            }
        }

        public DataTable ExecuteQuery(string Lenh, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection ketnoi = new SqlConnection(connectionSTR))
            {
                ketnoi.Open();

                SqlCommand command = new SqlCommand(Lenh, ketnoi);

                if (parameter != null)
                {
                    string[] listpara = Lenh.Split(' ');
                    int i = 0;
                    foreach(string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter ap = new SqlDataAdapter(command);

                ap.Fill(data);

                ketnoi.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string Lenh, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection ketnoi = new SqlConnection(connectionSTR))
            {
                ketnoi.Open();

                SqlCommand command = new SqlCommand(Lenh, ketnoi);

                if (parameter != null)
                {
                    string[] listpara = Lenh.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                ketnoi.Close();
            }

            return data;
        }

        public object ExecuteScalar(string Lenh, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection ketnoi = new SqlConnection(connectionSTR))
            {
                ketnoi.Open();

                SqlCommand command = new SqlCommand(Lenh, ketnoi);

                if (parameter != null)
                {
                    string[] listpara = Lenh.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                ketnoi.Close();
            }

            return data;
        }

    }
}
