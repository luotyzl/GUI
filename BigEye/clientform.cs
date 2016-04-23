using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigEye
{
    public partial class clientform : Form
    {
        private datamodule DM;
        private mainform frmMenu;
        private CurrencyManager currencyManager;
        public clientform(datamodule dm, mainform mnu)
        {
            DM = dm;
            frmMenu = mnu;
            InitializeComponent();
            display();

            pnladd.Visible = false;
            pnladd.Left = 233;
            pnladd.Top = 30;
            btmodifysave.Visible = false;
            btmodifycancel.Visible = false;

        }
        ///<Summary> method : display
        /////display the data on the form and binding data into the list
        ///</Summary>
        public void display()
        {
            //load client's data and display on the right place;
            lblclientid.DataBindings.Add("Text", DM.dsbigeye, "T_Client.ClientID");
            txtfirstname.DataBindings.Add("Text", DM.dsbigeye, "T_Client.FirstName");
            txtlastname.DataBindings.Add("Text", DM.dsbigeye, "T_Client.LastName");
            txtaddress.DataBindings.Add("Text", DM.dsbigeye, "T_Client.StreetAddress");
            txtsuburb.DataBindings.Add("Text", DM.dsbigeye, "T_Client.Suburb");
            txtcity.DataBindings.Add("Text", DM.dsbigeye, "T_Client.City");
            txtphone.DataBindings.Add("Text", DM.dsbigeye, "T_Client.PhoneNumber");

            //disable the txt unless click the add or modify
            txtfirstname.Enabled = false;
            txtlastname.Enabled = false;
            txtaddress.Enabled = false;
            txtsuburb.Enabled = false;
            txtcity.Enabled = false;
            txtphone.Enabled = false;

            //display the name of client on the listbox
            lstclient.DataSource = DM.dsbigeye;
            lstclient.DisplayMember = "T_Client.FirstName"+ "T_Client.LastName";
            lstclient.ValueMember = "T_Client.FirstName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Client"];
        }
        ///<Summary> method : btreturn_Click
        /////close the form
        ///</Summary>
        private void btreturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method : btnext_Click
        /////move the currencymanager down 1 position
        ///</Summary>
        private void btnext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }
        ///<Summary> method : btprevious_Click
        /////move the currencymanager up 1 position
        ///</Summary>
        private void btprevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }
        ///<Summary> method : btdelete_Click
        /////delete the Client and update to datamodule
        ///</Summary>
        private void btdelete_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtclient.Rows[currencyManager.Position];
            DataRow[] CaseClientRow = DM.dtcase.Select("ClientID = " + lblclientid.Text);
            if (CaseClientRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Clients who have no cases", "Error");
                return;
            }
            //Update
            DM.UpdateClient();
        }
        ///<Summary> method : btadd_Click
        /////display the panal
        ///</Summary>
        private void btadd_Click(object sender, EventArgs e)
        {
            pnlmodify.Visible = false; 
            lstclient.Enabled = false; //disable the listbox
            lstclient.SelectedItem = null; 
            btdelete.Enabled = false; // disable buttons
            btprevious.Enabled = false;
            btnext.Enabled = false;
            btmodify.Enabled = false;
            btadd.Enabled = false;
            pnladd.Show();
        }
        ///<Summary> method : btaddcancel_Click
        /////disable the button and show the list
        ///</Summary>
        private void btaddcancel_Click(object sender, EventArgs e)
        {
            pnladd.Hide();
            lstclient.Enabled = true;
            lstclient.Visible = true;
            btdelete.Enabled = true;
            btnext.Enabled = true;
            btprevious.Enabled = true;
            btmodify.Enabled = true;
            btadd.Enabled = true;
            pnlmodify.Visible = true;
        }
        ///<Summary> method : btaddsave_Click
        /////save the data and update to datamodule
        ///</Summary>
        private void btaddsave_Click(object sender, EventArgs e)
        {
            lblclientid.Text = "";
            DataRow newClientRow = DM.dtclient.NewRow();
            if ((txtaddfirstname.Text == "") || (txtaddlastname.Text == "") || (txtaddaddress.Text == "") || 
                (txtaddsuburb.Text == "") || (txtaddcity.Text == "") || (txtaddphone.Text == "") )
            {
                MessageBox.Show("You must type in all details of the client", "Error");
            }
            else
            {
                try
                {
                    newClientRow["FirstName"] = txtaddfirstname.Text;
                    newClientRow["LastName"] = txtaddlastname.Text;
                    newClientRow["StreetAddress"] = txtaddaddress.Text;
                    newClientRow["Suburb"] = txtaddsuburb.Text;
                    newClientRow["City"] = txtaddcity.Text;
                    newClientRow["PhoneNumber"] = txtaddphone.Text;
                    DM.dtclient.Rows.Add(newClientRow);
                    MessageBox.Show("Client added successfully", "Success");
                    DM.UpdateClient();
                    btaddcancel_Click(sender, e);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a number for Phone Number", "Error");
                }
            }
            return;
        }
        ///<Summary> method : btmodifysave_Click
        /////save data and update to datamodule
        ///</Summary>
        private void btmodifysave_Click(object sender, EventArgs e)
        {
            DataRow ModifyClientRow = DM.dtclient.Rows[currencyManager.Position];
            if ((txtfirstname.Text == "") || (txtlastname.Text == "") || (txtaddress.Text == "") ||
                (txtsuburb.Text == "") || (txtcity.Text == "") || (txtphone.Text == ""))
            {
                MessageBox.Show("You must type in in all details of the client", "Error");
            }
            else
            {
                ModifyClientRow["FirstName"] = txtfirstname.Text;
                ModifyClientRow["LastName"] = txtlastname.Text;
                ModifyClientRow["StreetAddress"] = txtaddress.Text;
                ModifyClientRow["Suburb"] = txtsuburb.Text;
                ModifyClientRow["City"] = txtcity.Text;
                ModifyClientRow["PhoneNumber"] = txtphone.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateClient();
                MessageBox.Show("Client updated successfully", "Success");
                btmodifycancel_Click(sender, e);
            }
            return;
        }
        ///<Summary> method : btmodify_Click
        /////enable the button and show modify panal
        ///</Summary>
        private void btmodify_Click(object sender, EventArgs e)
        {
            txtfirstname.Enabled = true;
            txtlastname.Enabled = true;
            txtaddress.Enabled = true;
            txtsuburb.Enabled = true;
            txtcity.Enabled = true;
            txtphone.Enabled = true;

            btprevious.Enabled = false;
            btnext.Enabled = false;
            btmodifycancel.Visible = true;
            btmodifysave.Visible = true;
            btdelete.Enabled = false;
            btadd.Enabled = false;
            btmodify.Enabled = false;
        }
        ///<Summary> method : btmodifycancel_Click
        /////disable the button and show the list
        ///</Summary>
        private void btmodifycancel_Click(object sender, EventArgs e)
        {
            btmodifycancel.Visible = false;
            btmodifysave.Visible = false;
            lstclient.Enabled = true;
            lstclient.Visible = true;
            btdelete.Enabled = true;
            btnext.Enabled = true;
            btprevious.Enabled = true;
            btmodify.Enabled = true;
            btadd.Enabled = true;
            
            txtfirstname.Enabled = false;
            txtlastname.Enabled = false;
            txtaddress.Enabled = false;
            txtsuburb.Enabled = false;
            txtcity.Enabled = false;
            txtphone.Enabled = false;
        }
    }
}
