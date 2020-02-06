using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_System_Management.Forms
{
    public partial class Form2 : Form
    {
        int Panelwidth;
        bool isCollapsed;
        public string user;
        public Form2()
        {

            InitializeComponent();
            timerTime.Start();
            Panelwidth = paneLeft.Width;
            isCollapsed = false;
            tabControl1.Hide();
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage10);
            tabControl1.TabPages.Remove(tabPage11);
            tabControl1.TabPages.Remove(tabPage12);
            tabControl1.TabPages.Remove(tabPage13);
            tabControl1.TabPages.Remove(tabPage14);
            tabControl1.TabPages.Remove(tabPage15);
            
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N3718S7\\SQLEXPRESS;Initial Catalog=LibrarySystem3;Integrated Security=True");

        private void button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                paneLeft.Width = paneLeft.Width + 10;
                if (paneLeft.Width >= Panelwidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                paneLeft.Width = paneLeft.Width - 10;
                if (paneLeft.Width <= 75)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            btnHome.Enabled = false;
            btnBooks.Enabled = true;
            btnSubjects.Enabled = true;
            btnStudents.Enabled = true;
            btnShelves.Enabled = true;
            moveSidePanel(btnHome);
            tabControl1.Hide();

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage10);
            tabControl1.TabPages.Remove(tabPage11);
            tabControl1.TabPages.Remove(tabPage12);
            tabControl1.TabPages.Remove(tabPage13);
            tabControl1.TabPages.Remove(tabPage14);
            tabControl1.TabPages.Remove(tabPage15);
        }

        private void btnBooks_Click_1(object sender, EventArgs e)
        {
            btnBooks.Enabled = false;
            btnBarrows.Enabled = true;
            btnSubjects.Enabled = true;
            btnStudents.Enabled = true;
            btnShelves.Enabled = true;
            btnHome.Enabled = true;

            moveSidePanel(btnBooks);
            tabControl1.Show();
            bookPnl.Show();
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage10);
            tabControl1.TabPages.Remove(tabPage11);
            tabControl1.TabPages.Remove(tabPage12);
            tabControl1.TabPages.Remove(tabPage13);
            tabControl1.TabPages.Remove(tabPage14);
            tabControl1.TabPages.Remove(tabPage15);
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabControl1.TabPages.Add(tabPage3);

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            SqlCommand shelfkomut = new SqlCommand();
            shelfkomut.CommandText = "Select *FROM shelf";
            shelfkomut.Connection = conn;
            shelfkomut.CommandType = CommandType.Text;
            SqlDataReader shelfdr;
            conn.Open();
            shelfdr = shelfkomut.ExecuteReader();
            while (shelfdr.Read())
            {
                comboBox2.Items.Add(shelfdr["ShelfNumber"]);
            }
            conn.Close();
            button1.Show();
            button2.Hide();

            SqlCommand departmentkomut = new SqlCommand();
            departmentkomut.CommandText = "SELECT *FROM department";
            departmentkomut.Connection = conn;
            departmentkomut.CommandType = CommandType.Text;
            SqlDataReader departmentdr;
            conn.Open();
            departmentdr = departmentkomut.ExecuteReader();
            while (departmentdr.Read())
            {
                comboBox1.Items.Add(departmentdr["department_name"]);
            }
            conn.Close();

        }

        private void btnBarrows_Click_1(object sender, EventArgs e)
        {
            btnBarrows.Enabled = false;
            btnBooks.Enabled = true;
            btnSubjects.Enabled = true;
            btnStudents.Enabled = true;
            btnShelves.Enabled = true;
            btnHome.Enabled = true;

            moveSidePanel(btnBarrows);
            tabControl1.Show();
            tabControl1.TabPages.Add(tabPage4);
            tabControl1.TabPages.Add(tabPage5);
            tabControl1.TabPages.Add(tabPage6);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage10);
            tabControl1.TabPages.Remove(tabPage11);
            tabControl1.TabPages.Remove(tabPage12);
            tabControl1.TabPages.Remove(tabPage13);
            tabControl1.TabPages.Remove(tabPage14);
            tabControl1.TabPages.Remove(tabPage15);

            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            SqlCommand book = new SqlCommand();
            book.CommandText = "SELECT *FROM book";
            book.Connection = conn;
            book.CommandType = CommandType.Text;
            SqlDataReader bookdr;
            conn.Open();
            bookdr = book.ExecuteReader();
            while (bookdr.Read())
            {
                comboBox3.Items.Add(bookdr["BookName"]);
            }
            conn.Close();
            button5.Show();
            button10.Hide();



            SqlCommand deneme = new SqlCommand();
            deneme.CommandText = "select *from student";
            deneme.Connection = conn;
            deneme.CommandType = CommandType.Text;
            SqlDataReader denemedr;
            conn.Open();
            denemedr = deneme.ExecuteReader();
            while (denemedr.Read())
            {
                comboBox4.Items.Add(denemedr["StudentID"]);
            }
            conn.Close();
        }

        private void btnSubjects_Click_1(object sender, EventArgs e)
        {
            btnSubjects.Enabled = false;
            btnBooks.Enabled = true;
            btnBarrows.Enabled = true;
            btnStudents.Enabled = true;
            btnShelves.Enabled = true;
            btnHome.Enabled = true;

            moveSidePanel(btnSubjects);
            tabControl1.Show();
            tabControl1.TabPages.Add(tabPage7);
            tabControl1.TabPages.Add(tabPage8);
            tabControl1.TabPages.Add(tabPage9);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage10);
            tabControl1.TabPages.Remove(tabPage11);
            tabControl1.TabPages.Remove(tabPage12);
            tabControl1.TabPages.Remove(tabPage13);
            tabControl1.TabPages.Remove(tabPage14);
            tabControl1.TabPages.Remove(tabPage15);
            button14.Hide();
            button11.Show();
        }

        private void btnStudents_Click_1(object sender, EventArgs e)
        {
            btnStudents.Enabled = false;
            btnBooks.Enabled = true;
            btnBarrows.Enabled = true;
            btnSubjects.Enabled = true;
            btnShelves.Enabled = true;
            btnHome.Enabled = true;

            moveSidePanel(btnStudents);
            tabControl1.Show();
            tabControl1.TabPages.Add(tabPage10);
            tabControl1.TabPages.Add(tabPage11);
            tabControl1.TabPages.Add(tabPage12);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage13);
            tabControl1.TabPages.Remove(tabPage14);
            tabControl1.TabPages.Remove(tabPage15);
            button16.Hide();
            button15.Show();
        }
       private void btnShelves_Click_1(object sender, EventArgs e)
        {
            btnShelves.Enabled = false;
            btnBooks.Enabled = true;
            btnBarrows.Enabled = true;
            btnSubjects.Enabled = true;
            btnStudents.Enabled = true;
            btnHome.Enabled = true;

            moveSidePanel(btnShelves);
            tabControl1.Show();
            tabControl1.TabPages.Add(tabPage13);
            tabControl1.TabPages.Add(tabPage14);
            tabControl1.TabPages.Add(tabPage15);
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage10);
            tabControl1.TabPages.Remove(tabPage11);
            tabControl1.TabPages.Remove(tabPage12);
            button21.Hide();
            button19.Show();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timerTime_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:mm:ss");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N3718S7\\SQLEXPRESS;Initial Catalog=LibrarySystem3;Integrated Security=True");

            string book_name, author, publication_year;
            string shelf;
            book_name = textBox1.Text;
            author = textBox2.Text;
            publication_year = textBox3.Text;
            shelf = comboBox2.Text;

            SqlCommand librarysystem = new SqlCommand("Insert Into book(BookName ,author,PublicationYear,Topic,Shelf) values ('" + book_name + "','" + author + "','" + publication_year + "','" + comboBox1.Text + "','" + shelf + "')", conn);

            conn.Open();
            librarysystem.ExecuteNonQuery();
            MessageBox.Show("basarılı");
            yenile();
            conn.Close();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'librarySystem3DataSet.shelf' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.shelfTableAdapter.Fill(this.librarySystem3DataSet.shelf);
            // TODO: Bu kod satırı 'librarySystem3DataSet.student' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.studentTableAdapter.Fill(this.librarySystem3DataSet.student);
            // TODO: Bu kod satırı 'librarySystem3DataSet.department' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.departmentTableAdapter.Fill(this.librarySystem3DataSet.department);
            // TODO: Bu kod satırı 'librarySystem3DataSet.Borrow' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borrowTableAdapter.Fill(this.librarySystem3DataSet.Borrow);
            // TODO: Bu kod satırı 'librarySystem3DataSet.book' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bookTableAdapter.Fill(this.librarySystem3DataSet.book);
            // TODO: Bu kod satırı 'librarySystem3DataSet2.shelf' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            label3.Text = user;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            button1.Hide();
            button2.Show();
            tabControl1.SelectedTab = tabPage1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null && textBox3 != null && comboBox1 != null && comboBox2 != null)
            {
                conn.Open();
                string kayıt = "update book set BookName=@BookName,author=@author,PublicationYear=@PublicationYear,Topic=@Topic,Shelf=@Shelf where id=@id";
                SqlCommand cmd = new SqlCommand(kayıt, conn);
                cmd.Parameters.AddWithValue("@BookName", textBox1.Text);
                cmd.Parameters.AddWithValue("@author", textBox2.Text);
                cmd.Parameters.AddWithValue("@PublicationYear", textBox3.Text);
                cmd.Parameters.AddWithValue("@Topic", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Shelf", comboBox2.Text);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated");
                yenile();
                tabControl1.SelectedTab = tabPage2;
                button1.Show();
                button2.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        public void yenile()
        {
            conn.Open();
            string kayıt = "Select *From book";
            SqlCommand cmd = new SqlCommand(kayıt, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            conn.Open();
            string select = "Select *From book";
            SqlDataAdapter datwo = new SqlDataAdapter(select, conn);
            DataTable dt2 = new DataTable();
            datwo.Fill(dt2);
            dataGridView2.DataSource = dt2;
            conn.Close();

            conn.Open();
            string slct = "Select *From borrow";
            SqlDataAdapter dathree = new SqlDataAdapter(slct, conn);
            DataTable dt3 = new DataTable();
            dathree.Fill(dt3);
            dataGridView3.DataSource = dt3;
            conn.Close();

            conn.Open();
            string kyt = "Select *From borrow";
            SqlDataAdapter dafour = new SqlDataAdapter(kyt, conn);
            DataTable dt4 = new DataTable();
            dafour.Fill(dt4);
            dataGridView4.DataSource = dt4;
            conn.Close();

            conn.Open();
            string sbjct = "select *From department";
            SqlDataAdapter dafive = new SqlDataAdapter(sbjct, conn);
            DataTable dt5 = new DataTable();
            dafive.Fill(dt5);
            dataGridView5.DataSource = dt5;
            conn.Close();

            conn.Open();
            string subj = "select *From department";
            SqlDataAdapter dasix = new SqlDataAdapter(subj, conn);
            DataTable dt6 = new DataTable();
            dasix.Fill(dt6);
            dataGridView6.DataSource = dt6;
            conn.Close();

            conn.Open();
            string stdnt = "select *from student";
            SqlDataAdapter dasev = new SqlDataAdapter(stdnt, conn);
            DataTable dt7 = new DataTable();
            dasev.Fill(dt7);
            dataGridView7.DataSource = dt7;
            conn.Close();

            conn.Open();
            string stdnt2 = "select *from student";
            SqlDataAdapter daeig = new SqlDataAdapter(stdnt2, conn);
            DataTable dt8 = new DataTable();
            daeig.Fill(dt8);
            dataGridView8.DataSource = dt8;
            conn.Close();

            conn.Open();
            string shelf = "select *from shelf";
            SqlDataAdapter shelfda = new SqlDataAdapter(shelf, conn);
            DataTable dt9 = new DataTable();
            shelfda.Fill(dt9);
            dataGridView9.DataSource = dt9;
            conn.Close();

            conn.Open();
            string shelf2 = "select *from shelf";
            SqlDataAdapter shelfda2 = new SqlDataAdapter(shelf2, conn);
            DataTable dt10 = new DataTable();
            shelfda2.Fill(dt10);
            dataGridView10.DataSource = dt10;
            conn.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kayıt = "DELETE FROM book WHERE id=@id ";
            SqlCommand komut = new SqlCommand(kayıt, conn);
            komut.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            yenile();
            tabControl1.SelectedTab = tabPage1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N3718S7\\SQLEXPRESS;Initial Catalog=LibrarySystem3;Integrated Security=True");
            string studentid, bookname;
            studentid = comboBox4.Text ;
            bookname = comboBox3.Text;
            DateTime date = DateTime.Now;
            date.ToString();
            DateTime returndate;
            returndate = date.AddDays(+10);
            returndate.ToString();
            string name;
            name = "";
            string author="", topic="", shelf="",publication="";

            conn.Open();
            SqlCommand SQLKomut = new SqlCommand("select NameSurname from student where StudentID=@StudentID", conn);
            SQLKomut.Parameters.AddWithValue("@StudentID", studentid);
            SqlDataReader sdr = SQLKomut.ExecuteReader();
            while (sdr.Read())
            {
                name = sdr["NameSurname"].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("Select author,topic,shelf,publicationyear from book where bookname=@bookname", conn);
            sqlCommand.Parameters.AddWithValue("@bookname", bookname);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                author = sqlDataReader["author"].ToString() ;
                topic = sqlDataReader["topic"].ToString();
                shelf = sqlDataReader["shelf"].ToString();
                publication = sqlDataReader["PublicationYear"].ToString();

            }
            conn.Close();

            SqlCommand librarysystem = new SqlCommand("Insert Into borrow(studentID ,BookName,BorrowDate,ReturnDate,StudentName,author,topic,shelf,PublicationYear) values ('" + studentid + "','" + bookname + "','" + date + "','" + returndate + "','" + name + "','"+author+"','"+topic+"','"+shelf+"','"+publication+"')", conn);
            conn.Open();
            librarysystem.ExecuteNonQuery();
            MessageBox.Show("basarılı");
            yenile();
            conn.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string kayıt = "DELETE FROM borrow WHERE id=@id ";
            SqlCommand komut = new SqlCommand(kayıt, conn);
            komut.Parameters.AddWithValue("@id", dataGridView4.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            yenile();
            MessageBox.Show("Silme İşlemi Başarılı");
            tabControl1.SelectedTab = tabPage4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox4.Text= dataGridView3.CurrentRow.Cells[1].Value.ToString();
            comboBox3.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            button5.Hide();
            button10.Show();
            tabControl1.SelectedTab = tabPage4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string StudentName, Author, PublicationYear, Topic, Shelf;
            StudentName = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            Author = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            PublicationYear = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            Topic = dataGridView3.CurrentRow.Cells[6].Value.ToString();
            Shelf = dataGridView3.CurrentRow.Cells[7].Value.ToString();
            DateTime date = DateTime.Now;
            date.ToString();
            DateTime returndate;
            returndate = date.AddDays(+10);
            returndate.ToString();

            if (comboBox4 != null  && comboBox3 != null)
            {
                conn.Open();
                string kayıt = "update borrow set StudentID=@StudentID,StudentName=@StudentName,BookName=@BookName,Author=@Author,PublicationYear=@PublicationYear,Topic=@Topic,Shelf=@Shelf,BorrowDate=@BorrowDate,ReturnDate=@ReturnDate where id=@id";
                SqlCommand cmd = new SqlCommand(kayıt, conn);
                cmd.Parameters.AddWithValue("@StudentID",comboBox4.Text);
                cmd.Parameters.AddWithValue("@StudentName", StudentName);
                cmd.Parameters.AddWithValue("@BookName", comboBox3.Text);
                cmd.Parameters.AddWithValue("@Author", Author);
                cmd.Parameters.AddWithValue("@PublicationYear", PublicationYear);
                cmd.Parameters.AddWithValue("@Topic", Topic);
                cmd.Parameters.AddWithValue("@Shelf", Shelf);
                cmd.Parameters.AddWithValue("BorrowDate", date);
                cmd.Parameters.AddWithValue("ReturnDate", returndate);
                cmd.Parameters.AddWithValue("@id", dataGridView3.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated");
                yenile();
                tabControl1.SelectedTab = tabPage5;
                button5.Show();
                button10.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        bool status;
        void repeat()
        {

            conn.Open();
            SqlCommand stat = new SqlCommand("select *From department where department_name=@p1", conn);
            stat.Parameters.AddWithValue("@p1", textBox4.Text);
            SqlDataReader dr = stat.ExecuteReader();
            if (dr.Read())
            {
                status = false;
            }
            else
            {
                status = true;
            }
            conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N3718S7\\SQLEXPRESS;Initial Catalog=LibrarySystem3;Integrated Security=True");

            string subject;
            subject = textBox4.Text;

            repeat();
            if(status==true)
            {
                SqlCommand cmd = new SqlCommand("Insert Into department(department_name) values ('" + subject + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("basarılı");
                yenile();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Bu Kategori Mevcut, Lütfen Başka Giriniz.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text= dataGridView5.CurrentRow.Cells[1].Value.ToString();
            button11.Hide();
            button14.Show();
            tabControl1.SelectedTab = tabPage7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string kayıt = "DELETE FROM department WHERE deparmentID=@id ";
            SqlCommand komut = new SqlCommand(kayıt, conn);
            komut.Parameters.AddWithValue("@id", dataGridView6.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            yenile();
            MessageBox.Show("Silme İşlemi Başarılı");
            tabControl1.SelectedTab = tabPage7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox4 != null)
            {
                conn.Open();
                string kayıt = "update department set department_name=@department_name where deparmentID=@id";
                SqlCommand cmd = new SqlCommand(kayıt, conn);
                cmd.Parameters.AddWithValue("@department_name", textBox4.Text);
                cmd.Parameters.AddWithValue("@id", dataGridView5.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated");
                yenile();
                tabControl1.SelectedTab = tabPage8;
                button11.Show();
                button14.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N3718S7\\SQLEXPRESS;Initial Catalog=LibrarySystem3;Integrated Security=True");
            string name, email,studentid;
            name = textBox6.Text;
            studentid = textBox7.Text;
            email = textBox8.Text;

            SqlCommand studentadd = new SqlCommand("Insert Into student(NameSurname ,StudentID,Email) values ('" + name + "','" + studentid + "','" + email + "')", conn);
            conn.Open();
            studentadd.ExecuteNonQuery();
            MessageBox.Show("basarılı");
            yenile();
            conn.Close();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox6 != null && textBox7 != null && textBox8 !=null)
            {
                conn.Open();
                string kayıt = "update student set NameSurname=@Name,StudentID=@StudentID,EMail=@Email where id=@id";
                SqlCommand cmd = new SqlCommand(kayıt, conn);
                cmd.Parameters.AddWithValue("@StudentID", textBox7.Text);
                cmd.Parameters.AddWithValue("@Name", textBox6.Text);
                cmd.Parameters.AddWithValue("@Email", textBox8.Text);
                cmd.Parameters.AddWithValue("@id", dataGridView7.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated");
                yenile();
                tabControl1.SelectedTab = tabPage11;
                button15.Show();
                button16.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox6.Text = dataGridView7.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView7.CurrentRow.Cells[3].Value.ToString();
            textBox8.Text = dataGridView7.CurrentRow.Cells[2].Value.ToString();
            button15.Hide();
            button16.Show();
            tabControl1.SelectedTab = tabPage10;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string kayıt = "DELETE FROM student WHERE id=@id ";
            SqlCommand komut = new SqlCommand(kayıt, conn);
            komut.Parameters.AddWithValue("@id", dataGridView8.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            yenile();
            MessageBox.Show("Silme İşlemi Başarılı");
            tabControl1.SelectedTab = tabPage10;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-N3718S7\\SQLEXPRESS;Initial Catalog=LibrarySystem3;Integrated Security=True");
            string Sequence, part;
            Sequence = textBox5.Text;
            part = textBox9.Text;

            SqlCommand shelfadd = new SqlCommand("Insert Into shelf(ShelfNumber ,ShelfChar) values ('" + Sequence + "','" + part +"')", conn);
            conn.Open();
            shelfadd.ExecuteNonQuery();
            MessageBox.Show("basarılı");
            yenile();
            conn.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox5.Text = dataGridView9.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView9.CurrentRow.Cells[2].Value.ToString();
            button19.Hide();
            button21.Show();
            tabControl1.SelectedTab = tabPage13;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox5 != null && textBox9 != null )
            {
                conn.Open();
                string kayıt = "update shelf set ShelfNumber=@Sequence,ShelfChar=@Part where id=@id";
                SqlCommand cmd = new SqlCommand(kayıt, conn);
                cmd.Parameters.AddWithValue("@Sequence", textBox5.Text);
                cmd.Parameters.AddWithValue("@Part", textBox9.Text);
                cmd.Parameters.AddWithValue("@id", dataGridView9.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated");
                yenile();
                tabControl1.SelectedTab = tabPage14;
                button15.Show();
                button16.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string kayıt = "DELETE FROM shelf WHERE id=@id ";
            SqlCommand komut = new SqlCommand(kayıt, conn);
            komut.Parameters.AddWithValue("@id", dataGridView10.CurrentRow.Cells[0].Value.ToString());
            conn.Open();
            komut.ExecuteNonQuery();
            conn.Close();
            yenile();
            MessageBox.Show("Silme İşlemi Başarılı");
            tabControl1.SelectedTab = tabPage13;

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
