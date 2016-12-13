using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Timers;
namespace Assignment1
{
    //

    public partial class Form1 : Form
    {
        //variables used thoughout the program
        private int liftStatus;
       //these variables are used for moving the lift on the form
        int upLocation = -120;
        int downLocation = 120;

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void logUpdate(string floorName) //function that is passed though the name of the floor
        {
            listBox1.Items.Add("Lift went to "+ floorName + " at " + DateTime.Now);
            liftBox.Text = floorName;

        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            if (liftStatus == 0) //if the lift is on the ground floor then this piece of code can run
            {
                liftStatus = 1;
                logUpdate("First Floor");
                lift.Top += (upLocation);



            }
            else //if the lift isn't on the ground floor it must be on the first floor therefore it can't go past
            {
                MessageBox.Show("lift can't go above that floor");
            }

        }

        private void downbtn_Click(object sender, EventArgs e)
        {
            if (liftStatus == 1)//if the lift is on the first floor then this piece of code can run
            {
                liftStatus = 0;
                logUpdate("Ground Floor");
                lift.Top += (downLocation);
            }
            else//if the lift isn't on the first floor it must be on the ground floor therefore it can't go past
            {
                MessageBox.Show("Lift can't go below that floor");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lift_Click(object sender, EventArgs e)
        { 
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void liftBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            
            if (liftStatus == 1)//if the lift is on the first floor this bit of code sends a sql command to write in the date the time and the floor
            { 
            string connectionString = null;
            OleDbConnection connection;
            OleDbDataAdapter OleDbAdapter;
            DataSet ds = new DataSet();
            connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\Assignment1\\Assignment1\\Database2.mdb";
            connection = new OleDbConnection(connectionString);


            try
            {
                connection.Open();
                OleDbAdapter = new OleDbDataAdapter("Insert INTO Table1 VALUES (\"first floor\", NOW());", connection);
                OleDbAdapter.Fill(ds);
                OleDbAdapter.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
            else//if the lift isn't on the first floor when the log button is pressed  then it must be on the ground floor
            {
                string connectionString = null;
                OleDbConnection connection;
                OleDbDataAdapter OleDbAdapter;
                DataSet ds = new DataSet();
                connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\Assignment1\\Assignment1\\Database2.mdb";
                connection = new OleDbConnection(connectionString);
                try
                {
                    connection.Open();
                    OleDbAdapter = new OleDbDataAdapter("Insert INTO Table1 VALUES (\"ground floor\", NOW());", connection);
                    OleDbAdapter.Fill(ds);
                    OleDbAdapter.Dispose();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

            }
           
            }

        

    

       
    

