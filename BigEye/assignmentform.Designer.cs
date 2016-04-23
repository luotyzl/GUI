namespace BigEye
{
    partial class assignmentform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnladd = new System.Windows.Forms.Panel();
            this.cboxassigninvest = new System.Windows.Forms.ComboBox();
            this.btaddcancel = new System.Windows.Forms.Button();
            this.btaddsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpassignnewdata = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtassignhours = new System.Windows.Forms.TextBox();
            this.pnlmodify = new System.Windows.Forms.Panel();
            this.lblclient = new System.Windows.Forms.Label();
            this.lblclientno = new System.Windows.Forms.Label();
            this.dtpdataassign = new System.Windows.Forms.DateTimePicker();
            this.btmodifycancel = new System.Windows.Forms.Button();
            this.btmodifysave = new System.Windows.Forms.Button();
            this.txthours = new System.Windows.Forms.TextBox();
            this.lblhours = new System.Windows.Forms.Label();
            this.lbldataassigned = new System.Windows.Forms.Label();
            this.lblcaseid = new System.Windows.Forms.Label();
            this.lblcaseno = new System.Windows.Forms.Label();
            this.btreturn = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btmodify = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.lstcase = new System.Windows.Forms.ListBox();
            this.lstInvest = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.pnladd.SuspendLayout();
            this.pnlmodify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladd
            // 
            this.pnladd.Controls.Add(this.cboxassigninvest);
            this.pnladd.Controls.Add(this.btaddcancel);
            this.pnladd.Controls.Add(this.btaddsave);
            this.pnladd.Controls.Add(this.label4);
            this.pnladd.Controls.Add(this.label7);
            this.pnladd.Controls.Add(this.dtpassignnewdata);
            this.pnladd.Controls.Add(this.label6);
            this.pnladd.Controls.Add(this.txtassignhours);
            this.pnladd.Location = new System.Drawing.Point(12, 326);
            this.pnladd.Name = "pnladd";
            this.pnladd.Size = new System.Drawing.Size(407, 131);
            this.pnladd.TabIndex = 50;
            // 
            // cboxassigninvest
            // 
            this.cboxassigninvest.FormattingEnabled = true;
            this.cboxassigninvest.Location = new System.Drawing.Point(117, 11);
            this.cboxassigninvest.Name = "cboxassigninvest";
            this.cboxassigninvest.Size = new System.Drawing.Size(121, 20);
            this.cboxassigninvest.TabIndex = 64;
            // 
            // btaddcancel
            // 
            this.btaddcancel.Location = new System.Drawing.Point(278, 100);
            this.btaddcancel.Name = "btaddcancel";
            this.btaddcancel.Size = new System.Drawing.Size(104, 21);
            this.btaddcancel.TabIndex = 32;
            this.btaddcancel.Text = "Cancel";
            this.btaddcancel.UseVisualStyleBackColor = true;
            this.btaddcancel.Click += new System.EventHandler(this.btaddcancel_Click);
            // 
            // btaddsave
            // 
            this.btaddsave.Location = new System.Drawing.Point(70, 100);
            this.btaddsave.Name = "btaddsave";
            this.btaddsave.Size = new System.Drawing.Size(135, 21);
            this.btaddsave.TabIndex = 22;
            this.btaddsave.Text = "Save Assignment";
            this.btaddsave.UseVisualStyleBackColor = true;
            this.btaddsave.Click += new System.EventHandler(this.btaddsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "Investigator:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 57;
            this.label7.Text = "DateAssigned:";
            // 
            // dtpassignnewdata
            // 
            this.dtpassignnewdata.Location = new System.Drawing.Point(117, 66);
            this.dtpassignnewdata.Name = "dtpassignnewdata";
            this.dtpassignnewdata.Size = new System.Drawing.Size(115, 21);
            this.dtpassignnewdata.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "Hours:";
            // 
            // txtassignhours
            // 
            this.txtassignhours.Location = new System.Drawing.Point(117, 37);
            this.txtassignhours.Name = "txtassignhours";
            this.txtassignhours.Size = new System.Drawing.Size(115, 21);
            this.txtassignhours.TabIndex = 58;
            // 
            // pnlmodify
            // 
            this.pnlmodify.Controls.Add(this.lblclient);
            this.pnlmodify.Controls.Add(this.lblclientno);
            this.pnlmodify.Controls.Add(this.dtpdataassign);
            this.pnlmodify.Controls.Add(this.btmodifycancel);
            this.pnlmodify.Controls.Add(this.btmodifysave);
            this.pnlmodify.Controls.Add(this.txthours);
            this.pnlmodify.Controls.Add(this.lblhours);
            this.pnlmodify.Controls.Add(this.lbldataassigned);
            this.pnlmodify.Location = new System.Drawing.Point(232, 27);
            this.pnlmodify.Name = "pnlmodify";
            this.pnlmodify.Size = new System.Drawing.Size(407, 125);
            this.pnlmodify.TabIndex = 49;
            // 
            // lblclient
            // 
            this.lblclient.AutoSize = true;
            this.lblclient.Location = new System.Drawing.Point(115, 14);
            this.lblclient.Name = "lblclient";
            this.lblclient.Size = new System.Drawing.Size(41, 12);
            this.lblclient.TabIndex = 55;
            this.lblclient.Text = "Client";
            // 
            // lblclientno
            // 
            this.lblclientno.AutoSize = true;
            this.lblclientno.Location = new System.Drawing.Point(17, 14);
            this.lblclientno.Name = "lblclientno";
            this.lblclientno.Size = new System.Drawing.Size(47, 12);
            this.lblclientno.TabIndex = 54;
            this.lblclientno.Text = "Client:";
            // 
            // dtpdataassign
            // 
            this.dtpdataassign.Location = new System.Drawing.Point(117, 65);
            this.dtpdataassign.Name = "dtpdataassign";
            this.dtpdataassign.Size = new System.Drawing.Size(115, 21);
            this.dtpdataassign.TabIndex = 34;
            // 
            // btmodifycancel
            // 
            this.btmodifycancel.Location = new System.Drawing.Point(277, 94);
            this.btmodifycancel.Name = "btmodifycancel";
            this.btmodifycancel.Size = new System.Drawing.Size(104, 21);
            this.btmodifycancel.TabIndex = 21;
            this.btmodifycancel.Text = "Cancel";
            this.btmodifycancel.UseVisualStyleBackColor = true;
            this.btmodifycancel.Click += new System.EventHandler(this.btmodifycancel_Click);
            // 
            // btmodifysave
            // 
            this.btmodifysave.Location = new System.Drawing.Point(70, 94);
            this.btmodifysave.Name = "btmodifysave";
            this.btmodifysave.Size = new System.Drawing.Size(135, 21);
            this.btmodifysave.TabIndex = 20;
            this.btmodifysave.Text = "Update Investigator";
            this.btmodifysave.UseVisualStyleBackColor = true;
            this.btmodifysave.Click += new System.EventHandler(this.btmodifysave_Click);
            // 
            // txthours
            // 
            this.txthours.Location = new System.Drawing.Point(117, 36);
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(115, 21);
            this.txthours.TabIndex = 14;
            // 
            // lblhours
            // 
            this.lblhours.AutoSize = true;
            this.lblhours.Location = new System.Drawing.Point(17, 43);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(41, 12);
            this.lblhours.TabIndex = 8;
            this.lblhours.Text = "Hours:";
            // 
            // lbldataassigned
            // 
            this.lbldataassigned.AutoSize = true;
            this.lbldataassigned.Location = new System.Drawing.Point(17, 69);
            this.lbldataassigned.Name = "lbldataassigned";
            this.lbldataassigned.Size = new System.Drawing.Size(83, 12);
            this.lbldataassigned.TabIndex = 9;
            this.lbldataassigned.Text = "DateAssigned:";
            // 
            // lblcaseid
            // 
            this.lblcaseid.AutoSize = true;
            this.lblcaseid.Location = new System.Drawing.Point(347, 12);
            this.lblcaseid.Name = "lblcaseid";
            this.lblcaseid.Size = new System.Drawing.Size(41, 12);
            this.lblcaseid.TabIndex = 48;
            this.lblcaseid.Text = "CaseID";
            // 
            // lblcaseno
            // 
            this.lblcaseno.AutoSize = true;
            this.lblcaseno.Location = new System.Drawing.Point(249, 12);
            this.lblcaseno.Name = "lblcaseno";
            this.lblcaseno.Size = new System.Drawing.Size(47, 12);
            this.lblcaseno.TabIndex = 47;
            this.lblcaseno.Text = "CaseID:";
            // 
            // btreturn
            // 
            this.btreturn.Location = new System.Drawing.Point(509, 365);
            this.btreturn.Name = "btreturn";
            this.btreturn.Size = new System.Drawing.Size(129, 23);
            this.btreturn.TabIndex = 46;
            this.btreturn.Text = "Return";
            this.btreturn.UseVisualStyleBackColor = true;
            this.btreturn.Click += new System.EventHandler(this.btreturn_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(509, 297);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(129, 23);
            this.btdelete.TabIndex = 45;
            this.btdelete.Text = "Remove Investigator";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btmodify
            // 
            this.btmodify.Location = new System.Drawing.Point(367, 297);
            this.btmodify.Name = "btmodify";
            this.btmodify.Size = new System.Drawing.Size(136, 23);
            this.btmodify.TabIndex = 44;
            this.btmodify.Text = "Modify Assignment";
            this.btmodify.UseVisualStyleBackColor = true;
            this.btmodify.Click += new System.EventHandler(this.btmodify_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(226, 297);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(135, 23);
            this.btadd.TabIndex = 43;
            this.btadd.Text = "Assign Investigator";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(145, 297);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(75, 23);
            this.btnext.TabIndex = 42;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btprevious
            // 
            this.btprevious.Location = new System.Drawing.Point(11, 297);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(75, 23);
            this.btprevious.TabIndex = 41;
            this.btprevious.Text = "Previous";
            this.btprevious.UseVisualStyleBackColor = true;
            this.btprevious.Click += new System.EventHandler(this.btprevious_Click);
            // 
            // lstcase
            // 
            this.lstcase.FormattingEnabled = true;
            this.lstcase.ItemHeight = 12;
            this.lstcase.Location = new System.Drawing.Point(12, 12);
            this.lstcase.Name = "lstcase";
            this.lstcase.Size = new System.Drawing.Size(208, 280);
            this.lstcase.TabIndex = 40;
            this.lstcase.SelectedIndexChanged += new System.EventHandler(this.lstcase_SelectedIndexChanged);
            // 
            // lstInvest
            // 
            this.lstInvest.FormattingEnabled = true;
            this.lstInvest.ItemHeight = 12;
            this.lstInvest.Location = new System.Drawing.Point(232, 182);
            this.lstInvest.Name = "lstInvest";
            this.lstInvest.Size = new System.Drawing.Size(406, 100);
            this.lstInvest.TabIndex = 51;
            this.lstInvest.SelectedIndexChanged += new System.EventHandler(this.lstInvest_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 56;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 56;
            this.label2.Text = "DateAssigned";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 57;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 58;
            this.label5.Text = "Investigator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 59;
            this.label8.Text = "ID";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(536, 167);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(17, 12);
            this.lblid.TabIndex = 60;
            this.lblid.Text = "ID";
            // 
            // assignmentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 467);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstInvest);
            this.Controls.Add(this.pnladd);
            this.Controls.Add(this.pnlmodify);
            this.Controls.Add(this.lblcaseid);
            this.Controls.Add(this.lblcaseno);
            this.Controls.Add(this.btreturn);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btmodify);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btprevious);
            this.Controls.Add(this.lstcase);
            this.Name = "assignmentform";
            this.Text = "case assignment maintenance";
            this.pnladd.ResumeLayout(false);
            this.pnladd.PerformLayout();
            this.pnlmodify.ResumeLayout(false);
            this.pnlmodify.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnladd;
        private System.Windows.Forms.Button btaddcancel;
        private System.Windows.Forms.Button btaddsave;
        private System.Windows.Forms.Panel pnlmodify;
        private System.Windows.Forms.DateTimePicker dtpdataassign;
        private System.Windows.Forms.Button btmodifycancel;
        private System.Windows.Forms.Button btmodifysave;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Label lbldataassigned;
        private System.Windows.Forms.Label lblcaseid;
        private System.Windows.Forms.Label lblcaseno;
        private System.Windows.Forms.Button btreturn;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btmodify;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btprevious;
        private System.Windows.Forms.ListBox lstcase;
        private System.Windows.Forms.Label lblclientno;
        private System.Windows.Forms.Label lblclient;
        private System.Windows.Forms.ComboBox cboxassigninvest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpassignnewdata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtassignhours;
        private System.Windows.Forms.ListBox lstInvest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblid;
    }
}