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
    public partial class equipmentform : Form
    {
        private datamodule DM;
        private mainform frmMenu;
        private CurrencyManager currencyManager;
        private string ModifyInvestigator;
        public equipmentform(datamodule dm, mainform mnu)
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
            txtaddinvestid.Enabled = false;
        }
        ///<Summary> method : display
        /////display the data on the form and binding data into the list
        ///</Summary>
        public void display()
        {
            //load equipment's data and display on the right place;
            lblequipmentid.DataBindings.Add("Text", DM.dsbigeye, "T_Equipment.EquipmentID");
            txtdescription.DataBindings.Add("Text", DM.dsbigeye, "T_Equipment.Description");

            //disable the txt unless click the add or modify
            txtdescription.Enabled = false;
            cboxinvestid.Enabled = false;

            //display the name of investigator on the combo box
            DataRow FirstEquipment = DM.dtequipmentform.Rows[0];
            if (FirstEquipment["InvestigatorID"] != null && !string.IsNullOrEmpty(FirstEquipment["InvestigatorID"].ToString()))
            {
                DataRow Invest = DM.dtinvestigator.Select("InvestigatorID = " + FirstEquipment["InvestigatorID"]).FirstOrDefault();
                if (Invest != null)
                {
                    cboxinvestid.Text = Invest["InvestigatorID"].ToString() + "," + Invest["FirstName"].ToString() + " " + Invest["LastName"].ToString();
                }
            }

            //display the name of equipment on the listbox
            lstequipment.DataSource = DM.dsbigeye;
            lstequipment.DisplayMember = "T_Equipment.Description";
            lstequipment.ValueMember = "T_Equipment.Description";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Equipment"];

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
            lstequipment.Enabled = false; //disable the listbox
            lstequipment.SelectedItem = null;
            btdelete.Enabled = false; // disable buttons
            btprevious.Enabled = false;
            btnext.Enabled = false;
            btmodify.Enabled = false;
            btadd.Enabled = false;
            pnladd.Show();
        }
        ///<Summary> method : btaddsave_Click
        /////save the data and update to datamodule
        ///</Summary>
        private void btaddsave_Click(object sender, EventArgs e)
        {
            lblequipmentid.Text = "";
            DataRow newEquipmentRow = DM.dtequipmentform.NewRow();
            if ((txtadddescription.Text == "") )
            {
                MessageBox.Show("You must type in details of the description", "Error");
            }
            else
            {
                    newEquipmentRow["Description"] = txtadddescription.Text;
                    newEquipmentRow["InvestigatorID"] = DBNull.Value;
                    DM.dtequipmentform.Rows.Add(newEquipmentRow);
                    MessageBox.Show("Equipment added successfully", "Success");
                    DM.UpdateEquipment();
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
            lstequipment.Enabled = true;
            lstequipment.Visible = true;
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
            txtdescription.Enabled = true;
            cboxinvestid.Enabled = true;

            btmodifycancel.Visible = true;
            btmodifysave.Visible = true;
            btdelete.Enabled = false;
            btadd.Enabled = false;
            btmodify.Enabled = false;
            btprevious.Enabled = false;
            btnext.Enabled = false;

            List<string> Investigatorname = new List<string>();
            DataRow[] Investigatorrows = DM.dtinvestigator.Select();
            foreach (DataRow row in Investigatorrows)
            {
                Investigatorname.Add(row["InvestigatorID"].ToString() + "," + row["FirstName"].ToString() + " " + row["LastName"].ToString());
            }
            
            cboxinvestid.DataSource = Investigatorname.Distinct().ToList();
        }
        ///<Summary> method : btmodifysave_Click
        /////save data and update to datamodule
        ///</Summary>
        private void btmodifysave_Click(object sender, EventArgs e)
        {
            DataRow ModifyEquipmentRow = DM.dtequipmentform.Rows[currencyManager.Position];
            if (txtdescription.Text == "")
            {
                MessageBox.Show("You must type in description of the Equipment", "Error");
            }
            else
            {
                ModifyEquipmentRow["Description"] = txtdescription.Text;
                ModifyEquipmentRow["InvestigatorID"] = ModifyInvestigator;
               
                currencyManager.EndCurrentEdit();
                DM.UpdateEquipment();
                MessageBox.Show("Equipment updated successfully", "Success");
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
            lstequipment.Enabled = true;
            lstequipment.Visible = true;
            btdelete.Enabled = true;
            btnext.Enabled = true;
            btprevious.Enabled = true;
            btmodify.Enabled = true;
            btadd.Enabled = true;
            txtdescription.Enabled = false;
            cboxinvestid.Enabled = false;
            btnext.Enabled = true;
            btprevious.Enabled = true;
        }
        ///<Summary> method : btreturn_Click
        /////close the form
        ///</Summary>
        private void btreturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method : btdelete_Click
        /////delete the equipment and update to datamodule
        ///</Summary>
        private void btdelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtequipmentform.Rows[currencyManager.Position];
            if (deleteEquipmentRow["InvestigatorID"].ToString() == "") //check investigator status
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        deleteEquipmentRow.Delete();
                    }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("You may only delete Equipment that is not assigned to an investigator", "Error");
                return;
            }
            DM.UpdateEquipment();
        }
        ///<Summary> method : btremoveinvestigator_Click
        /////remove the investigator and update to datamodule
        ///</Summary>
        private void btremoveinvestigator_Click(object sender, EventArgs e)
        {
            DataRow RemoveInvestigatorRow = DM.dtequipmentform.Rows[currencyManager.Position];
            RemoveInvestigatorRow["InvestigatorID"] = DBNull.Value;
            currencyManager.EndCurrentEdit();
            DM.UpdateEquipment();
            MessageBox.Show("Investigator removed successfully", "Success");
            cboxinvestid.Text = "";
            return;
        }
        ///<Summary> method : cboxinvestid_SelectedIndexChanged
        /////get the text in the combo box and read the first char as id
        ///</Summary>
        private void cboxinvestid_SelectedIndexChanged(object sender, EventArgs e)
        {            
            int end = cboxinvestid.Text.LastIndexOf(",");
            if (end > 0)
                ModifyInvestigator = cboxinvestid.Text.Substring(0, end);
            else
                ModifyInvestigator = null;
        }
        ///<Summary> method : lstequipment_SelectedIndexChanged
        /////when change the seleted item in the list, get the information of equipment and binding data again
        ///</Summary>
        private void lstequipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currencyManager != null)
            {
                DataRow CurrentEquipment = DM.dtequipmentform.Rows[currencyManager.Position];
                if (CurrentEquipment["InvestigatorID"] != null && !string.IsNullOrEmpty(CurrentEquipment["InvestigatorID"].ToString()))
                {
                    DataRow InvestClient = DM.dtinvestigator.Select("InvestigatorID = " + CurrentEquipment["InvestigatorID"]).FirstOrDefault();
                    if (InvestClient != null)
                    {
                        cboxinvestid.Text = InvestClient["InvestigatorID"].ToString() + "," + InvestClient["FirstName"].ToString() + " " + InvestClient["LastName"].ToString();
                    }
                }
            }
        }
    }
}
