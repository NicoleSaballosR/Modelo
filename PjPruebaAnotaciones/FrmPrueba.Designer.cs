namespace PjPruebaAnotaciones
{
    partial class FrmPrueba
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(200, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIDNumber.Location = new System.Drawing.Point(125, 33);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(164, 26);
            this.txtIDNumber.TabIndex = 4;
            this.txtIDNumber.Text = "9999999";
            this.txtIDNumber.TextChanged += new System.EventHandler(this.txtIDNumber_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(125, 134);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(164, 26);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.Text = "k";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(125, 81);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(164, 26);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Text = "5";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // FrmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 255);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPrueba";
            this.Text = "FrmPrueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private TextBox txtIDNumber;
        private TextBox txtLastName;
        private TextBox txtFirstName;
    }
}