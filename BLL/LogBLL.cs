﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LogBLL
    {
        public static void AddLog(int ProceesType, string TableName, int ProcessID)
        {
            LogDAO.AddLog(ProceesType, TableName, ProcessID);
        }
    }
}
