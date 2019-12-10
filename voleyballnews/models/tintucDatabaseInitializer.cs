using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace voleyballnews.models
{
    public class tintucDatabaseInitializer : DropCreateDatabaseAlways<NOIDUNG>
    {
        protected override void Seed(NOIDUNG context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            Gettintuc().ForEach(p => context.tintuc.Add(p));
        }
        private static List<TACGIA> GetCategories()
        {
            var TACGIA = new List<TACGIA> {
 new TACGIA
 {
 TACGIA_ID = 1,
CategoryName = "Fiction"
 },
 new TACGIA
 {
 TACGIA_ID = 2,
TENTACGIA = "Biographies and Memoirs",
EMAIL = ""
 },
 new TACGIA
 {
 TACGIA_ID = 3,
TENTACGIA = "Biological Sciences",
EMAIL = ""
 },
 new TACGIA
 {
 TACGIA_ID = 4,
TENTACGIA = "Self-Help"
,EMAIL = ""
 }
 };
            return TACGIA;
        }
        private static List<tintuc> Gettintuc()
        {
            var tintuc = new List<tintuc> {
 //book 1
 new tintuc
 {
 TINTUC_ID = 1,
NOIDUNG = "Fire & Blood",
TACGIA = "",
ImagePath = "Pic2.png",
 TACGIA_ID = 1
        },
 //book 2
 new tintuc
 {
TINTUC_ID = 2,
NOIDUNG = "Benjamin Franklin: An American Life",
TACGIA = "",
ImagePath = "Pic2.png",
TACGIA_ID = 2
    },
 //book 3
 new tintuc
 {
 TINTUC_ID = 3,
 NOIDUNG  = "Obama: An Intimate Portrait",
 TACGIA = "",
 ImagePath="Pic3.png",
TACGIA_ID = 2
 },
 //book 4
 new tintuc
 {
 TINTUC_ID = 4,
NOIDUNG = "Sapiens: A Brief History of Humankind",
TACGIA = "",
ImagePath="Pic4.png",
UnitPrice = 23.79f,
TACGIA_ID = 3
 },
 //book 5
 new tintuc
 {
 TINTUC_ID = 5,
NOIDUNG = "The 7 Habits of Highly Effective People",
TACGIA = "",
 ImagePath= "Pic5.png",
UnitPrice = 16.04f,
TACGIA_ID = 4
 },
 };
 return tintuc;
 }
 }
}