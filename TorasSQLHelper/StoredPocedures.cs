using System.Data;
using System.Data.SqlClient;

namespace TorasSQLHelper
{
    public class StoredPocedures
    {
        public static void AddLoginProc(in int CashieID, in string Login, in string Password, out string outputValue1)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var parameters = new[] {
                new SqlParameter("@0", CashieID),
                new SqlParameter("@1", Login),
                new SqlParameter("@2", Password),
                new SqlParameter("@3", SqlDbType.NVarChar) { Direction = ParameterDirection.Output }
            };
                db.ExecuteStoreCommand("exec AddLogin @iD_Cashier = @0, @pLoginName = @1, @pPassword = @2, @responseMessage=@3 output", parameters);
                outputValue1 = (string)parameters[1].Value;
            }
        }

        public static void CheckLoginProc( in string Login, in string Password, out string outputValue1)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var parameters = new[] {
                new SqlParameter("@1", SqlDbType.NVarChar,254){ Value = Login},
                new SqlParameter("@2", SqlDbType.NVarChar,50) { Value = Password},
                new SqlParameter("@3", SqlDbType.NVarChar, 254) { Direction = ParameterDirection.Output }
            };
                var c =  db.ExecuteStoreCommand("exec CheckLogin @pLoginName = @1, @pPassword = @2, @responseMessage=@3 output", parameters);
                outputValue1 = parameters[2].Value.ToString();
            }
        }
    }
}