namespace BigEye
{
    partial class equipmentform
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
            this.btaddcancel = new System.Windows.Forms.Button();
            this.btaddsave = new System.Windows.Forms.Button();
            this.txtaddinvestid = new System.Windows.Forms.TextBox();
            this.lbladdinvestid = new System.Windows.Forms.Label();
            this.txtadddescription = new System.Windows.Forms.TextBox();
            this.lbladddescription = new System.Windows.Forms.Label();
            this.pnlmodify = new System.Windows.Forms.Panel();
            this.cboxinvestid = new System.Windows.Forms.ComboBox();
            this.btmodifycancel = new System.Windows.Forms.Button();
            this.btmodifysave = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblinvesitgatorid = new System.Windows.Forms.Label();
            this.lblequipmentid = new System.Windows.Forms.Label();
            this.lblinvestigatorno = new System.Windows.Forms.Label();
            this.btreturn = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btmodify = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.lstequipment = new System.Windows.Forms.ListBox();
            this.btremoveinvestigator = new System.Windows.Forms.Button();
            this.pnladd.SuspendLayout();
            this.pnlmodify.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnladd
            // 
            this.pnladd.Controls.Add(this.btaddcancel);
            this.pnladd.Controls.Add(this.btaddsave);
            this.pnladd.Controls.Add(this.txtaddinvestid);
            this.pnladd.Controls.Add(this.lbladdinvestid);
            this.pnladd.Controls.Add(this.txtadddescription);
            this.pnladd.Controls.Add(this.lbladddescription);
            this.pnladd.Location = new System.Drawing.Point(232, 157);
            this.pnladd.Name = "pnladd";
            this.pnladd.Size = new System.Drawing.Size(407, 131);
            this.pnladd.TabIndex = 38;
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
            this.btaddsave.Text = "Save Equipment";
            this.btaddsave.UseVisualStyleBackColor = true;
            this.btaddsave.Click += new System.EventHandler(this.btaddsave_Click);
            // 
            // txtaddinvestid
            // 
            this.txtaddinvestid.Location = new System.Drawing.Point(112, 50);
            this.txtaddinvestid.Name = "txtaddinvestid";
            this.txtaddinvestid.Size = new System.Drawing.Size(100, 21);
            this.txtaddinvestid.TabIndex = 28;
            // 
            // lbladdinvestid
            // 
            this.lbladdinvestid.AutoSize = true;
            this.lbladdinvestid.Location = new System.Drawing.Point(23, 53);
            this.lbladdinvestid.Name = "lbladdinvestid";
            this.lbladdinvestid.Size = new System.Drawing.Size(83, 12);
            this.lbladdinvestid.TabIndex = 22;
            this.lbladdinvestid.Text = "Investigator:";
            // 
            // txtadddescription
            // 
            this.txtadddescription.Location = new System.Drawing.Point(112, 20);
            this.txtadddescription.Name = "txtadddescription";
            this.txtadddescription.Size = new System.Drawing.Size(100, 21);
            this.txtadddescription.TabIndex = 26;
            // 
            // lbladddescription
            // 
            this.lbladddescription.AutoSize = true;
            this.lbladddescription.Location = new System.Drawing.Point(29, 23);
            this.lbladddescription.Name = "lbladddescription";
            this.lbladddescription.Size = new System.Drawing.Size(77, 12);
            this.lbladddescription.TabIndex = 20;
            this.lbladddescription.Text = "Description:";
            // 
            // pnlmodify
            // 
            this.pnlmodify.Controls.Add(this.cboxinvestid);
            this.pnlmodify.Controls.Add(this.btmodifycancel);
            this.pnlmodify.Controls.Add(this.btmodifysave);
            this.pnlmodify.Controls.Add(this.txtdescription);
            this.pnlmodify.Controls.Add(this.lbldescription);
            this.pnlmodify.Controls.Add(this.lblinvesitgatorid);
            this.pnlmodify.Location = new System.Drawing.Point(232, 27);
            this.pnlmodify.Name = "pnlmodify";
            this.pnlmodify.Size = new System.Drawing.Size(407, 125);
            this.pnlmodify.TabIndex = 37;
            // 
            // cboxinvestid
            // 
            this.cboxinvestid.FormattingEnabled = true;
            this.cboxinvestid.Location = new System.Drawing.Point(112, 53);
            this.cboxinvestid.Name = "cboxinvestid";
            this.cboxinvestid.Size = new System.Drawing.Size(121, 20);
            this.cboxinvestid.TabIndex = 22;
            this.cboxinvestid.SelectedIndexChanged += new System.EventHandler(this.cboxinvestid_SelectedIndexChanged);
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
            this.btmodifysave.Text = "Update  Equipment";
            this.btmodifysave.UseVisualStyleBackColor = true;
            this.btmodifysave.Click += new System.EventHandler(this.btmodifysave_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(112, 23);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(100, 21);
            this.txtdescription.TabIndex = 14;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(29, 26);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(77, 12);
            this.lbldescription.TabIndex = 8;
            this.lbldescription.Text = "Description:";
            // 
            // lblinvesitgatorid
            // 
            this.lblinvesitgatorid.AutoSize = true;
            this.lblinvesitgatorid.Location = new System.Drawing.Point(23, 56);
            this.lblinvesitgatorid.Name = "lblinvesitgatorid";
            this.lblinvesitgatorid.Size = new System.Drawing.Size(83, 12);
            this.lblinvesitgatorid.TabIndex = 10;
            this.lblinvesitgatorid.Text = "Investigator:";
            // 
            // lblequipmentid
            // 
            this.lblequipmentid.AutoSize = true;
            this.lblequipmentid.Location = new System.Drawing.Point(320, 12);
            this.lblequipmentid.Name = "lblequipmentid";
            this.lblequipmentid.Size = new System.Drawing.Size(71, 12);
            this.lblequipmentid.TabIndex = 36;
            this.lblequipmentid.Text = "EquipmentID";
            // 
            // lblinvestigatorno
            // 
            this.lblinvestigatorno.AutoSize = true;
            this.lblinvestigatorno.Location = new System.Drawing.Point(230, 12);
            this.lblinvestigatorno.Name = "lblinvestigatorno";
            this.lblinvestigatorno.Size = new System.Drawing.Size(77, 12);
            this.lblinvestigatorno.TabIndex = 35;
            this.lblinvestigatorno.Text = "EquipmentID:";
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
            this.btmodify.Text = "Modify Equipment";
            this.btmodify.UseVisualStyleBackColor = true;
            this.btmodify.Click += new System.EventHandler(this.btmodify_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(245, 297);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(135, 23);
            this.btadd.TabIndex = 31;
            this.btadd.Text = "Add Equipment";
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
            // lstequipment
            // 
            this.lstequipment.FormattingEnabled = true;
            this.lstequipment.ItemHeight = 12;
            this.lstequipment.Location = new System.Drawing.Point(12, 12);
            this.lstequipment.Name = "lstequipment";
            this.lstequipment.Size = new System.Drawing.Size(208, 280);
            this.lstequipment.TabIndex = 28;
            this.lstequipment.SelectedIndexChanged += new System.EventHandler(this.lstequipment_SelectedIndexChanged);
            // 
            // btremoveinvestigator
            // 
            this.btremoveinvestigator.Location = new System.Drawing.Point(245, 342);
            this.btremoveinvestigator.Name = "btremoveinvestigator";
            this.btremoveinvestigator.Size = new System.Drawing.Size(135, 23);
            this.btremoveinvestigator.TabIndex = 39;
            this.btremoveinvestigator.Text = "Remove Investigator";
            this.btremoveinvestigator.UseVisualStyleBackColor = true;
            this.btremoveinvestigator.Click += new System.EventHandler(this.btremoveinvestigator_Click);
            // 
            // equipmentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 378);
            this.Controls.Add(this.btremoveinvestigator);
            this.Controls.Add(this.pnladd);
            this.Controls.Add(this.pnlmodify);
            this.Controls.Add(this.lblequipmentid);
            this.Controls.Add(this.lblinvestigatorno);
            this.Controls.Add(this.btreturn);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btmodify);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btprevious);
            this.Controls.Add(this.lstequipment);
            this.Name = "equipmentform";
            this.Text = "equipment maintenance";
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
        private System.Windows.Forms.TextBox txtaddinvestid;
        private System.Windows.Forms.Label lbladdinvestid;
        private System.Windows.Forms.TextBox txtadddescription;
        private System.Windows.Forms.Label lbladddescription;
        private System.Windows.Forms.Panel pnlmodify;
        private System.Windows.Forms.Button btmodifycancel;
        private System.Windows.Forms.Button btmodifysave;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblinvesitgatorid;
        private System.Windows.Forms.Label lblequipmentid;
        private System.Windows.Forms.Label lblinvestigatorno;
        private System.Windows.Forms.Button btreturn;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btmodify;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btprevious;
        private System.Windows.Forms.ListBox lstequipment;
        private System.Windows.Forms.Button btremoveinvestigator;
        private System.Windows.Forms.ComboBox cboxinvestid;
    }
}