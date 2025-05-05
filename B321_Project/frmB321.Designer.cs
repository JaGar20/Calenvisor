using System.Windows.Forms;

namespace B321_Project
{
    partial class frmB321
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
            System.Windows.Forms.TabPage tbAvailability;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmB321));
            this.tabEditAddAvailability = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblDaysLeft = new System.Windows.Forms.Label();
            this.txtLeftDays = new System.Windows.Forms.TextBox();
            this.cboAvAdvisors = new System.Windows.Forms.ComboBox();
            this.txtSchedule = new System.Windows.Forms.TextBox();
            this.lblAvailableHours = new System.Windows.Forms.Label();
            this.cboAHourBlocks = new System.Windows.Forms.ComboBox();
            this.lblAvailableTime = new System.Windows.Forms.Label();
            this.dtpAvailableDate = new System.Windows.Forms.DateTimePicker();
            this.lblAvLocation = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.cboALocation = new System.Windows.Forms.ComboBox();
            this.txtAvailabilityID = new System.Windows.Forms.TextBox();
            this.lvwAvailability = new System.Windows.Forms.ListView();
            this.AvailDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvilAdvisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAvAdvisorName = new System.Windows.Forms.Label();
            this.lblAvailabilityID = new System.Windows.Forms.Label();
            this.lblAvailabilityDetails = new System.Windows.Forms.Label();
            this.btnUpdateAvailabilityInfo = new System.Windows.Forms.Button();
            this.btnDeleteAvailabilityInfo = new System.Windows.Forms.Button();
            this.btnEditAvailabilityInfo = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtTimeDisplay = new System.Windows.Forms.TextBox();
            this.cboMeetingAdvisors = new System.Windows.Forms.ComboBox();
            this.lblAddAvailableDate = new System.Windows.Forms.Label();
            this.dtpAddDate = new System.Windows.Forms.DateTimePicker();
            this.lblSelectLocation = new System.Windows.Forms.Label();
            this.lblAddAvailableTime = new System.Windows.Forms.Label();
            this.cboHourBlocks = new System.Windows.Forms.ComboBox();
            this.lblSelectAdvisor = new System.Windows.Forms.Label();
            this.lblAddAvailability = new System.Windows.Forms.Label();
            this.btnAddAvailabilityInfo = new System.Windows.Forms.Button();
            this.cboLocations = new System.Windows.Forms.ComboBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentFName = new System.Windows.Forms.TextBox();
            this.txtStudentLName = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateStudentInfo = new System.Windows.Forms.Button();
            this.lvwStudents = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentFName = new System.Windows.Forms.Label();
            this.lblStudentLName = new System.Windows.Forms.Label();
            this.lblStudentEmail = new System.Windows.Forms.Label();
            this.btnEditStudentInfo = new System.Windows.Forms.Button();
            this.txtStudentMName = new System.Windows.Forms.TextBox();
            this.lblStudentMName = new System.Windows.Forms.Label();
            this.txtUSCBID = new System.Windows.Forms.TextBox();
            this.lblUSCBID = new System.Windows.Forms.Label();
            this.btnDeleteStudentInfo = new System.Windows.Forms.Button();
            this.tbAbout = new System.Windows.Forms.TabControl();
            this.tbStudents = new System.Windows.Forms.TabPage();
            this.tabEditAddStudent = new System.Windows.Forms.TabControl();
            this.tbUpdateStudent = new System.Windows.Forms.TabPage();
            this.lblStudentDetails = new System.Windows.Forms.Label();
            this.tbAddStudent = new System.Windows.Forms.TabPage();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.lblAddUSCBID = new System.Windows.Forms.Label();
            this.txtAddUSCBID = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblAddStudentFName = new System.Windows.Forms.Label();
            this.txtAddStudentMName = new System.Windows.Forms.TextBox();
            this.lblAddStudentLName = new System.Windows.Forms.Label();
            this.lblAddStudentEmail = new System.Windows.Forms.Label();
            this.txtAddStudentFName = new System.Windows.Forms.TextBox();
            this.lblAddStudentMName = new System.Windows.Forms.Label();
            this.txtAddStudentEmail = new System.Windows.Forms.TextBox();
            this.txtAddStudentLName = new System.Windows.Forms.TextBox();
            this.tbAdvisors = new System.Windows.Forms.TabPage();
            this.tabAddEditAdvisor = new System.Windows.Forms.TabControl();
            this.tbEditAdvisor = new System.Windows.Forms.TabPage();
            this.maskedEditAdvisorPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblAdvisorDetails = new System.Windows.Forms.Label();
            this.lvwAdvisors = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAdvisorOfficeAddress = new System.Windows.Forms.TextBox();
            this.lblAdvisorFName = new System.Windows.Forms.Label();
            this.lblAdvisorOffice = new System.Windows.Forms.Label();
            this.lblAdvisorLName = new System.Windows.Forms.Label();
            this.btnDeleteAdvisorInfo = new System.Windows.Forms.Button();
            this.lblAdvisorID = new System.Windows.Forms.Label();
            this.txtAdvisorMName = new System.Windows.Forms.TextBox();
            this.lblAdvisorEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnUpdateAdvisorInfo = new System.Windows.Forms.Button();
            this.txtAdvisorID = new System.Windows.Forms.TextBox();
            this.btnEditAdvisorInfo = new System.Windows.Forms.Button();
            this.txtAdvisorEmail = new System.Windows.Forms.TextBox();
            this.txtAdvisorFName = new System.Windows.Forms.TextBox();
            this.txtAdvisorLName = new System.Windows.Forms.TextBox();
            this.lblAdvisorMName = new System.Windows.Forms.Label();
            this.tbAddAdvisor = new System.Windows.Forms.TabPage();
            this.maskedAdvisorPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblAddAdvisor = new System.Windows.Forms.Label();
            this.btnAddAdvisor = new System.Windows.Forms.Button();
            this.txtAddOfficeAddress = new System.Windows.Forms.TextBox();
            this.lblAddAdvisorFName = new System.Windows.Forms.Label();
            this.lblAddAdvisorOffice = new System.Windows.Forms.Label();
            this.lblAddAdvisorLName = new System.Windows.Forms.Label();
            this.txtAddAdvisorMName = new System.Windows.Forms.TextBox();
            this.lblAddAdvisorEmail = new System.Windows.Forms.Label();
            this.lblAddPhoneNumber = new System.Windows.Forms.Label();
            this.txtAddAdvisorEmail = new System.Windows.Forms.TextBox();
            this.txtAddAdvisorFName = new System.Windows.Forms.TextBox();
            this.txtAddAdvisorLName = new System.Windows.Forms.TextBox();
            this.lblAddAdvisorMName = new System.Windows.Forms.Label();
            this.tbLocations = new System.Windows.Forms.TabPage();
            this.tabAddEditLocation = new System.Windows.Forms.TabControl();
            this.tbEditLocation = new System.Windows.Forms.TabPage();
            this.lblLocationDetails = new System.Windows.Forms.Label();
            this.btnDeleteLocationInfo = new System.Windows.Forms.Button();
            this.lvwLocations = new System.Windows.Forms.ListView();
            this.btnEditLocationInfo = new System.Windows.Forms.Button();
            this.lblLocationID = new System.Windows.Forms.Label();
            this.btnUpdateLocationInfo = new System.Windows.Forms.Button();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.txtLocationType = new System.Windows.Forms.TextBox();
            this.lblLocationType = new System.Windows.Forms.Label();
            this.tbAddLocation = new System.Windows.Forms.TabPage();
            this.lblAddLocation = new System.Windows.Forms.Label();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.txtAddLocationType = new System.Windows.Forms.TextBox();
            this.lblAddLocationType = new System.Windows.Forms.Label();
            this.tbMeetings = new System.Windows.Forms.TabPage();
            this.tbEditAddMeetings = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblMeetingOffice = new System.Windows.Forms.Label();
            this.txtMeetingAddress = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMeetingID = new System.Windows.Forms.Label();
            this.lblMeetingDetails = new System.Windows.Forms.Label();
            this.txtAvailableDate_Meetings = new System.Windows.Forms.TextBox();
            this.txtLocationType_Meetings = new System.Windows.Forms.TextBox();
            this.btnDeleteMeetingInfo = new System.Windows.Forms.Button();
            this.btnUpdateMeetingInfo = new System.Windows.Forms.Button();
            this.btnEditMeetingInfo = new System.Windows.Forms.Button();
            this.lblMeetingHours = new System.Windows.Forms.Label();
            this.txtEndHour_Meetings = new System.Windows.Forms.TextBox();
            this.txtStartHour_Meetings = new System.Windows.Forms.TextBox();
            this.lblMeetingAdvisor = new System.Windows.Forms.Label();
            this.txtAdvisorFName_Meetings = new System.Windows.Forms.TextBox();
            this.lblMtAvailabilityID = new System.Windows.Forms.Label();
            this.txtAvailabilityID_Meetings = new System.Windows.Forms.TextBox();
            this.txtMeetingName = new System.Windows.Forms.TextBox();
            this.txtStudentFName_Meetings = new System.Windows.Forms.TextBox();
            this.lblMeetingName = new System.Windows.Forms.Label();
            this.txtStudentID_Meetings = new System.Windows.Forms.TextBox();
            this.txtMeetingID = new System.Windows.Forms.TextBox();
            this.lvwMeetings = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblMeetingLocation = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMtEndBlock = new System.Windows.Forms.Label();
            this.lblMtStartBlock = new System.Windows.Forms.Label();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lblAddStatus = new System.Windows.Forms.Label();
            this.lblMtAddAvailabilityID = new System.Windows.Forms.Label();
            this.lblAddMeetings = new System.Windows.Forms.Label();
            this.txtStatusAdd = new System.Windows.Forms.TextBox();
            this.txtAvailabilityID_MeetingsAdd = new System.Windows.Forms.TextBox();
            this.lvwAddMeetings = new System.Windows.Forms.ListView();
            this.MeetingDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeetingAdvisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeetingLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeetingStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MeetingEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label42 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblAddMeetingName = new System.Windows.Forms.Label();
            this.txtMeetingNameAdd = new System.Windows.Forms.TextBox();
            this.txtEndHourAddMeetings = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.btnAddMeeting = new System.Windows.Forms.Button();
            this.lblMtAddAvailableDate = new System.Windows.Forms.Label();
            this.cboMeetingStudents = new System.Windows.Forms.ComboBox();
            this.txtAvailableDate = new System.Windows.Forms.TextBox();
            this.txtStartHourAddMeetings = new System.Windows.Forms.TextBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pctUSCBLogo = new System.Windows.Forms.PictureBox();
            tbAvailability = new System.Windows.Forms.TabPage();
            tbAvailability.SuspendLayout();
            this.tabEditAddAvailability.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tbAbout.SuspendLayout();
            this.tbStudents.SuspendLayout();
            this.tabEditAddStudent.SuspendLayout();
            this.tbUpdateStudent.SuspendLayout();
            this.tbAddStudent.SuspendLayout();
            this.tbAdvisors.SuspendLayout();
            this.tabAddEditAdvisor.SuspendLayout();
            this.tbEditAdvisor.SuspendLayout();
            this.tbAddAdvisor.SuspendLayout();
            this.tbLocations.SuspendLayout();
            this.tabAddEditLocation.SuspendLayout();
            this.tbEditLocation.SuspendLayout();
            this.tbAddLocation.SuspendLayout();
            this.tbMeetings.SuspendLayout();
            this.tbEditAddMeetings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUSCBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAvailability
            // 
            tbAvailability.Controls.Add(this.tabEditAddAvailability);
            tbAvailability.Location = new System.Drawing.Point(4, 22);
            tbAvailability.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            tbAvailability.Name = "tbAvailability";
            tbAvailability.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            tbAvailability.Size = new System.Drawing.Size(611, 383);
            tbAvailability.TabIndex = 3;
            tbAvailability.Text = "Availability";
            tbAvailability.UseVisualStyleBackColor = true;
            // 
            // tabEditAddAvailability
            // 
            this.tabEditAddAvailability.Controls.Add(this.tabPage5);
            this.tabEditAddAvailability.Controls.Add(this.tabPage4);
            this.tabEditAddAvailability.Location = new System.Drawing.Point(5, 3);
            this.tabEditAddAvailability.Name = "tabEditAddAvailability";
            this.tabEditAddAvailability.SelectedIndex = 0;
            this.tabEditAddAvailability.Size = new System.Drawing.Size(601, 382);
            this.tabEditAddAvailability.TabIndex = 174;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.lblDaysLeft);
            this.tabPage5.Controls.Add(this.txtLeftDays);
            this.tabPage5.Controls.Add(this.cboAvAdvisors);
            this.tabPage5.Controls.Add(this.txtSchedule);
            this.tabPage5.Controls.Add(this.lblAvailableHours);
            this.tabPage5.Controls.Add(this.cboAHourBlocks);
            this.tabPage5.Controls.Add(this.lblAvailableTime);
            this.tabPage5.Controls.Add(this.dtpAvailableDate);
            this.tabPage5.Controls.Add(this.lblAvLocation);
            this.tabPage5.Controls.Add(this.label61);
            this.tabPage5.Controls.Add(this.cboALocation);
            this.tabPage5.Controls.Add(this.txtAvailabilityID);
            this.tabPage5.Controls.Add(this.lvwAvailability);
            this.tabPage5.Controls.Add(this.lblAvAdvisorName);
            this.tabPage5.Controls.Add(this.lblAvailabilityID);
            this.tabPage5.Controls.Add(this.lblAvailabilityDetails);
            this.tabPage5.Controls.Add(this.btnUpdateAvailabilityInfo);
            this.tabPage5.Controls.Add(this.btnDeleteAvailabilityInfo);
            this.tabPage5.Controls.Add(this.btnEditAvailabilityInfo);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(593, 356);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Edit Availability";
            // 
            // lblDaysLeft
            // 
            this.lblDaysLeft.AutoSize = true;
            this.lblDaysLeft.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysLeft.Location = new System.Drawing.Point(260, 85);
            this.lblDaysLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDaysLeft.Name = "lblDaysLeft";
            this.lblDaysLeft.Size = new System.Drawing.Size(52, 13);
            this.lblDaysLeft.TabIndex = 236;
            this.lblDaysLeft.Text = "Days Left:";
            // 
            // txtLeftDays
            // 
            this.txtLeftDays.Enabled = false;
            this.txtLeftDays.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeftDays.Location = new System.Drawing.Point(320, 81);
            this.txtLeftDays.Name = "txtLeftDays";
            this.txtLeftDays.Size = new System.Drawing.Size(71, 22);
            this.txtLeftDays.TabIndex = 235;
            // 
            // cboAvAdvisors
            // 
            this.cboAvAdvisors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAvAdvisors.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAvAdvisors.FormattingEnabled = true;
            this.cboAvAdvisors.Location = new System.Drawing.Point(98, 51);
            this.cboAvAdvisors.Name = "cboAvAdvisors";
            this.cboAvAdvisors.Size = new System.Drawing.Size(121, 21);
            this.cboAvAdvisors.TabIndex = 234;
            // 
            // txtSchedule
            // 
            this.txtSchedule.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchedule.Location = new System.Drawing.Point(320, 55);
            this.txtSchedule.Name = "txtSchedule";
            this.txtSchedule.Size = new System.Drawing.Size(121, 22);
            this.txtSchedule.TabIndex = 231;
            // 
            // lblAvailableHours
            // 
            this.lblAvailableHours.AutoSize = true;
            this.lblAvailableHours.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableHours.Location = new System.Drawing.Point(9, 83);
            this.lblAvailableHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableHours.Name = "lblAvailableHours";
            this.lblAvailableHours.Size = new System.Drawing.Size(82, 13);
            this.lblAvailableHours.TabIndex = 210;
            this.lblAvailableHours.Text = "Available Hours:";
            // 
            // cboAHourBlocks
            // 
            this.cboAHourBlocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAHourBlocks.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAHourBlocks.Location = new System.Drawing.Point(98, 80);
            this.cboAHourBlocks.Name = "cboAHourBlocks";
            this.cboAHourBlocks.Size = new System.Drawing.Size(121, 21);
            this.cboAHourBlocks.TabIndex = 209;
            // 
            // lblAvailableTime
            // 
            this.lblAvailableTime.AutoSize = true;
            this.lblAvailableTime.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableTime.Location = new System.Drawing.Point(236, 58);
            this.lblAvailableTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableTime.Name = "lblAvailableTime";
            this.lblAvailableTime.Size = new System.Drawing.Size(77, 13);
            this.lblAvailableTime.TabIndex = 208;
            this.lblAvailableTime.Text = "Available Time:";
            // 
            // dtpAvailableDate
            // 
            this.dtpAvailableDate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAvailableDate.Location = new System.Drawing.Point(447, 55);
            this.dtpAvailableDate.Name = "dtpAvailableDate";
            this.dtpAvailableDate.Size = new System.Drawing.Size(72, 22);
            this.dtpAvailableDate.TabIndex = 207;
            this.dtpAvailableDate.ValueChanged += new System.EventHandler(this.dtpAvailableDate_ValueChanged);
            // 
            // lblAvLocation
            // 
            this.lblAvLocation.AutoSize = true;
            this.lblAvLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvLocation.Location = new System.Drawing.Point(42, 110);
            this.lblAvLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvLocation.Name = "lblAvLocation";
            this.lblAvLocation.Size = new System.Drawing.Size(51, 13);
            this.lblAvLocation.TabIndex = 205;
            this.lblAvLocation.Text = "Location: ";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Enabled = false;
            this.label61.Location = new System.Drawing.Point(4, 69);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(0, 13);
            this.label61.TabIndex = 204;
            // 
            // cboALocation
            // 
            this.cboALocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboALocation.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboALocation.Location = new System.Drawing.Point(98, 107);
            this.cboALocation.Name = "cboALocation";
            this.cboALocation.Size = new System.Drawing.Size(121, 21);
            this.cboALocation.TabIndex = 203;
            // 
            // txtAvailabilityID
            // 
            this.txtAvailabilityID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailabilityID.Location = new System.Drawing.Point(474, 28);
            this.txtAvailabilityID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAvailabilityID.Name = "txtAvailabilityID";
            this.txtAvailabilityID.ReadOnly = true;
            this.txtAvailabilityID.Size = new System.Drawing.Size(45, 22);
            this.txtAvailabilityID.TabIndex = 202;
            // 
            // lvwAvailability
            // 
            this.lvwAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwAvailability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwAvailability.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AvailDate,
            this.AvilAdvisor,
            this.Location,
            this.StartTime,
            this.EndTime});
            this.lvwAvailability.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAvailability.FullRowSelect = true;
            this.lvwAvailability.GridLines = true;
            this.lvwAvailability.HideSelection = false;
            this.lvwAvailability.Location = new System.Drawing.Point(8, 144);
            this.lvwAvailability.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwAvailability.Name = "lvwAvailability";
            this.lvwAvailability.Size = new System.Drawing.Size(579, 207);
            this.lvwAvailability.TabIndex = 176;
            this.lvwAvailability.UseCompatibleStateImageBehavior = false;
            this.lvwAvailability.View = System.Windows.Forms.View.Details;
            this.lvwAvailability.SelectedIndexChanged += new System.EventHandler(this.lvwAvailability_SelectedIndexChanged);
            // 
            // AvailDate
            // 
            this.AvailDate.Text = "Date";
            this.AvailDate.Width = 91;
            // 
            // AvilAdvisor
            // 
            this.AvilAdvisor.Text = "Advisor";
            this.AvilAdvisor.Width = 198;
            // 
            // Location
            // 
            this.Location.Text = "Location";
            this.Location.Width = 107;
            // 
            // StartTime
            // 
            this.StartTime.Text = "Start Time";
            this.StartTime.Width = 88;
            // 
            // EndTime
            // 
            this.EndTime.Text = "End Time";
            this.EndTime.Width = 92;
            // 
            // lblAvAdvisorName
            // 
            this.lblAvAdvisorName.AutoSize = true;
            this.lblAvAdvisorName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvAdvisorName.Location = new System.Drawing.Point(16, 54);
            this.lblAvAdvisorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvAdvisorName.Name = "lblAvAdvisorName";
            this.lblAvAdvisorName.Size = new System.Drawing.Size(75, 13);
            this.lblAvAdvisorName.TabIndex = 42;
            this.lblAvAdvisorName.Text = "Advisor Name:";
            // 
            // lblAvailabilityID
            // 
            this.lblAvailabilityID.AutoSize = true;
            this.lblAvailabilityID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilityID.Location = new System.Drawing.Point(397, 31);
            this.lblAvailabilityID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailabilityID.Name = "lblAvailabilityID";
            this.lblAvailabilityID.Size = new System.Drawing.Size(71, 13);
            this.lblAvailabilityID.TabIndex = 39;
            this.lblAvailabilityID.Text = "Availability ID:";
            // 
            // lblAvailabilityDetails
            // 
            this.lblAvailabilityDetails.AutoSize = true;
            this.lblAvailabilityDetails.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilityDetails.ForeColor = System.Drawing.Color.Peru;
            this.lblAvailabilityDetails.Location = new System.Drawing.Point(2, 3);
            this.lblAvailabilityDetails.Name = "lblAvailabilityDetails";
            this.lblAvailabilityDetails.Size = new System.Drawing.Size(233, 40);
            this.lblAvailabilityDetails.TabIndex = 175;
            this.lblAvailabilityDetails.Text = "Availability Details";
            // 
            // btnUpdateAvailabilityInfo
            // 
            this.btnUpdateAvailabilityInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAvailabilityInfo.Location = new System.Drawing.Point(407, 82);
            this.btnUpdateAvailabilityInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpdateAvailabilityInfo.Name = "btnUpdateAvailabilityInfo";
            this.btnUpdateAvailabilityInfo.Size = new System.Drawing.Size(63, 25);
            this.btnUpdateAvailabilityInfo.TabIndex = 141;
            this.btnUpdateAvailabilityInfo.Text = "UPDATE";
            this.btnUpdateAvailabilityInfo.UseVisualStyleBackColor = true;
            this.btnUpdateAvailabilityInfo.Visible = false;
            this.btnUpdateAvailabilityInfo.Click += new System.EventHandler(this.btnUpdateAvailabilityInfo_Click);
            // 
            // btnDeleteAvailabilityInfo
            // 
            this.btnDeleteAvailabilityInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAvailabilityInfo.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAvailabilityInfo.Location = new System.Drawing.Point(474, 82);
            this.btnDeleteAvailabilityInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDeleteAvailabilityInfo.Name = "btnDeleteAvailabilityInfo";
            this.btnDeleteAvailabilityInfo.Size = new System.Drawing.Size(63, 25);
            this.btnDeleteAvailabilityInfo.TabIndex = 140;
            this.btnDeleteAvailabilityInfo.Text = "DELETE";
            this.btnDeleteAvailabilityInfo.UseVisualStyleBackColor = true;
            this.btnDeleteAvailabilityInfo.Visible = false;
            this.btnDeleteAvailabilityInfo.Click += new System.EventHandler(this.btnDeleteAvailabilityInfo_Click_1);
            // 
            // btnEditAvailabilityInfo
            // 
            this.btnEditAvailabilityInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAvailabilityInfo.Location = new System.Drawing.Point(456, 82);
            this.btnEditAvailabilityInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEditAvailabilityInfo.Name = "btnEditAvailabilityInfo";
            this.btnEditAvailabilityInfo.Size = new System.Drawing.Size(63, 25);
            this.btnEditAvailabilityInfo.TabIndex = 139;
            this.btnEditAvailabilityInfo.Text = "EDIT";
            this.btnEditAvailabilityInfo.UseVisualStyleBackColor = true;
            this.btnEditAvailabilityInfo.Click += new System.EventHandler(this.btnEditAvailabilityInfo_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.txtTimeDisplay);
            this.tabPage4.Controls.Add(this.cboMeetingAdvisors);
            this.tabPage4.Controls.Add(this.lblAddAvailableDate);
            this.tabPage4.Controls.Add(this.dtpAddDate);
            this.tabPage4.Controls.Add(this.lblSelectLocation);
            this.tabPage4.Controls.Add(this.lblAddAvailableTime);
            this.tabPage4.Controls.Add(this.cboHourBlocks);
            this.tabPage4.Controls.Add(this.lblSelectAdvisor);
            this.tabPage4.Controls.Add(this.lblAddAvailability);
            this.tabPage4.Controls.Add(this.btnAddAvailabilityInfo);
            this.tabPage4.Controls.Add(this.cboLocations);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(593, 356);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Add Availability";
            // 
            // txtTimeDisplay
            // 
            this.txtTimeDisplay.Enabled = false;
            this.txtTimeDisplay.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeDisplay.Location = new System.Drawing.Point(331, 148);
            this.txtTimeDisplay.Name = "txtTimeDisplay";
            this.txtTimeDisplay.Size = new System.Drawing.Size(69, 22);
            this.txtTimeDisplay.TabIndex = 228;
            // 
            // cboMeetingAdvisors
            // 
            this.cboMeetingAdvisors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeetingAdvisors.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeetingAdvisors.FormattingEnabled = true;
            this.cboMeetingAdvisors.Location = new System.Drawing.Point(251, 95);
            this.cboMeetingAdvisors.Name = "cboMeetingAdvisors";
            this.cboMeetingAdvisors.Size = new System.Drawing.Size(119, 21);
            this.cboMeetingAdvisors.TabIndex = 221;
            // 
            // lblAddAvailableDate
            // 
            this.lblAddAvailableDate.AutoSize = true;
            this.lblAddAvailableDate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAvailableDate.Location = new System.Drawing.Point(167, 151);
            this.lblAddAvailableDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAvailableDate.Name = "lblAddAvailableDate";
            this.lblAddAvailableDate.Size = new System.Drawing.Size(77, 13);
            this.lblAddAvailableDate.TabIndex = 220;
            this.lblAddAvailableDate.Text = "Available Date:";
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddDate.Location = new System.Drawing.Point(251, 148);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(74, 22);
            this.dtpAddDate.TabIndex = 219;
            this.dtpAddDate.ValueChanged += new System.EventHandler(this.dtpAddDate_ValueChanged);
            // 
            // lblSelectLocation
            // 
            this.lblSelectLocation.AutoSize = true;
            this.lblSelectLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLocation.Location = new System.Drawing.Point(161, 178);
            this.lblSelectLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectLocation.Name = "lblSelectLocation";
            this.lblSelectLocation.Size = new System.Drawing.Size(79, 13);
            this.lblSelectLocation.TabIndex = 218;
            this.lblSelectLocation.Text = "Select Location:";
            // 
            // lblAddAvailableTime
            // 
            this.lblAddAvailableTime.AutoSize = true;
            this.lblAddAvailableTime.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAvailableTime.Location = new System.Drawing.Point(166, 125);
            this.lblAddAvailableTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAvailableTime.Name = "lblAddAvailableTime";
            this.lblAddAvailableTime.Size = new System.Drawing.Size(77, 13);
            this.lblAddAvailableTime.TabIndex = 216;
            this.lblAddAvailableTime.Text = "Available Time:";
            // 
            // cboHourBlocks
            // 
            this.cboHourBlocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHourBlocks.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHourBlocks.Location = new System.Drawing.Point(251, 121);
            this.cboHourBlocks.Name = "cboHourBlocks";
            this.cboHourBlocks.Size = new System.Drawing.Size(119, 21);
            this.cboHourBlocks.TabIndex = 215;
            // 
            // lblSelectAdvisor
            // 
            this.lblSelectAdvisor.AutoSize = true;
            this.lblSelectAdvisor.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAdvisor.Location = new System.Drawing.Point(167, 98);
            this.lblSelectAdvisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectAdvisor.Name = "lblSelectAdvisor";
            this.lblSelectAdvisor.Size = new System.Drawing.Size(74, 13);
            this.lblSelectAdvisor.TabIndex = 214;
            this.lblSelectAdvisor.Text = "Select Advisor:";
            // 
            // lblAddAvailability
            // 
            this.lblAddAvailability.AutoSize = true;
            this.lblAddAvailability.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAvailability.ForeColor = System.Drawing.Color.Peru;
            this.lblAddAvailability.Location = new System.Drawing.Point(3, 3);
            this.lblAddAvailability.Name = "lblAddAvailability";
            this.lblAddAvailability.Size = new System.Drawing.Size(199, 40);
            this.lblAddAvailability.TabIndex = 198;
            this.lblAddAvailability.Text = "Add Availability";
            // 
            // btnAddAvailabilityInfo
            // 
            this.btnAddAvailabilityInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAvailabilityInfo.Location = new System.Drawing.Point(251, 199);
            this.btnAddAvailabilityInfo.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAddAvailabilityInfo.Name = "btnAddAvailabilityInfo";
            this.btnAddAvailabilityInfo.Size = new System.Drawing.Size(63, 25);
            this.btnAddAvailabilityInfo.TabIndex = 138;
            this.btnAddAvailabilityInfo.Text = "ADD";
            this.btnAddAvailabilityInfo.UseVisualStyleBackColor = true;
            this.btnAddAvailabilityInfo.Click += new System.EventHandler(this.btnAddAvailabilityInfo_Click);
            // 
            // cboLocations
            // 
            this.cboLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocations.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocations.FormattingEnabled = true;
            this.cboLocations.Location = new System.Drawing.Point(251, 174);
            this.cboLocations.Name = "cboLocations";
            this.cboLocations.Size = new System.Drawing.Size(119, 21);
            this.cboLocations.TabIndex = 143;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(381, 67);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(112, 22);
            this.txtStudentID.TabIndex = 0;
            // 
            // txtStudentFName
            // 
            this.txtStudentFName.Location = new System.Drawing.Point(381, 93);
            this.txtStudentFName.Name = "txtStudentFName";
            this.txtStudentFName.Size = new System.Drawing.Size(112, 22);
            this.txtStudentFName.TabIndex = 1;
            // 
            // txtStudentLName
            // 
            this.txtStudentLName.Location = new System.Drawing.Point(381, 145);
            this.txtStudentLName.Name = "txtStudentLName";
            this.txtStudentLName.Size = new System.Drawing.Size(112, 22);
            this.txtStudentLName.TabIndex = 2;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(381, 170);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(112, 22);
            this.txtStudentEmail.TabIndex = 3;
            // 
            // btnUpdateStudentInfo
            // 
            this.btnUpdateStudentInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudentInfo.Location = new System.Drawing.Point(363, 222);
            this.btnUpdateStudentInfo.Name = "btnUpdateStudentInfo";
            this.btnUpdateStudentInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateStudentInfo.TabIndex = 4;
            this.btnUpdateStudentInfo.Text = "UPDATE";
            this.btnUpdateStudentInfo.UseVisualStyleBackColor = true;
            this.btnUpdateStudentInfo.Visible = false;
            this.btnUpdateStudentInfo.Click += new System.EventHandler(this.btnUpdateStudentInfo_Click);
            // 
            // lvwStudents
            // 
            this.lvwStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwStudents.BackColor = System.Drawing.SystemColors.Window;
            this.lvwStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader8});
            this.lvwStudents.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwStudents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lvwStudents.FullRowSelect = true;
            this.lvwStudents.GridLines = true;
            this.lvwStudents.HideSelection = false;
            this.lvwStudents.Location = new System.Drawing.Point(5, 3);
            this.lvwStudents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwStudents.Name = "lvwStudents";
            this.lvwStudents.Size = new System.Drawing.Size(250, 339);
            this.lvwStudents.TabIndex = 5;
            this.lvwStudents.UseCompatibleStateImageBehavior = false;
            this.lvwStudents.View = System.Windows.Forms.View.Details;
            this.lvwStudents.SelectedIndexChanged += new System.EventHandler(this.lvwStudents_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "First Name";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Middle Name";
            this.columnHeader4.Width = 84;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Last Name";
            this.columnHeader8.Width = 77;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(315, 70);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(59, 13);
            this.lblStudentID.TabIndex = 6;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblStudentFName
            // 
            this.lblStudentFName.AutoSize = true;
            this.lblStudentFName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentFName.Location = new System.Drawing.Point(316, 96);
            this.lblStudentFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentFName.Name = "lblStudentFName";
            this.lblStudentFName.Size = new System.Drawing.Size(59, 13);
            this.lblStudentFName.TabIndex = 7;
            this.lblStudentFName.Text = "First Name:";
            // 
            // lblStudentLName
            // 
            this.lblStudentLName.AutoSize = true;
            this.lblStudentLName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentLName.Location = new System.Drawing.Point(316, 148);
            this.lblStudentLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentLName.Name = "lblStudentLName";
            this.lblStudentLName.Size = new System.Drawing.Size(59, 13);
            this.lblStudentLName.TabIndex = 8;
            this.lblStudentLName.Text = "Last Name:";
            // 
            // lblStudentEmail
            // 
            this.lblStudentEmail.AutoSize = true;
            this.lblStudentEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentEmail.Location = new System.Drawing.Point(340, 175);
            this.lblStudentEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentEmail.Name = "lblStudentEmail";
            this.lblStudentEmail.Size = new System.Drawing.Size(34, 13);
            this.lblStudentEmail.TabIndex = 9;
            this.lblStudentEmail.Text = "Email:";
            // 
            // btnEditStudentInfo
            // 
            this.btnEditStudentInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudentInfo.Location = new System.Drawing.Point(381, 222);
            this.btnEditStudentInfo.Name = "btnEditStudentInfo";
            this.btnEditStudentInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditStudentInfo.TabIndex = 10;
            this.btnEditStudentInfo.Text = "EDIT";
            this.btnEditStudentInfo.UseVisualStyleBackColor = true;
            this.btnEditStudentInfo.Click += new System.EventHandler(this.btnEditStudentInfo_Click);
            // 
            // txtStudentMName
            // 
            this.txtStudentMName.Location = new System.Drawing.Point(381, 119);
            this.txtStudentMName.Name = "txtStudentMName";
            this.txtStudentMName.Size = new System.Drawing.Size(112, 22);
            this.txtStudentMName.TabIndex = 11;
            // 
            // lblStudentMName
            // 
            this.lblStudentMName.AutoSize = true;
            this.lblStudentMName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentMName.Location = new System.Drawing.Point(304, 122);
            this.lblStudentMName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentMName.Name = "lblStudentMName";
            this.lblStudentMName.Size = new System.Drawing.Size(73, 13);
            this.lblStudentMName.TabIndex = 12;
            this.lblStudentMName.Text = "Middle Name:";
            // 
            // txtUSCBID
            // 
            this.txtUSCBID.Location = new System.Drawing.Point(381, 196);
            this.txtUSCBID.Name = "txtUSCBID";
            this.txtUSCBID.ReadOnly = true;
            this.txtUSCBID.Size = new System.Drawing.Size(112, 22);
            this.txtUSCBID.TabIndex = 13;
            // 
            // lblUSCBID
            // 
            this.lblUSCBID.AutoSize = true;
            this.lblUSCBID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSCBID.Location = new System.Drawing.Point(329, 200);
            this.lblUSCBID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUSCBID.Name = "lblUSCBID";
            this.lblUSCBID.Size = new System.Drawing.Size(46, 13);
            this.lblUSCBID.TabIndex = 14;
            this.lblUSCBID.Text = "USCBID:";
            // 
            // btnDeleteStudentInfo
            // 
            this.btnDeleteStudentInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudentInfo.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteStudentInfo.Location = new System.Drawing.Point(444, 222);
            this.btnDeleteStudentInfo.Name = "btnDeleteStudentInfo";
            this.btnDeleteStudentInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudentInfo.TabIndex = 15;
            this.btnDeleteStudentInfo.Text = "DELETE";
            this.btnDeleteStudentInfo.UseVisualStyleBackColor = true;
            this.btnDeleteStudentInfo.Visible = false;
            this.btnDeleteStudentInfo.Click += new System.EventHandler(this.btnDeleteStudentInfo_Click);
            // 
            // tbAbout
            // 
            this.tbAbout.Controls.Add(this.tbStudents);
            this.tbAbout.Controls.Add(this.tbAdvisors);
            this.tbAbout.Controls.Add(this.tbLocations);
            this.tbAbout.Controls.Add(tbAvailability);
            this.tbAbout.Controls.Add(this.tbMeetings);
            this.tbAbout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAbout.Location = new System.Drawing.Point(16, 63);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.SelectedIndex = 0;
            this.tbAbout.Size = new System.Drawing.Size(619, 409);
            this.tbAbout.TabIndex = 16;
            // 
            // tbStudents
            // 
            this.tbStudents.Controls.Add(this.tabEditAddStudent);
            this.tbStudents.Location = new System.Drawing.Point(4, 22);
            this.tbStudents.Name = "tbStudents";
            this.tbStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudents.Size = new System.Drawing.Size(611, 383);
            this.tbStudents.TabIndex = 0;
            this.tbStudents.Text = "Students";
            this.tbStudents.UseVisualStyleBackColor = true;
            // 
            // tabEditAddStudent
            // 
            this.tabEditAddStudent.Controls.Add(this.tbUpdateStudent);
            this.tabEditAddStudent.Controls.Add(this.tbAddStudent);
            this.tabEditAddStudent.Location = new System.Drawing.Point(5, 4);
            this.tabEditAddStudent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabEditAddStudent.Name = "tabEditAddStudent";
            this.tabEditAddStudent.SelectedIndex = 0;
            this.tabEditAddStudent.Size = new System.Drawing.Size(604, 382);
            this.tabEditAddStudent.TabIndex = 16;
            // 
            // tbUpdateStudent
            // 
            this.tbUpdateStudent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbUpdateStudent.Controls.Add(this.lblStudentDetails);
            this.tbUpdateStudent.Controls.Add(this.lvwStudents);
            this.tbUpdateStudent.Controls.Add(this.btnDeleteStudentInfo);
            this.tbUpdateStudent.Controls.Add(this.lblStudentFName);
            this.tbUpdateStudent.Controls.Add(this.txtStudentMName);
            this.tbUpdateStudent.Controls.Add(this.lblStudentLName);
            this.tbUpdateStudent.Controls.Add(this.lblUSCBID);
            this.tbUpdateStudent.Controls.Add(this.lblStudentID);
            this.tbUpdateStudent.Controls.Add(this.txtStudentID);
            this.tbUpdateStudent.Controls.Add(this.lblStudentEmail);
            this.tbUpdateStudent.Controls.Add(this.txtUSCBID);
            this.tbUpdateStudent.Controls.Add(this.btnUpdateStudentInfo);
            this.tbUpdateStudent.Controls.Add(this.txtStudentFName);
            this.tbUpdateStudent.Controls.Add(this.btnEditStudentInfo);
            this.tbUpdateStudent.Controls.Add(this.lblStudentMName);
            this.tbUpdateStudent.Controls.Add(this.txtStudentEmail);
            this.tbUpdateStudent.Controls.Add(this.txtStudentLName);
            this.tbUpdateStudent.Location = new System.Drawing.Point(4, 22);
            this.tbUpdateStudent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbUpdateStudent.Name = "tbUpdateStudent";
            this.tbUpdateStudent.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbUpdateStudent.Size = new System.Drawing.Size(596, 356);
            this.tbUpdateStudent.TabIndex = 1;
            this.tbUpdateStudent.Text = "Edit Student";
            // 
            // lblStudentDetails
            // 
            this.lblStudentDetails.AutoSize = true;
            this.lblStudentDetails.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentDetails.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStudentDetails.Location = new System.Drawing.Point(260, 3);
            this.lblStudentDetails.Name = "lblStudentDetails";
            this.lblStudentDetails.Size = new System.Drawing.Size(199, 40);
            this.lblStudentDetails.TabIndex = 175;
            this.lblStudentDetails.Text = "Student Details";
            // 
            // tbAddStudent
            // 
            this.tbAddStudent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAddStudent.Controls.Add(this.lblAddStudent);
            this.tbAddStudent.Controls.Add(this.lblAddUSCBID);
            this.tbAddStudent.Controls.Add(this.txtAddUSCBID);
            this.tbAddStudent.Controls.Add(this.btnAddStudent);
            this.tbAddStudent.Controls.Add(this.lblAddStudentFName);
            this.tbAddStudent.Controls.Add(this.txtAddStudentMName);
            this.tbAddStudent.Controls.Add(this.lblAddStudentLName);
            this.tbAddStudent.Controls.Add(this.lblAddStudentEmail);
            this.tbAddStudent.Controls.Add(this.txtAddStudentFName);
            this.tbAddStudent.Controls.Add(this.lblAddStudentMName);
            this.tbAddStudent.Controls.Add(this.txtAddStudentEmail);
            this.tbAddStudent.Controls.Add(this.txtAddStudentLName);
            this.tbAddStudent.Location = new System.Drawing.Point(4, 22);
            this.tbAddStudent.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAddStudent.Name = "tbAddStudent";
            this.tbAddStudent.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAddStudent.Size = new System.Drawing.Size(596, 356);
            this.tbAddStudent.TabIndex = 2;
            this.tbAddStudent.Text = "Add Student";
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudent.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAddStudent.Location = new System.Drawing.Point(1, 1);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(165, 40);
            this.lblAddStudent.TabIndex = 49;
            this.lblAddStudent.Text = "Add Student";
            // 
            // lblAddUSCBID
            // 
            this.lblAddUSCBID.AutoSize = true;
            this.lblAddUSCBID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUSCBID.Location = new System.Drawing.Point(215, 198);
            this.lblAddUSCBID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddUSCBID.Name = "lblAddUSCBID";
            this.lblAddUSCBID.Size = new System.Drawing.Size(46, 13);
            this.lblAddUSCBID.TabIndex = 24;
            this.lblAddUSCBID.Text = "USCBID:";
            // 
            // txtAddUSCBID
            // 
            this.txtAddUSCBID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUSCBID.Location = new System.Drawing.Point(269, 189);
            this.txtAddUSCBID.Name = "txtAddUSCBID";
            this.txtAddUSCBID.Size = new System.Drawing.Size(112, 22);
            this.txtAddUSCBID.TabIndex = 23;
            this.txtAddUSCBID.TextChanged += new System.EventHandler(this.txtAddUSCBID_TextChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.White;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(269, 216);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 21;
            this.btnAddStudent.Text = "ADD";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblAddStudentFName
            // 
            this.lblAddStudentFName.AutoSize = true;
            this.lblAddStudentFName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentFName.Location = new System.Drawing.Point(202, 91);
            this.lblAddStudentFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentFName.Name = "lblAddStudentFName";
            this.lblAddStudentFName.Size = new System.Drawing.Size(59, 13);
            this.lblAddStudentFName.TabIndex = 16;
            this.lblAddStudentFName.Text = "First Name:";
            // 
            // txtAddStudentMName
            // 
            this.txtAddStudentMName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStudentMName.Location = new System.Drawing.Point(268, 114);
            this.txtAddStudentMName.Name = "txtAddStudentMName";
            this.txtAddStudentMName.Size = new System.Drawing.Size(112, 22);
            this.txtAddStudentMName.TabIndex = 19;
            // 
            // lblAddStudentLName
            // 
            this.lblAddStudentLName.AutoSize = true;
            this.lblAddStudentLName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentLName.Location = new System.Drawing.Point(202, 142);
            this.lblAddStudentLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentLName.Name = "lblAddStudentLName";
            this.lblAddStudentLName.Size = new System.Drawing.Size(59, 13);
            this.lblAddStudentLName.TabIndex = 17;
            this.lblAddStudentLName.Text = "Last Name:";
            // 
            // lblAddStudentEmail
            // 
            this.lblAddStudentEmail.AutoSize = true;
            this.lblAddStudentEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentEmail.Location = new System.Drawing.Point(228, 169);
            this.lblAddStudentEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentEmail.Name = "lblAddStudentEmail";
            this.lblAddStudentEmail.Size = new System.Drawing.Size(34, 13);
            this.lblAddStudentEmail.TabIndex = 18;
            this.lblAddStudentEmail.Text = "Email:";
            // 
            // txtAddStudentFName
            // 
            this.txtAddStudentFName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStudentFName.Location = new System.Drawing.Point(268, 87);
            this.txtAddStudentFName.Name = "txtAddStudentFName";
            this.txtAddStudentFName.Size = new System.Drawing.Size(112, 22);
            this.txtAddStudentFName.TabIndex = 13;
            // 
            // lblAddStudentMName
            // 
            this.lblAddStudentMName.AutoSize = true;
            this.lblAddStudentMName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStudentMName.Location = new System.Drawing.Point(192, 114);
            this.lblAddStudentMName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStudentMName.Name = "lblAddStudentMName";
            this.lblAddStudentMName.Size = new System.Drawing.Size(73, 13);
            this.lblAddStudentMName.TabIndex = 20;
            this.lblAddStudentMName.Text = "Middle Name:";
            // 
            // txtAddStudentEmail
            // 
            this.txtAddStudentEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStudentEmail.Location = new System.Drawing.Point(269, 164);
            this.txtAddStudentEmail.Name = "txtAddStudentEmail";
            this.txtAddStudentEmail.Size = new System.Drawing.Size(112, 22);
            this.txtAddStudentEmail.TabIndex = 15;
            // 
            // txtAddStudentLName
            // 
            this.txtAddStudentLName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStudentLName.Location = new System.Drawing.Point(268, 139);
            this.txtAddStudentLName.Name = "txtAddStudentLName";
            this.txtAddStudentLName.Size = new System.Drawing.Size(112, 22);
            this.txtAddStudentLName.TabIndex = 14;
            // 
            // tbAdvisors
            // 
            this.tbAdvisors.Controls.Add(this.tabAddEditAdvisor);
            this.tbAdvisors.Location = new System.Drawing.Point(4, 22);
            this.tbAdvisors.Name = "tbAdvisors";
            this.tbAdvisors.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdvisors.Size = new System.Drawing.Size(611, 383);
            this.tbAdvisors.TabIndex = 1;
            this.tbAdvisors.Text = "Advisors";
            this.tbAdvisors.UseVisualStyleBackColor = true;
            // 
            // tabAddEditAdvisor
            // 
            this.tabAddEditAdvisor.Controls.Add(this.tbEditAdvisor);
            this.tabAddEditAdvisor.Controls.Add(this.tbAddAdvisor);
            this.tabAddEditAdvisor.Location = new System.Drawing.Point(5, 4);
            this.tabAddEditAdvisor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAddEditAdvisor.Name = "tabAddEditAdvisor";
            this.tabAddEditAdvisor.SelectedIndex = 0;
            this.tabAddEditAdvisor.Size = new System.Drawing.Size(604, 382);
            this.tabAddEditAdvisor.TabIndex = 17;
            // 
            // tbEditAdvisor
            // 
            this.tbEditAdvisor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEditAdvisor.Controls.Add(this.maskedEditAdvisorPhone);
            this.tbEditAdvisor.Controls.Add(this.lblAdvisorDetails);
            this.tbEditAdvisor.Controls.Add(this.lvwAdvisors);
            this.tbEditAdvisor.Controls.Add(this.txtAdvisorOfficeAddress);
            this.tbEditAdvisor.Controls.Add(this.lblAdvisorFName);
            this.tbEditAdvisor.Controls.Add(this.lblAdvisorOffice);
            this.tbEditAdvisor.Controls.Add(this.lblAdvisorLName);
            this.tbEditAdvisor.Controls.Add(this.btnDeleteAdvisorInfo);
            this.tbEditAdvisor.Controls.Add(this.lblAdvisorID);
            this.tbEditAdvisor.Controls.Add(this.txtAdvisorMName);
            this.tbEditAdvisor.Controls.Add(this.lblAdvisorEmail);
            this.tbEditAdvisor.Controls.Add(this.lblPhoneNumber);
            this.tbEditAdvisor.Controls.Add(this.btnUpdateAdvisorInfo);
            this.tbEditAdvisor.Controls.Add(this.txtAdvisorID);
            this.tbEditAdvisor.Controls.Add(this.btnEditAdvisorInfo);
            this.tbEditAdvisor.Controls.Add(this.txtAdvisorEmail);
            this.tbEditAdvisor.Controls.Add(this.txtAdvisorFName);
            this.tbEditAdvisor.Controls.Add(this.txtAdvisorLName);
            this.tbEditAdvisor.Controls.Add(this.lblAdvisorMName);
            this.tbEditAdvisor.Location = new System.Drawing.Point(4, 22);
            this.tbEditAdvisor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEditAdvisor.Name = "tbEditAdvisor";
            this.tbEditAdvisor.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEditAdvisor.Size = new System.Drawing.Size(596, 356);
            this.tbEditAdvisor.TabIndex = 1;
            this.tbEditAdvisor.Text = "Edit Advisor";
            // 
            // maskedEditAdvisorPhone
            // 
            this.maskedEditAdvisorPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedEditAdvisorPhone.Location = new System.Drawing.Point(385, 204);
            this.maskedEditAdvisorPhone.Mask = "(999) 000-0000";
            this.maskedEditAdvisorPhone.Name = "maskedEditAdvisorPhone";
            this.maskedEditAdvisorPhone.Size = new System.Drawing.Size(112, 22);
            this.maskedEditAdvisorPhone.TabIndex = 175;
            // 
            // lblAdvisorDetails
            // 
            this.lblAdvisorDetails.AutoSize = true;
            this.lblAdvisorDetails.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorDetails.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAdvisorDetails.Location = new System.Drawing.Point(262, 5);
            this.lblAdvisorDetails.Name = "lblAdvisorDetails";
            this.lblAdvisorDetails.Size = new System.Drawing.Size(193, 40);
            this.lblAdvisorDetails.TabIndex = 174;
            this.lblAdvisorDetails.Text = "Advisor Details";
            // 
            // lvwAdvisors
            // 
            this.lvwAdvisors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwAdvisors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwAdvisors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwAdvisors.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAdvisors.FullRowSelect = true;
            this.lvwAdvisors.GridLines = true;
            this.lvwAdvisors.HideSelection = false;
            this.lvwAdvisors.Location = new System.Drawing.Point(4, 5);
            this.lvwAdvisors.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwAdvisors.Name = "lvwAdvisors";
            this.lvwAdvisors.Size = new System.Drawing.Size(255, 341);
            this.lvwAdvisors.TabIndex = 34;
            this.lvwAdvisors.UseCompatibleStateImageBehavior = false;
            this.lvwAdvisors.View = System.Windows.Forms.View.Details;
            this.lvwAdvisors.SelectedIndexChanged += new System.EventHandler(this.lvwAdvisors_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "First Name";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Middle Name";
            this.columnHeader6.Width = 88;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Last Name";
            this.columnHeader7.Width = 93;
            // 
            // txtAdvisorOfficeAddress
            // 
            this.txtAdvisorOfficeAddress.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvisorOfficeAddress.Location = new System.Drawing.Point(385, 178);
            this.txtAdvisorOfficeAddress.Name = "txtAdvisorOfficeAddress";
            this.txtAdvisorOfficeAddress.Size = new System.Drawing.Size(112, 22);
            this.txtAdvisorOfficeAddress.TabIndex = 32;
            // 
            // lblAdvisorFName
            // 
            this.lblAdvisorFName.AutoSize = true;
            this.lblAdvisorFName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorFName.Location = new System.Drawing.Point(321, 78);
            this.lblAdvisorFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvisorFName.Name = "lblAdvisorFName";
            this.lblAdvisorFName.Size = new System.Drawing.Size(59, 13);
            this.lblAdvisorFName.TabIndex = 23;
            this.lblAdvisorFName.Text = "First Name:";
            // 
            // lblAdvisorOffice
            // 
            this.lblAdvisorOffice.AutoSize = true;
            this.lblAdvisorOffice.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorOffice.Location = new System.Drawing.Point(303, 181);
            this.lblAdvisorOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvisorOffice.Name = "lblAdvisorOffice";
            this.lblAdvisorOffice.Size = new System.Drawing.Size(76, 13);
            this.lblAdvisorOffice.TabIndex = 33;
            this.lblAdvisorOffice.Text = "Office Address:";
            // 
            // lblAdvisorLName
            // 
            this.lblAdvisorLName.AutoSize = true;
            this.lblAdvisorLName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorLName.Location = new System.Drawing.Point(320, 130);
            this.lblAdvisorLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvisorLName.Name = "lblAdvisorLName";
            this.lblAdvisorLName.Size = new System.Drawing.Size(59, 13);
            this.lblAdvisorLName.TabIndex = 24;
            this.lblAdvisorLName.Text = "Last Name:";
            // 
            // btnDeleteAdvisorInfo
            // 
            this.btnDeleteAdvisorInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdvisorInfo.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteAdvisorInfo.Location = new System.Drawing.Point(449, 230);
            this.btnDeleteAdvisorInfo.Name = "btnDeleteAdvisorInfo";
            this.btnDeleteAdvisorInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAdvisorInfo.TabIndex = 31;
            this.btnDeleteAdvisorInfo.Text = "DELETE";
            this.btnDeleteAdvisorInfo.UseVisualStyleBackColor = true;
            this.btnDeleteAdvisorInfo.Visible = false;
            this.btnDeleteAdvisorInfo.Click += new System.EventHandler(this.btnDeleteAdvisorInfo_Click);
            // 
            // lblAdvisorID
            // 
            this.lblAdvisorID.AutoSize = true;
            this.lblAdvisorID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorID.Location = new System.Drawing.Point(322, 55);
            this.lblAdvisorID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvisorID.Name = "lblAdvisorID";
            this.lblAdvisorID.Size = new System.Drawing.Size(57, 13);
            this.lblAdvisorID.TabIndex = 22;
            this.lblAdvisorID.Text = "Advisor ID:";
            // 
            // txtAdvisorMName
            // 
            this.txtAdvisorMName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvisorMName.Location = new System.Drawing.Point(385, 101);
            this.txtAdvisorMName.Name = "txtAdvisorMName";
            this.txtAdvisorMName.Size = new System.Drawing.Size(112, 22);
            this.txtAdvisorMName.TabIndex = 27;
            // 
            // lblAdvisorEmail
            // 
            this.lblAdvisorEmail.AutoSize = true;
            this.lblAdvisorEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorEmail.Location = new System.Drawing.Point(346, 153);
            this.lblAdvisorEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvisorEmail.Name = "lblAdvisorEmail";
            this.lblAdvisorEmail.Size = new System.Drawing.Size(34, 13);
            this.lblAdvisorEmail.TabIndex = 25;
            this.lblAdvisorEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(298, 207);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 30;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // btnUpdateAdvisorInfo
            // 
            this.btnUpdateAdvisorInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAdvisorInfo.Location = new System.Drawing.Point(368, 230);
            this.btnUpdateAdvisorInfo.Name = "btnUpdateAdvisorInfo";
            this.btnUpdateAdvisorInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAdvisorInfo.TabIndex = 20;
            this.btnUpdateAdvisorInfo.Text = "UPDATE";
            this.btnUpdateAdvisorInfo.UseVisualStyleBackColor = true;
            this.btnUpdateAdvisorInfo.Visible = false;
            this.btnUpdateAdvisorInfo.Click += new System.EventHandler(this.btnUpdateAdvisorInfo_Click);
            // 
            // txtAdvisorID
            // 
            this.txtAdvisorID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvisorID.Location = new System.Drawing.Point(385, 52);
            this.txtAdvisorID.Name = "txtAdvisorID";
            this.txtAdvisorID.ReadOnly = true;
            this.txtAdvisorID.Size = new System.Drawing.Size(112, 22);
            this.txtAdvisorID.TabIndex = 16;
            // 
            // btnEditAdvisorInfo
            // 
            this.btnEditAdvisorInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdvisorInfo.Location = new System.Drawing.Point(386, 230);
            this.btnEditAdvisorInfo.Name = "btnEditAdvisorInfo";
            this.btnEditAdvisorInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditAdvisorInfo.TabIndex = 26;
            this.btnEditAdvisorInfo.Text = "EDIT";
            this.btnEditAdvisorInfo.UseVisualStyleBackColor = true;
            this.btnEditAdvisorInfo.Click += new System.EventHandler(this.btnEditAdvisorInfo_Click);
            // 
            // txtAdvisorEmail
            // 
            this.txtAdvisorEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvisorEmail.Location = new System.Drawing.Point(385, 151);
            this.txtAdvisorEmail.Name = "txtAdvisorEmail";
            this.txtAdvisorEmail.Size = new System.Drawing.Size(112, 22);
            this.txtAdvisorEmail.TabIndex = 19;
            // 
            // txtAdvisorFName
            // 
            this.txtAdvisorFName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvisorFName.Location = new System.Drawing.Point(385, 75);
            this.txtAdvisorFName.Name = "txtAdvisorFName";
            this.txtAdvisorFName.Size = new System.Drawing.Size(112, 22);
            this.txtAdvisorFName.TabIndex = 17;
            // 
            // txtAdvisorLName
            // 
            this.txtAdvisorLName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvisorLName.Location = new System.Drawing.Point(385, 127);
            this.txtAdvisorLName.Name = "txtAdvisorLName";
            this.txtAdvisorLName.Size = new System.Drawing.Size(112, 22);
            this.txtAdvisorLName.TabIndex = 18;
            // 
            // lblAdvisorMName
            // 
            this.lblAdvisorMName.AutoSize = true;
            this.lblAdvisorMName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorMName.Location = new System.Drawing.Point(309, 104);
            this.lblAdvisorMName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvisorMName.Name = "lblAdvisorMName";
            this.lblAdvisorMName.Size = new System.Drawing.Size(73, 13);
            this.lblAdvisorMName.TabIndex = 28;
            this.lblAdvisorMName.Text = "Middle Name:";
            // 
            // tbAddAdvisor
            // 
            this.tbAddAdvisor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAddAdvisor.Controls.Add(this.maskedAdvisorPhone);
            this.tbAddAdvisor.Controls.Add(this.lblAddAdvisor);
            this.tbAddAdvisor.Controls.Add(this.btnAddAdvisor);
            this.tbAddAdvisor.Controls.Add(this.txtAddOfficeAddress);
            this.tbAddAdvisor.Controls.Add(this.lblAddAdvisorFName);
            this.tbAddAdvisor.Controls.Add(this.lblAddAdvisorOffice);
            this.tbAddAdvisor.Controls.Add(this.lblAddAdvisorLName);
            this.tbAddAdvisor.Controls.Add(this.txtAddAdvisorMName);
            this.tbAddAdvisor.Controls.Add(this.lblAddAdvisorEmail);
            this.tbAddAdvisor.Controls.Add(this.lblAddPhoneNumber);
            this.tbAddAdvisor.Controls.Add(this.txtAddAdvisorEmail);
            this.tbAddAdvisor.Controls.Add(this.txtAddAdvisorFName);
            this.tbAddAdvisor.Controls.Add(this.txtAddAdvisorLName);
            this.tbAddAdvisor.Controls.Add(this.lblAddAdvisorMName);
            this.tbAddAdvisor.Location = new System.Drawing.Point(4, 22);
            this.tbAddAdvisor.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAddAdvisor.Name = "tbAddAdvisor";
            this.tbAddAdvisor.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAddAdvisor.Size = new System.Drawing.Size(596, 356);
            this.tbAddAdvisor.TabIndex = 2;
            this.tbAddAdvisor.Text = "Add Advisor";
            // 
            // maskedAdvisorPhone
            // 
            this.maskedAdvisorPhone.BeepOnError = true;
            this.maskedAdvisorPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedAdvisorPhone.Location = new System.Drawing.Point(263, 199);
            this.maskedAdvisorPhone.Mask = "(999) 000-0000";
            this.maskedAdvisorPhone.Name = "maskedAdvisorPhone";
            this.maskedAdvisorPhone.Size = new System.Drawing.Size(111, 22);
            this.maskedAdvisorPhone.TabIndex = 49;
            this.maskedAdvisorPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedAdvisorPhone_MaskInputRejected);
            // 
            // lblAddAdvisor
            // 
            this.lblAddAdvisor.AutoSize = true;
            this.lblAddAdvisor.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdvisor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAddAdvisor.Location = new System.Drawing.Point(3, 1);
            this.lblAddAdvisor.Name = "lblAddAdvisor";
            this.lblAddAdvisor.Size = new System.Drawing.Size(159, 40);
            this.lblAddAdvisor.TabIndex = 48;
            this.lblAddAdvisor.Text = "Add Advisor";
            // 
            // btnAddAdvisor
            // 
            this.btnAddAdvisor.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdvisor.Location = new System.Drawing.Point(260, 225);
            this.btnAddAdvisor.Name = "btnAddAdvisor";
            this.btnAddAdvisor.Size = new System.Drawing.Size(83, 23);
            this.btnAddAdvisor.TabIndex = 46;
            this.btnAddAdvisor.Text = "ADD";
            this.btnAddAdvisor.UseVisualStyleBackColor = true;
            this.btnAddAdvisor.Click += new System.EventHandler(this.btnAddAdvisor_Click);
            // 
            // txtAddOfficeAddress
            // 
            this.txtAddOfficeAddress.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddOfficeAddress.Location = new System.Drawing.Point(262, 172);
            this.txtAddOfficeAddress.Name = "txtAddOfficeAddress";
            this.txtAddOfficeAddress.Size = new System.Drawing.Size(112, 22);
            this.txtAddOfficeAddress.TabIndex = 44;
            // 
            // lblAddAdvisorFName
            // 
            this.lblAddAdvisorFName.AutoSize = true;
            this.lblAddAdvisorFName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdvisorFName.Location = new System.Drawing.Point(194, 73);
            this.lblAddAdvisorFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAdvisorFName.Name = "lblAddAdvisorFName";
            this.lblAddAdvisorFName.Size = new System.Drawing.Size(59, 13);
            this.lblAddAdvisorFName.TabIndex = 37;
            this.lblAddAdvisorFName.Text = "First Name:";
            // 
            // lblAddAdvisorOffice
            // 
            this.lblAddAdvisorOffice.AutoSize = true;
            this.lblAddAdvisorOffice.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdvisorOffice.Location = new System.Drawing.Point(177, 175);
            this.lblAddAdvisorOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAdvisorOffice.Name = "lblAddAdvisorOffice";
            this.lblAddAdvisorOffice.Size = new System.Drawing.Size(76, 13);
            this.lblAddAdvisorOffice.TabIndex = 45;
            this.lblAddAdvisorOffice.Text = "Office Address:";
            // 
            // lblAddAdvisorLName
            // 
            this.lblAddAdvisorLName.AutoSize = true;
            this.lblAddAdvisorLName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdvisorLName.Location = new System.Drawing.Point(194, 125);
            this.lblAddAdvisorLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAdvisorLName.Name = "lblAddAdvisorLName";
            this.lblAddAdvisorLName.Size = new System.Drawing.Size(59, 13);
            this.lblAddAdvisorLName.TabIndex = 38;
            this.lblAddAdvisorLName.Text = "Last Name:";
            // 
            // txtAddAdvisorMName
            // 
            this.txtAddAdvisorMName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAdvisorMName.Location = new System.Drawing.Point(261, 96);
            this.txtAddAdvisorMName.Name = "txtAddAdvisorMName";
            this.txtAddAdvisorMName.Size = new System.Drawing.Size(112, 22);
            this.txtAddAdvisorMName.TabIndex = 40;
            // 
            // lblAddAdvisorEmail
            // 
            this.lblAddAdvisorEmail.AutoSize = true;
            this.lblAddAdvisorEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdvisorEmail.Location = new System.Drawing.Point(219, 148);
            this.lblAddAdvisorEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAdvisorEmail.Name = "lblAddAdvisorEmail";
            this.lblAddAdvisorEmail.Size = new System.Drawing.Size(34, 13);
            this.lblAddAdvisorEmail.TabIndex = 39;
            this.lblAddAdvisorEmail.Text = "Email:";
            // 
            // lblAddPhoneNumber
            // 
            this.lblAddPhoneNumber.AutoSize = true;
            this.lblAddPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPhoneNumber.Location = new System.Drawing.Point(172, 205);
            this.lblAddPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddPhoneNumber.Name = "lblAddPhoneNumber";
            this.lblAddPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblAddPhoneNumber.TabIndex = 43;
            this.lblAddPhoneNumber.Text = "Phone Number:";
            // 
            // txtAddAdvisorEmail
            // 
            this.txtAddAdvisorEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAdvisorEmail.Location = new System.Drawing.Point(262, 148);
            this.txtAddAdvisorEmail.Name = "txtAddAdvisorEmail";
            this.txtAddAdvisorEmail.Size = new System.Drawing.Size(112, 22);
            this.txtAddAdvisorEmail.TabIndex = 36;
            // 
            // txtAddAdvisorFName
            // 
            this.txtAddAdvisorFName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAdvisorFName.Location = new System.Drawing.Point(260, 70);
            this.txtAddAdvisorFName.Name = "txtAddAdvisorFName";
            this.txtAddAdvisorFName.Size = new System.Drawing.Size(112, 22);
            this.txtAddAdvisorFName.TabIndex = 34;
            // 
            // txtAddAdvisorLName
            // 
            this.txtAddAdvisorLName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAdvisorLName.Location = new System.Drawing.Point(261, 122);
            this.txtAddAdvisorLName.Name = "txtAddAdvisorLName";
            this.txtAddAdvisorLName.Size = new System.Drawing.Size(112, 22);
            this.txtAddAdvisorLName.TabIndex = 35;
            // 
            // lblAddAdvisorMName
            // 
            this.lblAddAdvisorMName.AutoSize = true;
            this.lblAddAdvisorMName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAdvisorMName.Location = new System.Drawing.Point(180, 99);
            this.lblAddAdvisorMName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddAdvisorMName.Name = "lblAddAdvisorMName";
            this.lblAddAdvisorMName.Size = new System.Drawing.Size(73, 13);
            this.lblAddAdvisorMName.TabIndex = 41;
            this.lblAddAdvisorMName.Text = "Middle Name:";
            // 
            // tbLocations
            // 
            this.tbLocations.Controls.Add(this.tabAddEditLocation);
            this.tbLocations.Location = new System.Drawing.Point(4, 22);
            this.tbLocations.Name = "tbLocations";
            this.tbLocations.Size = new System.Drawing.Size(611, 383);
            this.tbLocations.TabIndex = 2;
            this.tbLocations.Text = "Locations";
            this.tbLocations.UseVisualStyleBackColor = true;
            // 
            // tabAddEditLocation
            // 
            this.tabAddEditLocation.Controls.Add(this.tbEditLocation);
            this.tabAddEditLocation.Controls.Add(this.tbAddLocation);
            this.tabAddEditLocation.Location = new System.Drawing.Point(5, 6);
            this.tabAddEditLocation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAddEditLocation.Name = "tabAddEditLocation";
            this.tabAddEditLocation.SelectedIndex = 0;
            this.tabAddEditLocation.Size = new System.Drawing.Size(604, 382);
            this.tabAddEditLocation.TabIndex = 18;
            // 
            // tbEditLocation
            // 
            this.tbEditLocation.BackColor = System.Drawing.Color.White;
            this.tbEditLocation.Controls.Add(this.lblLocationDetails);
            this.tbEditLocation.Controls.Add(this.btnDeleteLocationInfo);
            this.tbEditLocation.Controls.Add(this.lvwLocations);
            this.tbEditLocation.Controls.Add(this.btnEditLocationInfo);
            this.tbEditLocation.Controls.Add(this.lblLocationID);
            this.tbEditLocation.Controls.Add(this.btnUpdateLocationInfo);
            this.tbEditLocation.Controls.Add(this.txtLocationID);
            this.tbEditLocation.Controls.Add(this.txtLocationType);
            this.tbEditLocation.Controls.Add(this.lblLocationType);
            this.tbEditLocation.Location = new System.Drawing.Point(4, 22);
            this.tbEditLocation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEditLocation.Name = "tbEditLocation";
            this.tbEditLocation.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEditLocation.Size = new System.Drawing.Size(596, 356);
            this.tbEditLocation.TabIndex = 1;
            this.tbEditLocation.Text = "Edit Location";
            // 
            // lblLocationDetails
            // 
            this.lblLocationDetails.AutoSize = true;
            this.lblLocationDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblLocationDetails.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationDetails.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLocationDetails.Location = new System.Drawing.Point(193, 5);
            this.lblLocationDetails.Name = "lblLocationDetails";
            this.lblLocationDetails.Size = new System.Drawing.Size(206, 40);
            this.lblLocationDetails.TabIndex = 175;
            this.lblLocationDetails.Text = "Location Details";
            // 
            // btnDeleteLocationInfo
            // 
            this.btnDeleteLocationInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLocationInfo.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteLocationInfo.Location = new System.Drawing.Point(415, 153);
            this.btnDeleteLocationInfo.Name = "btnDeleteLocationInfo";
            this.btnDeleteLocationInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLocationInfo.TabIndex = 34;
            this.btnDeleteLocationInfo.Text = "DELETE";
            this.btnDeleteLocationInfo.UseVisualStyleBackColor = true;
            this.btnDeleteLocationInfo.Visible = false;
            this.btnDeleteLocationInfo.Click += new System.EventHandler(this.btnDeleteLocationInfo_Click);
            // 
            // lvwLocations
            // 
            this.lvwLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwLocations.BackColor = System.Drawing.Color.White;
            this.lvwLocations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwLocations.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLocations.FullRowSelect = true;
            this.lvwLocations.GridLines = true;
            this.lvwLocations.HideSelection = false;
            this.lvwLocations.Location = new System.Drawing.Point(4, 5);
            this.lvwLocations.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwLocations.Name = "lvwLocations";
            this.lvwLocations.Size = new System.Drawing.Size(184, 337);
            this.lvwLocations.TabIndex = 6;
            this.lvwLocations.UseCompatibleStateImageBehavior = false;
            this.lvwLocations.View = System.Windows.Forms.View.List;
            this.lvwLocations.SelectedIndexChanged += new System.EventHandler(this.lvwLocations_SelectedIndexChanged);
            // 
            // btnEditLocationInfo
            // 
            this.btnEditLocationInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditLocationInfo.Location = new System.Drawing.Point(352, 153);
            this.btnEditLocationInfo.Name = "btnEditLocationInfo";
            this.btnEditLocationInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditLocationInfo.TabIndex = 33;
            this.btnEditLocationInfo.Text = "EDIT";
            this.btnEditLocationInfo.UseVisualStyleBackColor = true;
            this.btnEditLocationInfo.Click += new System.EventHandler(this.btnEditLocationInfo_Click);
            // 
            // lblLocationID
            // 
            this.lblLocationID.AutoSize = true;
            this.lblLocationID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationID.Location = new System.Drawing.Point(282, 104);
            this.lblLocationID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationID.Name = "lblLocationID";
            this.lblLocationID.Size = new System.Drawing.Size(62, 13);
            this.lblLocationID.TabIndex = 24;
            this.lblLocationID.Text = "Location ID:";
            // 
            // btnUpdateLocationInfo
            // 
            this.btnUpdateLocationInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLocationInfo.Location = new System.Drawing.Point(334, 153);
            this.btnUpdateLocationInfo.Name = "btnUpdateLocationInfo";
            this.btnUpdateLocationInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateLocationInfo.TabIndex = 32;
            this.btnUpdateLocationInfo.Text = "UPDATE";
            this.btnUpdateLocationInfo.UseVisualStyleBackColor = true;
            this.btnUpdateLocationInfo.Visible = false;
            this.btnUpdateLocationInfo.Click += new System.EventHandler(this.btnUpdateLocationInfo_Click);
            // 
            // txtLocationID
            // 
            this.txtLocationID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationID.Location = new System.Drawing.Point(352, 101);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.ReadOnly = true;
            this.txtLocationID.Size = new System.Drawing.Size(112, 22);
            this.txtLocationID.TabIndex = 23;
            // 
            // txtLocationType
            // 
            this.txtLocationType.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationType.Location = new System.Drawing.Point(352, 127);
            this.txtLocationType.Name = "txtLocationType";
            this.txtLocationType.Size = new System.Drawing.Size(112, 22);
            this.txtLocationType.TabIndex = 25;
            // 
            // lblLocationType
            // 
            this.lblLocationType.AutoSize = true;
            this.lblLocationType.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationType.Location = new System.Drawing.Point(274, 130);
            this.lblLocationType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocationType.Name = "lblLocationType";
            this.lblLocationType.Size = new System.Drawing.Size(73, 13);
            this.lblLocationType.TabIndex = 26;
            this.lblLocationType.Text = "Location Type:";
            // 
            // tbAddLocation
            // 
            this.tbAddLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAddLocation.Controls.Add(this.lblAddLocation);
            this.tbAddLocation.Controls.Add(this.btnAddLocation);
            this.tbAddLocation.Controls.Add(this.txtAddLocationType);
            this.tbAddLocation.Controls.Add(this.lblAddLocationType);
            this.tbAddLocation.Location = new System.Drawing.Point(4, 22);
            this.tbAddLocation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAddLocation.Name = "tbAddLocation";
            this.tbAddLocation.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbAddLocation.Size = new System.Drawing.Size(596, 356);
            this.tbAddLocation.TabIndex = 2;
            this.tbAddLocation.Text = "Add Location";
            // 
            // lblAddLocation
            // 
            this.lblAddLocation.AutoSize = true;
            this.lblAddLocation.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLocation.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAddLocation.Location = new System.Drawing.Point(3, 1);
            this.lblAddLocation.Name = "lblAddLocation";
            this.lblAddLocation.Size = new System.Drawing.Size(172, 40);
            this.lblAddLocation.TabIndex = 49;
            this.lblAddLocation.Text = "Add Location";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.Location = new System.Drawing.Point(258, 161);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocation.TabIndex = 34;
            this.btnAddLocation.Text = "ADD";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // txtAddLocationType
            // 
            this.txtAddLocationType.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddLocationType.Location = new System.Drawing.Point(258, 135);
            this.txtAddLocationType.Name = "txtAddLocationType";
            this.txtAddLocationType.Size = new System.Drawing.Size(112, 22);
            this.txtAddLocationType.TabIndex = 27;
            // 
            // lblAddLocationType
            // 
            this.lblAddLocationType.AutoSize = true;
            this.lblAddLocationType.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLocationType.Location = new System.Drawing.Point(180, 138);
            this.lblAddLocationType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddLocationType.Name = "lblAddLocationType";
            this.lblAddLocationType.Size = new System.Drawing.Size(73, 13);
            this.lblAddLocationType.TabIndex = 28;
            this.lblAddLocationType.Text = "Location Type:";
            // 
            // tbMeetings
            // 
            this.tbMeetings.Controls.Add(this.tbEditAddMeetings);
            this.tbMeetings.Location = new System.Drawing.Point(4, 22);
            this.tbMeetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbMeetings.Name = "tbMeetings";
            this.tbMeetings.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbMeetings.Size = new System.Drawing.Size(611, 383);
            this.tbMeetings.TabIndex = 4;
            this.tbMeetings.Text = "Meetings";
            this.tbMeetings.UseVisualStyleBackColor = true;
            // 
            // tbEditAddMeetings
            // 
            this.tbEditAddMeetings.Controls.Add(this.tabPage2);
            this.tbEditAddMeetings.Controls.Add(this.tabPage1);
            this.tbEditAddMeetings.Location = new System.Drawing.Point(2, 4);
            this.tbEditAddMeetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEditAddMeetings.Name = "tbEditAddMeetings";
            this.tbEditAddMeetings.SelectedIndex = 0;
            this.tbEditAddMeetings.Size = new System.Drawing.Size(607, 385);
            this.tbEditAddMeetings.TabIndex = 162;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lblMeetingOffice);
            this.tabPage2.Controls.Add(this.txtMeetingAddress);
            this.tabPage2.Controls.Add(this.cboStatus);
            this.tabPage2.Controls.Add(this.lblAppointmentDate);
            this.tabPage2.Controls.Add(this.lblStatus);
            this.tabPage2.Controls.Add(this.lblMeetingID);
            this.tabPage2.Controls.Add(this.lblMeetingDetails);
            this.tabPage2.Controls.Add(this.txtAvailableDate_Meetings);
            this.tabPage2.Controls.Add(this.txtLocationType_Meetings);
            this.tabPage2.Controls.Add(this.btnDeleteMeetingInfo);
            this.tabPage2.Controls.Add(this.btnUpdateMeetingInfo);
            this.tabPage2.Controls.Add(this.btnEditMeetingInfo);
            this.tabPage2.Controls.Add(this.lblMeetingHours);
            this.tabPage2.Controls.Add(this.txtEndHour_Meetings);
            this.tabPage2.Controls.Add(this.txtStartHour_Meetings);
            this.tabPage2.Controls.Add(this.lblMeetingAdvisor);
            this.tabPage2.Controls.Add(this.txtAdvisorFName_Meetings);
            this.tabPage2.Controls.Add(this.lblMtAvailabilityID);
            this.tabPage2.Controls.Add(this.txtAvailabilityID_Meetings);
            this.tabPage2.Controls.Add(this.txtMeetingName);
            this.tabPage2.Controls.Add(this.txtStudentFName_Meetings);
            this.tabPage2.Controls.Add(this.lblMeetingName);
            this.tabPage2.Controls.Add(this.txtStudentID_Meetings);
            this.tabPage2.Controls.Add(this.txtMeetingID);
            this.tabPage2.Controls.Add(this.lvwMeetings);
            this.tabPage2.Controls.Add(this.lblStudentInfo);
            this.tabPage2.Controls.Add(this.lblMeetingLocation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(599, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Meetings";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblMeetingOffice
            // 
            this.lblMeetingOffice.AutoSize = true;
            this.lblMeetingOffice.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingOffice.Location = new System.Drawing.Point(311, 236);
            this.lblMeetingOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeetingOffice.Name = "lblMeetingOffice";
            this.lblMeetingOffice.Size = new System.Drawing.Size(76, 13);
            this.lblMeetingOffice.TabIndex = 181;
            this.lblMeetingOffice.Text = "Office Address:";
            // 
            // txtMeetingAddress
            // 
            this.txtMeetingAddress.Enabled = false;
            this.txtMeetingAddress.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingAddress.Location = new System.Drawing.Point(394, 232);
            this.txtMeetingAddress.Name = "txtMeetingAddress";
            this.txtMeetingAddress.Size = new System.Drawing.Size(124, 22);
            this.txtMeetingAddress.TabIndex = 180;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Scheduled",
            "In-Progress",
            "Finished"});
            this.cboStatus.Location = new System.Drawing.Point(394, 181);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(96, 21);
            this.cboStatus.TabIndex = 179;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(294, 157);
            this.lblAppointmentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(95, 13);
            this.lblAppointmentDate.TabIndex = 178;
            this.lblAppointmentDate.Text = "Appointment Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(349, 186);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 177;
            this.lblStatus.Text = "Status:";
            // 
            // lblMeetingID
            // 
            this.lblMeetingID.AutoSize = true;
            this.lblMeetingID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingID.Location = new System.Drawing.Point(326, 56);
            this.lblMeetingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeetingID.Name = "lblMeetingID";
            this.lblMeetingID.Size = new System.Drawing.Size(62, 13);
            this.lblMeetingID.TabIndex = 174;
            this.lblMeetingID.Text = "Meeting ID:";
            // 
            // lblMeetingDetails
            // 
            this.lblMeetingDetails.AutoSize = true;
            this.lblMeetingDetails.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingDetails.ForeColor = System.Drawing.Color.Peru;
            this.lblMeetingDetails.Location = new System.Drawing.Point(278, 4);
            this.lblMeetingDetails.Name = "lblMeetingDetails";
            this.lblMeetingDetails.Size = new System.Drawing.Size(204, 40);
            this.lblMeetingDetails.TabIndex = 173;
            this.lblMeetingDetails.Text = "Meeting Details";
            // 
            // txtAvailableDate_Meetings
            // 
            this.txtAvailableDate_Meetings.Enabled = false;
            this.txtAvailableDate_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableDate_Meetings.Location = new System.Drawing.Point(394, 153);
            this.txtAvailableDate_Meetings.Name = "txtAvailableDate_Meetings";
            this.txtAvailableDate_Meetings.Size = new System.Drawing.Size(125, 22);
            this.txtAvailableDate_Meetings.TabIndex = 172;
            // 
            // txtLocationType_Meetings
            // 
            this.txtLocationType_Meetings.Enabled = false;
            this.txtLocationType_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationType_Meetings.Location = new System.Drawing.Point(394, 206);
            this.txtLocationType_Meetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLocationType_Meetings.Name = "txtLocationType_Meetings";
            this.txtLocationType_Meetings.Size = new System.Drawing.Size(125, 22);
            this.txtLocationType_Meetings.TabIndex = 171;
            // 
            // btnDeleteMeetingInfo
            // 
            this.btnDeleteMeetingInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMeetingInfo.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteMeetingInfo.Location = new System.Drawing.Point(467, 286);
            this.btnDeleteMeetingInfo.Name = "btnDeleteMeetingInfo";
            this.btnDeleteMeetingInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMeetingInfo.TabIndex = 170;
            this.btnDeleteMeetingInfo.Text = "DELETE";
            this.btnDeleteMeetingInfo.UseVisualStyleBackColor = true;
            this.btnDeleteMeetingInfo.Visible = false;
            this.btnDeleteMeetingInfo.Click += new System.EventHandler(this.btnDeleteMeetingInfo_Click);
            // 
            // btnUpdateMeetingInfo
            // 
            this.btnUpdateMeetingInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMeetingInfo.Location = new System.Drawing.Point(379, 286);
            this.btnUpdateMeetingInfo.Name = "btnUpdateMeetingInfo";
            this.btnUpdateMeetingInfo.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateMeetingInfo.TabIndex = 169;
            this.btnUpdateMeetingInfo.Text = "UPDATE";
            this.btnUpdateMeetingInfo.UseVisualStyleBackColor = true;
            this.btnUpdateMeetingInfo.Visible = false;
            this.btnUpdateMeetingInfo.Click += new System.EventHandler(this.btnUpdateMeetingInfo_Click);
            // 
            // btnEditMeetingInfo
            // 
            this.btnEditMeetingInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMeetingInfo.Location = new System.Drawing.Point(393, 286);
            this.btnEditMeetingInfo.Name = "btnEditMeetingInfo";
            this.btnEditMeetingInfo.Size = new System.Drawing.Size(75, 23);
            this.btnEditMeetingInfo.TabIndex = 168;
            this.btnEditMeetingInfo.Text = "EDIT";
            this.btnEditMeetingInfo.UseVisualStyleBackColor = true;
            this.btnEditMeetingInfo.Click += new System.EventHandler(this.btnEditMeetingInfo_Click);
            // 
            // lblMeetingHours
            // 
            this.lblMeetingHours.AutoSize = true;
            this.lblMeetingHours.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingHours.Location = new System.Drawing.Point(350, 263);
            this.lblMeetingHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeetingHours.Name = "lblMeetingHours";
            this.lblMeetingHours.Size = new System.Drawing.Size(37, 13);
            this.lblMeetingHours.TabIndex = 167;
            this.lblMeetingHours.Text = "Hours:";
            // 
            // txtEndHour_Meetings
            // 
            this.txtEndHour_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHour_Meetings.Location = new System.Drawing.Point(471, 258);
            this.txtEndHour_Meetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEndHour_Meetings.Name = "txtEndHour_Meetings";
            this.txtEndHour_Meetings.Size = new System.Drawing.Size(47, 22);
            this.txtEndHour_Meetings.TabIndex = 166;
            // 
            // txtStartHour_Meetings
            // 
            this.txtStartHour_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHour_Meetings.Location = new System.Drawing.Point(394, 258);
            this.txtStartHour_Meetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtStartHour_Meetings.Name = "txtStartHour_Meetings";
            this.txtStartHour_Meetings.Size = new System.Drawing.Size(47, 22);
            this.txtStartHour_Meetings.TabIndex = 165;
            // 
            // lblMeetingAdvisor
            // 
            this.lblMeetingAdvisor.AutoSize = true;
            this.lblMeetingAdvisor.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingAdvisor.Location = new System.Drawing.Point(343, 134);
            this.lblMeetingAdvisor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeetingAdvisor.Name = "lblMeetingAdvisor";
            this.lblMeetingAdvisor.Size = new System.Drawing.Size(43, 13);
            this.lblMeetingAdvisor.TabIndex = 164;
            this.lblMeetingAdvisor.Text = "Advisor:";
            // 
            // txtAdvisorFName_Meetings
            // 
            this.txtAdvisorFName_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvisorFName_Meetings.Location = new System.Drawing.Point(393, 127);
            this.txtAdvisorFName_Meetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAdvisorFName_Meetings.Name = "txtAdvisorFName_Meetings";
            this.txtAdvisorFName_Meetings.Size = new System.Drawing.Size(125, 22);
            this.txtAdvisorFName_Meetings.TabIndex = 163;
            // 
            // lblMtAvailabilityID
            // 
            this.lblMtAvailabilityID.AutoSize = true;
            this.lblMtAvailabilityID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtAvailabilityID.Location = new System.Drawing.Point(434, 56);
            this.lblMtAvailabilityID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMtAvailabilityID.Name = "lblMtAvailabilityID";
            this.lblMtAvailabilityID.Size = new System.Drawing.Size(71, 13);
            this.lblMtAvailabilityID.TabIndex = 161;
            this.lblMtAvailabilityID.Text = "Availability ID:";
            // 
            // txtAvailabilityID_Meetings
            // 
            this.txtAvailabilityID_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailabilityID_Meetings.Location = new System.Drawing.Point(510, 52);
            this.txtAvailabilityID_Meetings.Name = "txtAvailabilityID_Meetings";
            this.txtAvailabilityID_Meetings.Size = new System.Drawing.Size(32, 22);
            this.txtAvailabilityID_Meetings.TabIndex = 161;
            // 
            // txtMeetingName
            // 
            this.txtMeetingName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingName.Location = new System.Drawing.Point(394, 101);
            this.txtMeetingName.Name = "txtMeetingName";
            this.txtMeetingName.Size = new System.Drawing.Size(148, 22);
            this.txtMeetingName.TabIndex = 160;
            // 
            // txtStudentFName_Meetings
            // 
            this.txtStudentFName_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentFName_Meetings.Location = new System.Drawing.Point(429, 77);
            this.txtStudentFName_Meetings.Name = "txtStudentFName_Meetings";
            this.txtStudentFName_Meetings.Size = new System.Drawing.Size(113, 22);
            this.txtStudentFName_Meetings.TabIndex = 159;
            // 
            // lblMeetingName
            // 
            this.lblMeetingName.AutoSize = true;
            this.lblMeetingName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingName.Location = new System.Drawing.Point(309, 106);
            this.lblMeetingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeetingName.Name = "lblMeetingName";
            this.lblMeetingName.Size = new System.Drawing.Size(80, 13);
            this.lblMeetingName.TabIndex = 159;
            this.lblMeetingName.Text = "Meeting Name:";
            // 
            // txtStudentID_Meetings
            // 
            this.txtStudentID_Meetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentID_Meetings.Location = new System.Drawing.Point(393, 77);
            this.txtStudentID_Meetings.Name = "txtStudentID_Meetings";
            this.txtStudentID_Meetings.Size = new System.Drawing.Size(32, 22);
            this.txtStudentID_Meetings.TabIndex = 158;
            // 
            // txtMeetingID
            // 
            this.txtMeetingID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingID.Location = new System.Drawing.Point(393, 52);
            this.txtMeetingID.Name = "txtMeetingID";
            this.txtMeetingID.ReadOnly = true;
            this.txtMeetingID.Size = new System.Drawing.Size(32, 22);
            this.txtMeetingID.TabIndex = 152;
            // 
            // lvwMeetings
            // 
            this.lvwMeetings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwMeetings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwMeetings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.lvwMeetings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMeetings.FullRowSelect = true;
            this.lvwMeetings.GridLines = true;
            this.lvwMeetings.HideSelection = false;
            this.lvwMeetings.Location = new System.Drawing.Point(4, 4);
            this.lvwMeetings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwMeetings.Name = "lvwMeetings";
            this.lvwMeetings.Size = new System.Drawing.Size(269, 348);
            this.lvwMeetings.TabIndex = 91;
            this.lvwMeetings.UseCompatibleStateImageBehavior = false;
            this.lvwMeetings.View = System.Windows.Forms.View.Details;
            this.lvwMeetings.SelectedIndexChanged += new System.EventHandler(this.lvwMeetings_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Meeting";
            this.columnHeader17.Width = 107;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Student";
            this.columnHeader18.Width = 72;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Date";
            this.columnHeader19.Width = 86;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.Location = new System.Drawing.Point(320, 79);
            this.lblStudentInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(66, 13);
            this.lblStudentInfo.TabIndex = 128;
            this.lblStudentInfo.Text = "Student Info:";
            // 
            // lblMeetingLocation
            // 
            this.lblMeetingLocation.AutoSize = true;
            this.lblMeetingLocation.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeetingLocation.Location = new System.Drawing.Point(338, 213);
            this.lblMeetingLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeetingLocation.Name = "lblMeetingLocation";
            this.lblMeetingLocation.Size = new System.Drawing.Size(48, 13);
            this.lblMeetingLocation.TabIndex = 90;
            this.lblMeetingLocation.Text = "Location:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblMtEndBlock);
            this.tabPage1.Controls.Add(this.lblMtStartBlock);
            this.tabPage1.Controls.Add(this.lblSelectStudent);
            this.tabPage1.Controls.Add(this.lblAddStatus);
            this.tabPage1.Controls.Add(this.lblMtAddAvailabilityID);
            this.tabPage1.Controls.Add(this.lblAddMeetings);
            this.tabPage1.Controls.Add(this.txtStatusAdd);
            this.tabPage1.Controls.Add(this.txtAvailabilityID_MeetingsAdd);
            this.tabPage1.Controls.Add(this.lvwAddMeetings);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.lblAddMeetingName);
            this.tabPage1.Controls.Add(this.txtMeetingNameAdd);
            this.tabPage1.Controls.Add(this.txtEndHourAddMeetings);
            this.tabPage1.Controls.Add(this.label52);
            this.tabPage1.Controls.Add(this.btnAddMeeting);
            this.tabPage1.Controls.Add(this.lblMtAddAvailableDate);
            this.tabPage1.Controls.Add(this.cboMeetingStudents);
            this.tabPage1.Controls.Add(this.txtAvailableDate);
            this.tabPage1.Controls.Add(this.txtStartHourAddMeetings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(599, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Meetings";
            // 
            // lblMtEndBlock
            // 
            this.lblMtEndBlock.AutoSize = true;
            this.lblMtEndBlock.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtEndBlock.Location = new System.Drawing.Point(436, 72);
            this.lblMtEndBlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMtEndBlock.Name = "lblMtEndBlock";
            this.lblMtEndBlock.Size = new System.Drawing.Size(53, 13);
            this.lblMtEndBlock.TabIndex = 201;
            this.lblMtEndBlock.Text = "End Time:";
            // 
            // lblMtStartBlock
            // 
            this.lblMtStartBlock.AutoSize = true;
            this.lblMtStartBlock.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtStartBlock.Location = new System.Drawing.Point(309, 72);
            this.lblMtStartBlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMtStartBlock.Name = "lblMtStartBlock";
            this.lblMtStartBlock.Size = new System.Drawing.Size(57, 13);
            this.lblMtStartBlock.TabIndex = 200;
            this.lblMtStartBlock.Text = "Start Time:";
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStudent.Location = new System.Drawing.Point(15, 98);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(76, 13);
            this.lblSelectStudent.TabIndex = 199;
            this.lblSelectStudent.Text = "Select Student:";
            // 
            // lblAddStatus
            // 
            this.lblAddStatus.AutoSize = true;
            this.lblAddStatus.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStatus.Location = new System.Drawing.Point(417, 42);
            this.lblAddStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddStatus.Name = "lblAddStatus";
            this.lblAddStatus.Size = new System.Drawing.Size(37, 13);
            this.lblAddStatus.TabIndex = 198;
            this.lblAddStatus.Text = "Status:";
            // 
            // lblMtAddAvailabilityID
            // 
            this.lblMtAddAvailabilityID.AutoSize = true;
            this.lblMtAddAvailabilityID.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtAddAvailabilityID.Location = new System.Drawing.Point(311, 42);
            this.lblMtAddAvailabilityID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMtAddAvailabilityID.Name = "lblMtAddAvailabilityID";
            this.lblMtAddAvailabilityID.Size = new System.Drawing.Size(71, 13);
            this.lblMtAddAvailabilityID.TabIndex = 197;
            this.lblMtAddAvailabilityID.Text = "Availability ID:";
            // 
            // lblAddMeetings
            // 
            this.lblAddMeetings.AutoSize = true;
            this.lblAddMeetings.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMeetings.ForeColor = System.Drawing.Color.Peru;
            this.lblAddMeetings.Location = new System.Drawing.Point(5, 1);
            this.lblAddMeetings.Name = "lblAddMeetings";
            this.lblAddMeetings.Size = new System.Drawing.Size(181, 40);
            this.lblAddMeetings.TabIndex = 196;
            this.lblAddMeetings.Text = "Add Meetings";
            // 
            // txtStatusAdd
            // 
            this.txtStatusAdd.Enabled = false;
            this.txtStatusAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusAdd.Location = new System.Drawing.Point(461, 39);
            this.txtStatusAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtStatusAdd.Name = "txtStatusAdd";
            this.txtStatusAdd.ReadOnly = true;
            this.txtStatusAdd.Size = new System.Drawing.Size(76, 22);
            this.txtStatusAdd.TabIndex = 194;
            this.txtStatusAdd.Text = "Scheduled";
            // 
            // txtAvailabilityID_MeetingsAdd
            // 
            this.txtAvailabilityID_MeetingsAdd.Enabled = false;
            this.txtAvailabilityID_MeetingsAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailabilityID_MeetingsAdd.Location = new System.Drawing.Point(385, 39);
            this.txtAvailabilityID_MeetingsAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAvailabilityID_MeetingsAdd.Name = "txtAvailabilityID_MeetingsAdd";
            this.txtAvailabilityID_MeetingsAdd.ReadOnly = true;
            this.txtAvailabilityID_MeetingsAdd.Size = new System.Drawing.Size(28, 22);
            this.txtAvailabilityID_MeetingsAdd.TabIndex = 193;
            // 
            // lvwAddMeetings
            // 
            this.lvwAddMeetings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwAddMeetings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MeetingDate,
            this.MeetingAdvisor,
            this.MeetingLocation,
            this.MeetingStartTime,
            this.MeetingEndTime});
            this.lvwAddMeetings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAddMeetings.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwAddMeetings.FullRowSelect = true;
            this.lvwAddMeetings.GridLines = true;
            this.lvwAddMeetings.HideSelection = false;
            this.lvwAddMeetings.Location = new System.Drawing.Point(6, 135);
            this.lvwAddMeetings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvwAddMeetings.Name = "lvwAddMeetings";
            this.lvwAddMeetings.Size = new System.Drawing.Size(589, 220);
            this.lvwAddMeetings.TabIndex = 192;
            this.lvwAddMeetings.UseCompatibleStateImageBehavior = false;
            this.lvwAddMeetings.View = System.Windows.Forms.View.Details;
            this.lvwAddMeetings.SelectedIndexChanged += new System.EventHandler(this.lvwAddMeetings_SelectedIndexChanged);
            // 
            // MeetingDate
            // 
            this.MeetingDate.Text = "Date";
            this.MeetingDate.Width = 89;
            // 
            // MeetingAdvisor
            // 
            this.MeetingAdvisor.Tag = "h";
            this.MeetingAdvisor.Text = "Advisor";
            this.MeetingAdvisor.Width = 195;
            // 
            // MeetingLocation
            // 
            this.MeetingLocation.Text = "Location";
            this.MeetingLocation.Width = 132;
            // 
            // MeetingStartTime
            // 
            this.MeetingStartTime.Text = "Start Time";
            this.MeetingStartTime.Width = 81;
            // 
            // MeetingEndTime
            // 
            this.MeetingEndTime.Text = "End Time";
            this.MeetingEndTime.Width = 88;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(545, -18);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(18, 13);
            this.label42.TabIndex = 191;
            this.label42.Text = "ID";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(487, -30);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(45, 13);
            this.label34.TabIndex = 178;
            this.label34.Text = "Advisor";
            // 
            // lblAddMeetingName
            // 
            this.lblAddMeetingName.AutoSize = true;
            this.lblAddMeetingName.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMeetingName.Location = new System.Drawing.Point(15, 46);
            this.lblAddMeetingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddMeetingName.Name = "lblAddMeetingName";
            this.lblAddMeetingName.Size = new System.Drawing.Size(80, 13);
            this.lblAddMeetingName.TabIndex = 170;
            this.lblAddMeetingName.Text = "Meeting Name:";
            // 
            // txtMeetingNameAdd
            // 
            this.txtMeetingNameAdd.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeetingNameAdd.Location = new System.Drawing.Point(98, 42);
            this.txtMeetingNameAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtMeetingNameAdd.Name = "txtMeetingNameAdd";
            this.txtMeetingNameAdd.Size = new System.Drawing.Size(134, 22);
            this.txtMeetingNameAdd.TabIndex = 169;
            // 
            // txtEndHourAddMeetings
            // 
            this.txtEndHourAddMeetings.Enabled = false;
            this.txtEndHourAddMeetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndHourAddMeetings.Location = new System.Drawing.Point(494, 68);
            this.txtEndHourAddMeetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEndHourAddMeetings.Name = "txtEndHourAddMeetings";
            this.txtEndHourAddMeetings.ReadOnly = true;
            this.txtEndHourAddMeetings.Size = new System.Drawing.Size(43, 22);
            this.txtEndHourAddMeetings.TabIndex = 168;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(427, 144);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(0, 13);
            this.label52.TabIndex = 167;
            // 
            // btnAddMeeting
            // 
            this.btnAddMeeting.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMeeting.Location = new System.Drawing.Point(490, 93);
            this.btnAddMeeting.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddMeeting.Name = "btnAddMeeting";
            this.btnAddMeeting.Size = new System.Drawing.Size(47, 26);
            this.btnAddMeeting.TabIndex = 165;
            this.btnAddMeeting.Text = "ADD";
            this.btnAddMeeting.UseVisualStyleBackColor = true;
            this.btnAddMeeting.Click += new System.EventHandler(this.btnAddMeeting_Click);
            // 
            // lblMtAddAvailableDate
            // 
            this.lblMtAddAvailableDate.AutoSize = true;
            this.lblMtAddAvailableDate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtAddAvailableDate.Location = new System.Drawing.Point(14, 71);
            this.lblMtAddAvailableDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMtAddAvailableDate.Name = "lblMtAddAvailableDate";
            this.lblMtAddAvailableDate.Size = new System.Drawing.Size(77, 13);
            this.lblMtAddAvailableDate.TabIndex = 164;
            this.lblMtAddAvailableDate.Text = "Available Date:";
            // 
            // cboMeetingStudents
            // 
            this.cboMeetingStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMeetingStudents.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMeetingStudents.FormattingEnabled = true;
            this.cboMeetingStudents.Items.AddRange(new object[] {
            "xiamei"});
            this.cboMeetingStudents.Location = new System.Drawing.Point(98, 94);
            this.cboMeetingStudents.Name = "cboMeetingStudents";
            this.cboMeetingStudents.Size = new System.Drawing.Size(121, 21);
            this.cboMeetingStudents.TabIndex = 163;
            // 
            // txtAvailableDate
            // 
            this.txtAvailableDate.Enabled = false;
            this.txtAvailableDate.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableDate.Location = new System.Drawing.Point(98, 68);
            this.txtAvailableDate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtAvailableDate.Name = "txtAvailableDate";
            this.txtAvailableDate.Size = new System.Drawing.Size(121, 22);
            this.txtAvailableDate.TabIndex = 162;
            // 
            // txtStartHourAddMeetings
            // 
            this.txtStartHourAddMeetings.Enabled = false;
            this.txtStartHourAddMeetings.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartHourAddMeetings.Location = new System.Drawing.Point(370, 68);
            this.txtStartHourAddMeetings.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtStartHourAddMeetings.Name = "txtStartHourAddMeetings";
            this.txtStartHourAddMeetings.ReadOnly = true;
            this.txtStartHourAddMeetings.Size = new System.Drawing.Size(43, 22);
            this.txtStartHourAddMeetings.TabIndex = 140;
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.ErrorImage")));
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.InitialImage")));
            this.pctLogo.Location = new System.Drawing.Point(16, 4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(198, 53);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 17;
            this.pctLogo.TabStop = false;
            this.pctLogo.WaitOnLoad = true;
            // 
            // pctUSCBLogo
            // 
            this.pctUSCBLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctUSCBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctUSCBLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctUSCBLogo.ErrorImage")));
            this.pctUSCBLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctUSCBLogo.Image")));
            this.pctUSCBLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctUSCBLogo.InitialImage")));
            this.pctUSCBLogo.Location = new System.Drawing.Point(484, 16);
            this.pctUSCBLogo.Name = "pctUSCBLogo";
            this.pctUSCBLogo.Size = new System.Drawing.Size(151, 43);
            this.pctUSCBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUSCBLogo.TabIndex = 18;
            this.pctUSCBLogo.TabStop = false;
            // 
            // frmB321
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(652, 484);
            this.Controls.Add(this.pctUSCBLogo);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.tbAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmB321";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calenvisor (Admin)";
            this.Load += new System.EventHandler(this.frmB321_Load);
            tbAvailability.ResumeLayout(false);
            this.tabEditAddAvailability.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tbAbout.ResumeLayout(false);
            this.tbStudents.ResumeLayout(false);
            this.tabEditAddStudent.ResumeLayout(false);
            this.tbUpdateStudent.ResumeLayout(false);
            this.tbUpdateStudent.PerformLayout();
            this.tbAddStudent.ResumeLayout(false);
            this.tbAddStudent.PerformLayout();
            this.tbAdvisors.ResumeLayout(false);
            this.tabAddEditAdvisor.ResumeLayout(false);
            this.tbEditAdvisor.ResumeLayout(false);
            this.tbEditAdvisor.PerformLayout();
            this.tbAddAdvisor.ResumeLayout(false);
            this.tbAddAdvisor.PerformLayout();
            this.tbLocations.ResumeLayout(false);
            this.tabAddEditLocation.ResumeLayout(false);
            this.tbEditLocation.ResumeLayout(false);
            this.tbEditLocation.PerformLayout();
            this.tbAddLocation.ResumeLayout(false);
            this.tbAddLocation.PerformLayout();
            this.tbMeetings.ResumeLayout(false);
            this.tbEditAddMeetings.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUSCBLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentFName;
        private System.Windows.Forms.TextBox txtStudentLName;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.Button btnUpdateStudentInfo;
        private System.Windows.Forms.ListView lvwStudents;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentFName;
        private System.Windows.Forms.Label lblStudentLName;
        private System.Windows.Forms.Label lblStudentEmail;
        private System.Windows.Forms.Button btnEditStudentInfo;
        private System.Windows.Forms.TextBox txtStudentMName;
        private System.Windows.Forms.Label lblStudentMName;
        private System.Windows.Forms.TextBox txtUSCBID;
        private System.Windows.Forms.Label lblUSCBID;
        private System.Windows.Forms.Button btnDeleteStudentInfo;
        private System.Windows.Forms.TabControl tbAbout;
        private System.Windows.Forms.TabPage tbStudents;
        private System.Windows.Forms.TabPage tbAdvisors;
        private System.Windows.Forms.Button btnDeleteAdvisorInfo;
        private System.Windows.Forms.TextBox txtAdvisorMName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAdvisorID;
        private System.Windows.Forms.TextBox txtAdvisorFName;
        private System.Windows.Forms.Label lblAdvisorMName;
        private System.Windows.Forms.TextBox txtAdvisorLName;
        private System.Windows.Forms.TextBox txtAdvisorEmail;
        private System.Windows.Forms.Button btnEditAdvisorInfo;
        private System.Windows.Forms.Button btnUpdateAdvisorInfo;
        private System.Windows.Forms.Label lblAdvisorEmail;
        private System.Windows.Forms.Label lblAdvisorID;
        private System.Windows.Forms.Label lblAdvisorLName;
        private System.Windows.Forms.Label lblAdvisorFName;
        private System.Windows.Forms.TabPage tbLocations;
        private System.Windows.Forms.TextBox txtAdvisorOfficeAddress;
        private System.Windows.Forms.Label lblAdvisorOffice;
        private System.Windows.Forms.ListView lvwAdvisors;
        private System.Windows.Forms.ListView lvwLocations;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.Label lblLocationID;
        private System.Windows.Forms.TextBox txtLocationType;
        private System.Windows.Forms.Label lblLocationType;
        private System.Windows.Forms.Button btnDeleteLocationInfo;
        private System.Windows.Forms.Button btnEditLocationInfo;
        private System.Windows.Forms.Button btnUpdateLocationInfo;
        private System.Windows.Forms.TabControl tabEditAddStudent;
        private System.Windows.Forms.TabPage tbUpdateStudent;
        private System.Windows.Forms.TabPage tbAddStudent;
        private System.Windows.Forms.TabControl tabAddEditAdvisor;
        private System.Windows.Forms.TabPage tbEditAdvisor;
        private System.Windows.Forms.TabPage tbAddAdvisor;
        private System.Windows.Forms.TabControl tabAddEditLocation;
        private System.Windows.Forms.TabPage tbEditLocation;
        private System.Windows.Forms.TabPage tbAddLocation;
        private System.Windows.Forms.Button btnAddAdvisor;
        private System.Windows.Forms.TextBox txtAddOfficeAddress;
        private System.Windows.Forms.Label lblAddAdvisorFName;
        private System.Windows.Forms.Label lblAddAdvisorOffice;
        private System.Windows.Forms.Label lblAddAdvisorLName;
        private System.Windows.Forms.TextBox txtAddAdvisorMName;
        private System.Windows.Forms.Label lblAddAdvisorEmail;
        private System.Windows.Forms.Label lblAddPhoneNumber;
        private System.Windows.Forms.TextBox txtAddAdvisorEmail;
        private System.Windows.Forms.TextBox txtAddAdvisorFName;
        private System.Windows.Forms.TextBox txtAddAdvisorLName;
        private System.Windows.Forms.Label lblAddAdvisorMName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblAddStudentFName;
        private System.Windows.Forms.TextBox txtAddStudentMName;
        private System.Windows.Forms.Label lblAddStudentLName;
        private System.Windows.Forms.Label lblAddStudentEmail;
        private System.Windows.Forms.TextBox txtAddStudentFName;
        private System.Windows.Forms.Label lblAddStudentMName;
        private System.Windows.Forms.TextBox txtAddStudentEmail;
        private System.Windows.Forms.TextBox txtAddStudentLName;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.TextBox txtAddLocationType;
        private System.Windows.Forms.Label lblAddLocationType;
        private System.Windows.Forms.Label lblAddUSCBID;
        private System.Windows.Forms.TextBox txtAddUSCBID;
        private System.Windows.Forms.Label lblAddAdvisor;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblAddLocation;
        private System.Windows.Forms.TabPage tbMeetings;
        private System.Windows.Forms.Label lblAvAdvisorName;
        private System.Windows.Forms.Label lblAvailabilityID;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lblMeetingLocation;
        private System.Windows.Forms.MaskedTextBox maskedAdvisorPhone;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Button btnUpdateAvailabilityInfo;
        private System.Windows.Forms.Button btnDeleteAvailabilityInfo;
        private System.Windows.Forms.Button btnEditAvailabilityInfo;
        private System.Windows.Forms.Button btnAddAvailabilityInfo;
        private System.Windows.Forms.TextBox txtStartHourAddMeetings;
        private System.Windows.Forms.ComboBox cboLocations;
        private System.Windows.Forms.Label lblMtAvailabilityID;
        private System.Windows.Forms.Label lblMeetingName;
        private System.Windows.Forms.TabControl tbEditAddMeetings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvwMeetings;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.TextBox txtStudentFName_Meetings;
        private System.Windows.Forms.TextBox txtStudentID_Meetings;
        private System.Windows.Forms.TextBox txtMeetingID;
        private System.Windows.Forms.Label lblMeetingAdvisor;
        private System.Windows.Forms.TextBox txtAdvisorFName_Meetings;
        private System.Windows.Forms.TextBox txtAvailabilityID_Meetings;
        private System.Windows.Forms.TextBox txtMeetingName;
        private System.Windows.Forms.Button btnDeleteMeetingInfo;
        private System.Windows.Forms.Button btnUpdateMeetingInfo;
        private System.Windows.Forms.Button btnEditMeetingInfo;
        private System.Windows.Forms.Label lblMeetingHours;
        private System.Windows.Forms.TextBox txtEndHour_Meetings;
        private System.Windows.Forms.TextBox txtStartHour_Meetings;
        private System.Windows.Forms.TextBox txtLocationType_Meetings;
        private System.Windows.Forms.TextBox txtAvailableDate_Meetings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAvailableDate;
        private System.Windows.Forms.Label lblMeetingDetails;
        private System.Windows.Forms.Label lblMeetingID;
        private System.Windows.Forms.Label lblStudentDetails;
        private System.Windows.Forms.Label lblAdvisorDetails;
        private System.Windows.Forms.ComboBox cboMeetingStudents;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblMtAddAvailableDate;
        private System.Windows.Forms.Button btnAddMeeting;
        private System.Windows.Forms.TextBox txtEndHourAddMeetings;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label lblAddMeetingName;
        private System.Windows.Forms.TextBox txtMeetingNameAdd;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ColumnHeader MeetingStartTime;
        private System.Windows.Forms.ColumnHeader MeetingDate;
        private System.Windows.Forms.ColumnHeader MeetingAdvisor;
        private System.Windows.Forms.ColumnHeader MeetingLocation;
        private System.Windows.Forms.TextBox txtAvailabilityID_MeetingsAdd;
        private System.Windows.Forms.TextBox txtStatusAdd;
        private System.Windows.Forms.Label lblAddMeetings;
        private System.Windows.Forms.Label lblAddStatus;
        private System.Windows.Forms.Label lblMtAddAvailabilityID;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.Label lblMtEndBlock;
        private System.Windows.Forms.Label lblMtStartBlock;
        private System.Windows.Forms.TabControl tabEditAddAvailability;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblAvailabilityDetails;
        private System.Windows.Forms.TextBox txtAvailabilityID;
        private System.Windows.Forms.ListView lvwAvailability;
        private System.Windows.Forms.ColumnHeader AvilAdvisor;
        private System.Windows.Forms.ColumnHeader AvailDate;
        private System.Windows.Forms.ColumnHeader Location;
        private System.Windows.Forms.ColumnHeader StartTime;
        private System.Windows.Forms.ColumnHeader EndTime;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox cboALocation;
        private System.Windows.Forms.Label lblAvailableTime;
        private System.Windows.Forms.DateTimePicker dtpAvailableDate;
        private System.Windows.Forms.Label lblAvLocation;
        private System.Windows.Forms.Label lblAvailableHours;
        private System.Windows.Forms.ComboBox cboAHourBlocks;
        private System.Windows.Forms.Label lblAddAvailability;
        private System.Windows.Forms.Label lblAddAvailableDate;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.Label lblSelectLocation;
        private System.Windows.Forms.Label lblAddAvailableTime;
        private System.Windows.Forms.ComboBox cboHourBlocks;
        private System.Windows.Forms.Label lblSelectAdvisor;
        private System.Windows.Forms.ComboBox cboMeetingAdvisors;
        private System.Windows.Forms.TextBox txtTimeDisplay;
        private System.Windows.Forms.TextBox txtSchedule;
        private System.Windows.Forms.Label lblLocationDetails;
        private System.Windows.Forms.ComboBox cboAvAdvisors;
        private System.Windows.Forms.ListView lvwAddMeetings;
        private System.Windows.Forms.ColumnHeader MeetingEndTime;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblDaysLeft;
        private System.Windows.Forms.TextBox txtLeftDays;
        private MaskedTextBox maskedEditAdvisorPhone;
        private PictureBox pctUSCBLogo;
        private TextBox txtMeetingAddress;
        private Label lblMeetingOffice;
    }
}

