namespace ZooManagement
{
    partial class ManageAnimalsForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.animalListBx = new System.Windows.Forms.ListBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addBtn.Location = new System.Drawing.Point(35, 30);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(140, 60);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "&Add New";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(35, 130);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(140, 60);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(35, 330);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(140, 60);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "&Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(35, 430);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(140, 60);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // animalListBx
            // 
            this.animalListBx.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalListBx.FormattingEnabled = true;
            this.animalListBx.ItemHeight = 37;
            this.animalListBx.Location = new System.Drawing.Point(206, 30);
            this.animalListBx.Name = "animalListBx";
            this.animalListBx.Size = new System.Drawing.Size(656, 448);
            this.animalListBx.TabIndex = 6;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(35, 230);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(140, 60);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "&Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataSource = typeof(ZooManagement.Animal);
            // 
            // ManageAnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 526);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.animalListBx);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "ManageAnimalsForm";
            this.Text = "Zoo Animal Management System";
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button exitBtn;
        public System.Windows.Forms.ListBox animalListBx;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.Button updateBtn;
    }
}

