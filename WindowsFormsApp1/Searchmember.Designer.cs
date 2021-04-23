
namespace WindowsFormsApp1
{
    partial class Searchmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searchmember));
            this.label10 = new System.Windows.Forms.Label();
            this.fname1 = new System.Windows.Forms.Label();
            this.searchid = new System.Windows.Forms.TextBox();
            this.btnSearchmem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(421, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 39);
            this.label10.TabIndex = 24;
            this.label10.Text = "ROYAL FITNESS CLUB";
            // 
            // fname1
            // 
            this.fname1.AutoSize = true;
            this.fname1.BackColor = System.Drawing.Color.Transparent;
            this.fname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname1.Location = new System.Drawing.Point(417, 70);
            this.fname1.Name = "fname1";
            this.fname1.Size = new System.Drawing.Size(67, 17);
            this.fname1.TabIndex = 26;
            this.fname1.Text = "Enter ID";
            // 
            // searchid
            // 
            this.searchid.Location = new System.Drawing.Point(544, 69);
            this.searchid.Name = "searchid";
            this.searchid.Size = new System.Drawing.Size(260, 20);
            this.searchid.TabIndex = 25;
            // 
            // btnSearchmem
            // 
            this.btnSearchmem.Location = new System.Drawing.Point(544, 115);
            this.btnSearchmem.Name = "btnSearchmem";
            this.btnSearchmem.Size = new System.Drawing.Size(176, 23);
            this.btnSearchmem.TabIndex = 27;
            this.btnSearchmem.Text = "Search Member";
            this.btnSearchmem.UseVisualStyleBackColor = true;
            this.btnSearchmem.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1142, 310);
            this.dataGridView1.TabIndex = 28;
            // 
            // Searchmember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchmem);
            this.Controls.Add(this.fname1);
            this.Controls.Add(this.searchid);
            this.Controls.Add(this.label10);
            this.Name = "Searchmember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searchmember";
            this.Load += new System.EventHandler(this.Searchmember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fname1;
        private System.Windows.Forms.TextBox searchid;
        private System.Windows.Forms.Button btnSearchmem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}