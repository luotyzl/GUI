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
    public partial class mainform : Form
    {
        private datamodule DM;                          // the reference to the form that holds the data components
        private clientform frmclient;                   // the reference to the client form
        private investigatorform frminvestigator;       // the reference to the investigator form
        private equipmentform frmequipment;             // the reference to the equipment form
        private caseform frmcase;                       // the reference to the case form
        private assignmentform frmassignment;           // the reference to the assignment form
        private Invoicesform frmInvoice;                // the reference to the  Invoice form
        public mainform()
        {
            InitializeComponent();
        }

        ///<Summary> method : mainform_Load
        /////create the data module and load the dataset
        ///</Summary>
        private void mainform_Load(object sender, EventArgs e)
        {
            DM = new datamodule(); 
        }
        ///<Summary> method : btexit_Click
        /////close
        ///</Summary>
        private void btexit_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method : btclient_Click
        ///open the form client
        ///</Summary>
        private void btclient_Click(object sender, EventArgs e)
        {
            if (frmclient == null)
            {
                frmclient = new clientform(DM, this);
            }
            frmclient.ShowDialog();
        }
        ///<Summary> method : btclient_Click
        ///open the form investigator
        ///</Summary>
        private void btinvestigator_Click(object sender, EventArgs e)
        {
            if (frminvestigator == null)
            {
                frminvestigator = new investigatorform(DM, this);
            }
            frminvestigator.ShowDialog();
        }
        ///<Summary> method : btclient_Click
        ///open the form equipment
        ///</Summary>
        private void btequipment_Click(object sender, EventArgs e)
        {
            if (frmequipment == null)
            {
                frmequipment = new equipmentform(DM, this);
            }
            frmequipment.ShowDialog();
        }
        ///<Summary> method : btclient_Click
        ///open the form case
        ///</Summary>
        private void btcase_Click(object sender, EventArgs e)
        {
            if (frmcase == null)
            {
                frmcase = new caseform(DM, this);
            }
            frmcase.ShowDialog();
        }
        ///<Summary> method : btclient_Click
        ///open the form assignment
        ///</Summary>
        private void btcaseassignment_Click(object sender, EventArgs e)
        {
            if (frmassignment == null)
            {
                frmassignment = new assignmentform(DM, this);
            }
            frmassignment.ShowDialog();
        }
        ///<Summary> method : btclient_Click
        ///open the form Invoices
        ///</Summary>
        private void btInvoices_Click(object sender, EventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new Invoicesform(DM, this);
            }
            frmInvoice.ShowDialog();
        }
    }
}
