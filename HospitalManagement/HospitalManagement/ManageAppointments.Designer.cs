namespace HospitalManagement
{
    partial class frmManageAppointments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAppointments));
            this.dataGridViewDeleteFunctionality = new System.Windows.Forms.DataGridView();
            this.clmnSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnSrNoPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnPatidPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApptIDPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApptDatePanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOperatoryPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnProvPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApptTimePanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnApptLengthPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAmountPanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnClinicNamePanel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTask5Description = new System.Windows.Forms.Label();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSelectRequest = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteFunctionality)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDeleteFunctionality
            // 
            this.dataGridViewDeleteFunctionality.AllowUserToAddRows = false;
            this.dataGridViewDeleteFunctionality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDeleteFunctionality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDeleteFunctionality.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDeleteFunctionality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeleteFunctionality.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnSelect,
            this.clmnSrNoPanel,
            this.clmnPatidPanel,
            this.clmnApptIDPanel,
            this.clmnApptDatePanel,
            this.clmnOperatoryPanel,
            this.clmnProvPanel,
            this.clmnApptTimePanel,
            this.clmnApptLengthPanel,
            this.clmnAmountPanel,
            this.clmnClinicNamePanel});
            this.dataGridViewDeleteFunctionality.Location = new System.Drawing.Point(36, 120);
            this.dataGridViewDeleteFunctionality.Name = "dataGridViewDeleteFunctionality";
            this.dataGridViewDeleteFunctionality.RowHeadersVisible = false;
            this.dataGridViewDeleteFunctionality.RowTemplate.Height = 24;
            this.dataGridViewDeleteFunctionality.Size = new System.Drawing.Size(940, 450);
            this.dataGridViewDeleteFunctionality.TabIndex = 16;
            // 
            // clmnSelect
            // 
            this.clmnSelect.Frozen = true;
            this.clmnSelect.HeaderText = "Select all";
            this.clmnSelect.Name = "clmnSelect";
            // 
            // clmnSrNoPanel
            // 
            this.clmnSrNoPanel.HeaderText = "Sr. No.";
            this.clmnSrNoPanel.Name = "clmnSrNoPanel";
            this.clmnSrNoPanel.Width = 97;
            // 
            // clmnPatidPanel
            // 
            this.clmnPatidPanel.HeaderText = "Patient ID";
            this.clmnPatidPanel.Name = "clmnPatidPanel";
            this.clmnPatidPanel.Width = 131;
            // 
            // clmnApptIDPanel
            // 
            this.clmnApptIDPanel.HeaderText = "Appt. ID";
            this.clmnApptIDPanel.Name = "clmnApptIDPanel";
            this.clmnApptIDPanel.Width = 115;
            // 
            // clmnApptDatePanel
            // 
            this.clmnApptDatePanel.HeaderText = "Appt. Date";
            this.clmnApptDatePanel.Name = "clmnApptDatePanel";
            this.clmnApptDatePanel.Width = 135;
            // 
            // clmnOperatoryPanel
            // 
            this.clmnOperatoryPanel.HeaderText = "Operatory";
            this.clmnOperatoryPanel.Name = "clmnOperatoryPanel";
            this.clmnOperatoryPanel.Width = 146;
            // 
            // clmnProvPanel
            // 
            this.clmnProvPanel.HeaderText = "Provider Name";
            this.clmnProvPanel.Name = "clmnProvPanel";
            this.clmnProvPanel.Width = 176;
            // 
            // clmnApptTimePanel
            // 
            this.clmnApptTimePanel.HeaderText = "Appt. Time";
            this.clmnApptTimePanel.Name = "clmnApptTimePanel";
            this.clmnApptTimePanel.Width = 139;
            // 
            // clmnApptLengthPanel
            // 
            this.clmnApptLengthPanel.HeaderText = "Appt. Length";
            this.clmnApptLengthPanel.Name = "clmnApptLengthPanel";
            this.clmnApptLengthPanel.Width = 158;
            // 
            // clmnAmountPanel
            // 
            this.clmnAmountPanel.HeaderText = "Amount";
            this.clmnAmountPanel.Name = "clmnAmountPanel";
            this.clmnAmountPanel.Width = 119;
            // 
            // clmnClinicNamePanel
            // 
            this.clmnClinicNamePanel.HeaderText = "Clinic Name";
            this.clmnClinicNamePanel.Name = "clmnClinicNamePanel";
            this.clmnClinicNamePanel.Width = 150;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(849, 611);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(849, 661);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 36);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTask5Description
            // 
            this.lblTask5Description.AutoSize = true;
            this.lblTask5Description.Location = new System.Drawing.Point(36, 84);
            this.lblTask5Description.Name = "lblTask5Description";
            this.lblTask5Description.Size = new System.Drawing.Size(497, 26);
            this.lblTask5Description.TabIndex = 19;
            this.lblTask5Description.Text = "List of Appointmets having Amount less than 50";
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBar.Location = new System.Drawing.Point(350, 580);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(312, 22);
            this.lblProgressBar.TabIndex = 20;
            this.lblProgressBar.Text = "Appointments Deleting Please Wait...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(254, 611);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(505, 19);
            this.progressBar1.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSelectRequest
            // 
            this.lblSelectRequest.AutoSize = true;
            this.lblSelectRequest.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectRequest.Location = new System.Drawing.Point(205, 580);
            this.lblSelectRequest.Name = "lblSelectRequest";
            this.lblSelectRequest.Size = new System.Drawing.Size(603, 26);
            this.lblSelectRequest.TabIndex = 22;
            this.lblSelectRequest.Text = "*Please select the Appointments which you want to delete.";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1006, 721);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(832, 597);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(160, 115);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(72, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmManageAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSelectRequest);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.lblTask5Description);
            this.Controls.Add(this.dataGridViewDeleteFunctionality);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManageAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeleteFunctionality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDeleteFunctionality;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTask5Description;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSelectRequest;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSrNoPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnPatidPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApptIDPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApptDatePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOperatoryPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnProvPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApptTimePanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnApptLengthPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAmountPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnClinicNamePanel;
    }
}