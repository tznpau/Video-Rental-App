namespace Video_Rental.Forms
{
    partial class Films
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Films));
            this.cbIsAvailable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilmPrice = new System.Windows.Forms.ComboBox();
            this.tbFilmTitle = new System.Windows.Forms.TextBox();
            this.tbFilmId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgFilms = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripFilms = new System.Windows.Forms.StatusStrip();
            this.statusLabelAvailableFilms = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backToMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFilms)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStripFilms.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.FormattingEnabled = true;
            this.cbIsAvailable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsAvailable.Location = new System.Drawing.Point(193, 206);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(121, 24);
            this.cbIsAvailable.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Availability:";
            // 
            // cbFilmPrice
            // 
            this.cbFilmPrice.FormattingEnabled = true;
            this.cbFilmPrice.Items.AddRange(new object[] {
            "5.00",
            "10.00",
            "15.00",
            "20.00",
            "25.00",
            "30.00"});
            this.cbFilmPrice.Location = new System.Drawing.Point(193, 159);
            this.cbFilmPrice.Name = "cbFilmPrice";
            this.cbFilmPrice.Size = new System.Drawing.Size(121, 24);
            this.cbFilmPrice.TabIndex = 4;
            // 
            // tbFilmTitle
            // 
            this.tbFilmTitle.Location = new System.Drawing.Point(193, 113);
            this.tbFilmTitle.Name = "tbFilmTitle";
            this.tbFilmTitle.Size = new System.Drawing.Size(375, 22);
            this.tbFilmTitle.TabIndex = 4;
            // 
            // tbFilmId
            // 
            this.tbFilmId.Location = new System.Drawing.Point(193, 65);
            this.tbFilmId.Name = "tbFilmId";
            this.tbFilmId.Size = new System.Drawing.Size(121, 22);
            this.tbFilmId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film ID:";
            // 
            // dvgFilms
            // 
            this.dvgFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFilms.Location = new System.Drawing.Point(33, 265);
            this.dvgFilms.Name = "dvgFilms";
            this.dvgFilms.RowHeadersWidth = 51;
            this.dvgFilms.RowTemplate.Height = 24;
            this.dvgFilms.Size = new System.Drawing.Size(611, 199);
            this.dvgFilms.TabIndex = 5;
            this.dvgFilms.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgFilms_CellDoubleClick);
            this.dvgFilms.SelectionChanged += new System.EventHandler(this.dvgFilms_SelectionChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(353, 488);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 40);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Gold;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(448, 488);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(101, 40);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(555, 488);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 40);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(33, 488);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 40);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 100);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // statusStripFilms
            // 
            this.statusStripFilms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripFilms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelAvailableFilms});
            this.statusStripFilms.Location = new System.Drawing.Point(0, 541);
            this.statusStripFilms.Name = "statusStripFilms";
            this.statusStripFilms.Size = new System.Drawing.Size(701, 26);
            this.statusStripFilms.TabIndex = 11;
            this.statusStripFilms.Text = "statusStrip1";
            // 
            // statusLabelAvailableFilms
            // 
            this.statusLabelAvailableFilms.Name = "statusLabelAvailableFilms";
            this.statusLabelAvailableFilms.Size = new System.Drawing.Size(116, 20);
            this.statusLabelAvailableFilms.Text = "Available Films: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(701, 27);
            this.toolStrip1.TabIndex = 12;
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
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
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 567);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStripFilms);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.cbIsAvailable);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.cbFilmPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFilmTitle);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.tbFilmId);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dvgFilms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Films";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Films_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgFilms)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStripFilms.ResumeLayout(false);
            this.statusStripFilms.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilmPrice;
        private System.Windows.Forms.TextBox tbFilmTitle;
        private System.Windows.Forms.TextBox tbFilmId;
        private System.Windows.Forms.DataGridView dvgFilms;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbIsAvailable;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripFilms;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelAvailableFilms;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem backToMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}