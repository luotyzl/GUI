namespace BigEye
{
    partial class caseform
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
            this.dtpadddata = new System.Windows.Forms.DateTimePicker();
            this.cboxaddtype = new System.Windows.Forms.ComboBox();
            this.cboxaddclientid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btaddcancel = new System.Windows.Forms.Button();
            this.btaddsave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaddstatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtadddescription = new System.Windows.Forms.TextBox();
            this.lbladddescription = new System.Windows.Forms.Label();
            this.pnlmodify = new System.Windows.Forms.Panel();
            this.cboxclientid = new System.Windows.Forms.ComboBox();
            this.cboxtype = new System.Windows.Forms.ComboBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.lblcasetype = new System.Windows.Forms.Label();
            this.btmodifycancel = new System.Windows.Forms.Button();
            this.btmodifysave = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbldataopened = new System.Windows.Forms.Label();
            this.lblclientid = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblcaseid = new System.Windows.Forms.Label();
            this.lblcaseno = new System.Windows.Forms.Label();
            this.btreturn = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btmodify = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.lstcase = new System.Windows.Forms.ListBox();
            this.btmark = new System.Windows.Forms.Button();
            this.pnladd.SuspendLayout();
            this.pnlmodify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladd
            // 
            this.pnladd.Controls.Add(this.dtpadddata);
            this.pnladd.Controls.Add(this.cboxaddtype);
            this.pnladd.Controls.Add(this.cboxaddclientid);
            this.pnladd.Controls.Add(this.label1);
            this.pnladd.Controls.Add(this.btaddcancel);
            this.pnladd.Controls.Add(this.btaddsave);
            this.pnladd.Controls.Add(this.label3);
            this.pnladd.Controls.Add(this.txtaddstatus);
            this.pnladd.Controls.Add(this.label5);
            this.pnladd.Controls.Add(this.label4);
            this.pnladd.Controls.Add(this.txtadddescription);
            this.pnladd.Controls.Add(this.lbladddescription);
            this.pnladd.Location = new System.Drawing.Point(232, 157);
            this.pnladd.Name = "pnladd";
            this.pnladd.Size = new System.Drawing.Size(407, 131);
            this.pnladd.TabIndex = 38;
            // 
            // dtpadddata
            // 
            this.dtpadddata.Location = new System.Drawing.Point(277, 42);
            this.dtpadddata.Name = "dtpadddata";
            this.dtpadddata.Size = new System.Drawing.Size(116, 21);
            this.dtpadddata.TabIndex = 39;
            // 
            // cboxaddtype
            // 
            this.cboxaddtype.FormattingEnabled = true;
            this.cboxaddtype.Location = new System.Drawing.Point(88, 74);
            this.cboxaddtype.Name = "cboxaddtype";
            this.cboxaddtype.Size = new System.Drawing.Size(137, 20);
            this.cboxaddtype.TabIndex = 45;
            // 
            // cboxaddclientid
            // 
            this.cboxaddclientid.FormattingEnabled = true;
            this.cboxaddclientid.Location = new System.Drawing.Point(277, 72);
            this.cboxaddclientid.Name = "cboxaddclientid";
            this.cboxaddclientid.Size = new System.Drawing.Size(116, 20);
            this.cboxaddclientid.TabIndex = 44;
            this.cboxaddclientid.SelectedIndexChanged += new System.EventHandler(this.cboxaddclientid_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "CaseType:";
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
            this.btaddsave.Text = "Save Case";
            this.btaddsave.UseVisualStyleBackColor = true;
            this.btaddsave.Click += new System.EventHandler(this.btaddsave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "DateOpened:";
            // 
            // txtaddstatus
            // 
            this.txtaddstatus.Location = new System.Drawing.Point(88, 42);
            this.txtaddstatus.Name = "txtaddstatus";
            this.txtaddstatus.Size = new System.Drawing.Size(100, 21);
            this.txtaddstatus.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Client";
            // 
            // txtadddescription
            // 
            this.txtadddescription.Location = new System.Drawing.Point(88, 12);
            this.txtadddescription.Name = "txtadddescription";
            this.txtadddescription.Size = new System.Drawing.Size(305, 21);
            this.txtadddescription.TabIndex = 38;
            // 
            // lbladddescription
            // 
            this.lbladddescription.AutoSize = true;
            this.lbladddescription.Location = new System.Drawing.Point(5, 15);
            this.lbladddescription.Name = "lbladddescription";
            this.lbladddescription.Size = new System.Drawing.Size(77, 12);
            this.lbladddescription.TabIndex = 34;
            this.lbladddescription.Text = "Description:";
            // 
            // pnlmodify
            // 
            this.pnlmodify.Controls.Add(this.cboxclientid);
            this.pnlmodify.Controls.Add(this.cboxtype);
            this.pnlmodify.Controls.Add(this.dtpdata);
            this.pnlmodify.Controls.Add(this.lblcasetype);
            this.pnlmodify.Controls.Add(this.btmodifycancel);
            this.pnlmodify.Controls.Add(this.btmodifysave);
            this.pnlmodify.Controls.Add(this.txtstatus);
            this.pnlmodify.Controls.Add(this.txtdescription);
            this.pnlmodify.Controls.Add(this.lbldescription);
            this.pnlmodify.Controls.Add(this.lbldataopened);
            this.pnlmodify.Controls.Add(this.lblclientid);
            this.pnlmodify.Controls.Add(this.lblstatus);
            this.pnlmodify.Location = new System.Drawing.Point(232, 27);
            this.pnlmodify.Name = "pnlmodify";
            this.pnlmodify.Size = new System.Drawing.Size(407, 125);
            this.pnlmodify.TabIndex = 37;
            // 
            // cboxclientid
            // 
            this.cboxclientid.FormattingEnabled = true;
            this.cboxclientid.Location = new System.Drawing.Point(278, 70);
            this.cboxclientid.Name = "cboxclientid";
            this.cboxclientid.Size = new System.Drawing.Size(115, 20);
            this.cboxclientid.TabIndex = 36;
            // 
            // cboxtype
            // 
            this.cboxtype.FormattingEnabled = true;
            this.cboxtype.Location = new System.Drawing.Point(88, 70);
            this.cboxtype.Name = "cboxtype";
            this.cboxtype.Size = new System.Drawing.Size(137, 20);
            this.cboxtype.TabIndex = 35;
            // 
            // dtpdata
            // 
            this.dtpdata.Location = new System.Drawing.Point(215, 40);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(178, 21);
            this.dtpdata.TabIndex = 34;
            // 
            // lblcasetype
            // 
            this.lblcasetype.AutoSize = true;
            this.lblcasetype.Location = new System.Drawing.Point(23, 75);
            this.lblcasetype.Name = "lblcasetype";
            this.lblcasetype.Size = new System.Drawing.Size(59, 12);
            this.lblcasetype.TabIndex = 33;
            this.lblcasetype.Text = "CaseType:";
            // 
            // btmodifycancel
            // 
            this.btmodifycancel.Location = new System.Drawing.Point(278, 96);
            this.btmodifycancel.Name = "btmodifycancel";
            this.btmodifycancel.Size = new System.Drawing.Size(104, 21);
            this.btmodifycancel.TabIndex = 21;
            this.btmodifycancel.Text = "Cancel";
            this.btmodifycancel.UseVisualStyleBackColor = true;
            this.btmodifycancel.Click += new System.EventHandler(this.btmodifycancel_Click);
            // 
            // btmodifysave
            // 
            this.btmodifysave.Location = new System.Drawing.Point(70, 96);
            this.btmodifysave.Name = "btmodifysave";
            this.btmodifysave.Size = new System.Drawing.Size(135, 21);
            this.btmodifysave.TabIndex = 20;
            this.btmodifysave.Text = "Update  Case";
            this.btmodifysave.UseVisualStyleBackColor = true;
            this.btmodifysave.Click += new System.EventHandler(this.btmodifysave_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(88, 40);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(44, 21);
            this.txtstatus.TabIndex = 16;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(88, 10);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(305, 21);
            this.txtdescription.TabIndex = 14;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(5, 13);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(77, 12);
            this.lbldescription.TabIndex = 8;
            this.lbldescription.Text = "Description:";
            // 
            // lbldataopened
            // 
            this.lbldataopened.AutoSize = true;
            this.lbldataopened.Location = new System.Drawing.Point(138, 42);
            this.lbldataopened.Name = "lbldataopened";
            this.lbldataopened.Size = new System.Drawing.Size(71, 12);
            this.lbldataopened.TabIndex = 9;
            this.lbldataopened.Text = "DateOpened:";
            // 
            // lblclientid
            // 
            this.lblclientid.AutoSize = true;
            this.lblclientid.Location = new System.Drawing.Point(231, 75);
            this.lblclientid.Name = "lblclientid";
            this.lblclientid.Size = new System.Drawing.Size(47, 12);
            this.lblclientid.TabIndex = 13;
            this.lblclientid.Text = "Client:";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(35, 43);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(47, 12);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Status:";
            // 
            // lblcaseid
            // 
            this.lblcaseid.AutoSize = true;
            this.lblcaseid.Location = new System.Drawing.Point(283, 12);
            this.lblcaseid.Name = "lblcaseid";
            this.lblcaseid.Size = new System.Drawing.Size(41, 12);
            this.lblcaseid.TabIndex = 36;
            this.lblcaseid.Text = "CaseID";
            // 
            // lblcaseno
            // 
            this.lblcaseno.AutoSize = true;
            this.lblcaseno.Location = new System.Drawing.Point(230, 12);
            this.lblcaseno.Name = "lblcaseno";
            this.lblcaseno.Size = new System.Drawing.Size(47, 12);
            this.lblcaseno.TabIndex = 35;
            this.lblcaseno.Text = "CaseID:";
            // 
            // btreturn
            // 
            this.btreturn.Location = new System.Drawing.Point(535, 342);
            this.btreturn.Name = "btreturn";
            this.btreturn.Size = new System.Drawing.Size(104, 23);
            this.btreturn.TabIndex = 34;
            this.btreturn.Text = "Return";
            this.btreturn.UseVisualStyleBackColor = true;
            this.btreturn.Click += new System.EventHandler(this.btreturn_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(535, 297);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(104, 23);
            this.btdelete.TabIndex = 33;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btmodify
            // 
            this.btmodify.Location = new System.Drawing.Point(386, 297);
            this.btmodify.Name = "btmodify";
            this.btmodify.Size = new System.Drawing.Size(136, 23);
            this.btmodify.TabIndex = 32;
            this.btmodify.Text = "Modify Case";
            this.btmodify.UseVisualStyleBackColor = true;
            this.btmodify.Click += new System.EventHandler(this.btmodify_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(245, 297);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(135, 23);
            this.btadd.TabIndex = 31;
            this.btadd.Text = "Add Case";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(145, 297);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(75, 23);
            this.btnext.TabIndex = 30;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btprevious
            // 
            this.btprevious.Location = new System.Drawing.Point(11, 297);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(75, 23);
            this.btprevious.TabIndex = 29;
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
            this.lstcase.TabIndex = 28;
            this.lstcase.SelectedIndexChanged += new System.EventHandler(this.lstcase_SelectedIndexChanged);
            // 
            // btmark
            // 
            this.btmark.Location = new System.Drawing.Point(245, 327);
            this.btmark.Name = "btmark";
            this.btmark.Size = new System.Drawing.Size(135, 23);
            this.btmark.TabIndex = 39;
            this.btmark.Text = "Mark Case as Closed";
            this.btmark.UseVisualStyleBackColor = true;
            this.btmark.Click += new System.EventHandler(this.btmark_Click);
            // 
            // caseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 378);
            this.Controls.Add(this.btmark);
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
            this.Name = "caseform";
            this.Text = "case maintenance";
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
        private System.Windows.Forms.Label lblcasetype;
        private System.Windows.Forms.Button btmodifycancel;
        private System.Windows.Forms.Button btmodifysave;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lbldataopened;
        private System.Windows.Forms.Label lblclientid;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblcaseid;
        private System.Windows.Forms.Label lblcaseno;
        private System.Windows.Forms.Button btreturn;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btmodify;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btprevious;
        private System.Windows.Forms.ListBox lstcase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaddstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtadddescription;
        private System.Windows.Forms.Label lbladddescription;
        private System.Windows.Forms.ComboBox cboxaddtype;
        private System.Windows.Forms.ComboBox cboxaddclientid;
        private System.Windows.Forms.DateTimePicker dtpadddata;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.ComboBox cboxclientid;
        private System.Windows.Forms.ComboBox cboxtype;
        private System.Windows.Forms.Button btmark;
    }
}