namespace CSVFileData
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lblScreen_id = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDepth_to_water_level = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.txtScreen_id = new System.Windows.Forms.TextBox();
            this.txtDepth_to_water_level = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSelectedId = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(328, 691);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReplace.Location = new System.Drawing.Point(211, 24);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(199, 35);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace character \'a\' to\'@\'";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btn_ReplaceClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUpdate.Location = new System.Drawing.Point(498, 691);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(671, 691);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(364, 403);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(102, 17);
            this.lblStationName.TabIndex = 5;
            this.lblStationName.Text = "StationName: *";
            // 
            // lblScreen_id
            // 
            this.lblScreen_id.AutoSize = true;
            this.lblScreen_id.Location = new System.Drawing.Point(364, 460);
            this.lblScreen_id.Name = "lblScreen_id";
            this.lblScreen_id.Size = new System.Drawing.Size(85, 17);
            this.lblScreen_id.TabIndex = 6;
            this.lblScreen_id.Text = "Screen_id: *";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(364, 519);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            // 
            // lblDepth_to_water_level
            // 
            this.lblDepth_to_water_level.AutoSize = true;
            this.lblDepth_to_water_level.Location = new System.Drawing.Point(364, 571);
            this.lblDepth_to_water_level.Name = "lblDepth_to_water_level";
            this.lblDepth_to_water_level.Size = new System.Drawing.Size(149, 17);
            this.lblDepth_to_water_level.TabIndex = 8;
            this.lblDepth_to_water_level.Text = "Depth_to_water_level:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(364, 629);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(71, 17);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "Comment:";
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(623, 403);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(164, 22);
            this.txtStationName.TabIndex = 10;
            // 
            // txtScreen_id
            // 
            this.txtScreen_id.Location = new System.Drawing.Point(623, 457);
            this.txtScreen_id.Name = "txtScreen_id";
            this.txtScreen_id.Size = new System.Drawing.Size(164, 22);
            this.txtScreen_id.TabIndex = 11;
            // 
            // txtDepth_to_water_level
            // 
            this.txtDepth_to_water_level.Location = new System.Drawing.Point(623, 566);
            this.txtDepth_to_water_level.Name = "txtDepth_to_water_level";
            this.txtDepth_to_water_level.Size = new System.Drawing.Size(164, 22);
            this.txtDepth_to_water_level.TabIndex = 13;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(623, 629);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(164, 22);
            this.txtComment.TabIndex = 14;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(699, 35);
            this.cmbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(190, 24);
            this.cmbName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(634, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name:";
            // 
            // btnSelectedId
            // 
            this.btnSelectedId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectedId.Location = new System.Drawing.Point(895, 29);
            this.btnSelectedId.Name = "btnSelectedId";
            this.btnSelectedId.Size = new System.Drawing.Size(107, 35);
            this.btnSelectedId.TabIndex = 19;
            this.btnSelectedId.Text = "Select";
            this.btnSelectedId.UseVisualStyleBackColor = false;
            this.btnSelectedId.Click += new System.EventHandler(this.btnSelectedId_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(623, 519);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1306, 776);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSelectedId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtDepth_to_water_level);
            this.Controls.Add(this.txtScreen_id);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblDepth_to_water_level);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblScreen_id);
            this.Controls.Add(this.lblStationName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Label lblScreen_id;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDepth_to_water_level;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.TextBox txtScreen_id;
        private System.Windows.Forms.TextBox txtDepth_to_water_level;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSelectedId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

