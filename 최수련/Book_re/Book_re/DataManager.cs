using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{
    class DataManager
    {
        public static List<SearchBook> searchbooks = new List<SearchBook>();
        public static string LoginDone { get; set; }

        public void Load(string bname)
        {
            DBHelper.SearchBname(bname);
            searchbooks.Clear();

            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                SearchBook temp = new SearchBook();
                temp.bName = item["BNAME"].ToString();
                temp.controllNum = item["CONTROLNUMBER"].ToString();
                temp.author = item["AUTHOR"].ToString();
                temp.publisher = item["PUBLISHER"].ToString();
                temp.isbn = item["ISBN"].ToString();
                temp.category = item["CATEGORY"].ToString();
                temp.pYear = item["PYEAR"].ToString();
                searchbooks.Add(temp);
            }
        }

        public void Rent(string pid, string bid)
        {
            DBHelper.RentBook(pid, bid);
        }

    }
}
