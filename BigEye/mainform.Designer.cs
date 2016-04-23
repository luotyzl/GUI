namespace BigEye
{
    partial class mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpmaintenance = new System.Windows.Forms.GroupBox();
            this.btcaseassignment = new System.Windows.Forms.Button();
            this.btcase = new System.Windows.Forms.Button();
            this.btequipment = new System.Windows.Forms.Button();
            this.btinvestigator = new System.Windows.Forms.Button();
            this.btclient = new System.Windows.Forms.Button();
            this.grpreport = new System.Windows.Forms.GroupBox();
            this.btexit = new System.Windows.Forms.Button();
            this.btInvoices = new System.Windows.Forms.Button();
            this.grpmaintenance.SuspendLayout();
            this.grpreport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpmaintenance
            // 
            this.grpmaintenance.Controls.Add(this.btcaseassignment);
            this.grpmaintenance.Controls.Add(this.btcase);
            this.grpmaintenance.Controls.Add(this.btequipment);
            this.grpmaintenance.Controls.Add(this.btinvestigator);
            this.grpmaintenance.Controls.Add(this.btclient);
            this.grpmaintenance.Location = new System.Drawing.Point(13, 13);
            this.grpmaintenance.Name = "grpmaintenance";
            this.grpmaintenance.Size = new System.Drawing.Size(452, 184);
            this.grpmaintenance.TabIndex = 0;
            this.grpmaintenance.TabStop = false;
            this.grpmaintenance.Text = "maintenance";
            // 
            // btcaseassignment
            // 
            this.btcaseassignment.Location = new System.Drawing.Point(252, 105);
            this.btcaseassignment.Name = "btcaseassignment";
            this.btcaseassignment.Size = new System.Drawing.Size(125, 60);
            this.btcaseassignment.TabIndex = 4;
            this.btcaseassignment.Text = "case assignment maintenance";
            this.btcaseassignment.UseVisualStyleBackColor = true;
            this.btcaseassignment.Click += new System.EventHandler(this.btcaseassignment_Click);
            // 
            // btcase
            // 
            this.btcase.Location = new System.Drawing.Point(83, 105);
            this.btcase.Name = "btcase";
            this.btcase.Size = new System.Drawing.Size(125, 60);
            this.btcase.TabIndex = 3;
            this.btcase.Text = "case maintenance";
            this.btcase.UseVisualStyleBackColor = true;
            this.btcase.Click += new System.EventHandler(this.btcase_Click);
            // 
            // btequipment
            // 
            this.btequipment.Location = new System.Drawing.Point(321, 21);
            this.btequipment.Name = "btequipment";
            this.btequipment.Size = new System.Drawing.Size(125, 60);
            this.btequipment.TabIndex = 2;
            this.btequipment.Text = "equipment maintenance";
            this.btequipment.UseVisualStyleBackColor = true;
            this.btequipment.Click += new System.EventHandler(this.btequipment_Click);
            // 
            // btinvestigator
            // 
            this.btinvestigator.Location = new System.Drawing.Point(169, 21);
            this.btinvestigator.Name = "btinvestigator";
            this.btinvestigator.Size = new System.Drawing.Size(125, 60);
            this.btinvestigator.TabIndex = 1;
            this.btinvestigator.Text = "investigator maintenance";
            this.btinvestigator.UseVisualStyleBackColor = true;
            this.btinvestigator.Click += new System.EventHandler(this.btinvestigator_Click);
            // 
            // btclient
            // 
            this.btclient.Location = new System.Drawing.Point(7, 21);
            this.btclient.Name = "btclient";
            this.btclient.Size = new System.Drawing.Size(125, 60);
            this.btclient.TabIndex = 0;
            this.btclient.Text = "client maintenance";
            this.btclient.UseVisualStyleBackColor = true;
            this.btclient.Click += new System.EventHandler(this.btclient_Click);
            // 
            // grpreport
            // 
            this.grpreport.Controls.Add(this.btexit);
            this.grpreport.Controls.Add(this.btInvoices);
            this.grpreport.Location = new System.Drawing.Point(13, 203);
            this.grpreport.Name = "grpreport";
            this.grpreport.Size = new System.Drawing.Size(452, 142);
            this.grpreport.TabIndex = 1;
            this.grpreport.TabStop = false;
            this.grpreport.Text = "reporting";
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(252, 51);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(125, 60);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btInvoices
            // 
            this.btInvoices.Location = new System.Drawing.Point(83, 51);
            this.btInvoices.Name = "btInvoices";
            this.btInvoices.Size = new System.Drawing.Size(125, 60);
            this.btInvoices.TabIndex = 5;
            this.btInvoices.Text = "invoices";
            this.btInvoices.UseVisualStyleBackColor = true;
            this.btInvoices.Click += new System.EventHandler(this.btInvoices_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 357);
            this.Controls.Add(this.grpreport);
            this.Controls.Add(this.grpmaintenance);
            this.Name = "mainform";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.grpmaintenance.ResumeLayout(false);
            this.grpreport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpmaintenance;
        private System.Windows.Forms.Button btcaseassignment;
        private System.Windows.Forms.Button btcase;
        private System.Windows.Forms.Button btequipment;
        private System.Windows.Forms.Button btinvestigator;
        private System.Windows.Forms.Button btclient;
        private System.Windows.Forms.GroupBox grpreport;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btInvoices;
    }
}

