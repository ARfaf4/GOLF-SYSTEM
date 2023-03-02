namespace GOLF_SYSTEM.Views
{
    partial class GolfView
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
            this.dgvGolfes = new System.Windows.Forms.DataGridView();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolfes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGolfes
            // 
            this.dgvGolfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGolfes.Location = new System.Drawing.Point(-3, -6);
            this.dgvGolfes.Name = "dgvGolfes";
            this.dgvGolfes.Size = new System.Drawing.Size(282, 177);
            this.dgvGolfes.TabIndex = 0;
            this.dgvGolfes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(583, 45);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(176, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(583, 90);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(176, 20);
            this.txtYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Golf number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(583, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add year of release:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(583, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(583, 177);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 55);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(583, 238);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 55);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GolfView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GOLF_SYSTEM.Properties.Resources.images_841x584;
            this.ClientSize = new System.Drawing.Size(825, 545);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.dgvGolfes);
            this.Name = "GolfView";
            this.Text = "GolfView";
            this.Load += new System.EventHandler(this.GolfView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGolfes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGolfes;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}