using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace B321_Project
{
    public partial class frmB321 : Form
    {
        private Dictionary<int, clsStudent> dctStudents = new Dictionary<int, clsStudent>();
        private Dictionary<int, clsAdvisor> dctAdvisors = new Dictionary<int, clsAdvisor>();
        private Dictionary<int, clsLocation> dctLocations = new Dictionary<int, clsLocation>();
        private Dictionary<int, clsAvailability> dctAvailability = new Dictionary<int, clsAvailability>();
        private Dictionary<int, clsHourBlock> dctHourBlocks = new Dictionary<int, clsHourBlock>();
        private Dictionary<int, clsMeeting> dctMeetings = new Dictionary<int, clsMeeting>();
        public frmB321()
        {
            InitializeComponent();
        }

        private void frmB321_Load(object sender, EventArgs e)
        {
            #region

            fillComboBoxWithAdvisors();
            cboMeetingAdvisors.SelectedIndex = -1;
            cboAvAdvisors.SelectedIndex = -1;

            fillComboBoxWithStudents();
            cboMeetingStudents.SelectedIndex = -1;

            fillComboBoxWithLocations();
            cboLocations.SelectedIndex = -1;
            cboALocation.SelectedIndex = -1;

            fillComboBoxWithHourBlocks();
            cboAHourBlocks.SelectedIndex = -1;

            populateStudentDictionary(ref dctStudents);
            refreshStudentListview();
            studentInformation_Update_ClearTextboxes();

            populateAdvisorDictionary(ref dctAdvisors);
            refreshAdvisorListview();
            advisorInformation_Update_ClearTextboxes();

            populateLocationDictionary(ref dctLocations);
            refreshLocationListview();
            locationInformation_Update_ClearTextboxes();

            populateHourBlockDictionary(ref dctHourBlocks);
            refreshHourBlockListview();
            hourblockInformation_Update_ClearTextboxes();

            populateAvailabilityDictionary(ref dctAvailability);
            refreshAvailabilityListview();
            refreshAddMeetingsListView();

            availabilityInformation_Update_ClearTextboxes();

            populateMeetingDictionary(ref dctMeetings);
            refreshMeetingListview();
            meetingInformation_Update_ClearTextboxes();

            #endregion
        }



        private void populateStudentDictionary(ref Dictionary<int, clsStudent> dctStudents)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();

            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetStudents", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dctStudents.Clear();

                        while (rdr.Read() == true)
                        {
                            clsStudent currentStudent = new clsStudent();
                            currentStudent.StudentID = (int)rdr["StudentID"];
                            currentStudent.StudentFName = clsDBUtil.convertFromDBType_VarcharToString(rdr["StudentFName"]);
                            currentStudent.StudentMName = clsDBUtil.convertFromDBType_VarcharToString(rdr["StudentMName"]);
                            currentStudent.StudentLName = clsDBUtil.convertFromDBType_VarcharToString(rdr["StudentLName"]);
                            currentStudent.StudentEmail = clsDBUtil.convertFromDBType_VarcharToString(rdr["StudentEmail"]);
                            currentStudent.USCBID = clsDBUtil.convertFromDBType_VarcharToString(rdr["USCBID"]);

                            dctStudents.Add(currentStudent.StudentID, currentStudent);
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private void populateAdvisorDictionary(ref Dictionary<int, clsAdvisor> dctAdvisors)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();

            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetAdvisors", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dctAdvisors.Clear();

                        while (rdr.Read() == true)
                        {
                            clsAdvisor currentAdvisor = new clsAdvisor();
                            currentAdvisor.AdvisorID = (int)rdr["AdvisorID"];
                            currentAdvisor.AdvisorFName = clsDBUtil.convertFromDBType_VarcharToString(rdr["AdvisorFName"]);
                            currentAdvisor.AdvisorMName = clsDBUtil.convertFromDBType_VarcharToString(rdr["AdvisorMName"]);
                            currentAdvisor.AdvisorLName = clsDBUtil.convertFromDBType_VarcharToString(rdr["AdvisorLName"]);
                            currentAdvisor.AdvisorEmail = clsDBUtil.convertFromDBType_VarcharToString(rdr["AdvisorEmail"]);
                            currentAdvisor.OfficeAddress = clsDBUtil.convertFromDBType_VarcharToString(rdr["OfficeAddress"]);
                            currentAdvisor.PhoneNumber = clsDBUtil.convertFromDBType_VarcharToString(rdr["PhoneNumber"]);

                            dctAdvisors.Add(currentAdvisor.AdvisorID, currentAdvisor);
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private void populateLocationDictionary(ref Dictionary<int, clsLocation> dctLocations)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();

            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetLocations", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dctLocations.Clear();

                        while (rdr.Read() == true)
                        {
                            clsLocation currentLocation = new clsLocation();
                            currentLocation.LocationID = (int)rdr["LocationID"];
                            currentLocation.LocationType = clsDBUtil.convertFromDBType_VarcharToString(rdr["LocationType"]);

                            dctLocations.Add(currentLocation.LocationID, currentLocation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private void populateHourBlockDictionary(ref Dictionary<int, clsHourBlock> dctHourBlocks)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetHourBlocks", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dctHourBlocks.Clear();
                        while (rdr.Read() == true)
                        {
                            clsHourBlock currentHourBlock = new clsHourBlock();
                            currentHourBlock.HourBlockID = (int)rdr["HourBlockID"];
                            currentHourBlock.StartBlock = clsDBUtil.convertFromDBType_VarcharToString(rdr["StartBlock"]);
                            currentHourBlock.EndBlock = clsDBUtil.convertFromDBType_VarcharToString(rdr["EndBlock"]);
                            dctHourBlocks.Add(currentHourBlock.HourBlockID, currentHourBlock);
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private void populateAvailabilityDictionary(ref Dictionary<int, clsAvailability> dctAvailability)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetAvailability", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dctAvailability.Clear();
                        while (rdr.Read() == true)
                        {
                            clsAvailability currentAvailability = new clsAvailability();
                            currentAvailability.AvailabilityID = (int)rdr["AvailabilityID"];
                            currentAvailability.AdvisorID = (int)rdr["AdvisorID"];
                            currentAvailability.HourBlockID = (int)rdr["HourBlockID"];
                            currentAvailability.LocationID = (int)rdr["LocationID"];
                            currentAvailability.AvailableDate = DateTime.Parse(rdr["AvailableDate"].ToString());
                            dctAvailability.Add(currentAvailability.AvailabilityID, currentAvailability);
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private void populateMeetingDictionary(ref Dictionary<int, clsMeeting> dctMeetings)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetMeetings", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        dctMeetings.Clear();
                        while (rdr.Read() == true)
                        {
                            clsMeeting currentMeeting = new clsMeeting();
                            currentMeeting.MeetingID = (int)rdr["MeetingID"];
                            currentMeeting.StudentID = (int)rdr["StudentID"];
                            currentMeeting.AvailabilityID = (int)rdr["AvailabilityID"];
                            currentMeeting.MeetingName = clsDBUtil.convertFromDBType_VarcharToString(rdr["MeetingName"]);
                            currentMeeting.Status = clsDBUtil.convertFromDBType_VarcharToString(rdr["Status"]);
                            dctMeetings.Add(currentMeeting.MeetingID, currentMeeting);
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }




        /* UPDATE METHODS */
        private bool updateStudent(clsStudent currentStudent)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();

            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateStudents", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", currentStudent.StudentID);
                    cmd.Parameters.AddWithValue("@StudentFName", currentStudent.StudentFName);
                    cmd.Parameters.AddWithValue("@StudentMName", currentStudent.StudentMName);
                    cmd.Parameters.AddWithValue("@StudentLName", currentStudent.StudentLName);
                    cmd.Parameters.AddWithValue("@StudentEmail", currentStudent.StudentEmail);
                    cmd.Parameters.AddWithValue("@USCBID", currentStudent.USCBID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in updateStudents: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool updateAdvisor(clsAdvisor currentAdvisor)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();

            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateAdvisors", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdvisorID", currentAdvisor.AdvisorID);
                    cmd.Parameters.AddWithValue("@AdvisorFName", currentAdvisor.AdvisorFName);
                    cmd.Parameters.AddWithValue("@AdvisorMName", currentAdvisor.AdvisorMName);
                    cmd.Parameters.AddWithValue("@AdvisorLName", currentAdvisor.AdvisorLName);
                    cmd.Parameters.AddWithValue("@AdvisorEmail", currentAdvisor.AdvisorEmail);
                    cmd.Parameters.AddWithValue("@OfficeAddress", currentAdvisor.OfficeAddress);
                    cmd.Parameters.AddWithValue("@PhoneNumber", currentAdvisor.PhoneNumber);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in updateAdvisors: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool updateLocation(clsLocation currentLocation)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();

            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateLocations", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LocationID", currentLocation.LocationID);
                    cmd.Parameters.AddWithValue("@LocationType", currentLocation.LocationType);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in updateLocation: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool updateAvailability(clsAvailability currentAvailability)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateAvailability", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AvailabilityID", currentAvailability.AvailabilityID);
                    cmd.Parameters.AddWithValue("@AdvisorID", currentAvailability.AdvisorID);
                    cmd.Parameters.AddWithValue("@HourBlockID", currentAvailability.HourBlockID);
                    cmd.Parameters.AddWithValue("@LocationID", currentAvailability.LocationID);
                    cmd.Parameters.AddWithValue("@AvailableDate", currentAvailability.AvailableDate);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in updateAvailability: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool updateMeeting(clsMeeting currentMeeting)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateMeetings", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MeetingID", currentMeeting.MeetingID);
                    cmd.Parameters.AddWithValue("@StudentID", currentMeeting.StudentID);
                    cmd.Parameters.AddWithValue("@AvailabilityID", currentMeeting.AvailabilityID);
                    cmd.Parameters.AddWithValue("@MeetingName", currentMeeting.MeetingName);
                    cmd.Parameters.AddWithValue("@Status", currentMeeting.Status);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in updateMeetings: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }




        /* DELETE METHODS */
        private bool deleteStudent(int studentID)
        {
            #region
            try
            {
                string myConnectionString = clsDBUtil.getConnectionString();
                using (SqlConnection conn = new SqlConnection(myConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteStudents", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                messageBoxOK("Cannot delete the selected Student. Meetings currently depends on it. Please delete them first.");
                messageBoxOK("Error in deleteAdvisors: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                messageBoxOK("Error in deleteAdvisors: " + ex.Message);
                return false;
            }
            return true;
            #endregion
        }


        private bool deleteAdvisor(int advisorID)
        {
            #region
            try
            {
                string myConnectionString = clsDBUtil.getConnectionString();
                using (SqlConnection conn = new SqlConnection(myConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteAdvisors", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@advisorID", advisorID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                messageBoxOK("Cannot delete the selected Advisor. Meetings or Availability depends on it. Please delete them first.");
                messageBoxOK("Error in deleteAdvisors: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                messageBoxOK("Error in deleteAdvisors: " + ex.Message);
                return false;
            }
            return true;
            #endregion
        }


        private bool deleteLocation(int LocationID)
        {
            #region
            try
            {
                string myConnectionString = clsDBUtil.getConnectionString();
                using (SqlConnection conn = new SqlConnection(myConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteLocations", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LocationID", LocationID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                messageBoxOK("Cannot delete the selected Location. Meetings or Availability depends on it. Please delete them first.");
                messageBoxOK("Error in deleteLocations: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                messageBoxOK("Error in deleteLocations: " + ex.Message);
                return false;
            }
            return true;
            #endregion
        }


        private bool deleteAvailability(int AvailabilityID)
        {
            #region
            try
            {
                string myConnectionString = clsDBUtil.getConnectionString();
                using (SqlConnection conn = new SqlConnection(myConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteAvailability", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AvailabilityID", AvailabilityID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                messageBoxOK("Cannot delete the selected Availability. Meetings depends on it. Please delete them first.");
                messageBoxOK("Error in deleteAvailability: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                messageBoxOK("Error in deleteAvailability: " + ex.Message);
                return false;
            }
            return true;
            #endregion
        }


        private bool deleteMeeting(int MeetingID)
        {
            #region
            try
            {
                string myConnectionString = clsDBUtil.getConnectionString();
                using (SqlConnection conn = new SqlConnection(myConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteMeetings", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MeetingID", MeetingID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                messageBoxOK("Error in deleteMeetings: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                messageBoxOK("Error in deleteMeetings: " + ex.Message);
                return false;
            }
            return true;
            #endregion
        }




        /* INSERT METHODS */
        private bool insertStudent(clsStudent currentStudent)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertStudents", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentFName", currentStudent.StudentFName);
                    cmd.Parameters.AddWithValue("@StudentMName", currentStudent.StudentMName);
                    cmd.Parameters.AddWithValue("@StudentLName", currentStudent.StudentLName);
                    cmd.Parameters.AddWithValue("@StudentEmail", currentStudent.StudentEmail);
                    cmd.Parameters.AddWithValue("@USCBID", currentStudent.USCBID);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in addStudents: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool insertAdvisor(clsAdvisor currentAdvisor)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertAdvisors", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdvisorFName", currentAdvisor.AdvisorFName);
                    cmd.Parameters.AddWithValue("@AdvisorMName", currentAdvisor.AdvisorMName);
                    cmd.Parameters.AddWithValue("@AdvisorLName", currentAdvisor.AdvisorLName);
                    cmd.Parameters.AddWithValue("@AdvisorEmail", currentAdvisor.AdvisorEmail);
                    cmd.Parameters.AddWithValue("@OfficeAddress", currentAdvisor.OfficeAddress);
                    cmd.Parameters.AddWithValue("@PhoneNumber", currentAdvisor.PhoneNumber);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in addAdvisors: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool insertLocation(clsLocation currentLocation)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertLocations", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LocationType", currentLocation.LocationType);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in addLocations: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool insertMeeting(clsMeeting clsMeeting)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();


                    SqlCommand cmd = new SqlCommand("sp_InsertMeetings", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StudentID", clsMeeting.StudentID);
                    cmd.Parameters.AddWithValue("@AvailabilityID", clsMeeting.AvailabilityID);
                    cmd.Parameters.AddWithValue("@MeetingName", clsMeeting.MeetingName);
                    cmd.Parameters.AddWithValue("@Status", clsMeeting.Status);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in addMeetings: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }


        private bool insertAvailability(clsAvailability currentAvailability)
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_InsertAvailability", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdvisorID", currentAvailability.AdvisorID);
                    cmd.Parameters.AddWithValue("@HourBlockID", currentAvailability.HourBlockID);
                    cmd.Parameters.AddWithValue("@LocationID", currentAvailability.LocationID);
                    cmd.Parameters.AddWithValue("@AvailableDate", currentAvailability.AvailableDate);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    messageBoxOK("Error in addAvailability: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
            #endregion
        }




        /* DATA REFRESH METHODS */
        private void refreshStudentListview()
        {
            #region
            lvwStudents.Items.Clear();

            foreach (KeyValuePair<int, clsStudent> kvp in dctStudents)
            {
                clsStudent currentStudent = kvp.Value;
                ListViewItem item = new ListViewItem(currentStudent.StudentFName);
                item.SubItems.Add(currentStudent.StudentMName);
                item.SubItems.Add(currentStudent.StudentLName);
                item.Tag = currentStudent;
                lvwStudents.Items.Add(item);
            }
            #endregion
        }


        private void refreshAdvisorListview()
        {
            #region
            lvwAdvisors.Items.Clear();

            foreach (KeyValuePair<int, clsAdvisor> kvp in dctAdvisors)
            {
                clsAdvisor currentAdvisor = kvp.Value;
                ListViewItem item = new ListViewItem(currentAdvisor.AdvisorFName);
                item.SubItems.Add(currentAdvisor.AdvisorMName);
                item.SubItems.Add(currentAdvisor.AdvisorLName);
                item.Tag = currentAdvisor;
                lvwAdvisors.Items.Add(item);
            }
            #endregion
        }



        private void refreshLocationListview()
        {
            #region
            lvwLocations.Items.Clear();

            foreach (KeyValuePair<int, clsLocation> kvp in dctLocations)
            {
                clsLocation currentLocation = kvp.Value;
                ListViewItem item = new ListViewItem(currentLocation.LocationType);
                item.Tag = currentLocation;
                lvwLocations.Items.Add(item);
            }
            #endregion
        }


        private void refreshAvailabilityListview()
        {
            #region
            lvwAvailability.Items.Clear();

            foreach (var currentAvailability in dctAvailability.Values)
            {
                string advisorName = dctAdvisors.ContainsKey(currentAvailability.AdvisorID)
                    ? $"{dctAdvisors[currentAvailability.AdvisorID].AdvisorFName}, {dctAdvisors[currentAvailability.AdvisorID].AdvisorLName}"
                    : "Unknown Advisor";

                string locationType = dctLocations.ContainsKey(currentAvailability.LocationID)
                    ? dctLocations[currentAvailability.LocationID].LocationType
                    : "Unknown Location";


                if (dctAvailability.TryGetValue(currentAvailability.AvailabilityID, out clsAvailability availability))
                {
                    string startBlock = dctHourBlocks.TryGetValue(currentAvailability.HourBlockID, out clsHourBlock hourBlock)
                        ? hourBlock.StartBlock
                        : "Unknown StartBlock";

                    string endBlock = hourBlock != null
                        ? dctHourBlocks[availability.HourBlockID].EndBlock
                        : "Unknown EndBlock";


                    ListViewItem item = new ListViewItem(currentAvailability.AvailableDate.ToString("yyyy-MM-dd"));
                    item.SubItems.Add(advisorName);
                    item.SubItems.Add(locationType);
                    item.SubItems.Add(startBlock);
                    item.SubItems.Add(endBlock);
                    item.Tag = currentAvailability;
                    lvwAvailability.Items.Add(item);
                }
            }
            #endregion
        }


        private void refreshAddMeetingsListView()
        {
            #region
            lvwAddMeetings.Items.Clear();

            foreach (var currentMeeting in dctAvailability.Values)
            {

                if (dctAvailability.TryGetValue(currentMeeting.AvailabilityID, out clsAvailability availability))
                {

                    string startBlock = dctHourBlocks.TryGetValue(availability.HourBlockID, out clsHourBlock hourBlock)
                        ? hourBlock.StartBlock
                        : "Unknown StartBlock";

                    string endBlock = hourBlock != null
                        ? dctHourBlocks[availability.HourBlockID].EndBlock
                        : "Unknown EndBlock";

                    string locationType = dctLocations.TryGetValue(availability.LocationID, out clsLocation location)
                        ? location.LocationType
                        : "Unknown Location";

                    string advisorName = dctAdvisors.TryGetValue(availability.AdvisorID, out clsAdvisor advisor)
                        ? $"{dctAdvisors[currentMeeting.AdvisorID].AdvisorFName}, {dctAdvisors[currentMeeting.AdvisorID].AdvisorLName}"
                        : "Unknown Advisor";

                    ListViewItem item = new ListViewItem(currentMeeting.AvailableDate.ToString("yyyy-MM-dd")); // Convert DateTime to string
                    item.SubItems.Add(advisorName);
                    item.SubItems.Add(locationType);
                    item.SubItems.Add(startBlock);
                    item.SubItems.Add(endBlock);
                    item.Tag = currentMeeting;
                    lvwAddMeetings.Items.Add(item);
                }
            }
            #endregion
        }


        private void refreshMeetingListview()
        {
            #region
            lvwMeetings.Items.Clear();

            foreach (var currentMeeting in dctMeetings.Values)
            {

                string studentName = dctStudents.ContainsKey(currentMeeting.StudentID)
                    ? dctStudents[currentMeeting.StudentID].StudentFName
                    : "Unknown Student";

                if (dctAvailability.TryGetValue(currentMeeting.AvailabilityID, out clsAvailability availability))
                {
                    string availabilityDate = availability.AvailableDate.ToString("yyyy-MM-dd");

                    string startBlock = dctHourBlocks.TryGetValue(availability.HourBlockID, out clsHourBlock hourBlock)
                        ? hourBlock.StartBlock
                        : "Unknown StartBlock";

                    string endBlock = hourBlock != null
                        ? hourBlock.EndBlock
                        : "Unknown EndBlock";

                    string locationType = dctLocations.TryGetValue(availability.LocationID, out clsLocation location)
                        ? location.LocationType
                        : "Unknown Location";

                    string advisorName = dctAdvisors.TryGetValue(availability.AdvisorID, out clsAdvisor advisor)
                        ? advisor.AdvisorFName
                        : "Unknown Advisor";

                    ListViewItem item = new ListViewItem(currentMeeting.MeetingName);
                    item.SubItems.Add(studentName);
                    item.SubItems.Add(availabilityDate);
                    item.SubItems.Add(locationType);
                    item.SubItems.Add(advisorName);
                    item.SubItems.Add(startBlock);
                    item.SubItems.Add(endBlock);
                    item.SubItems.Add(currentMeeting.Status);
                    item.Tag = currentMeeting;
                    lvwMeetings.Items.Add(item);
                }
                else
                {
                    messageBoxOK($"Warning: MeetingID={currentMeeting.MeetingID} references an unknown AvailabilityID={currentMeeting.AvailabilityID}");

                }
            }
            #endregion
        }


        private void refreshHourBlockListview()
        {
            #region
            foreach (KeyValuePair<int, clsHourBlock> kvp in dctHourBlocks)
            {
                clsHourBlock currentHourBlock = kvp.Value;
                ListViewItem item = new ListViewItem(currentHourBlock.StartBlock);
                item.SubItems.Add(currentHourBlock.EndBlock);
                item.Tag = currentHourBlock;
            }
            #endregion
        }




        /* LIST VIEWS METHODS */
        private void lvwStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region

            if (lvwStudents.SelectedItems.Count == 0)
            {

                return;
            }

            ListViewItem selectedItem = lvwStudents.SelectedItems[0];
            if (selectedItem.Tag is clsStudent currentStudent)
            {

                displayStudentInformation_update(currentStudent);
            }
            #endregion
        }


        private void lvwAdvisors_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region

            if (lvwAdvisors.SelectedItems.Count == 0)
            {

                return;
            }

            ListViewItem selectedItem = lvwAdvisors.SelectedItems[0];
            if (selectedItem.Tag is clsAdvisor currentAdvisor)
            {

                displayAdvisorInformation_update(currentAdvisor);
            }
            #endregion
        }


        private void lvwAvailability_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region

            if (lvwAvailability.SelectedItems.Count == 0)
            {
                txtLeftDays.Text = string.Empty;
                return;
            }


            ListViewItem selectedItem = lvwAvailability.SelectedItems[0];
            if (selectedItem.Tag is clsAvailability currentAvailability)
            {

                displayAvailabilityInformation_update(currentAvailability);
                try
                {
                    string myConnectionString = clsDBUtil.getConnectionString();
                    using (SqlConnection conn = new SqlConnection(myConnectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("sp_GetAvailabilityWithDaysLeft", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@AvailabilityID", currentAvailability.AvailabilityID);


                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                txtLeftDays.Text = result.ToString();
                            }
                            else
                            {
                                txtLeftDays.Text = "N/A";
                            }
                        }
                    }
                }

                catch (Exception)
                {
                    txtLeftDays.Text = "Error";
                }

                if (dctAdvisors.TryGetValue(currentAvailability.AdvisorID, out clsAdvisor advisor))
                {
                    cboAvAdvisors.Text = $"{advisor.AdvisorFName}, {advisor.AdvisorLName}";
                }
                else
                {
                    cboAvAdvisors.SelectedIndex = -1; // Clear selection if advisor not found
                }

                if (dctHourBlocks.TryGetValue(currentAvailability.HourBlockID, out clsHourBlock hourBlock))
                {
                    cboAHourBlocks.SelectedValue = hourBlock.HourBlockID;
                }
                else
                {
                    cboAHourBlocks.SelectedIndex = -1;
                }
            }
            #endregion
        }


        private void lvwMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region

            if (lvwMeetings.SelectedItems.Count == 0)
            {

                return;
            }

            ListViewItem selectedItem = lvwMeetings.SelectedItems[0];
            if (selectedItem.Tag is clsMeeting currentMeeting)
            {
                displayMeetingInformation_update(currentMeeting);
            }
            else
            {
                messageBoxOK("Selected item is not a clsMeeting object.");
            }
            #endregion
        }


        private void lvwAddMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region

            if (lvwAddMeetings.SelectedItems.Count == 0)
            {

                return;
            }

            ListViewItem selectedItem = lvwAddMeetings.SelectedItems[0];
            if (selectedItem.Tag is clsAvailability addMeeting)
            {
                displayAddMeetingInformation_update(addMeeting);
            }
            #endregion
        }




        /* DISPLAY METHODS */
        private void displayStudentInformation_update(clsStudent currentStudent)
        {
            #region
            txtStudentID.Text = currentStudent.StudentID.ToString();
            txtStudentFName.Text = currentStudent.StudentFName;
            txtStudentMName.Text = currentStudent.StudentMName;
            txtStudentLName.Text = currentStudent.StudentLName;
            txtStudentEmail.Text = currentStudent.StudentEmail;
            txtUSCBID.Text = currentStudent.USCBID;
            #endregion
        }


        private void displayAdvisorInformation_update(clsAdvisor currentAdvisor)
        {
            #region
            txtAdvisorID.Text = currentAdvisor.AdvisorID.ToString();
            txtAdvisorFName.Text = currentAdvisor.AdvisorFName;
            txtAdvisorMName.Text = currentAdvisor.AdvisorMName;
            txtAdvisorLName.Text = currentAdvisor.AdvisorLName;
            txtAdvisorEmail.Text = currentAdvisor.AdvisorEmail;
            txtAdvisorOfficeAddress.Text = currentAdvisor.OfficeAddress;
            maskedEditAdvisorPhone.Text = currentAdvisor.PhoneNumber;
            #endregion
        }


        private void displayLocationInformation_update(clsLocation currentLocation)
        {
            #region
            txtLocationID.Text = currentLocation.LocationID.ToString();
            txtLocationType.Text = currentLocation.LocationType;
            #endregion
        }


        private void displayAddMeetingInformation_update(clsAvailability addMeeting)
        {
            #region
            txtAvailabilityID_MeetingsAdd.Text = addMeeting.AvailabilityID.ToString();
            txtAvailableDate.Text = addMeeting.AvailableDate.ToString("yyyy-MM-dd");

            if (dctAvailability.TryGetValue(addMeeting.AvailabilityID, out clsAvailability availability2))
            {
                txtStartHourAddMeetings.Text = dctHourBlocks.TryGetValue(availability2.HourBlockID, out clsHourBlock hourBlock)
                    ? hourBlock.StartBlock
                    : "Unknown StartBlock";

                txtEndHourAddMeetings.Text = hourBlock != null
                    ? dctHourBlocks[availability2.HourBlockID].EndBlock
                    : "Unknown EndBlock";
            }
            #endregion
        }


        private void displayAvailabilityInformation_update(clsAvailability currentAvailability)
        {
            #region
            txtAvailabilityID.Text = currentAvailability.AvailabilityID.ToString();
            txtSchedule.Text = currentAvailability.AvailableDate.ToString("yyyy-MM-dd");

            if (dctAvailability.TryGetValue(currentAvailability.AvailabilityID, out clsAvailability availability))
            {
                cboAvAdvisors.Text = dctAdvisors.TryGetValue(availability.AdvisorID, out clsAdvisor advisor2)
                    ? advisor2.AdvisorFName
                    : "Unknown Advisor";

                cboALocation.Text = dctLocations.TryGetValue(availability.LocationID, out clsLocation location)
                    ? location.LocationType
                    : "Unknown Location";

                cboAHourBlocks.Text = dctHourBlocks.TryGetValue(availability.HourBlockID, out clsHourBlock hourBlock)
                    ? $"{hourBlock.StartBlock} - {hourBlock.EndBlock}"
                    : "Unknown HourBlock";
            }
            #endregion
        }


        private void displayMeetingInformation_update(clsMeeting currentMeeting)
        {
            #region

            txtMeetingID.Text = currentMeeting.MeetingID.ToString();
            txtStudentID_Meetings.Text = currentMeeting.StudentID.ToString();
            txtMeetingName.Text = currentMeeting.MeetingName;
            cboStatus.Text = currentMeeting.Status;
            txtAvailabilityID_Meetings.Text = currentMeeting.AvailabilityID.ToString();

            txtStudentFName_Meetings.Text = dctStudents.TryGetValue(currentMeeting.StudentID, out clsStudent student)
                ? $"{student.StudentFName}, {student.StudentLName}"
                : "Unknown Student";

            if (dctAvailability.TryGetValue(currentMeeting.AvailabilityID, out clsAvailability availability))
            {
                txtStartHour_Meetings.Text = dctHourBlocks.TryGetValue(availability.HourBlockID, out clsHourBlock hourBlock)
                    ? hourBlock.StartBlock
                    : "Unknown StartBlock";

                txtEndHour_Meetings.Text = hourBlock != null
                    ? dctHourBlocks[availability.HourBlockID].EndBlock
                    : "Unknown EndBlock";

                txtAdvisorFName_Meetings.Text = dctAdvisors.TryGetValue(availability.AdvisorID, out clsAdvisor advisor)
                    ? $"{advisor.AdvisorFName}, {advisor.AdvisorLName}"
                    : "Unknown Advisor";

                txtLocationType_Meetings.Text = dctLocations.TryGetValue(availability.LocationID, out clsLocation location)
                    ? location.LocationType
                    : "Unknown Location";

                if (txtLocationType_Meetings.Text.Equals("Office Address", StringComparison.OrdinalIgnoreCase))
                {
                    txtMeetingAddress.Text = dctAdvisors.TryGetValue(availability.AdvisorID, out clsAdvisor advisor2)
                        ? advisor2.OfficeAddress
                        : "Unknown Address";
                }
                else
                {
                    txtMeetingAddress.Text = "N/A";
                }

                txtAvailableDate_Meetings.Text = availability.AvailableDate.ToString("yyyy-MM-dd");
            }
            #endregion
        }




        /* CLEAR TEXTBOXES METHODS */
        private void studentInformation_Update_ClearTextboxes()
        {
            #region
            txtStudentID.Clear();
            txtStudentID.ReadOnly = true;
            txtStudentID.Enabled = false;

            txtStudentFName.Clear();
            txtStudentFName.ReadOnly = true;
            txtStudentFName.Enabled = false;

            txtStudentMName.Clear();
            txtStudentMName.ReadOnly = true;
            txtStudentMName.Enabled = false;

            txtStudentLName.Clear();
            txtStudentLName.ReadOnly = true;
            txtStudentLName.Enabled = false;

            txtStudentEmail.Clear();
            txtStudentEmail.ReadOnly = true;
            txtStudentEmail.Enabled = false;

            txtUSCBID.Clear();
            txtUSCBID.ReadOnly = true;
            txtUSCBID.Enabled = false;
            #endregion
        }


        private void advisorInformation_Update_ClearTextboxes()
        {
            #region
            txtAdvisorID.Clear();
            txtAdvisorID.ReadOnly = true;
            txtAdvisorID.Enabled = false;

            txtAdvisorFName.Clear();
            txtAdvisorFName.ReadOnly = true;
            txtAdvisorFName.Enabled = false;

            txtAdvisorMName.Clear();
            txtAdvisorMName.ReadOnly = true;
            txtAdvisorMName.Enabled = false;

            txtAdvisorLName.Clear();
            txtAdvisorLName.ReadOnly = true;
            txtAdvisorLName.Enabled = false;

            txtAdvisorEmail.Clear();
            txtAdvisorEmail.ReadOnly = true;
            txtAdvisorEmail.Enabled = false;

            txtAdvisorOfficeAddress.Clear();
            txtAdvisorOfficeAddress.ReadOnly = true;
            txtAdvisorOfficeAddress.Enabled = false;

            txtAdvisorOfficeAddress.Clear();
            txtAdvisorOfficeAddress.ReadOnly = true;
            txtAdvisorOfficeAddress.Enabled = false;

            maskedEditAdvisorPhone.Clear();
            maskedEditAdvisorPhone.ReadOnly = true;
            maskedEditAdvisorPhone.Enabled = false;
            #endregion
        }


        private void locationInformation_Update_ClearTextboxes()
        {
            #region
            txtLocationID.Clear();
            txtLocationID.ReadOnly = true;
            txtLocationID.Enabled = false;

            txtLocationType.Clear();
            txtLocationType.ReadOnly = true;
            txtLocationType.Enabled = false;
            #endregion
        }


        private void availabilityInformation_Update_ClearTextboxes()
        {
            #region
            txtAvailabilityID.Clear();
            txtAvailabilityID.ReadOnly = false;
            txtAvailabilityID.Enabled = false;

            cboAHourBlocks.Enabled = false;
            cboALocation.Enabled = false;
            cboAvAdvisors.Enabled = false;
            dtpAvailableDate.Enabled = false;

            txtSchedule.Clear();
            txtSchedule.ReadOnly = false;
            txtSchedule.Enabled = false;

            txtAvailableDate.Clear();
            txtAvailableDate.ReadOnly = true;
            #endregion
        }


        private void hourblockInformation_Update_ClearTextboxes()
        {
            /* insert something here */
        }


        private void meetingInformation_Update_ClearTextboxes()
        {
            #region
            txtMeetingID.Clear();
            txtMeetingID.ReadOnly = true;
            txtMeetingID.Enabled = false;

            txtLocationType_Meetings.Clear();
            txtLocationType_Meetings.ReadOnly = true;
            txtLocationType_Meetings.Enabled = false;

            txtStudentID_Meetings.Clear();
            txtStudentID_Meetings.ReadOnly = true;
            txtStudentID_Meetings.Enabled = false;

            txtStudentFName_Meetings.Clear();
            txtStudentFName_Meetings.ReadOnly = true;
            txtStudentFName_Meetings.Enabled = false;

            txtMeetingName.Clear();
            txtMeetingName.ReadOnly = true;
            txtMeetingName.Enabled = false;

            txtAvailabilityID_Meetings.Clear();
            txtAvailabilityID_Meetings.ReadOnly = false;
            txtAvailabilityID_Meetings.Enabled = false;

            txtAvailableDate_Meetings.Clear();
            txtAvailableDate_Meetings.ReadOnly = false;
            txtAvailableDate_Meetings.Enabled = false;

            txtAdvisorFName_Meetings.Clear();
            txtAdvisorFName_Meetings.ReadOnly = true;
            txtAdvisorFName_Meetings.Enabled = false;

            txtStartHour_Meetings.Clear();
            txtStartHour_Meetings.ReadOnly = true;
            txtStartHour_Meetings.Enabled = false;

            txtEndHour_Meetings.Clear();
            txtEndHour_Meetings.ReadOnly = true;
            txtEndHour_Meetings.Enabled = false;

            txtMeetingName.Clear();
            txtMeetingName.ReadOnly = true;
            txtMeetingName.Enabled = false;

            cboStatus.Enabled = false;
            #endregion
        }


        #region Private Helper Methods: general purpose
        private void messageBoxOK(string msg)
        {
            MessageBox.Show(msg, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private DialogResult messageBoxYesNo(string msg)
        {
            return MessageBox.Show(msg, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion




        /*UPDATE BUTTON METHODS*/
        private void btnUpdateStudentInfo_Click(object sender, EventArgs e)
        {
            #region
            clsStudent currentStudent = new clsStudent();

            if (int.TryParse(txtStudentID.Text, out int StudentID))
            {
                currentStudent.StudentID = StudentID;
            }
            else
            {
                messageBoxOK("Invalid Student ID");
                txtStudentID.Focus();
                return;
            }

            currentStudent.StudentFName = txtStudentFName.Text;
            currentStudent.StudentMName = txtStudentMName.Text;
            currentStudent.StudentLName = txtStudentLName.Text;
            currentStudent.StudentEmail = txtStudentEmail.Text;
            currentStudent.USCBID = txtUSCBID.Text;

            if (string.IsNullOrEmpty(currentStudent.StudentFName) ||
                string.IsNullOrEmpty(currentStudent.StudentLName) || 
                string.IsNullOrEmpty(currentStudent.StudentEmail) ||
                string.IsNullOrEmpty(currentStudent.USCBID))
            {
                messageBoxOK("Please fill in all fields.");
                txtStudentFName.Focus();
                return;
            }
            

            if (txtStudentEmail.Text == "")
            {
                currentStudent.StudentEmail = "";
            }
            else if (txtStudentEmail.Text.Contains("@"))
            {
                currentStudent.StudentEmail = txtStudentEmail.Text;
            }
            else
            {
                messageBoxOK("Invalid email address");
                txtStudentEmail.Focus();
                return;
            }

            if (updateStudent(currentStudent) == true)
            {
                populateStudentDictionary(ref dctStudents);
                messageBoxOK("The student (ID: " + currentStudent.StudentID.ToString() + ") has been updated.");
            }
            else
            {
                messageBoxOK("Failed to update the student (ID: " + currentStudent.StudentID.ToString() + ").");
            }

            refreshStudentListview();
            refreshMeetingListview();
            fillComboBoxWithStudents();
    
            btnEditStudentInfo.Visible = true;
            btnUpdateStudentInfo.Visible = false;
            btnDeleteStudentInfo.Visible = false;

            txtStudentFName.Enabled = false;
            txtStudentMName.Enabled = false;
            txtStudentLName.Enabled = false;
            txtStudentEmail.Enabled = false;
            txtUSCBID.Enabled = false;

            #endregion
        }


        private void btnUpdateAdvisorInfo_Click(object sender, EventArgs e)
        {
            #region
            clsAdvisor currentAdvisor = new clsAdvisor();

            if (int.TryParse(txtAdvisorID.Text, out int AdvisorID))
            {
                currentAdvisor.AdvisorID = AdvisorID;
            }
            else
            {
                messageBoxOK("Invalid Advisor ID");
                txtAdvisorID.Focus();
                return;
            }

            currentAdvisor.AdvisorFName = txtAdvisorFName.Text;
            currentAdvisor.AdvisorMName = txtAdvisorMName.Text;
            currentAdvisor.AdvisorLName = txtAdvisorLName.Text;
            currentAdvisor.AdvisorEmail = txtAdvisorEmail.Text;
            currentAdvisor.OfficeAddress = txtAdvisorOfficeAddress.Text;
            currentAdvisor.PhoneNumber = maskedEditAdvisorPhone.Text;

            if (string.IsNullOrEmpty(currentAdvisor.AdvisorFName) ||
                string.IsNullOrEmpty(currentAdvisor.AdvisorLName) ||
                string.IsNullOrEmpty(currentAdvisor.AdvisorEmail) ||
                string.IsNullOrEmpty(currentAdvisor.OfficeAddress) ||
                string.IsNullOrEmpty(currentAdvisor.PhoneNumber))
            {
                messageBoxOK("Please fill in all fields.");
                return;
            }

            string phoneNumber = maskedEditAdvisorPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length < 10)
            {
                messageBoxOK("Invalid Phone Number.");
                maskedEditAdvisorPhone.Focus();
                return;
            }
            currentAdvisor.PhoneNumber = maskedEditAdvisorPhone.Text;


            if (txtAdvisorEmail.Text == "")
            {
                currentAdvisor.AdvisorEmail = "";
            }
            else if (txtAdvisorEmail.Text.Contains("@"))
            {
                currentAdvisor.AdvisorEmail = txtAdvisorEmail.Text;
            }
            else
            {
                messageBoxOK("Invalid email address");
                txtAdvisorEmail.Focus();
                return;
            }

            if (updateAdvisor(currentAdvisor) == true)
            {
                populateAdvisorDictionary(ref dctAdvisors);
                refreshAdvisorListview();
                fillComboBoxWithAdvisors();

                messageBoxOK("The Advisor (ID: " + currentAdvisor.AdvisorID.ToString() + ") has been updated.");
            }
            else
            {
                messageBoxOK("Failed to update the student (ID: " + currentAdvisor.AdvisorID.ToString() + ").");
            }

            refreshAdvisorListview();

            cboMeetingAdvisors.SelectedIndex = -1;
            cboAvAdvisors.SelectedIndex = -1;

            txtAdvisorID.Enabled = false;
            txtAdvisorFName.Enabled = false;
            txtAdvisorMName.Enabled = false;
            txtAdvisorLName.Enabled = false;
            txtAdvisorEmail.Enabled = false;
            txtAdvisorOfficeAddress.Enabled = false;
            txtAdvisorOfficeAddress.Enabled = false;
            maskedEditAdvisorPhone.Enabled = false;

            btnEditAdvisorInfo.Visible = true;
            btnUpdateAdvisorInfo.Visible = false;
            btnDeleteAdvisorInfo.Visible = false;

            #endregion
        }


        private void btnUpdateLocationInfo_Click(object sender, EventArgs e)
        {
            #region

            clsLocation currentLocation = new clsLocation();

            if (int.TryParse(txtLocationID.Text, out int LocationID))
            {
                currentLocation.LocationID = LocationID;
            }
            else
            {
                messageBoxOK("Invalid Location ID");
                txtLocationID.Focus();
                return;
            }

            currentLocation.LocationType = txtLocationType.Text;

            if (string.IsNullOrEmpty(currentLocation.LocationType))
            {
                messageBoxOK("Location cannot be empty.");
                txtLocationType.Focus();
                return;
            }

            if (updateLocation(currentLocation) == true)
            {
                populateLocationDictionary(ref dctLocations);
                refreshLocationListview();
                fillComboBoxWithLocations();

                messageBoxOK("The Location (ID: " + currentLocation.LocationID.ToString() + ") has been updated.");
            }
            else
            {
                messageBoxOK("Failed to update the location (ID: " + currentLocation.LocationID.ToString() + ").");
            }

            refreshLocationListview();

            txtLocationType.Enabled = false;

            btnEditLocationInfo.Visible = true;
            btnUpdateLocationInfo.Visible = false;
            btnDeleteLocationInfo.Visible = false;
            #endregion
        }


        private void btnUpdateAvailabilityInfo_Click(object sender, EventArgs e)
        {
            #region   
            clsAvailability currentAvailability = new clsAvailability();

            if (int.TryParse(txtAvailabilityID.Text, out int AvailabilityID))
            {
                currentAvailability.AvailabilityID = AvailabilityID;
            }
            else
            {
                messageBoxOK("Invalid Availability ID");
                txtAvailabilityID.Focus();
                return;
            }

            if (cboAHourBlocks.SelectedValue != null && int.TryParse(cboAHourBlocks.SelectedValue.ToString(), out int selectHourBlockID))
            {
                currentAvailability.HourBlockID = selectHourBlockID;
            }
            else
            {
                messageBoxOK("Please select an HourBlock.");
                return;
            }

            if (cboALocation.SelectedValue != null && int.TryParse(cboALocation.SelectedValue.ToString(), out int selectLocationID))
            {
                currentAvailability.LocationID = selectLocationID;
            }
            else
            {
                messageBoxOK("Please select a Location.");
                return;
            }

            if (cboAvAdvisors.SelectedValue != null && int.TryParse(cboAvAdvisors.SelectedValue.ToString(), out int selectAdvisorID))
            {
                currentAvailability.AdvisorID = selectAdvisorID;
            }
            else
            {
                messageBoxOK("Please select an Advisor.");
                return;
            }

            if (DateTime.TryParse(txtSchedule.Text, out DateTime availableDate))
            {
                currentAvailability.AvailableDate = availableDate;
            }
            else
            {
                messageBoxOK("Invalid date format. Please enter a valid date.");
                txtSchedule.Focus();
                return;
            }
            
            try
            {
                if (updateAvailability(currentAvailability) == true)
                {
                    populateAvailabilityDictionary(ref dctAvailability);
                    refreshAvailabilityListview();
                    refreshAddMeetingsListView();
                    messageBoxOK("The availability (ID: " + currentAvailability.AvailabilityID.ToString() + ") has been updated.");
                }
                else
                {
                    messageBoxOK("Failed to update the availability (ID: " + currentAvailability.AvailabilityID.ToString() + ").");
                }
              
            }
            catch (Exception)
            {
                messageBoxOK("An unexpected error occured while updating the availability.");
            }

            fillComboBoxWithAdvisors();
            fillComboBoxWithHourBlocks();
            fillComboBoxWithLocations();

            cboAvAdvisors.SelectedIndex = -1;
            cboAHourBlocks.SelectedIndex = -1;
            cboALocation.SelectedIndex = -1;

            txtLeftDays.Text = string.Empty;

            refreshAvailabilityListview();
            btnEditAvailabilityInfo.Visible = true;
            btnUpdateAvailabilityInfo.Visible = false;
            btnDeleteAvailabilityInfo.Visible = false;

            txtAvailabilityID.Clear();
            txtAvailabilityID.ReadOnly = false;
            txtAvailabilityID.Enabled = false;

            cboAHourBlocks.Enabled = false;
            cboALocation.Enabled = false;
            cboAvAdvisors.Enabled = false;
            dtpAvailableDate.Enabled = false;

            txtSchedule.Clear();
            txtSchedule.ReadOnly = false;
            txtSchedule.Enabled = false;
            #endregion
        }


        private void btnUpdateMeetingInfo_Click(object sender, EventArgs e)
        {
            #region
            clsMeeting currentMeeting = new clsMeeting();

            if (int.TryParse(txtMeetingID.Text, out int MeetingID))
            {
                currentMeeting.MeetingID = MeetingID;
            }
            else
            {
                messageBoxOK("Invalid Meeting ID");
                txtMeetingID.Focus();
                return;
            }

            string studentIDText = txtStudentID_Meetings.Text.Trim();
            if (int.TryParse(studentIDText, out int StudentID))
            {
                currentMeeting.StudentID = StudentID;
            }
            else
            {
                messageBoxOK("Invalid Student ID");
                txtStudentID_Meetings.Focus();
                return;
            }

            if (int.TryParse(txtAvailabilityID_Meetings.Text, out int AvailabilityID))
            {
                currentMeeting.AvailabilityID = AvailabilityID;
            }
            else
            {
                messageBoxOK("Invalid Availability ID");
                txtAvailabilityID_Meetings.Focus();
                return;
            }

            currentMeeting.MeetingName = txtMeetingName.Text;

            if (string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                MessageBox.Show("Status cannot be empty."); 
                cboStatus.Focus(); 
                return;
            }
            else
            {
                currentMeeting.Status = cboStatus.Text; 
            }

            if (updateMeeting(currentMeeting))
            {
                populateMeetingDictionary(ref dctMeetings);
                refreshMeetingListview();

                messageBoxOK("The Meeting (ID: " + currentMeeting.MeetingID.ToString() + ") has been updated.");
            }
            else
            {
                messageBoxOK("Failed to update the meeting (ID: " + currentMeeting.MeetingID.ToString() + ").");
            }

            refreshMeetingListview();

            txtMeetingName.Enabled = false;
            cboStatus.Enabled = false;

            btnEditMeetingInfo.Visible = true;
            btnUpdateMeetingInfo.Visible = false;
            btnDeleteMeetingInfo.Visible = false;

            #endregion
        }




        /*EDIT BUTTON METHODS*/
        private void btnEditStudentInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtStudentID.Text == "")
            {
                messageBoxOK("Select a Student to Edit.");
                return;
            }

            txtUSCBID.ReadOnly = true;
            txtStudentID.ReadOnly = true;

            txtStudentFName.ReadOnly = false;
            txtStudentMName.ReadOnly = false;
            txtStudentLName.ReadOnly = false;
            txtStudentEmail.ReadOnly = false;

            txtStudentFName.Enabled = true;
            txtStudentMName.Enabled = true;
            txtStudentLName.Enabled = true;
            txtStudentEmail.Enabled = true;
   
            lvwStudents.Items.Clear();

            btnEditStudentInfo.Visible = false;
            btnUpdateStudentInfo.Visible = true;
            btnDeleteStudentInfo.Visible = true;
            #endregion
        }


        private void btnEditAdvisorInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtAdvisorID.Text == "")
            {
                messageBoxOK("Select a Advisor to Edit.");
                return;
            }

            txtAdvisorID.ReadOnly = true;
            txtAdvisorFName.ReadOnly = false;
            txtAdvisorMName.ReadOnly = false;
            txtAdvisorLName.ReadOnly = false;
            txtAdvisorEmail.ReadOnly = false;
            txtAdvisorOfficeAddress.ReadOnly = false;
            maskedEditAdvisorPhone.ReadOnly = false;

            lvwAdvisors.Items.Clear();

            txtAdvisorFName.Enabled = true;
            txtAdvisorMName.Enabled = true;
            txtAdvisorLName.Enabled = true;
            txtAdvisorEmail.Enabled = true;
            txtAdvisorOfficeAddress.Enabled = true;
            txtAdvisorOfficeAddress.Enabled = true;
            maskedEditAdvisorPhone.Enabled = true;

            btnEditAdvisorInfo.Visible = false;
            btnUpdateAdvisorInfo.Visible = true;
            btnDeleteAdvisorInfo.Visible = true;
            #endregion
        }


        private void btnEditLocationInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtLocationID.Text == "")
            {
                messageBoxOK("Select a location to Edit.");
                return;
            }

            txtLocationID.ReadOnly = true;

            txtLocationType.ReadOnly = false;

            txtLocationType.Enabled = true;

            lvwLocations.Items.Clear();

            btnEditLocationInfo.Visible = false;
            btnUpdateLocationInfo.Visible = true;
            btnDeleteLocationInfo.Visible = true;
            #endregion
        }


        private void btnEditMeetingInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtMeetingID.Text == "")
            {
                messageBoxOK("Select a Advisor to Edit.");
                return;
            }

            txtMeetingID.ReadOnly = true;

            txtMeetingName.ReadOnly = false;
            txtAvailabilityID_Meetings.ReadOnly = false;

            txtMeetingName.Enabled = true;
            cboStatus.Enabled = true;

            btnEditMeetingInfo.Visible = false;
            btnUpdateMeetingInfo.Visible = true;
            btnDeleteMeetingInfo.Visible = true;
            #endregion
        }


        private void btnEditAvailabilityInfo_Click_1(object sender, EventArgs e)
        {
            #region
            if (txtAvailabilityID.Text == "")
            {
                messageBoxOK("Select an Availability to Edit.");
                return;
            }

            txtSchedule.ReadOnly = true;
            cboAHourBlocks.Enabled = true;
            cboALocation.Enabled = true;
            cboAvAdvisors.Enabled = true;
            dtpAvailableDate.Enabled = true;
      
            lvwAvailability.Items.Clear();
        
            btnEditAvailabilityInfo.Visible = false;
            btnUpdateAvailabilityInfo.Visible = true;
            btnDeleteAvailabilityInfo.Visible = true;
            #endregion
        }


        /*DELETE BUTTON METHODS*/
        private void btnDeleteStudentInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtStudentID.Text == "")
            {
                messageBoxOK("Select a Student to Delete.");
                return;
            }

     
            DialogResult result = messageBoxYesNo("Are you sure you want to delete this student?");
            if (result == DialogResult.Yes)
            {
            
                int studentID = int.Parse(txtStudentID.Text);
             
                if (deleteStudent(studentID) == true)
                {
                    messageBoxOK("The student has been deleted.");
                    populateStudentDictionary(ref dctStudents);
                    refreshStudentListview();
                    studentInformation_Update_ClearTextboxes();
                }
                else
                {
                    messageBoxOK("Failed to delete the student.");
                }
            
                refreshStudentListview();
                fillComboBoxWithStudents();

                txtStudentFName.Enabled = false;
                txtStudentMName.Enabled = false;
                txtStudentLName.Enabled = false;
                txtStudentEmail.Enabled = false;
                txtUSCBID.Enabled = false;

                btnEditStudentInfo.Visible = true;
                btnUpdateStudentInfo.Visible = false;
                btnDeleteStudentInfo.Visible = false;
            }
            #endregion
        }


        private void btnDeleteAdvisorInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtAdvisorID.Text == "")
            {
                messageBoxOK("Select a Advisor to Delete.");
                return;
            }
 
            DialogResult result = messageBoxYesNo("Are you sure you want to delete this advisor?");
            if (result == DialogResult.Yes)
            {
            
                int advisorID = int.Parse(txtAdvisorID.Text);
      
                if (deleteAdvisor(advisorID) == true)
                {
                    messageBoxOK("The advisor has been deleted.");
                    populateAdvisorDictionary(ref dctAdvisors);
                    refreshAdvisorListview();
                    advisorInformation_Update_ClearTextboxes();

                    cboAvAdvisors.SelectedIndex = -1;
                }
                else
                {
                    messageBoxOK("Failed to delete the advisor.");
                }
          
                refreshAdvisorListview();
                fillComboBoxWithAdvisors();

                txtAdvisorID.Enabled = false;
                txtAdvisorFName.Enabled = false;
                txtAdvisorMName.Enabled = false;
                txtAdvisorLName.Enabled = false;
                txtAdvisorEmail.Enabled = false;
                txtAdvisorOfficeAddress.Enabled = false;
                txtAdvisorOfficeAddress.Enabled = false;
                maskedEditAdvisorPhone.Enabled = false;

                btnEditAdvisorInfo.Visible = true;
                btnUpdateAdvisorInfo.Visible = false;
                btnDeleteAdvisorInfo.Visible = false;
            }
            #endregion
        }


        private void btnDeleteLocationInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtLocationID.Text == "")
            {
                messageBoxOK("Select a Location to Delete.");
                return;
            }
        
            DialogResult result = messageBoxYesNo("Are you sure you want to delete this location?");
            if (result == DialogResult.Yes)
            {
             
                int locationID = int.Parse(txtLocationID.Text);
             
                if (deleteLocation(locationID) == true)
                {
                    messageBoxOK("The location has been deleted.");
                    populateLocationDictionary(ref dctLocations);
                    refreshLocationListview();
                    locationInformation_Update_ClearTextboxes();
                }
                else
                {
                    messageBoxOK("Failed to delete the location.");
                }
           
                refreshLocationListview();
                fillComboBoxWithLocations();

                txtLocationType.Enabled = false;

                btnEditLocationInfo.Visible = true;
                btnUpdateLocationInfo.Visible = false;
                btnDeleteLocationInfo.Visible = false;
            }
            #endregion
        }


        private void btnDeleteMeetingInfo_Click(object sender, EventArgs e)
        {
            #region
            if (txtMeetingID.Text == "")
            {
                messageBoxOK("Select a Meeting to Delete.");
                return;
            }
          
            DialogResult result = messageBoxYesNo("Are you sure you want to delete this meeting?");
            if (result == DialogResult.Yes)
            {
             
                int meetingID = int.Parse(txtMeetingID.Text);
            
                if (deleteMeeting(meetingID) == true)
                {
                    messageBoxOK("The meeting has been deleted.");
                    populateMeetingDictionary(ref dctMeetings);
                    refreshMeetingListview();
                    meetingInformation_Update_ClearTextboxes();
                }
                else
                {
                    messageBoxOK("Failed to delete the advisor.");
                }
            
                refreshAdvisorListview();

                txtMeetingName.Enabled = false;
                cboStatus.Enabled = false;

                btnEditMeetingInfo.Visible = true;
                btnUpdateMeetingInfo.Visible = false;
                btnDeleteMeetingInfo.Visible = false;

                cboStatus.SelectedIndex = -1;
            }
            #endregion
        }


        private void btnDeleteAvailabilityInfo_Click_1(object sender, EventArgs e)
        {
            #region
            if (txtAvailabilityID.Text == "")
            {
                messageBoxOK("Select an Availability to Delete.");
                return;
            }
           
            DialogResult result = messageBoxYesNo("Are you sure you want to delete this availability?");
            if (result == DialogResult.Yes)
            {
            
                int availabilityID = int.Parse(txtAvailabilityID.Text);
             
                if (deleteAvailability(availabilityID) == true)
                {
                    messageBoxOK("The availability has been deleted.");
                    populateAvailabilityDictionary(ref dctAvailability);
                    refreshAddMeetingsListView();
                    availabilityInformation_Update_ClearTextboxes();
                }
                else
                {
                    messageBoxOK("Failed to delete the availability.");
                }

                refreshAvailabilityListview();

                fillComboBoxWithAdvisors();
                fillComboBoxWithHourBlocks();
                fillComboBoxWithLocations();

                cboAvAdvisors.SelectedIndex = -1;
                cboAHourBlocks.SelectedIndex = -1;
                cboALocation.SelectedIndex = -1;

                btnEditAvailabilityInfo.Visible = true;
                btnUpdateAvailabilityInfo.Visible = false;
                btnDeleteAvailabilityInfo.Visible = false;

                txtAvailabilityID.Clear();
                txtAvailabilityID.ReadOnly = false;
                txtAvailabilityID.Enabled = false;

                cboAHourBlocks.Enabled = false;
                cboALocation.Enabled = false;
                cboAvAdvisors.Enabled = false;
                dtpAvailableDate.Enabled = false;

                txtSchedule.Clear();
                txtSchedule.ReadOnly = false;
                txtSchedule.Enabled = false;

                txtLeftDays.Text = String.Empty;
            }
            #endregion
        }




        /*ADD BUTTON METHODS*/
        private void btnAddAdvisor_Click(object sender, EventArgs e) 
        {
            #region
            clsAdvisor currentAdvisor = new clsAdvisor();

            #region Validate user input & assigning to Student properties

            currentAdvisor.AdvisorFName = txtAddAdvisorFName.Text;
            currentAdvisor.AdvisorMName = txtAddAdvisorMName.Text;
            currentAdvisor.AdvisorLName = txtAddAdvisorLName.Text;
            currentAdvisor.AdvisorEmail = txtAddAdvisorEmail.Text;
            currentAdvisor.OfficeAddress = txtAddOfficeAddress.Text;
            currentAdvisor.PhoneNumber = maskedAdvisorPhone.Text;

            string phoneNumber = maskedAdvisorPhone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (string.IsNullOrWhiteSpace(phoneNumber) || phoneNumber.Length < 10)
            {
                messageBoxOK("Invalid Phone Number.");
                maskedAdvisorPhone.Focus();
                return;
            }
            currentAdvisor.PhoneNumber = maskedAdvisorPhone.Text;

            if (txtAddAdvisorEmail.Text == "")
            {
                currentAdvisor.AdvisorEmail = "";
            }
            else if (txtAddAdvisorEmail.Text.Contains("@"))
            {
                currentAdvisor.AdvisorEmail = txtAddAdvisorEmail.Text;
            }
            else
            {
                messageBoxOK("Invalid email address");
                txtAddAdvisorEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(currentAdvisor.AdvisorFName) ||
                string.IsNullOrEmpty(currentAdvisor.AdvisorLName) ||
                string.IsNullOrEmpty(currentAdvisor.AdvisorEmail) ||
                string.IsNullOrEmpty(currentAdvisor.OfficeAddress) ||
                string.IsNullOrEmpty(currentAdvisor.PhoneNumber))
            {
                messageBoxOK("Please fill in all fields.");
                return;
            }
            else
            {
                if (insertAdvisor(currentAdvisor) == true)
                {
                    populateAdvisorDictionary(ref dctAdvisors);
                    refreshStudentListview();
                    fillComboBoxWithAdvisors();

                    messageBoxOK("Advisor: " + currentAdvisor.AdvisorFName + " successfully added");
                }
                else
                {
                    messageBoxOK("Failed to add the Advisor: " + currentAdvisor.AdvisorFName + ".");
                }
            }
            #endregion

            txtAddAdvisorFName.Text = String.Empty;
            txtAddAdvisorMName.Text = String.Empty;
            txtAddAdvisorLName.Text = String.Empty;
            txtAddAdvisorEmail.Text = String.Empty;
            txtAddOfficeAddress.Text = String.Empty;
            maskedAdvisorPhone.Text = String.Empty;

            refreshAdvisorListview();
            #endregion
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            #region
            clsStudent currentStudent = new clsStudent();

            #region Validate user input & assigning to Student properties

            currentStudent.StudentFName = txtAddStudentFName.Text;
            currentStudent.StudentMName = txtAddStudentMName.Text;
            currentStudent.StudentLName = txtAddStudentLName.Text;
            currentStudent.StudentEmail = txtAddStudentEmail.Text;
            currentStudent.USCBID = txtAddUSCBID.Text;

            if (txtAddStudentEmail.Text == "")
            {
                currentStudent.StudentEmail = "";
            }
            else if (txtAddStudentEmail.Text.Contains("@"))
            {
                currentStudent.StudentEmail = txtAddStudentEmail.Text;
            }
            else
            {
                messageBoxOK("Invalid email address");
                txtAddStudentEmail.Focus();
                return;
            }

            if (txtAddUSCBID.Text == "")
            {
                currentStudent.USCBID = "";
            }
            else if (txtAddUSCBID.Text.Length == 9)
            {
                currentStudent.USCBID = txtAddUSCBID.Text;
            }
            else
            {
                messageBoxOK("Invalid USCB ID");
                txtAddUSCBID.Focus();
                return;
            }

            if (string.IsNullOrEmpty(currentStudent.StudentFName) ||
                string.IsNullOrEmpty(currentStudent.StudentLName) ||
                string.IsNullOrEmpty(currentStudent.StudentEmail) ||
                string.IsNullOrEmpty(currentStudent.USCBID))
            {
                messageBoxOK("Please fill in all fields.");
                return;
            }
            else
            {
                if (insertStudent(currentStudent) == true)
                {
                    populateStudentDictionary(ref dctStudents);
                    refreshStudentListview();
                    fillComboBoxWithStudents();
                    messageBoxOK("Student: " + currentStudent.StudentFName + " successfully added");
                }
                else
                {
                    messageBoxOK("Failed to add the Student: " + currentStudent.StudentFName + ".");
                }
            }
            #endregion

            txtAddStudentFName.Text = String.Empty;
            txtAddStudentMName.Text = String.Empty;
            txtAddStudentLName.Text = String.Empty;
            txtAddStudentEmail.Text = String.Empty;
            txtAddUSCBID.Text = String.Empty;

            refreshStudentListview();
            #endregion
        }


        private void btnAddLocation_Click(object sender, EventArgs e)
        {
                #region
                clsLocation currentLocation = new clsLocation();
          
                currentLocation.LocationType = txtAddLocationType.Text;

                #region Validate user input & assigning to Student properties

                if (string.IsNullOrEmpty(currentLocation.LocationType))
                {
                    messageBoxOK("Please fill in all fields.");
                    return;
                }
                else
                {
                    if (insertLocation(currentLocation) == true)
                    {
                        populateLocationDictionary(ref dctLocations);
                        refreshLocationListview();
                        fillComboBoxWithLocations();

                        messageBoxOK("Location: " + currentLocation.LocationType + " successfully added");
                    }
                    else
                    {
                        messageBoxOK("Failed to add the Location: " + currentLocation.LocationType + ".");
                    }
                }

                #endregion

                txtAddLocationType.Text = String.Empty;

                refreshLocationListview();
            #endregion
        }


        private void btnAddMeeting_Click(object sender, EventArgs e)
        {
            #region     
            clsMeeting currentMeeting = new clsMeeting();

        
            if (txtMeetingNameAdd.Text.Length > 50)
            {
                messageBoxOK("Meeting name is too long. Please limit to 50 characters.");
                return;
            }
            else
            {
                currentMeeting.MeetingName = txtMeetingNameAdd.Text;
            }

           
            if (string.IsNullOrEmpty(txtAvailabilityID_MeetingsAdd.Text))
            {
                messageBoxOK("Please pick the Availability.");
                return;
            }
            else
            {
                currentMeeting.AvailabilityID = Int32.Parse(txtAvailabilityID_MeetingsAdd.Text);
            }

          
            if (cboMeetingStudents.SelectedValue != null && int.TryParse(cboMeetingStudents.SelectedValue.ToString(), out int selectedStudentID))
            {
                currentMeeting.StudentID = selectedStudentID;
            }
            else
            {
                messageBoxOK("Please select a student.");
                return;
            }

       
            if (string.IsNullOrWhiteSpace(txtStatusAdd.Text))
            {
                messageBoxOK("Status cannot be empty.");
                return;
            }
            else
            {
                currentMeeting.Status = txtStatusAdd.Text;
            }

        
            if (string.IsNullOrEmpty(currentMeeting.MeetingName) ||
                string.IsNullOrEmpty(currentMeeting.Status) ||
                currentMeeting.AvailabilityID == 0 ||
                currentMeeting.StudentID == 0)
            {
                messageBoxOK("Please fill in all fields.");
                return;
            }

            if (dctMeetings.Values.Any(m => m.MeetingName.Equals(currentMeeting.MeetingName, StringComparison.OrdinalIgnoreCase)))
            {
                messageBoxOK("Meeting name already exists. Please choose a different name.");
                return;
            }

            if (insertMeeting(currentMeeting))
            {
                populateMeetingDictionary(ref dctMeetings);
                refreshMeetingListview();
                messageBoxOK("Meeting: " + currentMeeting.MeetingName + " successfully added");
            }
            else
            {
                messageBoxOK("Failed to add the Meeting: " + currentMeeting.MeetingName + ".");
            }

            txtMeetingNameAdd.Text = String.Empty;
            txtAvailabilityID_MeetingsAdd.Text = String.Empty;
            cboMeetingStudents.SelectedIndex = -1;
            
            refreshMeetingListview();
            #endregion
        }


        private void btnAddAvailabilityInfo_Click(object sender, EventArgs e)
        {
            #region     
            clsAvailability currentAvailability = new clsAvailability();

            if (cboMeetingAdvisors.SelectedValue != null && int.TryParse(cboMeetingAdvisors.SelectedValue.ToString(), out int selectedAdvisorID))
            {
                currentAvailability.AdvisorID = selectedAdvisorID;
            }
            else
            {
                messageBoxOK("Please select a advisor.");
                return;
            }

            if (cboLocations.SelectedValue != null && int.TryParse(cboLocations.SelectedValue.ToString(), out int selectedLocationID))
            {
                currentAvailability.LocationID = selectedLocationID;
            }
            else
            {
                messageBoxOK("Please select a location.");
                return;
            }

            if (cboHourBlocks.SelectedValue != null && int.TryParse(cboHourBlocks.SelectedValue.ToString(), out int selectedHourBlocksID))
            {
                currentAvailability.HourBlockID = selectedHourBlocksID;
            }
            else
            {
                messageBoxOK("Please select a hour block.");
                return;
            }

            if (dtpAddDate.Value == null)
            {
                messageBoxOK("Please select a date.");
                return;
            }
            else
            {
                currentAvailability.AvailableDate = dtpAddDate.Value;
            }

            if (insertAvailability(currentAvailability))
            {
                populateAvailabilityDictionary(ref dctAvailability);
                refreshAvailabilityListview();
                refreshAddMeetingsListView();
                messageBoxOK("The Availability has been added.");

                fillComboBoxWithAdvisors();
                fillComboBoxWithHourBlocks();
                fillComboBoxWithLocations();

                cboMeetingAdvisors.SelectedIndex = -1;
                cboLocations.SelectedIndex = -1;
                cboHourBlocks.SelectedIndex = -1;
            }
            else
            {
                messageBoxOK("Failed to add the Availability.");
            }
            #endregion
        }



        /*SELECTED INDEX CHANGED METHODS*/
        private void lvwLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            if (lvwLocations.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selectedItem = lvwLocations.SelectedItems[0];
            if (selectedItem.Tag is clsLocation currentLocation)
            {
                displayLocationInformation_update(currentLocation);
            }
            #endregion
        }




        /*USCBID TEXT LIMIT*/
        private void txtAddUSCBID_TextChanged(object sender, EventArgs e)
        {
            txtAddUSCBID.MaxLength = 9;
        }
        



        /*FILL COMBOBOX VIA DATABASE*/
        private void fillComboBoxWithAdvisors()
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EXEC sp_GetAdvisors", conn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    dt.Columns.Add("FullName", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["FullName"] = $"{row["AdvisorFName"]}, {row["AdvisorLName"]}";
                    }

                    cboMeetingAdvisors.DataSource = null;
                    cboAvAdvisors.DataSource = null;

                    cboMeetingAdvisors.DataSource = dt;
                    cboMeetingAdvisors.DisplayMember = "FullName";
                    cboMeetingAdvisors.ValueMember = "AdvisorID";

                    cboAvAdvisors.DataSource = dt;
                    cboAvAdvisors.DisplayMember = "FullName";
                    cboAvAdvisors.ValueMember = "AdvisorID";

                    cboMeetingAdvisors.Refresh();
                    cboAvAdvisors.Refresh();
                }
                catch (Exception e)
                {
                    messageBoxOK("Error: " + e.Message);
                }
            }
            #endregion
        }


        private void fillComboBoxWithLocations()
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EXEC sp_GetLocations", conn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    cboLocations.DataSource = null;
                    cboALocation.DataSource = null;

                    cboLocations.DataSource = dt;
                    cboLocations.DisplayMember = "LocationType";
                    cboLocations.ValueMember = "LocationID";

                    cboALocation.DataSource = dt;
                    cboALocation.DisplayMember = "LocationType";
                    cboALocation.ValueMember = "LocationID";

                    cboLocations.Refresh();
                    cboALocation.Refresh();
                }
                catch (Exception e)
                {
                    messageBoxOK("Error: " + e.Message);
                }
            }
            #endregion
        }


        private void fillComboBoxWithStudents()
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EXEC sp_GetStudents", conn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    dt.Columns.Add("FullName", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["FullName"] = $"{row["StudentFName"]}, {row["StudentLName"]}";
                    }

                    cboMeetingStudents.DataSource = null;
                    cboMeetingStudents.DataSource = dt;
                    cboMeetingStudents.DisplayMember = "FullName";
                    cboMeetingStudents.ValueMember = "StudentID";

                    cboMeetingStudents.Refresh();
                }
                catch (Exception e)
                {
                    messageBoxOK("Error: " + e.Message);
                }
            }
            #endregion
        }


        private void fillComboBoxWithHourBlocks()
        {
            #region
            string myConnectionString = clsDBUtil.getConnectionString();
            using (SqlConnection conn = new SqlConnection(myConnectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("EXEC sp_GetHourBlocks", conn);
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dt.Columns.Add("HourBlock", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["HourBlock"] = $"{row["StartBlock"]} - {row["EndBlock"]}";
                    }

                    cboAHourBlocks.DataSource = null;
                    cboHourBlocks.DataSource = null;

                    cboAHourBlocks.DataSource = dt;
                    cboAHourBlocks.DisplayMember = "HourBlock";
                    cboAHourBlocks.ValueMember = "HourBlockID";

                    cboHourBlocks.DataSource = dt;
                    cboHourBlocks.DisplayMember = "HourBlock";
                    cboHourBlocks.ValueMember = "HourBlockID";

                    cboAHourBlocks.Refresh();
                    cboHourBlocks.Refresh();
                }
                catch (Exception e)
                {
                    messageBoxOK("Error: " + e.Message);
                }
            }
            #endregion
        }




        /*DATE TIME PICKER (CALENDER)* METHODS*/
        private void dtpAddDate_ValueChanged(object sender, EventArgs e)
        {
            #region
            string selectedDate = dtpAddDate.Value.ToString("yyyy-MM-dd");
            txtTimeDisplay.Text = selectedDate;

            dtpAddDate.MinDate = DateTime.Now;
            #endregion
        }


        private void dtpAvailableDate_ValueChanged(object sender, EventArgs e)
        {
            #region
            string selectedDate = dtpAvailableDate.Value.ToString("yyyy-MM-dd");
            txtSchedule.Text = selectedDate;

            dtpAvailableDate.MinDate = DateTime.Now;
            #endregion
        }


        private void maskedAdvisorPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            #region
            if (!maskedAdvisorPhone.Focused)
            {
                maskedAdvisorPhone.Focus();
            }

            // Set the cursor to the first position
            maskedAdvisorPhone.SelectionStart = 0;
            maskedAdvisorPhone.SelectionLength = 0;
            #endregion
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}


