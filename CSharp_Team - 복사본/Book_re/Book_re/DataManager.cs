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
        public static List<BookRank> rank = new List<BookRank>();

        public static void Load()
        {
            DBHelper.Query_Select();
            rank.Clear();
            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                BookRank temp = new BookRank();
                temp.rank = item["순위"].ToString();
                temp.subject = item["category"].ToString();
                rank.Add(temp);
            }
        }
      public int count_category(string query)
        {
            DBHelper.count(query);
            int count = 0;
            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                count = int.Parse(item["카테고리"].ToString());
            }
            return count;
        }
        public int count_rank(string query)
        {
            DBHelper.count(query);
            int count = 0;
            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                count = int.Parse(item["대출건수"].ToString());
            }
            return count;
        }
    }
}
