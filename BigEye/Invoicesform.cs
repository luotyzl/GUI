using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigEye
{
    public partial class Invoicesform : Form
    {
        private datamodule DM;
        private mainform frmMenu;
        private string stringToPrint;
        private string Doc;
        public Invoicesform(datamodule dm, mainform mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            
        }
        ///<Summary> method : btnReturn_Click
        /////close
        ///</Summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        ///<Summary> method : btnDisplayReport_Click
        /////display the detail on a textbox follow the format 
        ///</Summary>
        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
            CurrencyManager cmClient;
            CurrencyManager cmInvest;
            CurrencyManager cmCase;
            string clientText = "";
            double CaseTotal = 0;
            cmClient = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Client"];
            cmInvest = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Investigator"];
            cmCase = (CurrencyManager)this.BindingContext[DM.dsbigeye, "T_Case"];
            txtInvoices.Text = "";

            foreach (DataRow drCase in DM.dtcase.Rows)
            {
                string CaseStatus = drCase["Status"].ToString();
                if (CaseStatus.Equals("Open") == true) //check the status
                {
                    // get the client record matching the client ID from the case record
                    int aClientID = Convert.ToInt32(drCase["ClientID"].ToString());
                    cmClient.Position = DM.clientView.Find(aClientID);
                    DataRow drClient = DM.dtclient.Rows[cmClient.Position];

                    //OUTPUT  client details (client ID, LastName, FirstName, StreetAddress, and Suburb city,phone)
                    clientText += "Client ID: " + drClient["ClientID"] + "\r\n";
                    clientText += "Name: " + drClient["FirstName"] + " " + drClient["LastName"] + "\r\n";
                    clientText += "Address: " + drClient["StreetAddress"] + "\r\n";
                    clientText += "Subrub: " + drClient["Suburb"] + "\r\n";
                    clientText += "City: " + drClient["City"] + "\r\n";
                    clientText += "Phone: " + drClient["PhoneNumber"] + "\r\n";
                    clientText += "Case Description: " + drCase["Description"] + "\r\n" + "Date Opened: " + drCase["DateOpened"] + "\r\n\r\n\r\n";

                    // get the assignment record matching the case ID from the case record
                    DataRow[] drassignment = drCase.GetChildRows(DM.dtcase.ChildRelations["T_Case_T_Assignment"]);

                    //if there are assignments, output it
                    if (drassignment.Length >0)
                    {
                        txtInvoices.Text += clientText;
                        foreach (DataRow drCaseAssignment in drassignment)
                        {
                            string AssignmentText = "";
                            int aInvestID = Convert.ToInt32(drCaseAssignment["InvestigatorID"].ToString());
                            cmInvest.Position = DM.investigatorView.Find(aInvestID);
                            DataRow drInvest = DM.dtinvestigator.Rows[cmInvest.Position];
                            double InvestigatorCost;
                            InvestigatorCost = Convert.ToDouble(drInvest["HourlyRate"]) * Convert.ToDouble(drCaseAssignment["Hours"]);
                            //count total 
                            CaseTotal += InvestigatorCost;

                            //output investigator details
                            AssignmentText += "\t Investigator: " + drInvest["FirstName"] + " " + drInvest["LastName"];
                            AssignmentText += "\t Hours: "+drCaseAssignment["Hours"] + "\r\n";
                            AssignmentText += "\t Investigator Cost: " + InvestigatorCost.ToString() + "\r\n";
                            txtInvoices.Text += AssignmentText;
                        }

                        //output the total
                        txtInvoices.Text += "\r\n";
                        txtInvoices.Text += "Case_Total: $" + Convert.ToString(CaseTotal);
                        txtInvoices.Text += "\r\n\r\n\r\n\r\n";

                        //break to next page
                        //count++;
                    }
                    clientText = ""; //clear clienttext string,for next record
                    CaseTotal = 0;
                    
                }
                Doc = txtInvoices.Text;
                stringToPrint = Doc;
            }
        }
        ///<Summary> method : btnPrintReport_Click
        /////display a print preview form 
        ///</Summary>
        private void btnPrintReport_Click(object sender, EventArgs e)
        {

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(printForm_PrintPage);
            // Print the document.
            printPreviewDialog1.Document = pd;
            printPreviewDialog1.ShowDialog();

        }
        ///<Summary> method : printForm_PrintPage
        /////define how to print and how to divise pages
        ///</Summary>
        private void printForm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs ev)
        {
            string temp = stringToPrint;
            temp = temp.Substring(temp.IndexOf("Client ID:") + 10);
            int index = temp.IndexOf("Client ID:");
            if (index == -1)
            {
                temp = stringToPrint.Substring(0);
            }
            else
                temp = stringToPrint.Substring(0, index + 10);
            ev.Graphics.DrawString(temp, this.Font, Brushes.Black, ev.MarginBounds, StringFormat.GenericTypographic);
            stringToPrint = stringToPrint.Substring(index + 10);
            ev.HasMorePages = (stringToPrint.Length > 0);
            if (!ev.HasMorePages)
                stringToPrint = Doc;
            if (stringToPrint.IndexOf("Client ID:") == -1)
            {
                ev.HasMorePages = false;
                stringToPrint = Doc;
            }
        }
        
    }
}
