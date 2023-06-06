using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DTO;
namespace DAL
{
    public class LogDAO : PostContext
    {
        public static void AddLog(int ProceesType, string TableName, int ProcessID)
        {
            E_Log_Table log = new E_Log_Table();
            //Object create the E_Log_table to the database
            log.UserID = UserStatic.UserID;
            log.ProcessType = ProceesType;
            log.ProcessID = ProcessID;
            log.ProcessCategoryType = TableName;
            log.ProcessDate = DateTime.Now;
            log.IPAdress = HttpContext.Current.Request.UserHostAddress;//Get the IP addressfrom to current Host User.
            Db.E_Log_Table.Add(log);//Add data into used of db in to E_Log_table
            Db.SaveChanges();//Applied the changed.
        }
    }
}
