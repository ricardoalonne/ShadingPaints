﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAO;

namespace CTR
{
    public class CTR_CM
    {
        DAO_CM objDAO_CM;
        public CTR_CM()
        {
            objDAO_CM = new DAO_CM();
        }
        public DataTable CTR_SelectDemandaXColorYMes()
        {
            return objDAO_CM.SelectDemandaXColorYMes();
        }
            
    }
}
