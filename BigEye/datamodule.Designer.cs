namespace BigEye
{
    partial class datamodule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datamodule));
            this.ctnbigeye = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.dainvestigator = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daequipment = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.dacase = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbInsertCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daassignment = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.daclient = new System.Data.OleDb.OleDbDataAdapter();
            this.dsbigeye = new BigEye.Dsbigeye();
            ((System.ComponentModel.ISupportInitialize)(this.dsbigeye)).BeginInit();
            this.SuspendLayout();
            // 
            // ctnbigeye
            // 
            this.ctnbigeye.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"C:\\temp\\Big Eye.mdb\"";
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT   InvestigatorID, LastName, FirstName, HourlyRate, CellPhone, Licensed\r\nFR" +
    "OM      T_Investigator\r\nORDER BY InvestigatorID";
            this.oleDbSelectCommand2.Connection = this.ctnbigeye;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `T_Investigator` (`LastName`, `FirstName`, `HourlyRate`, `CellPhone`," +
    " `Licensed`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnbigeye;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("HourlyRate", System.Data.OleDb.OleDbType.Currency, 0, "HourlyRate"),
            new System.Data.OleDb.OleDbParameter("CellPhone", System.Data.OleDb.OleDbType.VarWChar, 0, "CellPhone"),
            new System.Data.OleDb.OleDbParameter("Licensed", System.Data.OleDb.OleDbType.Boolean, 0, "Licensed")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnbigeye;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("HourlyRate", System.Data.OleDb.OleDbType.Currency, 0, "HourlyRate"),
            new System.Data.OleDb.OleDbParameter("CellPhone", System.Data.OleDb.OleDbType.VarWChar, 0, "CellPhone"),
            new System.Data.OleDb.OleDbParameter("Licensed", System.Data.OleDb.OleDbType.Boolean, 0, "Licensed"),
            new System.Data.OleDb.OleDbParameter("Original_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HourlyRate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HourlyRate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HourlyRate", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HourlyRate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CellPhone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CellPhone", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CellPhone", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CellPhone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Licensed", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Licensed", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Licensed", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Licensed", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnbigeye;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HourlyRate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HourlyRate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HourlyRate", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HourlyRate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CellPhone", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CellPhone", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CellPhone", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CellPhone", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Licensed", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Licensed", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Licensed", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Licensed", System.Data.DataRowVersion.Original, null)});
            // 
            // dainvestigator
            // 
            this.dainvestigator.DeleteCommand = this.oleDbDeleteCommand2;
            this.dainvestigator.InsertCommand = this.oleDbInsertCommand2;
            this.dainvestigator.SelectCommand = this.oleDbSelectCommand2;
            this.dainvestigator.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_Investigator", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("InvestigatorID", "InvestigatorID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("HourlyRate", "HourlyRate"),
                        new System.Data.Common.DataColumnMapping("CellPhone", "CellPhone"),
                        new System.Data.Common.DataColumnMapping("Licensed", "Licensed")})});
            this.dainvestigator.UpdateCommand = this.oleDbUpdateCommand2;
            this.dainvestigator.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.dainvestigator_RowUpdated);
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT   EquipmentID, Description, InvestigatorID\r\nFROM      T_Equipment\r\nORDER B" +
    "Y EquipmentID";
            this.oleDbSelectCommand3.Connection = this.ctnbigeye;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `T_Equipment` (`Description`, `InvestigatorID`) VALUES (?, ?)";
            this.oleDbInsertCommand3.Connection = this.ctnbigeye;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, "InvestigatorID")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.ctnbigeye;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, "InvestigatorID"),
            new System.Data.OleDb.OleDbParameter("Original_EquipmentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EquipmentID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `T_Equipment` WHERE ((`EquipmentID` = ?) AND ((? = 1 AND `Description" +
    "` IS NULL) OR (`Description` = ?)) AND ((? = 1 AND `InvestigatorID` IS NULL) OR " +
    "(`InvestigatorID` = ?)))";
            this.oleDbDeleteCommand3.Connection = this.ctnbigeye;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_EquipmentID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EquipmentID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, null)});
            // 
            // daequipment
            // 
            this.daequipment.DeleteCommand = this.oleDbDeleteCommand3;
            this.daequipment.InsertCommand = this.oleDbInsertCommand3;
            this.daequipment.SelectCommand = this.oleDbSelectCommand3;
            this.daequipment.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_Equipment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EquipmentID", "EquipmentID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("InvestigatorID", "InvestigatorID")})});
            this.daequipment.UpdateCommand = this.oleDbUpdateCommand3;
            this.daequipment.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daequipment_RowUpdated);
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT  CaseID, Description, Status, CaseType, DateOpened, ClientID\r\nFROM      T_" +
    "Case\r\nORDER BY CaseID\r\n";
            this.oleDbSelectCommand4.Connection = this.ctnbigeye;
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.ctnbigeye;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CaseType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CaseType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CaseType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CaseType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateOpened", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateOpened", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateOpened", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateOpened", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null)});
            // 
            // dacase
            // 
            this.dacase.DeleteCommand = this.oleDbDeleteCommand4;
            this.dacase.InsertCommand = this.oleDbInsertCommand;
            this.dacase.SelectCommand = this.oleDbSelectCommand4;
            this.dacase.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_Case", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CaseID", "CaseID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("CaseType", "CaseType"),
                        new System.Data.Common.DataColumnMapping("DateOpened", "DateOpened"),
                        new System.Data.Common.DataColumnMapping("ClientID", "ClientID")})});
            this.dacase.UpdateCommand = this.oleDbUpdateCommand;
            this.dacase.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.dacase_RowUpdated);
            // 
            // oleDbInsertCommand
            // 
            this.oleDbInsertCommand.CommandText = "INSERT INTO `T_Case` (`Description`, `Status`, `CaseType`, `DateOpened`, `ClientI" +
    "D`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand.Connection = this.ctnbigeye;
            this.oleDbInsertCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("CaseType", System.Data.OleDb.OleDbType.VarWChar, 0, "CaseType"),
            new System.Data.OleDb.OleDbParameter("DateOpened", System.Data.OleDb.OleDbType.Date, 0, "DateOpened"),
            new System.Data.OleDb.OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer, 0, "ClientID")});
            // 
            // oleDbUpdateCommand
            // 
            this.oleDbUpdateCommand.CommandText = resources.GetString("oleDbUpdateCommand.CommandText");
            this.oleDbUpdateCommand.Connection = this.ctnbigeye;
            this.oleDbUpdateCommand.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("CaseType", System.Data.OleDb.OleDbType.VarWChar, 0, "CaseType"),
            new System.Data.OleDb.OleDbParameter("DateOpened", System.Data.OleDb.OleDbType.Date, 0, "DateOpened"),
            new System.Data.OleDb.OleDbParameter("ClientID", System.Data.OleDb.OleDbType.Integer, 0, "ClientID"),
            new System.Data.OleDb.OleDbParameter("Original_CaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CaseType", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CaseType", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CaseType", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CaseType", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateOpened", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateOpened", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateOpened", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateOpened", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT   CaseID, InvestigatorID, Hours, DateAssigned\r\nFROM      T_Assignment\r\nORD" +
    "ER BY CaseID, InvestigatorID";
            this.oleDbSelectCommand5.Connection = this.ctnbigeye;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `T_Assignment` (`CaseID`, `InvestigatorID`, `Hours`, `DateAssigned`) " +
    "VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand5.Connection = this.ctnbigeye;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CaseID", System.Data.OleDb.OleDbType.Integer, 0, "CaseID"),
            new System.Data.OleDb.OleDbParameter("InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, "InvestigatorID"),
            new System.Data.OleDb.OleDbParameter("Hours", System.Data.OleDb.OleDbType.Integer, 0, "Hours"),
            new System.Data.OleDb.OleDbParameter("DateAssigned", System.Data.OleDb.OleDbType.Date, 0, "DateAssigned")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnbigeye;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CaseID", System.Data.OleDb.OleDbType.Integer, 0, "CaseID"),
            new System.Data.OleDb.OleDbParameter("InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, "InvestigatorID"),
            new System.Data.OleDb.OleDbParameter("Hours", System.Data.OleDb.OleDbType.Integer, 0, "Hours"),
            new System.Data.OleDb.OleDbParameter("DateAssigned", System.Data.OleDb.OleDbType.Date, 0, "DateAssigned"),
            new System.Data.OleDb.OleDbParameter("Original_CaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hours", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hours", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hours", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hours", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateAssigned", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateAssigned", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateAssigned", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAssigned", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = "DELETE FROM `T_Assignment` WHERE ((`CaseID` = ?) AND (`InvestigatorID` = ?) AND (" +
    "(? = 1 AND `Hours` IS NULL) OR (`Hours` = ?)) AND ((? = 1 AND `DateAssigned` IS " +
    "NULL) OR (`DateAssigned` = ?)))";
            this.oleDbDeleteCommand5.Connection = this.ctnbigeye;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_InvestigatorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvestigatorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Hours", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Hours", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Hours", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Hours", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateAssigned", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateAssigned", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateAssigned", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAssigned", System.Data.DataRowVersion.Original, null)});
            // 
            // daassignment
            // 
            this.daassignment.DeleteCommand = this.oleDbDeleteCommand5;
            this.daassignment.InsertCommand = this.oleDbInsertCommand5;
            this.daassignment.SelectCommand = this.oleDbSelectCommand5;
            this.daassignment.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_Assignment", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CaseID", "CaseID"),
                        new System.Data.Common.DataColumnMapping("InvestigatorID", "InvestigatorID"),
                        new System.Data.Common.DataColumnMapping("Hours", "Hours"),
                        new System.Data.Common.DataColumnMapping("DateAssigned", "DateAssigned")})});
            this.daassignment.UpdateCommand = this.oleDbUpdateCommand5;
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT        ClientID, LastName, FirstName, StreetAddress, Suburb, City, PhoneNu" +
    "mber\r\nFROM            T_Client\r\nORDER BY ClientID";
            this.oleDbSelectCommand6.Connection = this.ctnbigeye;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `T_Client` (`LastName`, `FirstName`, `StreetAddress`, `Suburb`, `City" +
    "`, `PhoneNumber`) VALUES (?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand6.Connection = this.ctnbigeye;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.ctnbigeye;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.ctnbigeye;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ClientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ClientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // daclient
            // 
            this.daclient.DeleteCommand = this.oleDbDeleteCommand6;
            this.daclient.InsertCommand = this.oleDbInsertCommand6;
            this.daclient.SelectCommand = this.oleDbSelectCommand6;
            this.daclient.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "T_Client", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ClientID", "ClientID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber")})});
            this.daclient.UpdateCommand = this.oleDbUpdateCommand6;
            this.daclient.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daclient_RowUpdated_1);
            // 
            // dsbigeye
            // 
            this.dsbigeye.DataSetName = "dsbigeye";
            this.dsbigeye.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datamodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "datamodule";
            this.Text = "datamodule";
            ((System.ComponentModel.ISupportInitialize)(this.dsbigeye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.OleDb.OleDbConnection ctnbigeye;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter dainvestigator;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daequipment;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter dacase;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daassignment;
        public Dsbigeye dsbigeye;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter daclient;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand;
    }
}