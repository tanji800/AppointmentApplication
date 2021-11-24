using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentApplication
{
    public partial class AddAppointment : Form
    {
        private bool isEditMode;
        //private AppointmentApplicationModel _AppointmentRecords;
        private AppointmentList _appointmentList;
        private AppointmentDetail _appointmentDetails;
        private readonly AppointmentApplicationEntities _db;
        public AddAppointment( )
        {
            InitializeComponent();
            label1.Text = "Add New Appointment Record";
            this.Text = "Add New Appointment Record";
            isEditMode = false;
            //_appointmentDetails = AppointmentRecords;
            _db = new AppointmentApplicationEntities();
        }

        public AddAppointment(AppointmentDetail recordToEdit)//, AppointmentList  = null)
        {
            InitializeComponent();
            label1.Text = "Edit Or Modify Appointment";
            this.Text = "Edit Or Modify Appointment";
           // _appointmentDetails = AppointmentList;
            if (recordToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                isEditMode = true;
                _db = new AppointmentApplicationEntities();
                PopulateFields(recordToEdit);
            }
        }

        private void PopulateFields(AppointmentDetail recordToEdit)
        {
            tbFirstName.Text = recordToEdit.FirstName;
            tbLastName.Text = recordToEdit.FirstName;
            dateTimePickerAddAppointment.Value = (DateTime)recordToEdit.AppointmentDate;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string FirstName = tbFirstName.Text;
                var LastName = tbLastName.Text;
                var AppointmentDate = dateTimePickerAddAppointment.Value;
                
                var isValid = true;
                var errorMessage = "";

                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                {
                    isValid = false;
                    errorMessage += "Error: Please enter First Name or Last Name.\n\r";
                }

                if (isValid)
                {
                    //Declare an object of the record to be added
                    var Record = new AppointmentDetail();
                    if (isEditMode)
                    {
                        //If in edit mode, then get the ID and retrieve the record from the database and place
                        //the result in the record object
                        var id = int.Parse(lblId.Text);
                        Record = _db.AppointmentDetails.FirstOrDefault(q => q.id == id);
                    }
                    //Populate record object with values from the form 
                    Record.FirstName = FirstName;
                    Record.LastName = LastName;
                    Record.AppointmentDate = AppointmentDate;
                   
                    if (!isEditMode)
                        _db.AppointmentDetails.Add(Record);
                    //Save Changes made to the entity
                    _db.SaveChanges();
                    _appointmentList.PopulateGrid();

                    MessageBox.Show("New record Added Successfully");

                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
