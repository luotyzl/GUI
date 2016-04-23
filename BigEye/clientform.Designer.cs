namespace BigEye
{
    partial class clientform
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
            this.lstclient = new System.Windows.Forms.ListBox();
            this.btprevious = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btmodify = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btreturn = new System.Windows.Forms.Button();
            this.lblclientno = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblstreetaddress = new System.Windows.Forms.Label();
            this.lblsuburb = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lblclientid = new System.Windows.Forms.Label();
            this.pnlmodify = new System.Windows.Forms.Panel();
            this.btmodifycancel = new System.Windows.Forms.Button();
            this.btmodifysave = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtsuburb = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.pnladd = new System.Windows.Forms.Panel();
            this.btaddcancel = new System.Windows.Forms.Button();
            this.btaddsave = new System.Windows.Forms.Button();
            this.txtaddphone = new System.Windows.Forms.TextBox();
            this.txtaddcity = new System.Windows.Forms.TextBox();
            this.lbladdsuburb = new System.Windows.Forms.Label();
            this.txtaddsuburb = new System.Windows.Forms.TextBox();
            this.lbladdcity = new System.Windows.Forms.Label();
            this.txtaddaddress = new System.Windows.Forms.TextBox();
            this.lbladdaddress = new System.Windows.Forms.Label();
            this.txtaddlastname = new System.Windows.Forms.TextBox();
            this.lbladdphone = new System.Windows.Forms.Label();
            this.txtaddfirstname = new System.Windows.Forms.TextBox();
            this.lbladdlastname = new System.Windows.Forms.Label();
            this.lbladdfirstname = new System.Windows.Forms.Label();
            this.pnlmodify.SuspendLayout();
            this.pnladd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstclient
            // 
            this.lstclient.FormattingEnabled = true;
            this.lstclient.ItemHeight = 12;
            this.lstclient.Location = new System.Drawing.Point(13, 13);
            this.lstclient.Name = "lstclient";
            this.lstclient.Size = new System.Drawing.Size(208, 280);
            this.lstclient.TabIndex = 0;
            // 
            // btprevious
            // 
            this.btprevious.Location = new System.Drawing.Point(12, 298);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(75, 23);
            this.btprevious.TabIndex = 1;
            this.btprevious.Text = "Previous";
            this.btprevious.UseVisualStyleBackColor = true;
            this.btprevious.Click += new System.EventHandler(this.btprevious_Click);
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(146, 298);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(75, 23);
            this.btnext.TabIndex = 2;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(303, 298);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(104, 23);
            this.btadd.TabIndex = 3;
            this.btadd.Text = "Add Cilent";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btmodify
            // 
            this.btmodify.Location = new System.Drawing.Point(430, 298);
            this.btmodify.Name = "btmodify";
            this.btmodify.Size = new System.Drawing.Size(104, 23);
            this.btmodify.TabIndex = 4;
            this.btmodify.Text = "Modify Client";
            this.btmodify.UseVisualStyleBackColor = true;
            this.btmodify.Click += new System.EventHandler(this.btmodify_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(557, 298);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(104, 23);
            this.btdelete.TabIndex = 5;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btreturn
            // 
            this.btreturn.Location = new System.Drawing.Point(557, 342);
            this.btreturn.Name = "btreturn";
            this.btreturn.Size = new System.Drawing.Size(104, 23);
            this.btreturn.TabIndex = 6;
            this.btreturn.Text = "Return";
            this.btreturn.UseVisualStyleBackColor = true;
            this.btreturn.Click += new System.EventHandler(this.btreturn_Click);
            // 
            // lblclientno
            // 
            this.lblclientno.AutoSize = true;
            this.lblclientno.Location = new System.Drawing.Point(256, 13);
            this.lblclientno.Name = "lblclientno";
            this.lblclientno.Size = new System.Drawing.Size(59, 12);
            this.lblclientno.TabIndex = 7;
            this.lblclientno.Text = "ClientID:";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(11, 13);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(71, 12);
            this.lblfirstname.TabIndex = 8;
            this.lblfirstname.Text = "First Name:";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(194, 13);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(65, 12);
            this.lbllastname.TabIndex = 9;
            this.lbllastname.Text = "Last Name:";
            // 
            // lblstreetaddress
            // 
            this.lblstreetaddress.AutoSize = true;
            this.lblstreetaddress.Location = new System.Drawing.Point(11, 43);
            this.lblstreetaddress.Name = "lblstreetaddress";
            this.lblstreetaddress.Size = new System.Drawing.Size(95, 12);
            this.lblstreetaddress.TabIndex = 10;
            this.lblstreetaddress.Text = "Street Address:";
            // 
            // lblsuburb
            // 
            this.lblsuburb.AutoSize = true;
            this.lblsuburb.Location = new System.Drawing.Point(11, 75);
            this.lblsuburb.Name = "lblsuburb";
            this.lblsuburb.Size = new System.Drawing.Size(47, 12);
            this.lblsuburb.TabIndex = 11;
            this.lblsuburb.Text = "Suburb:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Location = new System.Drawing.Point(163, 75);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(35, 12);
            this.lblcity.TabIndex = 12;
            this.lblcity.Text = "City:";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Location = new System.Drawing.Point(309, 75);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(83, 12);
            this.lblphonenumber.TabIndex = 13;
            this.lblphonenumber.Text = "Phone Number:";
            // 
            // lblclientid
            // 
            this.lblclientid.AutoSize = true;
            this.lblclientid.Location = new System.Drawing.Point(321, 13);
            this.lblclientid.Name = "lblclientid";
            this.lblclientid.Size = new System.Drawing.Size(53, 12);
            this.lblclientid.TabIndex = 14;
            this.lblclientid.Text = "ClientID";
            // 
            // pnlmodify
            // 
            this.pnlmodify.Controls.Add(this.btmodifycancel);
            this.pnlmodify.Controls.Add(this.btmodifysave);
            this.pnlmodify.Controls.Add(this.txtphone);
            this.pnlmodify.Controls.Add(this.txtcity);
            this.pnlmodify.Controls.Add(this.txtsuburb);
            this.pnlmodify.Controls.Add(this.txtaddress);
            this.pnlmodify.Controls.Add(this.txtlastname);
            this.pnlmodify.Controls.Add(this.txtfirstname);
            this.pnlmodify.Controls.Add(this.lblfirstname);
            this.pnlmodify.Controls.Add(this.lbllastname);
            this.pnlmodify.Controls.Add(this.lblphonenumber);
            this.pnlmodify.Controls.Add(this.lblstreetaddress);
            this.pnlmodify.Controls.Add(this.lblcity);
            this.pnlmodify.Controls.Add(this.lblsuburb);
            this.pnlmodify.Location = new System.Drawing.Point(233, 28);
            this.pnlmodify.Name = "pnlmodify";
            this.pnlmodify.Size = new System.Drawing.Size(501, 125);
            this.pnlmodify.TabIndex = 15;
            // 
            // btmodifycancel
            // 
            this.btmodifycancel.Location = new System.Drawing.Point(324, 96);
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
            this.btmodifysave.Size = new System.Drawing.Size(104, 21);
            this.btmodifysave.TabIndex = 20;
            this.btmodifysave.Text = "Update  Client";
            this.btmodifysave.UseVisualStyleBackColor = true;
            this.btmodifysave.Click += new System.EventHandler(this.btmodifysave_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(398, 72);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 21);
            this.txtphone.TabIndex = 19;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(196, 72);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 21);
            this.txtcity.TabIndex = 18;
            // 
            // txtsuburb
            // 
            this.txtsuburb.Location = new System.Drawing.Point(57, 72);
            this.txtsuburb.Name = "txtsuburb";
            this.txtsuburb.Size = new System.Drawing.Size(100, 21);
            this.txtsuburb.TabIndex = 17;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(112, 37);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(386, 21);
            this.txtaddress.TabIndex = 16;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(266, 9);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(100, 21);
            this.txtlastname.TabIndex = 15;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(88, 10);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(100, 21);
            this.txtfirstname.TabIndex = 14;
            // 
            // pnladd
            // 
            this.pnladd.Controls.Add(this.btaddcancel);
            this.pnladd.Controls.Add(this.btaddsave);
            this.pnladd.Controls.Add(this.txtaddphone);
            this.pnladd.Controls.Add(this.txtaddcity);
            this.pnladd.Controls.Add(this.lbladdsuburb);
            this.pnladd.Controls.Add(this.txtaddsuburb);
            this.pnladd.Controls.Add(this.lbladdcity);
            this.pnladd.Controls.Add(this.txtaddaddress);
            this.pnladd.Controls.Add(this.lbladdaddress);
            this.pnladd.Controls.Add(this.txtaddlastname);
            this.pnladd.Controls.Add(this.lbladdphone);
            this.pnladd.Controls.Add(this.txtaddfirstname);
            this.pnladd.Controls.Add(this.lbladdlastname);
            this.pnladd.Controls.Add(this.lbladdfirstname);
            this.pnladd.Location = new System.Drawing.Point(233, 158);
            this.pnladd.Name = "pnladd";
            this.pnladd.Size = new System.Drawing.Size(503, 131);
            this.pnladd.TabIndex = 16;
            // 
            // btaddcancel
            // 
            this.btaddcancel.Location = new System.Drawing.Point(324, 100);
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
            this.btaddsave.Size = new System.Drawing.Size(104, 21);
            this.btaddsave.TabIndex = 22;
            this.btaddsave.Text = "Save  Client";
            this.btaddsave.UseVisualStyleBackColor = true;
            this.btaddsave.Click += new System.EventHandler(this.btaddsave_Click);
            // 
            // txtaddphone
            // 
            this.txtaddphone.Location = new System.Drawing.Point(398, 76);
            this.txtaddphone.Name = "txtaddphone";
            this.txtaddphone.Size = new System.Drawing.Size(100, 21);
            this.txtaddphone.TabIndex = 31;
            // 
            // txtaddcity
            // 
            this.txtaddcity.Location = new System.Drawing.Point(196, 76);
            this.txtaddcity.Name = "txtaddcity";
            this.txtaddcity.Size = new System.Drawing.Size(100, 21);
            this.txtaddcity.TabIndex = 30;
            // 
            // lbladdsuburb
            // 
            this.lbladdsuburb.AutoSize = true;
            this.lbladdsuburb.Location = new System.Drawing.Point(11, 79);
            this.lbladdsuburb.Name = "lbladdsuburb";
            this.lbladdsuburb.Size = new System.Drawing.Size(47, 12);
            this.lbladdsuburb.TabIndex = 23;
            this.lbladdsuburb.Text = "Suburb:";
            // 
            // txtaddsuburb
            // 
            this.txtaddsuburb.Location = new System.Drawing.Point(61, 76);
            this.txtaddsuburb.Name = "txtaddsuburb";
            this.txtaddsuburb.Size = new System.Drawing.Size(100, 21);
            this.txtaddsuburb.TabIndex = 29;
            // 
            // lbladdcity
            // 
            this.lbladdcity.AutoSize = true;
            this.lbladdcity.Location = new System.Drawing.Point(163, 79);
            this.lbladdcity.Name = "lbladdcity";
            this.lbladdcity.Size = new System.Drawing.Size(35, 12);
            this.lbladdcity.TabIndex = 24;
            this.lbladdcity.Text = "City:";
            // 
            // txtaddaddress
            // 
            this.txtaddaddress.Location = new System.Drawing.Point(112, 44);
            this.txtaddaddress.Name = "txtaddaddress";
            this.txtaddaddress.Size = new System.Drawing.Size(386, 21);
            this.txtaddaddress.TabIndex = 28;
            // 
            // lbladdaddress
            // 
            this.lbladdaddress.AutoSize = true;
            this.lbladdaddress.Location = new System.Drawing.Point(11, 47);
            this.lbladdaddress.Name = "lbladdaddress";
            this.lbladdaddress.Size = new System.Drawing.Size(95, 12);
            this.lbladdaddress.TabIndex = 22;
            this.lbladdaddress.Text = "Street Address:";
            // 
            // txtaddlastname
            // 
            this.txtaddlastname.Location = new System.Drawing.Point(266, 13);
            this.txtaddlastname.Name = "txtaddlastname";
            this.txtaddlastname.Size = new System.Drawing.Size(100, 21);
            this.txtaddlastname.TabIndex = 27;
            // 
            // lbladdphone
            // 
            this.lbladdphone.AutoSize = true;
            this.lbladdphone.Location = new System.Drawing.Point(309, 79);
            this.lbladdphone.Name = "lbladdphone";
            this.lbladdphone.Size = new System.Drawing.Size(83, 12);
            this.lbladdphone.TabIndex = 25;
            this.lbladdphone.Text = "Phone Number:";
            // 
            // txtaddfirstname
            // 
            this.txtaddfirstname.Location = new System.Drawing.Point(88, 14);
            this.txtaddfirstname.Name = "txtaddfirstname";
            this.txtaddfirstname.Size = new System.Drawing.Size(100, 21);
            this.txtaddfirstname.TabIndex = 26;
            // 
            // lbladdlastname
            // 
            this.lbladdlastname.AutoSize = true;
            this.lbladdlastname.Location = new System.Drawing.Point(194, 17);
            this.lbladdlastname.Name = "lbladdlastname";
            this.lbladdlastname.Size = new System.Drawing.Size(65, 12);
            this.lbladdlastname.TabIndex = 21;
            this.lbladdlastname.Text = "Last Name:";
            // 
            // lbladdfirstname
            // 
            this.lbladdfirstname.AutoSize = true;
            this.lbladdfirstname.Location = new System.Drawing.Point(11, 17);
            this.lbladdfirstname.Name = "lbladdfirstname";
            this.lbladdfirstname.Size = new System.Drawing.Size(71, 12);
            this.lbladdfirstname.TabIndex = 20;
            this.lbladdfirstname.Text = "First Name:";
            // 
            // clientform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 378);
            this.Controls.Add(this.pnladd);
            this.Controls.Add(this.pnlmodify);
            this.Controls.Add(this.lblclientid);
            this.Controls.Add(this.lblclientno);
            this.Controls.Add(this.btreturn);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btmodify);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btprevious);
            this.Controls.Add(this.lstclient);
            this.Name = "clientform";
            this.Text = "client maintenance";
            this.pnlmodify.ResumeLayout(false);
            this.pnlmodify.PerformLayout();
            this.pnladd.ResumeLayout(false);
            this.pnladd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstclient;
        private System.Windows.Forms.Button btprevious;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btmodify;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btreturn;
        private System.Windows.Forms.Label lblclientno;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblstreetaddress;
        private System.Windows.Forms.Label lblsuburb;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lblclientid;
        private System.Windows.Forms.Panel pnlmodify;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtsuburb;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Panel pnladd;
        private System.Windows.Forms.TextBox txtaddphone;
        private System.Windows.Forms.TextBox txtaddcity;
        private System.Windows.Forms.Label lbladdsuburb;
        private System.Windows.Forms.TextBox txtaddsuburb;
        private System.Windows.Forms.Label lbladdcity;
        private System.Windows.Forms.TextBox txtaddaddress;
        private System.Windows.Forms.Label lbladdaddress;
        private System.Windows.Forms.TextBox txtaddlastname;
        private System.Windows.Forms.Label lbladdphone;
        private System.Windows.Forms.TextBox txtaddfirstname;
        private System.Windows.Forms.Label lbladdlastname;
        private System.Windows.Forms.Label lbladdfirstname;
        private System.Windows.Forms.Button btmodifycancel;
        private System.Windows.Forms.Button btmodifysave;
        private System.Windows.Forms.Button btaddcancel;
        private System.Windows.Forms.Button btaddsave;
    }
}