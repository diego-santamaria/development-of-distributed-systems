using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WCFServiceCliente.Persistencia
{
    public class ToDataBase
    {
        public static Int32 InsertData(String StoredProcedure, List<SqlParameter> parms, String ConnectionName)
        {
            SqlCommand myCommand = null;
            Int32 affectedRows = 0;
            try
            {
                myCommand = SQLCommands.OpenCommand(StoredProcedure, parms, ConnectionName);
                affectedRows = myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (null != myCommand)
                    myCommand.Parameters.Clear();
                SQLCommands.CloseCommand(ref myCommand);
            }
            return affectedRows;
        }

        public static Int32 UpdateData(String Query, String ConnectionName)
        {
            SqlCommand myCommand = null;
            Int32 affectedRows = 0;
            try
            {
                myCommand = SQLCommands.OpenQueryCommand(Query, ConnectionName);
                affectedRows = myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (null != myCommand)
                    myCommand.Parameters.Clear();
                SQLCommands.CloseCommand(ref myCommand);
            }
            return affectedRows;
        }

        public static DataTable QueryProcedureData(String StoredProcedure, List<SqlParameter> parms, String ConnectionName)
        {
            SqlCommand myCommand = null;
            SqlDataAdapter dAdapter;
            DataSet dSet = new DataSet();
            DataTable dTable = null;

            try
            {
                myCommand = SQLCommands.OpenCommand(StoredProcedure, parms, ConnectionName);
                dAdapter = new SqlDataAdapter(myCommand);
                dAdapter.Fill(dSet);

                dTable = dSet.Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (null != myCommand)
                    myCommand.Parameters.Clear();
                SQLCommands.CloseCommand(ref myCommand);
            }

            return dTable;
        }

        public static DataTable QueryData(String Query, String ConnectionName)
        {
            SqlCommand myCommand = null;
            SqlDataAdapter dAdapter;
            DataSet dSet = new DataSet();
            DataTable dTable = null;

            try
            {
                myCommand = SQLCommands.OpenQueryCommand(Query, ConnectionName);
                dAdapter = new SqlDataAdapter(myCommand);
                dAdapter.Fill(dSet);

                dTable = dSet.Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                if (null != myCommand)
                    myCommand.Parameters.Clear();
                SQLCommands.CloseCommand(ref myCommand);
            }

            return dTable;
        }
    }
}