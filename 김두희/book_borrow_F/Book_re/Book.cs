using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }   // 제목
        public string Author { get; set; }  // 저자
        public string Publisher { get; set; }   // 출판사(발행자)
        public string Year { get; set; }   // 발행연도



        public bool IsBorrowed { get; set; }    //대여 가능 확인
        public string RentDate { set; get; }    //대여일
        public string ReturnPlanDate { set; get; }  //반납예정일
        public string ReturnDate { set; get; }     //반납일

    }
}
