
namespace WindowsFormsApp1
{
    partial class deletemember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletemember));
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndeletemem = new System.Windows.Forms.Button();
            this.fname1 = new System.Windows.Forms.Label();
            this.deleteid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(407, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 39);
            this.label10.TabIndex = 25;
            this.label10.Text = "ROYAL FITNESS CLUB";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 310);
            this.dataGridView1.TabIndex = 32;
            // 
            // btndeletemem
            // 
            this.btndeletemem.Location = new System.Drawing.Point(553, 141);
            this.btndeletemem.Name = "btndeletemem";
            this.btndeletemem.Size = new System.Drawing.Size(176, 23);
            this.btndeletemem.TabIndex = 31;
            this.btndeletemem.Text = "Delete Member";
            this.btndeletemem.UseVisualStyleBackColor = true;
            this.btndeletemem.Click += new System.EventHandler(this.btndeletemem_Click);
            // 
            // fname1
            // 
            this.fname1.AutoSize = true;
            this.fname1.BackColor = System.Drawing.Color.Transparent;
            this.fname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname1.Location = new System.Drawing.Point(426, 96);
            this.fname1.Name = "fname1";
            this.fname1.Size = new System.Drawing.Size(67, 17);
            this.fname1.TabIndex = 30;
            this.fname1.Text = "Enter ID";
            // 
            // deleteid
            // 
            this.deleteid.Location = new System.Drawing.Point(553, 95);
            this.deleteid.Name = "deleteid";
            this.deleteid.Size = new System.Drawing.Size(260, 20);
            this.deleteid.TabIndex = 29;
            // 
            // deletemember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndeletemem);
            this.Controls.Add(this.fname1);
            this.Controls.Add(this.deleteid);
            this.Controls.Add(this.label10);
            this.Name = "deletemember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deletemember";
            this.Load += new System.EventHandler(this.deletemember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndeletemem;
        private System.Windows.Forms.Label fname1;
        private System.Windows.Forms.TextBox deleteid;
    }
}