using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_sys_project
{
   public class Manage
    {

        
        public SqlConnection conn;

        // setting connection with database through string
        public String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=Rental_Sys;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        public SqlCommand cmd;

        //data reader is used to read thedata from the database table 
        public SqlDataReader DReader;

        public DataTable CmdRecord(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(conStr);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }


        //here this code is used to insert the  data into the table 
        public void CustomerInsert(String Name, String Contact, String Address)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "insert into Customer(Name,Contact,Address)values(@Name,@Contact,@Address)";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.ExecuteNonQuery();
            conn.Close();

        }


        
        public void CustomerDelete(int cust_ID)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "delete  from Customer where cust_ID=@cust_ID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@cust_ID", cust_ID);
            
            
            cmd.ExecuteNonQuery();
            conn.Close();

        }


        //here this code is used to insert the  data into the table 
        public void CustomerEdit(int cust_ID,String Name, String Contact, String Address)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "update Customer set Name=@Name,Contact=@Contact,Address=@Address  where cust_ID=@cust_ID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@cust_ID", cust_ID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Contact", Contact);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        //boooking here 
        public void BookingVideo(String cust_ID, String mov_ID, String issueDt)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "insert into Booking(cust_ID,mov_ID,issueDt,returnDt)values(@cust_ID,@mov_ID,@issueDt,@returnDt)";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@cust_ID", cust_ID);
            cmd.Parameters.AddWithValue("@mov_ID", mov_ID);
            cmd.Parameters.AddWithValue("@issueDt", issueDt);
            cmd.Parameters.AddWithValue("@returnDt", "Booked");


            cmd.ExecuteNonQuery();
            conn.Close();

        }


        //boooking here 
        public void BookingReturn(int bookID,String cust_ID, String mov_ID, String issueDt,String returnDt)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "update Booking set cust_ID=@cust_ID,mov_ID=@mov_ID,issueDt=@issueDt,returnDt=@returnDt where book_ID=@book_ID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@book_ID", bookID);
            cmd.Parameters.AddWithValue("@cust_ID", cust_ID);
            cmd.Parameters.AddWithValue("@mov_ID", mov_ID);
            cmd.Parameters.AddWithValue("@issueDt", issueDt);
            cmd.Parameters.AddWithValue("@returnDt", returnDt);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void BookingDelete(int book_ID)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "delete  from Booking where book_ID=@book_ID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@book_ID", book_ID);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void VideoInsert(String title, String ratting, String year,String total, String plot, String cost)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "insert into Video(Title,Ratting,Year,Total,Plot,Cost)values(@title,@ratting,@year,@total,@plot,@cost)";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@ratting",ratting );
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@plot", plot);

            cmd.Parameters.AddWithValue("@cost", cost);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void VideoDelete(int Video_ID)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "delete from Video where video_ID=@video_ID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@video_ID", Video_ID);
            
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void VideoEdit(int Video_ID,String title, String ratting, String year, String total, String plot, String cost)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            String query = "update Video set Title=@title,Ratting=@ratting,Year=@year,Total=@total,Plot=@plot,Cost=@cost where video_ID=@video_ID";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@video_ID", Video_ID);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@ratting", ratting);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@plot", plot);

            cmd.Parameters.AddWithValue("@cost", cost);


            cmd.ExecuteNonQuery();
            conn.Close();

        }



    }
}
