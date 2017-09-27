using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace CoreCrud.Data
{
    public class SQLHelper
    {
        /// <summary>
        /// 
        /// </summary>
        static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConSTR"].ToString();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataset(string StoreProcedureName, CommandType commandType)
        {
            SqlConnection con = new SqlConnection(constr);
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand(StoreProcedureName, con))
                {
                    cmd.CommandType = commandType;
                    //cmd.CommandTimeout=300
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        con.Dispose();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>

        /// <returns></returns>
        public static DataTable ExecuteDataTable(string StoreProcedureName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {

                try
                {
                    using (SqlCommand cmd = new SqlCommand(StoreProcedureName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }
                        con.Dispose();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {


                }
                finally
                {
                    con.Close();
                }
            }
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string StoreProcedureName, CommandType commandType)
        {
            SqlConnection con = new SqlConnection(constr);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(StoreProcedureName, con);
                cmd.CommandType = commandType;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Dispose();
                con.Close();
                da.Fill(dt);
            }
            catch (Exception ex)
            {


            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <param name="con"></param>
        /// <param name="SqlParamet Arrays"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataset(string StoreProcedureName, SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(constr);
            DataSet ds = new DataSet();
            try
            {
                using (SqlCommand cmd = new SqlCommand(StoreProcedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(param);
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {

                        da.Fill(ds);
                        con.Dispose();
                        con.Close();
                    }

                }

            }
            catch (Exception ex)
            {


            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <param name="con"></param>
        /// <param name="SqlParamet Arrays"></param>
        /// <returns></returns>
        public DataSet ExecuteDataset(string StoreProcedureName, CommandType commandType, SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(constr);
            DataSet ds = new DataSet();
            try
            {
                SqlCommand cmd = new SqlCommand(StoreProcedureName, con);
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(param);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Dispose();
                con.Close();
                da.Fill(ds);
            }
            catch (Exception ex)
            {


            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string StoreProcedureName, CommandType commandType, SqlParameter[] param)
        {
            SqlConnection con = new SqlConnection(constr);
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(StoreProcedureName, con);
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(param);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Dispose();
                con.Close();
                da.Fill(dt);
            }
            catch (Exception ex)
            {


            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string StoreProcedureName, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {

                try
                {
                    using (SqlCommand cmd = new SqlCommand(StoreProcedureName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(param);
                        con.Open();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {

                            da.Fill(dt);
                        }
                        con.Dispose();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {


                }
                finally
                {
                    con.Close();
                }
            }
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static int ExecuteQuery(string StoreProcedureName)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {

                try
                {
                    using (SqlCommand cmd = new SqlCommand(StoreProcedureName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                        con.Dispose();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int ExecuteQuery(string StoreProcedureName, SqlParameter[] param)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(StoreProcedureName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(param);
                        con.Open();
                        result = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {


                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="StoreProcedureName"></param>
        /// <param name="commandType"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object ExecuteScalerQuery(string StoreProcedureName, SqlParameter[] param)
        {
            object result = 0;
            using (SqlConnection con = new SqlConnection(constr))
            {

                try
                {
                    using (SqlCommand cmd = new SqlCommand(StoreProcedureName, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(param);
                        con.Open();
                        result = cmd.ExecuteScalar();
                        con.Dispose();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {


                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }
    }
}