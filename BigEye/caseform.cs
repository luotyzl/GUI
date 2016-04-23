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
    public partial class caseform : Form
    {
        private datamodule DM;
        private mainform frmMenu;
        private CurrencyManager currencyManager;
        //private string ModifyClient;
        private string AddClient;
        public caseform(datamodule dm, mainform mnu)
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
            txtaddstatus.Enabled = false;

        }
        ///<Summary> method : display
        /////display the data on the form and binding data into the list
        ///</Summary>
        public void display()
        {
            //load Cases data and display on the right place;
            lblcaseid.DataBindings.Add("Text", DM.dsbigeye, "T_Case.CaseID");
            txtdescription.DataBindings.Add("Text", DM.dsbigeye, "T_Case.Description");
            txtstatus.DataBindings.Add("Text", DM.dsbigeye, "T_Case.Status");
            cboxtype.DataBindings.Add("Text", DM.dsbigeye, "T_Case.CaseType");
            dtpdata.DataBindings.Add("Text", DM.dsbigeye, "T_Case.DateOpened");
            DataRow FirstCaseClient = DM.dtcase.Rows[0];
            if (FirstCaseClient["ClientID"] != null)
            {
                DataRow CaseClient = DM.dtclient.Select("ClientID = " + FirstCaseClient["ClientID"]).FirstOrDefault();
                if (CaseClient != null)
                {
                    cboxclientid.Text = CaseClient["ClientID"].ToString() + "," + CaseClient["FirstName"].ToString() + " " + CaseClient["LastName"].ToString();
                }
            }


            //disable the text unless click the add or modify
            txtdescription.Enabled = false;
            txtstatus.Enabled = false;
            cboxtype.Enabled = false;
            dtpdata.Enabled = false;
            cboxclientid.Enabled = false;
            
            //display the name of client on the listbox
            lstcase.DataSource = DM.dsbigeye;
            lstcase.DisplayMember = "T_Case.CaseID" ;
            lstcase.ValueMember = "T_Case.CaseID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Case"];

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
            lstcase.Enabled = false; //disable the listbox
            lstcase.SelectedItem = null;
            btdelete.Enabled = false; // disable buttons
            btprevious.Enabled = false;
            btnext.Enabled = false;
            btmodify.Enabled = false;
            btadd.Enabled = false;
            pnladd.Show();
            txtaddstatus.Text = "Open";

            //display the details on the combo box
            List<string> caseTypes = new List<string>();
            List<string> clientids = new List<string>();
            DataRow[] clientrows = DM.dtclient.Select();
            foreach (DataRow row in clientrows)
            {
                clientids.Add(row["ClientID"].ToString() + "," + row["FirstName"].ToString() + " " + row["LastName"].ToString());
            }
            DataRow[] typerows = DM.dtcase.Select();
            foreach (DataRow row in typerows)
            {
                caseTypes.Add(row["CaseType"].ToString());
            }
            cboxaddtype.DataSource = caseTypes.Distinct().ToList();
            cboxaddclientid.DataSource = clientids;

        }
        ///<Summary> method : btaddsave_Click
        /////save the data and update to datamodule
        ///</Summary>
        private void btaddsave_Click(object sender, EventArgs e)
        {
            lblcaseid.Text = "";
            DataRow newCaseRow = DM.dtcase.NewRow();
            if ((txtadddescription.Text == ""))
            {
                MessageBox.Show("You must type in description of the case", "Error");
            }
            else
            {
                    newCaseRow["Description"] = txtadddescription.Text;
                    newCaseRow["Status"] = "Open";
                    newCaseRow["CaseType"] = cboxtype.Text;
                    newCaseRow["DateOpened"] = dtpadddata.Value;
                    newCaseRow["ClientID"] = AddClient;
                    DM.dtcase.Rows.Add(newCaseRow);
                    MessageBox.Show("Case added successfully", "Success");
                    DM.UpdateCase();
                    btaddcancel_Click(sender, e);
            }
            return;
        }
        ///<Summary> method : btaddcancel_Click
        /////disable the button and show the list
        ///</Summary>
        private void btaddcancel_Click(object sender, EventArgs e)
        {
            pnladd.Hide();
            lstcase.Enabled = true;
            lstcase.Visible = true;
            btdelete.Enabled = true;
            btnext.Enabled = true;
            btprevious.Enabled = true;
            btmodify.Enabled = true;
            btadd.Enabled = true;
            pnlmodify.Visible = true;
        }
        ///<Summary> method : btmodify_Click
        /////enable the button and show modify panal
        ///</Summary>
        private void btmodify_Click(object sender, EventArgs e)
        {
            if (txtstatus.Text == "Closed")
                MessageBox.Show("Cannot update a closed Case", "Error");
            else
            {
                lstcase.Enabled = false;
                txtdescription.Enabled = true;
                cboxtype.Enabled = true;
                dtpdata.Enabled = true;

                btprevious.Enabled = false;
                btnext.Enabled = false;
                btmodifycancel.Visible = true;
                btmodifysave.Visible = true;
                btdelete.Enabled = false;
                btadd.Enabled = false;
                btmodify.Enabled = false;

                //display the details on the combo box

                List<string> caseTypes = new List<string>();
                DataRow[] typerows = DM.dtcase.Select();
                foreach (DataRow row in typerows)
                {
                    caseTypes.Add(row["CaseType"].ToString());
                }
                cboxtype.DataSource = caseTypes.Distinct().ToList(); 
            }
        }
        ///<Summary> method : btmodifysave_Click
        /////save data and update to datamodule
        ///</Summary>
        private void btmodifysave_Click(object sender, EventArgs e)
        {
            DataRow ModifyCaseRow = DM.dtcase.Rows[currencyManager.Position];
            if (txtdescription.Text == "")
            {
                MessageBox.Show("You must type in in description of the Case", "Error");
            }
            else
            {
                ModifyCaseRow["Description"] = txtdescription.Text;
                ModifyCaseRow["Status"] = "Open";
                ModifyCaseRow["CaseType"] = cboxtype.Text;
                ModifyCaseRow["DateOpened"] = dtpdata.Value;
                currencyManager.EndCurrentEdit();
                DM.UpdateCase();
                MessageBox.Show("Case updated successfully", "Success");
                btmodifycancel_Click(sender, e);
            }
            return;
        }
        ///<Summary> method : btmodifycancel_Click
        /////disable the button and show the list
        ///</Summary>
        private void btmodifycancel_Click(object sender, EventArgs e)
        {
            btmodifycancel.Visible = false;
            btmodifysave.Visible = false;
            lstcase.Enabled = true;
            lstcase.Visible = true;
            btdelete.Enabled = true;
            btnext.Enabled = true;
            btprevious.Enabled = true;
            btmodify.Enabled = true;
            btadd.Enabled = true;
            txtdescription.Enabled = false;
            cboxclientid.Enabled = false;
            cboxtype.Enabled = false;
            dtpdata.Enabled = false;
        }
        ///<Summary> method : btdelete_Click
        /////delete the case and update to datamodule
        ///</Summary>
        private void btdelete_Click(object sender, EventArgs e)
        {
            DataRow deleteCaseRow = DM.dtcase.Rows[currencyManager.Position];
            if (txtstatus.Text == "Closed") //check case status
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteCaseRow.Delete();
                }
            }
            else
            {
                MessageBox.Show("You may only delete closed Cases", "Error");
                return;
            }
            DM.UpdateCase();
        }
        ///<Summary> method : btreturn_Click
        /////close the form
        ///</Summary>
        private void btreturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method : btmark_Click
        /////change the status to closed
        ///</Summary>
        private void btmark_Click(object sender, EventArgs e)
        {
            DataRow ModifyCaseRow = DM.dtcase.Rows[currencyManager.Position];
            if (txtstatus.Text == "Closed")
            {
                MessageBox.Show("The Case is already closed", "Error");
            }
            else
            {
                ModifyCaseRow["Status"] = "Closed";
                currencyManager.EndCurrentEdit();
                DM.UpdateCase();
                MessageBox.Show("Case updated successfully", "Success");
            }
        }
        ///<Summary> method : cboxaddclientid_SelectedIndexChanged
        /////when change the seleted item in the combo box, read the first char as id
        ///</Summary>
        private void cboxaddclientid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int end = cboxaddclientid.Text.LastIndexOf(",");
            AddClient = cboxaddclientid.Text.Substring(0, end);
        }
        ///<Summary> method : lstcase_SelectedIndexChanged
        /////when change the seleted item in the list, get the information of client and binding data again
        ///</Summary>
        private void lstcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currencyManager != null)
            {
                DataRow CurrentCaseClient = DM.dtcase.Rows[currencyManager.Position];
                if (CurrentCaseClient["ClientID"] != null)
                {
                    DataRow CaseClient = DM.dtclient.Select("ClientID = " + CurrentCaseClient["ClientID"]).FirstOrDefault();
                    if (CaseClient != null)
                    {
                        cboxclientid.Text = CaseClient["ClientID"].ToString() + "," + CaseClient["FirstName"].ToString() + " " + CaseClient["LastName"].ToString();
                    }
                }
            }
        }
    }
}
