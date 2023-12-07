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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;

namespace PollypipeDB
{
    public partial class staff : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0BIRHB1;Initial Catalog=PollypipeDB;Integrated Security=True");
        public staff()
        {
            InitializeComponent();
        }

       

        
        private void btninsert_Click(object sender, EventArgs e)
        {
            staffdgv.Rows.Add(txtstaffid.Text, stafftypecb.Text, txtstaffname.Text, txtstafftelno.Text);
            MessageBox.Show("Added sucessfully!");

            txtstaffid.Text = "";
            stafftypecb.Text = "";
            txtstaffname.Text = "";
            txtstafftelno.Text = "";





        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void staff_Load(object sender, EventArgs e)
        {

        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.Show();
            this.Hide();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void btnequipements_Click(object sender, EventArgs e)
        {
            equipement equipement = new equipement();
            equipement.Show();
            this.Hide();
        }

        private void btninstallation_Click(object sender, EventArgs e)
        {
            installation installation = new installation();
            installation.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainmenu mainmenu = new Mainmenu();
            mainmenu.Show();
        }

        private void stafftypecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            stafftypecb.Items.Add("plumber");
            stafftypecb.Items.Add("installation Manager");
            stafftypecb.Items.Add("Aquatics installer");
            stafftypecb.Items.Add("Brick Layer");

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Staff set staffname= '"+txtstaffname+"'where staffname='"+txtstaffname+"' ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("update sucessfully");
            
        }

        private void staffdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            staffdgv.DataSource = dt;
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Staff where staffname = '" + txtstaffname + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted sucessfully");
        }
    }
}
