
namespace Rental_sys_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.movie_best = new System.Windows.Forms.Button();
            this.cust_best = new System.Windows.Forms.Button();
            this.rec_rental = new System.Windows.Forms.Button();
            this.rec_video = new System.Windows.Forms.Button();
            this.rec_customer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.del_videos = new System.Windows.Forms.Button();
            this.update_videos = new System.Windows.Forms.Button();
            this.add_video = new System.Windows.Forms.Button();
            this.video_Cost = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.video_plot = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.del_video = new System.Windows.Forms.Button();
            this.return_video = new System.Windows.Forms.Button();
            this.issue_video = new System.Windows.Forms.Button();
            this.del_cust = new System.Windows.Forms.Button();
            this.update_cust = new System.Windows.Forms.Button();
            this.add_cust = new System.Windows.Forms.Button();
            this.video_tot = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.video_real = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.video_ratting = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.video_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.video_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.customer_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerName_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_best
            // 
            this.movie_best.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_best.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movie_best.Location = new System.Drawing.Point(918, 585);
            this.movie_best.Name = "movie_best";
            this.movie_best.Size = new System.Drawing.Size(132, 33);
            this.movie_best.TabIndex = 91;
            this.movie_best.Text = "Best  Movie";
            this.movie_best.UseVisualStyleBackColor = true;
            this.movie_best.Click += new System.EventHandler(this.movie_best_Click);
            // 
            // cust_best
            // 
            this.cust_best.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_best.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cust_best.Location = new System.Drawing.Point(798, 585);
            this.cust_best.Name = "cust_best";
            this.cust_best.Size = new System.Drawing.Size(114, 33);
            this.cust_best.TabIndex = 90;
            this.cust_best.Text = "Best Customer";
            this.cust_best.UseVisualStyleBackColor = true;
            this.cust_best.Click += new System.EventHandler(this.cust_best_Click);
            // 
            // rec_rental
            // 
            this.rec_rental.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec_rental.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rec_rental.Location = new System.Drawing.Point(1056, 529);
            this.rec_rental.Name = "rec_rental";
            this.rec_rental.Size = new System.Drawing.Size(118, 33);
            this.rec_rental.TabIndex = 89;
            this.rec_rental.Text = "Rental Rec";
            this.rec_rental.UseVisualStyleBackColor = true;
            this.rec_rental.Click += new System.EventHandler(this.rec_rental_Click);
            // 
            // rec_video
            // 
            this.rec_video.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec_video.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rec_video.Location = new System.Drawing.Point(918, 529);
            this.rec_video.Name = "rec_video";
            this.rec_video.Size = new System.Drawing.Size(132, 33);
            this.rec_video.TabIndex = 88;
            this.rec_video.Text = "Videos Rec";
            this.rec_video.UseVisualStyleBackColor = true;
            this.rec_video.Click += new System.EventHandler(this.rec_video_Click);
            // 
            // rec_customer
            // 
            this.rec_customer.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec_customer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rec_customer.Location = new System.Drawing.Point(798, 529);
            this.rec_customer.Name = "rec_customer";
            this.rec_customer.Size = new System.Drawing.Size(114, 33);
            this.rec_customer.TabIndex = 87;
            this.rec_customer.Text = "Customer Rec";
            this.rec_customer.UseVisualStyleBackColor = true;
            this.rec_customer.Click += new System.EventHandler(this.rec_customer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Blue;
            this.dataGridView1.Location = new System.Drawing.Point(39, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 257);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // del_videos
            // 
            this.del_videos.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_videos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_videos.Location = new System.Drawing.Point(1056, 453);
            this.del_videos.Name = "del_videos";
            this.del_videos.Size = new System.Drawing.Size(118, 33);
            this.del_videos.TabIndex = 85;
            this.del_videos.Text = "Delete Video";
            this.del_videos.UseVisualStyleBackColor = true;
            this.del_videos.Click += new System.EventHandler(this.del_videos_Click);
            // 
            // update_videos
            // 
            this.update_videos.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_videos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_videos.Location = new System.Drawing.Point(918, 453);
            this.update_videos.Name = "update_videos";
            this.update_videos.Size = new System.Drawing.Size(132, 33);
            this.update_videos.TabIndex = 84;
            this.update_videos.Text = "Update Video";
            this.update_videos.UseVisualStyleBackColor = true;
            this.update_videos.Click += new System.EventHandler(this.update_videos_Click);
            // 
            // add_video
            // 
            this.add_video.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_video.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_video.Location = new System.Drawing.Point(798, 453);
            this.add_video.Name = "add_video";
            this.add_video.Size = new System.Drawing.Size(114, 33);
            this.add_video.TabIndex = 83;
            this.add_video.Text = "Add Video";
            this.add_video.UseVisualStyleBackColor = true;
            this.add_video.Click += new System.EventHandler(this.add_video_Click);
            // 
            // video_Cost
            // 
            this.video_Cost.Enabled = false;
            this.video_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_Cost.Location = new System.Drawing.Point(1015, 396);
            this.video_Cost.Name = "video_Cost";
            this.video_Cost.Size = new System.Drawing.Size(159, 35);
            this.video_Cost.TabIndex = 82;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(819, 396);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 29);
            this.label17.TabIndex = 81;
            this.label17.Text = "Cost:";
            // 
            // video_plot
            // 
            this.video_plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_plot.Location = new System.Drawing.Point(1015, 343);
            this.video_plot.Name = "video_plot";
            this.video_plot.Size = new System.Drawing.Size(159, 35);
            this.video_plot.TabIndex = 80;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(819, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 29);
            this.label16.TabIndex = 79;
            this.label16.Text = "Plot Videos :";
            // 
            // del_video
            // 
            this.del_video.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_video.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_video.Location = new System.Drawing.Point(681, 343);
            this.del_video.Name = "del_video";
            this.del_video.Size = new System.Drawing.Size(118, 33);
            this.del_video.TabIndex = 78;
            this.del_video.Text = "Delete";
            this.del_video.UseVisualStyleBackColor = true;
            this.del_video.Click += new System.EventHandler(this.del_video_Click);
            // 
            // return_video
            // 
            this.return_video.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_video.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.return_video.Location = new System.Drawing.Point(543, 343);
            this.return_video.Name = "return_video";
            this.return_video.Size = new System.Drawing.Size(132, 33);
            this.return_video.TabIndex = 77;
            this.return_video.Text = "Return";
            this.return_video.UseVisualStyleBackColor = true;
            this.return_video.Click += new System.EventHandler(this.return_video_Click);
            // 
            // issue_video
            // 
            this.issue_video.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_video.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.issue_video.Location = new System.Drawing.Point(423, 343);
            this.issue_video.Name = "issue_video";
            this.issue_video.Size = new System.Drawing.Size(114, 33);
            this.issue_video.TabIndex = 76;
            this.issue_video.Text = "Issue";
            this.issue_video.UseVisualStyleBackColor = true;
            this.issue_video.Click += new System.EventHandler(this.issue_video_Click);
            // 
            // del_cust
            // 
            this.del_cust.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_cust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.del_cust.Location = new System.Drawing.Point(111, 347);
            this.del_cust.Name = "del_cust";
            this.del_cust.Size = new System.Drawing.Size(145, 33);
            this.del_cust.TabIndex = 75;
            this.del_cust.Text = "Delete Customer";
            this.del_cust.UseVisualStyleBackColor = true;
            this.del_cust.Click += new System.EventHandler(this.del_cust_Click);
            // 
            // update_cust
            // 
            this.update_cust.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_cust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update_cust.Location = new System.Drawing.Point(215, 291);
            this.update_cust.Name = "update_cust";
            this.update_cust.Size = new System.Drawing.Size(132, 33);
            this.update_cust.TabIndex = 74;
            this.update_cust.Text = "Update Customer";
            this.update_cust.UseVisualStyleBackColor = true;
            this.update_cust.Click += new System.EventHandler(this.update_cust_Click);
            // 
            // add_cust
            // 
            this.add_cust.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_cust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add_cust.Location = new System.Drawing.Point(32, 291);
            this.add_cust.Name = "add_cust";
            this.add_cust.Size = new System.Drawing.Size(114, 33);
            this.add_cust.TabIndex = 73;
            this.add_cust.Text = "Add Customer";
            this.add_cust.UseVisualStyleBackColor = true;
            this.add_cust.Click += new System.EventHandler(this.add_cust_Click);
            // 
            // video_tot
            // 
            this.video_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_tot.Location = new System.Drawing.Point(1015, 295);
            this.video_tot.Name = "video_tot";
            this.video_tot.Size = new System.Drawing.Size(159, 35);
            this.video_tot.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(819, 295);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 29);
            this.label14.TabIndex = 71;
            this.label14.Text = "Total Videos :";
            // 
            // video_real
            // 
            this.video_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_real.Location = new System.Drawing.Point(1015, 241);
            this.video_real.Name = "video_real";
            this.video_real.Size = new System.Drawing.Size(159, 35);
            this.video_real.TabIndex = 70;
            this.video_real.TextChanged += new System.EventHandler(this.video_real_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(819, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 29);
            this.label15.TabIndex = 69;
            this.label15.Text = "Video Realsed  :";
            // 
            // video_ratting
            // 
            this.video_ratting.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_ratting.Location = new System.Drawing.Point(1015, 187);
            this.video_ratting.Name = "video_ratting";
            this.video_ratting.Size = new System.Drawing.Size(159, 35);
            this.video_ratting.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(819, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 29);
            this.label12.TabIndex = 67;
            this.label12.Text = "Video Ratting :";
            // 
            // video_name
            // 
            this.video_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_name.Location = new System.Drawing.Point(1015, 133);
            this.video_name.Name = "video_name";
            this.video_name.Size = new System.Drawing.Size(159, 35);
            this.video_name.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(819, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 29);
            this.label13.TabIndex = 65;
            this.label13.Text = "Video Name :";
            // 
            // dateTime2
            // 
            this.dateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime2.Location = new System.Drawing.Point(591, 304);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(200, 20);
            this.dateTime2.TabIndex = 64;
            // 
            // dateTime1
            // 
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime1.Location = new System.Drawing.Point(591, 246);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(200, 20);
            this.dateTime1.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 29);
            this.label10.TabIndex = 62;
            this.label10.Text = "Return DT :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(403, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 29);
            this.label11.TabIndex = 61;
            this.label11.Text = "Issue DT :";
            // 
            // video_id
            // 
            this.video_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.video_id.Location = new System.Drawing.Point(591, 184);
            this.video_id.Name = "video_id";
            this.video_id.Size = new System.Drawing.Size(159, 35);
            this.video_id.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "Video ID :";
            // 
            // cust_id
            // 
            this.cust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_id.Location = new System.Drawing.Point(591, 127);
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(159, 35);
            this.cust_id.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(403, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 29);
            this.label9.TabIndex = 57;
            this.label9.Text = "Customer ID :";
            // 
            // customer_address
            // 
            this.customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address.Location = new System.Drawing.Point(215, 231);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(159, 35);
            this.customer_address.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 29);
            this.label7.TabIndex = 55;
            this.label7.Text = "Customer Address :";
            // 
            // customer_phone
            // 
            this.customer_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone.Location = new System.Drawing.Point(215, 179);
            this.customer_phone.Name = "customer_phone";
            this.customer_phone.Size = new System.Drawing.Size(159, 35);
            this.customer_phone.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Customer Phone :";
            // 
            // customerName_textBox
            // 
            this.customerName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_textBox.Location = new System.Drawing.Point(215, 127);
            this.customerName_textBox.Name = "customerName_textBox";
            this.customerName_textBox.Size = new System.Drawing.Size(159, 35);
            this.customerName_textBox.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Customer Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(882, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 45);
            this.label3.TabIndex = 48;
            this.label3.Text = "Videos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 45);
            this.label2.TabIndex = 47;
            this.label2.Text = "Rentals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 45);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1200, 662);
            this.Controls.Add(this.movie_best);
            this.Controls.Add(this.cust_best);
            this.Controls.Add(this.rec_rental);
            this.Controls.Add(this.rec_video);
            this.Controls.Add(this.rec_customer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.del_videos);
            this.Controls.Add(this.update_videos);
            this.Controls.Add(this.add_video);
            this.Controls.Add(this.video_Cost);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.video_plot);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.del_video);
            this.Controls.Add(this.return_video);
            this.Controls.Add(this.issue_video);
            this.Controls.Add(this.del_cust);
            this.Controls.Add(this.update_cust);
            this.Controls.Add(this.add_cust);
            this.Controls.Add(this.video_tot);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.video_real);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.video_ratting);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.video_name);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.video_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.customer_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerName_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button movie_best;
        private System.Windows.Forms.Button cust_best;
        private System.Windows.Forms.Button rec_rental;
        private System.Windows.Forms.Button rec_video;
        private System.Windows.Forms.Button rec_customer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button del_videos;
        private System.Windows.Forms.Button update_videos;
        private System.Windows.Forms.Button add_video;
        private System.Windows.Forms.TextBox video_Cost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox video_plot;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button del_video;
        private System.Windows.Forms.Button return_video;
        private System.Windows.Forms.Button issue_video;
        private System.Windows.Forms.Button del_cust;
        private System.Windows.Forms.Button update_cust;
        private System.Windows.Forms.Button add_cust;
        private System.Windows.Forms.TextBox video_tot;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox video_real;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox video_ratting;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox video_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox video_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox customer_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customer_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerName_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

