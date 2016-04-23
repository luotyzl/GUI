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
    public partial class assignmentform : Form
    {
        private datamodule DM;
        private mainform frmMenu;
        private CurrencyManager cmInvest;
        private CurrencyManager cmCase;
        private CurrencyManager cmAssign;
        private CurrencyManager cmCtoAtoI;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;
        private bool editdata;
        public assignmentform(datamodule dm, mainform mnu)
        {
            DM = dm;
            frmMenu = mnu;
            InitializeComponent();

            cmCase = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Case"];
            cmInvest = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Investigator"];
            cmAssign = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Assignment"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmCtoAtoI = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Case.T_Case_T_Assignment"];
            display();

            pnladd.Visible = false;
            pnladd.Left = 233;
            pnladd.Top = 30;
            
            editdata = false;
        }
        ///<Summary> method : display
        /////display the data on the form and binding data into the list
        ///</Summary>
        public void display()
        {
            //load case's data and display on a list;
            lblcaseid.DataBindings.Add("Text", DM.dsbigeye, "T_Case.CaseID");
           
            //disable the txt and buttons unless click the assign or modify
            txthours.Visible = false;
            dtpdataassign.Visible = false;
            lblhours.Visible = false;
            lbldataassigned.Visible = false;
            btmodifysave.Visible = false;
            btmodifycancel.Visible = false;
            lblid.Visible = false;

            //display the name of client on the listbox
            lstcase.DataSource = DM.dsbigeye;
            lstcase.DisplayMember = "T_Case.CaseID";
            lstcase.ValueMember = "T_Case.CaseID";
            //cmCase = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Case"];

            List<string> InvestIdName = new List<string>();
            DataRow FirstCaseinvests = DM.dtassignment.Rows[0];
            if (FirstCaseinvests["InvestigatorID"].ToString() != "")
            {
                DataRow[] Investrows = DM.dtinvestigator.Select("InvestigatorID = " + FirstCaseinvests["InvestigatorID"]);
                foreach (DataRow rows in Investrows)
                {
                    InvestIdName.Add(rows["InvestigatorID"].ToString() + ".\t"
                        + rows["FirstName"].ToString() + " " + rows["LastName"].ToString() + "\t"
                        + FirstCaseinvests["Hours"] + "\t" + FirstCaseinvests["DateAssigned"]);
                }
            }
            lstInvest.DataSource = InvestIdName;
            

        }
        ///<Summary> method : btreturn_Click
        /////close the form
        ///</Summary>
        private void btreturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method : cboxaddclientid_SelectedIndexChanged
        /////when change the seleted item in the combo box, read the first char as id
        ///</Summary>
        private void lstcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmCase != null && editdata==false)
            {
                //get the client record matching the clientid
                DataRow caserow = DM.dtcase.Rows[cmCase.Position];
                if ( caserow["CaseID"] != null)
                {
                    DataRow CaseClient = DM.dtclient.Select("ClientID = " + caserow["ClientID"]).FirstOrDefault();
                    if (CaseClient != null)
                        lblclient.Text = CaseClient["ClientID"].ToString() + "," + CaseClient["FirstName"].ToString() + " " + CaseClient["LastName"].ToString();
                }
                List<string> InvestIdName = new List<string>();
                
                // get the assignment record matching the case which has assigned
                DataRow[] drassignment = caserow.GetChildRows(DM.dtcase.ChildRelations["T_Case_T_Assignment"]);

                if (drassignment.Length > 0)//check if the case has been assigned
                {
                    foreach (DataRow drCaseAssignment in drassignment)
                    {
                        int aInvestID = Convert.ToInt32(drCaseAssignment["InvestigatorID"].ToString());
                        cmInvest.Position = DM.investigatorView.Find(aInvestID);
                        DataRow drInvest = DM.dtinvestigator.Rows[cmInvest.Position];
                        InvestIdName.Add(drInvest["InvestigatorID"].ToString() + ".\t" 
                            + drInvest["FirstName"].ToString() + " " + drInvest["LastName"].ToString() + "\t"
                            + drCaseAssignment["Hours"] + "\t" + drCaseAssignment["DateAssigned"]);
                    }
                }
                lstInvest.DataSource = InvestIdName;
            }
        }
        ///<Summary> method : btprevious_Click
        /////move the currencymanager up 1 position
        ///</Summary>
        private void btprevious_Click(object sender, EventArgs e)
        {
            if (cmCase.Position > 0)
            {
                --cmCase.Position;
            }
        }
        ///<Summary> method : btnext_Click
        /////move the currencymanager down 1 position
        ///</Summary>
        private void btnext_Click(object sender, EventArgs e)
        {
            if (cmCase.Position < cmCase.Count - 1)
            {
                ++cmCase.Position;
            }
        }
        ///<Summary> method : btadd_Click
        /////display the panal
        ///</Summary>
        private void btadd_Click(object sender, EventArgs e)
        {
            DataRow CheckCaseStutasRow = DM.dtcase.Select("CaseID =" + lblcaseid.Text).FirstOrDefault();
            if (CheckCaseStutasRow["Status"].ToString() == "Closed") //check case status
            {
                MessageBox.Show("Cannot assign investigators to closed cases", "Error");
            }
            else
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

                //display the details on the combo box
                List<string> Investigatorids = new List<string>();
                DataRow[] InvestigatorRow = DM.dtinvestigator.Select();
                foreach (DataRow row in InvestigatorRow)
                {
                    Investigatorids.Add(row["InvestigatorID"].ToString() + "," + row["FirstName"].ToString() + " " + row["LastName"].ToString());
                }
                DataRow[] typerows = DM.dtcase.Select();
                cboxassigninvest.DataSource = Investigatorids;
            }
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
            editdata = true;
        }
        ///<Summary> method : btaddsave_Click
        /////save the data and update to datamodule
        ///</Summary>
        private void btaddsave_Click(object sender, EventArgs e)
        {
            try
            {
                int hours = Convert.ToInt32(txtassignhours.Text);
                if (hours == 0)
                    MessageBox.Show("You may type in a number more than 0 in hours ", "Error");
                else
                {
                    try
                    {
                        DataRow newAssignment = DM.dtassignment.NewRow();
                        newAssignment["CaseID"] = lblcaseid.Text;
                        int end = cboxassigninvest.Text.LastIndexOf(",");
                        newAssignment["InvestigatorID"] = cboxassigninvest.Text.Substring(0, end);
                        newAssignment["Hours"] = hours;
                        newAssignment["DateAssigned"] = dtpassignnewdata.Value;
                        DM.dsbigeye.Tables["T_Assignment"].Rows.Add(newAssignment); //add a new row to dataset
                        DM.UpdateAssignment();
                        MessageBox.Show("The case assigned successfully", "Success");
                        btaddcancel_Click(sender, e);
                        editdata = false;
                        lstcase_SelectedIndexChanged(sender, e);
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("This Investigator has already been assigned to this case.", "Error");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You may type in number in hours only", "Error");
            }
            return;
        }
        ///<Summary> method : btmodify_Click
        /////enable the button and show modify panal
        ///</Summary>
        private void btmodify_Click(object sender, EventArgs e)
        {
            DataRow CheckCaseStutasRow = DM.dtcase.Select("CaseID =" + lblcaseid.Text).FirstOrDefault();
            if (CheckCaseStutasRow["Status"].ToString() == "Closed") //check case status
            {
                MessageBox.Show("Cannot modify Investigators on a closed Case", "Error");
            }
            else
            {
                lstcase.Enabled = false;
                lblhours.Visible = true;
                lbldataassigned.Visible = true;
                txthours.Visible = true;
                dtpdataassign.Visible = true;

                btprevious.Enabled = false;
                btnext.Enabled = false;
                btmodifycancel.Visible = true;
                btmodifysave.Visible = true;
                btdelete.Enabled = false;
                btadd.Enabled = false;
                btmodify.Enabled = false;
            }
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
            lblhours.Visible = false;
            lbldataassigned.Visible = false;
            txthours.Visible = false;
            dtpdataassign.Visible = false;
        }
        ///<Summary> method : btmodifysave_Click
        /////save data and update to datamodule
        ///</Summary>
        private void btmodifysave_Click(object sender, EventArgs e)
        {
            string CaseID = DM.dtcase.Rows[cmCase.Position]["CaseID"].ToString();
            string InvestID = lblid.Text;//DM.dtassignment.Rows[cmCtoAtoI.Position]["InvestigatorID"].ToString();
            int row = 0;
            for (int i = 0; i < DM.dtassignment.Rows.Count; i++)
            {
                string cID = DM.dtassignment.Rows[i]["CaseID"].ToString();
                string iID = DM.dtassignment.Rows[i]["InvestigatorID"].ToString();
                if (CaseID == cID && InvestID == iID)
                {
                    row = i;
                }
            }
            try
            {
                int hours = Convert.ToInt32(txthours.Text);
                if (hours == 0)
                    MessageBox.Show("You may type in a number more than 0 in hours ", "Error");
                else
                {
                    DataRow Modifyrow = DM.dsbigeye.Tables["T_Assignment"].Rows[row];
                    Modifyrow["Hours"] = txthours.Text;
                    Modifyrow["DateAssigned"] = dtpdataassign.Value;
                    cmCase.EndCurrentEdit();
                    DM.UpdateAssignment();
                    MessageBox.Show("The case assigned successfully", "Success");
                    btmodifycancel_Click(sender, e);
                    lstcase_SelectedIndexChanged(sender, e);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You may type in number in hours only", "Error");
            }
            return;
           
        }
        ///<Summary> method : btdelete_Click
        /////delete the case and update to datamodule
        ///</Summary>
        private void btdelete_Click(object sender, EventArgs e)
        {
            DataRow CheckCaseStutasRow = DM.dtcase.Select("CaseID =" + lblcaseid.Text).FirstOrDefault();
            if (CheckCaseStutasRow["Status"].ToString() == "Open") //check case status
            {
                string CaseID = DM.dtcase.Rows[cmCase.Position]["CaseID"].ToString();
                string InvestID = lblid.Text;//DM.dtassignment.Rows[cmCtoAtoI.Position]["InvestigatorID"].ToString();
                int row = 0;
                for (int i = 0; i < DM.dtassignment.Rows.Count; i++)
                {
                    string cID = DM.dtassignment.Rows[i]["CaseID"].ToString();
                    string iID = DM.dtassignment.Rows[i]["InvestigatorID"].ToString();
                    if (CaseID == cID && InvestID == iID)
                    {
                        row = i;
                    }
                }
                DataRow dr = DM.dsbigeye.Tables["T_Assignment"].Rows[row];
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    dr.Delete();
                }
                DM.UpdateAssignment(); //update database
            }
            else
            {
                MessageBox.Show("You may only remove Investigators from open cases", "Error");
                return;
            }
            lstcase_SelectedIndexChanged(sender, e);
        }
        ///<Summary> method : lstInvest_SelectedIndexChanged
        /////when change the seleted item in the list, get the infornation of investigator and binding data again
        ///</Summary>
        private void lstInvest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectinvest = lstInvest.SelectedItem as string;
            int end = selectinvest.LastIndexOf(".");
            lblid.Text = selectinvest.Substring(0, end);
        }
    }
    
}
