namespace ZooManagement
{
    partial class AddAnimalForm
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
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.speciesTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.speciesLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.locationLbl = new System.Windows.Forms.Label();
            this.locationComboBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(332, 293);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(90, 29);
            this.maleRadio.TabIndex = 0;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(332, 339);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(114, 29);
            this.femaleRadio.TabIndex = 1;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(48, 92);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(398, 31);
            this.nameTxtBx.TabIndex = 2;
            // 
            // speciesTxtBx
            // 
            this.speciesTxtBx.Location = new System.Drawing.Point(48, 193);
            this.speciesTxtBx.Name = "speciesTxtBx";
            this.speciesTxtBx.Size = new System.Drawing.Size(398, 31);
            this.speciesTxtBx.TabIndex = 3;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(43, 44);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(68, 25);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Name";
            // 
            // speciesLbl
            // 
            this.speciesLbl.AutoSize = true;
            this.speciesLbl.Location = new System.Drawing.Point(43, 152);
            this.speciesLbl.Name = "speciesLbl";
            this.speciesLbl.Size = new System.Drawing.Size(89, 25);
            this.speciesLbl.TabIndex = 5;
            this.speciesLbl.Text = "Species";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(296, 446);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 60);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(48, 446);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 60);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "&Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(43, 293);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(196, 25);
            this.locationLbl.TabIndex = 8;
            this.locationLbl.Text = "Enclosure Location";
            // 
            // locationComboBx
            // 
            this.locationComboBx.FormattingEnabled = true;
            this.locationComboBx.Location = new System.Drawing.Point(48, 335);
            this.locationComboBx.Name = "locationComboBx";
            this.locationComboBx.Size = new System.Drawing.Size(186, 33);
            this.locationComboBx.TabIndex = 12;
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 526);
            this.Controls.Add(this.locationComboBx);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.speciesLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.speciesTxtBx);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Name = "AddAnimalForm";
            this.Text = "AddAnimalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.TextBox nameTxtBx;
        private System.Windows.Forms.TextBox speciesTxtBx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label speciesLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.ComboBox locationComboBx;
    }
}