using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assmain.Models
{
    public class Student
    {
        public int MaSinhVien { get; set; }
        public string HìnhThức  { get; set; }
        public int Money { get; set; }
        public DateTime NgayNopPhat
        {
            get { return DateTime.Now;}
        }

    }
}