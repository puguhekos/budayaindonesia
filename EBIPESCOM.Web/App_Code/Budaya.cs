using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Summary description for Budaya
/// </summary>
namespace DataBudaya.Models
{
   
    public class Budaya
    {
        public int id_budaya { get; set; }
        public string nama_budaya { get; set; }
        public string provinsi { get; set; }
        public string jenis_budaya { get; set; }
        public string ket { get; set; }
        public string ket_img { get; set; }
        public string sumber { get; set; }
        public byte[] image { get; set; }
        public string file_path { get; set; }

    }
}
