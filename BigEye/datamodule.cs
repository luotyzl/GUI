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

namespace BigEye
{
    public partial class datamodule : Form
    {
        public DataTable dtclient;
        public DataTable dtinvestigator;
        public DataTable dtequipmentform;
        public DataTable dtcase;
        public DataTable dtassignment;
        public DataView clientView;
        public DataView investigatorView;
        public DataView equptmentView;
        public DataView caseView;
        public DataView assignmentView;
        public datamodule()
        {
            InitializeComponent();
            dsbigeye.EnforceConstraints = false;
            daclient.Fill(dsbigeye);
            dainvestigator.Fill(dsbigeye);
            daequipment.Fill(dsbigeye);
            dacase.Fill(dsbigeye);
            daassignment.Fill(dsbigeye);
            dtclient = dsbigeye.Tables["T_Client"];
            dtinvestigator = dsbigeye.Tables["T_Investigator"];
            dtequipmentform = dsbigeye.Tables["T_Equipment"];
            dtcase = dsbigeye.Tables["T_Case"];
            dtassignment = dsbigeye.Tables["T_Assignment"];

            clientView = new DataView(dtclient);
            clientView.Sort = "ClientID";
            investigatorView = new DataView(dtinvestigator);
            investigatorView.Sort = "InvestigatorID";
            caseView = new DataView(dtcase);
            caseView.Sort = "CaseID";

            dsbigeye.EnforceConstraints = true;
        }
        ///<Summary> method : UpdateClient
        /////update information to bigeye. mdb
        ///</Summary>
        public void UpdateClient()
        {
            daclient.Update(dtclient);
        }
        ///<Summary> method : UpdateInvestigator
        /////update information to bigeye. mdb
        ///</Summary>
        public void UpdateInvestigator()
        {
            dainvestigator.Update(dtinvestigator);
        }
        ///<Summary> method : UpdateEquipment
        /////update information to bigeye. mdb
        ///</Summary>
        public void UpdateEquipment()
        {
            daequipment.Update(dtequipmentform);
        }
        ///<Summary> method : UpdateCase
        /////update information to bigeye. mdb
        ///</Summary>
        public void UpdateCase()
        {
            dacase.Update(dtcase);
        }
        ///<Summary> method : UpdateAssignment
        /////update information to bigeye. mdb
        ///</Summary>
        public void UpdateAssignment()
        {
            daassignment.Update(dtassignment);
        }
        ///<Summary> method : daclient_RowUpdated_1
        /////to solve the -1 problem when delete data
        ///</Summary>
        private void daclient_RowUpdated_1(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnbigeye);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the ClientID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientID"] = newID;
            }
        }
        ///<Summary> method : dainvestigator_RowUpdated
        /////to solve the -1 problem when delete data
        ///</Summary>
        private void dainvestigator_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnbigeye);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the InvestigatorID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["InvestigatorID"] = newID;
            }
        }
        ///<Summary> method : daequipment_RowUpdated
        /////to solve the -1 problem when delete data
        ///</Summary>
        private void daequipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnbigeye);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the EquipmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EquipmentID"] = newID;
            }
        }
        ///<Summary> method : dacase_RowUpdated
        /////to solve the -1 problem when delete data
        ///</Summary>
        private void dacase_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnbigeye);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and
                // store it in the CaseID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CaseID"] = newID;
            }
        }
    }
}
