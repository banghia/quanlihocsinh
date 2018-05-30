﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DTO
{
   public class MonHoc
    {
       public string MaMon { get; set; }
       public string TenMon { get; set; }
       public int SoTiet { get; set; }

       public MonHoc() { }

       public MonHoc(string MaMon, string tenMon, int SoTiet)
       {
           this.MaMon = MaMon;
           this.TenMon = TenMon;
           this.SoTiet = SoTiet;
       }

       public MonHoc(DataRow row) {
           this.MaMon = row["MaMon"].ToString();
           this.TenMon = row["TenMon"].ToString();
           this.SoTiet = Int32.Parse(row["SoTiet"].ToString());
       }
    }
}
