using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_sys_project
{
    public partial class Form1 : Form
    {
        Manage manage = new Manage();
        int bookingID = 0;
        String task = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_cust_Click(object sender, EventArgs e)
        {
            manage.CustomerInsert(customerName_textBox.Text, customer_phone.Text, customer_address.Text);
            MessageBox.Show("Customer record is stored ");

            cust_id.Text = "";
            customerName_textBox.Text = "";
            customer_address.Text = "";
            customer_phone.Text = "";

        }

        private void del_cust_Click(object sender, EventArgs e)
        {
            manage.CustomerDelete(Convert.ToInt32(cust_id.Text.ToString()));
            MessageBox.Show("customer record is deleted ");

            cust_id.Text = "";
            customerName_textBox.Text = "";
            customer_address.Text = "";
            customer_phone.Text = "";

        }

        private void issue_video_Click(object sender, EventArgs e)
        {
            manage.BookingVideo(cust_id.Text, video_id.Text, dateTime1.Text);
            MessageBox.Show("Movie is booked ");
            cust_id.Text = "";
            customerName_textBox.Text = "";
            customer_address.Text = "";
            customer_phone.Text = "";

            video_id.Text = "";
            video_name.Text = "";
            video_id.Text = "";
            video_name.Text = "";
            video_plot.Text = "";
            video_ratting.Text = "";
            video_real.Text = "";
            video_tot.Text = "";

        }


        private void del_video_Click(object sender, EventArgs e)
        {

            manage.BookingDelete(bookingID);
            MessageBox.Show("Booking record is deleted ");

            cust_id.Text = "";
            customerName_textBox.Text = "";
            customer_address.Text = "";
            customer_phone.Text = "";

            video_name.Text = "";
            video_id.Text = "";
            video_name.Text = "";
            video_plot.Text = "";
            video_ratting.Text = "";
            video_real.Text = "";
            video_tot.Text = "";

            video_id.Text = "";

        }

        private void return_video_Click(object sender, EventArgs e)
        {
            manage.BookingReturn(bookingID, cust_id.Text, video_id.Text, dateTime1.Text, dateTime2.Text);
            
            

            DateTime current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(dateTime1.Text);


            //get the difference in the days fromat
            String Daysdiff = (current_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

            DataTable tbl = new DataTable();

            tbl = manage.CmdRecord("select * from Video where video_ID="+Convert.ToInt32(video_id.Text.ToString())+"");

            int total = Convert.ToInt32(tbl.Rows[0]["Cost"].ToString()) * Convert.ToInt32(DaysInterval);


            MessageBox.Show("Video is returned and payment is ="+total);

            cust_id.Text = "";
            customerName_textBox.Text = "";
            customer_address.Text = "";
            customer_phone.Text = "";

            video_id.Text = "";

            video_name.Text = "";
            video_id.Text = "";
            video_name.Text = "";
            video_plot.Text = "";
            video_ratting.Text = "";
            video_real.Text = "";
            video_tot.Text = "";

        }

        // add videos

        private void add_video_Click(object sender, EventArgs e)
        {
            manage.VideoInsert(video_name.Text, video_ratting.Text, video_real.Text, video_plot.Text, video_tot.Text, video_Cost.Text);
            MessageBox.Show("video is stored ");
            
            video_name.Text = "";
            video_id.Text = "";
            video_name.Text = "";
            video_plot.Text = "";
            video_ratting.Text = "";
            video_real.Text = "";
            video_tot.Text = "";
            
                
        }

        //del videos

        private void del_videos_Click(object sender, EventArgs e)
        {
            manage.VideoDelete(Convert.ToInt32(video_id.Text.ToString()));
            MessageBox.Show("Video record is deleted ");
            video_name.Text = "";
            video_id.Text = "";
            video_name.Text = "";
            video_plot.Text = "";
            video_ratting.Text = "";
            video_real.Text = "";
            video_tot.Text = "";


        }

        // update videos 

        private void update_videos_Click(object sender, EventArgs e)
        {
            manage.VideoEdit(Convert.ToInt32(video_id.Text),video_name.Text, video_ratting.Text, video_real.Text, video_plot.Text, video_tot.Text, video_Cost.Text);
            MessageBox.Show("video is Updated  ");

            video_name.Text = "";
            video_id.Text = "";
            video_name.Text = "";
            video_plot.Text = "";
            video_ratting.Text = "";
            video_real.Text = "";
            video_tot.Text = "";

        }

        // customer record

        private void rec_customer_Click(object sender, EventArgs e)
        {
            task = "1";
            DataTable tbl = new DataTable();
            tbl = manage.CmdRecord("select * from Customer");
            dataGridView1.DataSource = tbl;
        }

        // video record show

        private void rec_video_Click(object sender, EventArgs e)
        {

            task = "2";
            DataTable tbl = new DataTable();
            tbl = manage.CmdRecord("select * from Video");
            dataGridView1.DataSource = tbl;
        }

        private void rec_rental_Click(object sender, EventArgs e)
        {
            task = "3";
            DataTable tbl = new DataTable();
            tbl = manage.CmdRecord("select * from Booking");
            dataGridView1.DataSource = tbl;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (task.Equals("1")) {
                cust_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                customerName_textBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                customer_phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                customer_address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }

            if (task.Equals("2"))
            {
                video_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                video_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                video_ratting.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                video_real.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                video_tot.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                video_plot.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                video_Cost.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }

            if (task.Equals("3"))
            {
                bookingID =Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cust_id.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                video_id.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTime1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }




            task = "";
        }

        // price according to year 

        private void video_real_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(video_real.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                video_Cost.Text = "" + cost;
            }
            catch (Exception ex)
            {

            }
        }

        // onclick event of update customer

        private void update_cust_Click(object sender, EventArgs e)
        {
            manage.CustomerEdit(Convert.ToInt32(cust_id.Text), customerName_textBox.Text, customer_phone.Text, customer_address.Text);
            MessageBox.Show("Customer Record is Updated ");

            customerName_textBox.Text = "";
            customer_address.Text = "";
            customer_phone.Text = "";
            cust_id.Text = "";

        }

        // best customer clicked and working defined 

        private void cust_best_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable tblvideo = new DataTable();
            tblvideo = manage.CmdRecord("select * from Customer");


            for (x = 0; x < tblvideo.Rows.Count; x++)
            {
                DataTable tblrentl = new DataTable();

                tblvideo = manage.CmdRecord("select * from Booking where cust_ID=" + Convert.ToInt32(tblvideo.Rows[x]["cust_ID"]) + "");


                if (tblrentl.Rows.Count > cunt)
                {

                    Title = tblvideo.Rows[x]["Name"].ToString();
                    cunt = tblrentl.Rows.Count;

                }

            }


            MessageBox.Show("Title of Best Customer  goes to   " + Title);


        }

        private void movie_best_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, cunt = 0;
            String Title = "";

            DataTable tblvideo = new DataTable();
            tblvideo= manage.CmdRecord("select * from Video");


            for (x = 0; x < tblvideo.Rows.Count; x++)
            {
                DataTable tblrentl = new DataTable();

                tblvideo = manage.CmdRecord("select * from Booking where mov_ID=" + Convert.ToInt32(tblvideo.Rows[x]["video_ID"]) + "");

               
                if (tblrentl.Rows.Count > cunt)
                {

                    Title = tblvideo.Rows[x]["Title"].ToString();
                    cunt = tblrentl.Rows.Count;

                }

            }


            MessageBox.Show("Title of Best Video goes to " + Title);



        }
    }
}
