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
    public partial class AppointmentList : Form
    {
        private readonly AppointmentApplicationEntities _db;
        public AppointmentList()
        {
            InitializeComponent();
            _db= new AppointmentApplicationEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentList_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }


        }

        public void PopulateGrid()
        {
            var record = _db.AppointmentDetails
               .Select(q => new
               {
                   firstName = q.FirstName,
                   LastName = q.LastName,
                   AppointmentDate = q.AppointmentDate,
                   q.id
               })
               .ToList();
            gvAppointmentList.DataSource = record;
            gvAppointmentList.Columns[0].HeaderText = "First Name";
            gvAppointmentList.Columns[1].HeaderText = "Last Name";
            gvAppointmentList.Columns[2].HeaderText = "Appointment Date";
             
            gvAppointmentList.Columns["Id"].Visible = false;

        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            var AddAppointment = new AddAppointment();
            AddAppointment.ShowDialog();
            AddAppointment.MdiParent = this.MdiParent;
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvAppointmentList.SelectedRows[0].Cells["Id"].Value;

                
                var record = _db.AppointmentDetails.FirstOrDefault(q => q.id == id);

                DialogResult dr = MessageBox.Show("Are You Sure You Want To Delete This Record?",
                    "Delete", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    
                    _db.AppointmentDetails.Remove(record);
                    _db.SaveChanges();

                    PopulateGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnModifyExistAppDetails_Click(object sender, EventArgs e)
        {
            try
            {
                // get Id of selected row
                var id = (int)gvAppointmentList.SelectedRows[0].Cells["Id"].Value;

                
                var record = _db.AppointmentDetails.FirstOrDefault(q => q.id == id);

               
                    var addEditRentalRecord = new AddAppointment(record);
                    addEditRentalRecord.MdiParent = this.MdiParent;
                    addEditRentalRecord.Show();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
