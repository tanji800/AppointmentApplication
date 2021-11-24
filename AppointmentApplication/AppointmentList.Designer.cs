namespace AppointmentApplication
{
    partial class AppointmentList
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
            this.label1 = new System.Windows.Forms.Label();
            this.gvAppointmentList = new System.Windows.Forms.DataGridView();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.btnModifyExistAppDetails = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gvAppointmentList
            // 
            this.gvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAppointmentList.Location = new System.Drawing.Point(12, 99);
            this.gvAppointmentList.Name = "gvAppointmentList";
            this.gvAppointmentList.RowHeadersWidth = 51;
            this.gvAppointmentList.RowTemplate.Height = 24;
            this.gvAppointmentList.Size = new System.Drawing.Size(766, 224);
            this.gvAppointmentList.TabIndex = 1;
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.Location = new System.Drawing.Point(45, 347);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(274, 40);
            this.btnAddNewAppointment.TabIndex = 2;
            this.btnAddNewAppointment.Text = "Add New Appointment";
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // btnModifyExistAppDetails
            // 
            this.btnModifyExistAppDetails.Location = new System.Drawing.Point(459, 347);
            this.btnModifyExistAppDetails.Name = "btnModifyExistAppDetails";
            this.btnModifyExistAppDetails.Size = new System.Drawing.Size(268, 40);
            this.btnModifyExistAppDetails.TabIndex = 3;
            this.btnModifyExistAppDetails.Text = "Modify Existing Appointment Details";
            this.btnModifyExistAppDetails.UseVisualStyleBackColor = true;
            this.btnModifyExistAppDetails.Click += new System.EventHandler(this.btnModifyExistAppDetails_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(45, 393);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(274, 45);
            this.btnDeleteAppointment.TabIndex = 4;
            this.btnDeleteAppointment.Text = "Delete existing/upcoming appointments";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Manage users";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnModifyExistAppDetails);
            this.Controls.Add(this.btnAddNewAppointment);
            this.Controls.Add(this.gvAppointmentList);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentList";
            this.Text = "Appointment List";
            this.Load += new System.EventHandler(this.AppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAppointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvAppointmentList;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Button btnModifyExistAppDetails;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button button1;
    }
}

