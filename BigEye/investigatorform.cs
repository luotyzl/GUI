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
    public partial class investigatorform : Form
    {
        private datamodule DM;
        private mainform frmMenu;
        private CurrencyManager currencyManager;
        public investigatorform(datamodule dm, mainform mnu)
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
            cblicensed.Visible = false;
        }
        ///<Summary> method : display
        /////display the data on the form and binding data into the list
        ///</Summary>
        public void display()
        {
            //load Investigator's data and display on the right place;
            lblinvestigatorid.DataBindings.Add("Text", DM.dsbigeye, "T_Investigator.InvestigatorID");
            txtfirstname.DataBindings.Add("Text", DM.dsbigeye, "T_Investigator.FirstName");
            txtlastname.DataBindings.Add("Text", DM.dsbigeye, "T_Investigator.LastName");
            txthourlyrate.DataBindings.Add("Text", DM.dsbigeye, "T_Investigator.HourlyRate");
            txtcellphone.DataBindings.Add("Text", DM.dsbigeye, "T_Investigator.CellPhone");
            txtlicensed.DataBindings.Add("Text", DM.dsbigeye, "T_Investigator.Licensed");

            //disable the txt unless click the add or modify
            txtfirstname.Enabled = false;
            txtlastname.Enabled = false;
            txthourlyrate.Enabled = false;
            txtcellphone.Enabled = false;
            txtlicensed.Enabled = false;

            //display the name of client on the listbox
            lstinvestigator.DataSource = DM.dsbigeye;
            lstinvestigator.DisplayMember = "T_Investigator.FirstName" + "T_Investigator.LastName";
            lstinvestigator.ValueMember = "T_Investigator.FirstName" ;
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Investigator"];

        }
        ///<Summary> method : btreturn_Click
        /////close the form
        ///</Summary>
        private void btreturn_Click(object sender, EventArgs e)
        {
            Close();
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
        ///<Summary> method : btadd_Click
        /////display the panal
        ///</Summary>
        private void btadd_Click(object sender, EventArgs e)
        {
            pnlmodify.Visible = false;
            lstinvestigator.Enabled = false; //disable the listbox
            lstinvestigator.SelectedItem = null;
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
            lstinvestigator.Enabled = true;
            lstinvestigator.Visible = true;
            btdelete.Enabled = true;
            btnext.Enabled = true;
            btprevious.Enabled = true;
            btmodify.Enabled = true;
            btadd.Enabled = true;
            pnlmodify.Visible = true;
        }
        ///<Summary> method : btmodifycancel_Click
        /////disable the button and show the list
        ///</Summary>
        private void btmodifycancel_Click(object sender, EventArgs e)
        {
            btmodifycancel.Visible = false;
            btmodifysave.Visible = false;
            lstinvestigator.Enabled = true;
            lstinvestigator.Visible = true;
            btdelete.Enabled = true;
            btnext.Enabled = true;
            btprevious.Enabled = true;
            btmodify.Enabled = true;
            btadd.Enabled = true;
            txtfirstname.Enabled = false;
            txtlastname.Enabled = false;
            txtlicensed.Enabled = false;
            txthourlyrate.Enabled = false;
            txtcellphone.Enabled = false;
            cblicensed.Visible = false;

        }
        ///<Summary> method : btaddsave_Click
        /////save the data and update to datamodule
        ///</Summary>
        private void btaddsave_Click(object sender, EventArgs e)
        {
            lblinvestigatorid.Text = "";
            DataRow newInvestigatorRow = DM.dtinvestigator.NewRow();
            if ((txtaddfirstname.Text == "") || (txtaddlastname.Text == "") || (txtaddhourlyrate.Text == "") ||
                (txtaddcellphone.Text == "") )
            {
                MessageBox.Show("You must type in all details of the investigator", "Error");
            }
            else
            {
                try
                {
                    newInvestigatorRow["FirstName"] = txtaddfirstname.Text;
                    newInvestigatorRow["LastName"] = txtaddlastname.Text;
                    newInvestigatorRow["HourlyRate"] = Convert.ToDouble(txtaddhourlyrate.Text);
                    newInvestigatorRow["CellPhone"] = txtaddcellphone.Text;
                    if (cbaddlicensed.Checked == true)
                        newInvestigatorRow["Licensed"] = true;
                    else
                        newInvestigatorRow["Licensed"] = false; ;
                    DM.dtinvestigator.Rows.Add(newInvestigatorRow);
                    MessageBox.Show("Investigator added successfully", "Success");
                    DM.UpdateInvestigator();
                    btaddcancel_Click(sender, e);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a number for Hourly Rate", "Error");
                }
               
            }
            return;
        }
        ///<Summary> method : btmodifysave_Click
        /////save data and update to datamodule
        ///</Summary>
        private void btmodifysave_Click(object sender, EventArgs e)
        {
            DataRow ModifyInvestigatorRow = DM.dtinvestigator.Rows[currencyManager.Position];
            if ((txtfirstname.Text == "") || (txtlastname.Text == "") || (txthourlyrate.Text == "") ||
                (txtcellphone.Text == ""))
            {
                MessageBox.Show("You must type in in all details of the investigator", "Error");
            }
            else
            {
                ModifyInvestigatorRow["FirstName"] = txtfirstname.Text;
                ModifyInvestigatorRow["LastName"] = txtlastname.Text;
                ModifyInvestigatorRow["HourlyRate"] = Convert.ToDouble(txthourlyrate.Text);
                ModifyInvestigatorRow["CellPhone"] = txtcellphone.Text;
                if (cblicensed.Checked == true)
                    ModifyInvestigatorRow["Licensed"] = true;
                else
                    ModifyInvestigatorRow["Licensed"] = false;
                currencyManager.EndCurrentEdit();
                DM.UpdateInvestigator();
                MessageBox.Show("Investigator updated successfully", "Success");
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
            txthourlyrate.Enabled = true;
            txtcellphone.Enabled = true;
            cblicensed.Visible = true;

            btmodifycancel.Visible = true;
            btmodifysave.Visible = true;
            btdelete.Enabled = false;
            btadd.Enabled = false;
            btmodify.Enabled = false;
            btprevious.Enabled = false;
            btnext.Enabled = false;
        }
        ///<Summary> method : cblicensed_CheckedChanged
        /////change the value of licensed
        ///</Summary>
        private void cblicensed_CheckedChanged(object sender, EventArgs e)
        {
            if (cblicensed.Checked == true)
                txtlicensed.Text = "True";
            else
                txtlicensed.Text = "False";
        }
        ///<Summary> method : btdelete_Click
        /////delete the Client and update to datamodule
        ///</Summary>
        private void btdelete_Click(object sender, EventArgs e)
        {
            DataRow deleteInvestigatorRow = DM.dtinvestigator.Rows[currencyManager.Position];
            DataRow[] EquipmentInvestigatorRow = DM.dtequipmentform.Select("InvestigatorID = " + lblinvestigatorid.Text);
            DataRow[] AssignmentInvestigatorRow = DM.dtassignment.Select("InvestigatorID = " + lblinvestigatorid.Text);
            if (AssignmentInvestigatorRow.Length == 0) //check assignment status
            {
                if (EquipmentInvestigatorRow.Length == 0) //check equipment status
                { 
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        deleteInvestigatorRow.Delete();
                    }
                }
                else
                {
                    MessageBox.Show("You may only delete Investigators who are not allocated equipment", "Error");
                    return;
                 }

            }
            else
            {
                MessageBox.Show("You may only delete Investigators who are not assigned to cases", "Error");
                return;
            }
            DM.UpdateInvestigator();
        }
    }
}
