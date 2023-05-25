namespace Video_Rental.Forms
{
    partial class Rentals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rentals));
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dpRentalDate = new System.Windows.Forms.DateTimePicker();
            this.tbRentalId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgRentals = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChooseFilm = new System.Windows.Forms.Button();
            this.buttonChooseClient = new System.Windows.Forms.Button();
            this.tbSelectedFilmId = new System.Windows.Forms.TextBox();
            this.tbSelectedClientId = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRentals)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Rented",
            "Returned",
            "Overdue"});
            this.cbStatus.Location = new System.Drawing.Point(614, 185);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 24);
            this.cbStatus.TabIndex = 13;
            // 
            // dpDueDate
            // 
            this.dpDueDate.Location = new System.Drawing.Point(614, 117);
            this.dpDueDate.Name = "dpDueDate";
            this.dpDueDate.Size = new System.Drawing.Size(200, 22);
            this.dpDueDate.TabIndex = 12;
            // 
            // dpRentalDate
            // 
            this.dpRentalDate.Location = new System.Drawing.Point(614, 70);
            this.dpRentalDate.Name = "dpRentalDate";
            this.dpRentalDate.Size = new System.Drawing.Size(200, 22);
            this.dpRentalDate.TabIndex = 11;
            // 
            // tbRentalId
            // 
            this.tbRentalId.Location = new System.Drawing.Point(146, 71);
            this.tbRentalId.Name = "tbRentalId";
            this.tbRentalId.Size = new System.Drawing.Size(121, 22);
            this.tbRentalId.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rental Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rental Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rental ID:";
            // 
            // dvgRentals
            // 
            this.dvgRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRentals.Location = new System.Drawing.Point(54, 286);
            this.dvgRentals.Name = "dvgRentals";
            this.dvgRentals.RowHeadersWidth = 51;
            this.dvgRentals.RowTemplate.Height = 24;
            this.dvgRentals.Size = new System.Drawing.Size(807, 213);
            this.dvgRentals.TabIndex = 1;
            this.dvgRentals.SelectionChanged += new System.EventHandler(this.dvgRentals_SelectionChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(54, 532);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 40);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(563, 532);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 40);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Gold;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(658, 532);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(108, 40);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(772, 532);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 40);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChooseFilm
            // 
            this.buttonChooseFilm.BackColor = System.Drawing.Color.IndianRed;
            this.buttonChooseFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseFilm.Location = new System.Drawing.Point(54, 127);
            this.buttonChooseFilm.Name = "buttonChooseFilm";
            this.buttonChooseFilm.Size = new System.Drawing.Size(188, 34);
            this.buttonChooseFilm.TabIndex = 18;
            this.buttonChooseFilm.Text = "Choose Film";
            this.buttonChooseFilm.UseVisualStyleBackColor = false;
            this.buttonChooseFilm.Click += new System.EventHandler(this.buttonChooseFilm_Click);
            // 
            // buttonChooseClient
            // 
            this.buttonChooseClient.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonChooseClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseClient.Location = new System.Drawing.Point(54, 176);
            this.buttonChooseClient.Name = "buttonChooseClient";
            this.buttonChooseClient.Size = new System.Drawing.Size(188, 34);
            this.buttonChooseClient.TabIndex = 19;
            this.buttonChooseClient.Text = "Choose Client";
            this.buttonChooseClient.UseVisualStyleBackColor = false;
            this.buttonChooseClient.Click += new System.EventHandler(this.buttonChooseClient_Click);
            // 
            // tbSelectedFilmId
            // 
            this.tbSelectedFilmId.Location = new System.Drawing.Point(273, 138);
            this.tbSelectedFilmId.Name = "tbSelectedFilmId";
            this.tbSelectedFilmId.Size = new System.Drawing.Size(100, 22);
            this.tbSelectedFilmId.TabIndex = 20;
            // 
            // tbSelectedClientId
            // 
            this.tbSelectedClientId.Location = new System.Drawing.Point(273, 188);
            this.tbSelectedClientId.Name = "tbSelectedClientId";
            this.tbSelectedClientId.Size = new System.Drawing.Size(100, 22);
            this.tbSelectedClientId.TabIndex = 21;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 31);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMenuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // backToMenuToolStripMenuItem
            // 
            this.backToMenuToolStripMenuItem.Name = "backToMenuToolStripMenuItem";
            this.backToMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToMenuToolStripMenuItem.Text = "Back To Menu";
            this.backToMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMenuToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 606);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbSelectedClientId);
            this.Controls.Add(this.tbSelectedFilmId);
            this.Controls.Add(this.buttonChooseClient);
            this.Controls.Add(this.buttonChooseFilm);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.dpDueDate);
            this.Controls.Add(this.dpRentalDate);
            this.Controls.Add(this.tbRentalId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dvgRentals);
            this.Controls.Add(this.label1);
            this.Name = "Rentals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentals";
            this.Load += new System.EventHandler(this.Rentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRentals)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dpDueDate;
        private System.Windows.Forms.DateTimePicker dpRentalDate;
        private System.Windows.Forms.TextBox tbRentalId;
        private System.Windows.Forms.DataGridView dvgRentals;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChooseFilm;
        private System.Windows.Forms.Button buttonChooseClient;
        private System.Windows.Forms.TextBox tbSelectedFilmId;
        private System.Windows.Forms.TextBox tbSelectedClientId;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}