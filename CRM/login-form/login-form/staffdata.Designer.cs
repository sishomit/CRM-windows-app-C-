namespace login_form
{
    partial class staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sgender = new System.Windows.Forms.GroupBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.staffperformance = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saddress = new System.Windows.Forms.TextBox();
            this.sage = new System.Windows.Forms.NumericUpDown();
            this.sname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stafflevel = new System.Windows.Forms.ComboBox();
            this.errorProviders = new System.Windows.Forms.ErrorProvider(this.components);
            this.sgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviders)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sgender
            // 
            this.sgender.Controls.Add(this.Male);
            this.sgender.Controls.Add(this.radioButton2);
            this.sgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sgender.Location = new System.Drawing.Point(208, 238);
            this.sgender.Name = "sgender";
            this.sgender.Size = new System.Drawing.Size(267, 76);
            this.sgender.TabIndex = 38;
            this.sgender.TabStop = false;
            this.sgender.Text = "Gender";
            this.sgender.Enter += new System.EventHandler(this.d_Enter);
            this.sgender.Validating += new System.ComponentModel.CancelEventHandler(this.sgender_Validating);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(24, 42);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(52, 17);
            this.Male.TabIndex = 8;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(118, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // staffperformance
            // 
            this.staffperformance.AllowDrop = true;
            this.staffperformance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffperformance.FormattingEnabled = true;
            this.staffperformance.Items.AddRange(new object[] {
            "Fair",
            "Excellent",
            "Bad",
            "Good"});
            this.staffperformance.Location = new System.Drawing.Point(366, 399);
            this.staffperformance.Name = "staffperformance";
            this.staffperformance.Size = new System.Drawing.Size(109, 56);
            this.staffperformance.TabIndex = 34;
            this.staffperformance.SelectedIndexChanged += new System.EventHandler(this.f_SelectedIndexChanged);
            this.staffperformance.Validating += new System.ComponentModel.CancelEventHandler(this.staffperformance_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Staff Performance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Staff Level";
            // 
            // saddress
            // 
            this.saddress.Location = new System.Drawing.Point(323, 179);
            this.saddress.Multiline = true;
            this.saddress.Name = "saddress";
            this.saddress.Size = new System.Drawing.Size(152, 53);
            this.saddress.TabIndex = 30;
            this.saddress.Validating += new System.ComponentModel.CancelEventHandler(this.saddress_Validating);
            // 
            // sage
            // 
            this.sage.Location = new System.Drawing.Point(323, 139);
            this.sage.Name = "sage";
            this.sage.Size = new System.Drawing.Size(152, 20);
            this.sage.TabIndex = 29;
            this.sage.ValueChanged += new System.EventHandler(this.sage_ValueChanged);
            this.sage.Validating += new System.ComponentModel.CancelEventHandler(this.sage_Validating);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(323, 97);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(152, 20);
            this.sname.TabIndex = 28;
            this.sname.TextChanged += new System.EventHandler(this.a_TextChanged);
            this.sname.Validating += new System.ComponentModel.CancelEventHandler(this.sname_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Accept Staff Data";
            // 
            // stafflevel
            // 
            this.stafflevel.FormattingEnabled = true;
            this.stafflevel.Items.AddRange(new object[] {
            "Low",
            "Mid",
            "High",
            "Very High"});
            this.stafflevel.Location = new System.Drawing.Point(336, 347);
            this.stafflevel.Name = "stafflevel";
            this.stafflevel.Size = new System.Drawing.Size(139, 21);
            this.stafflevel.TabIndex = 39;
            this.stafflevel.Validating += new System.ComponentModel.CancelEventHandler(this.stafflevel_Validating);
            // 
            // errorProviders
            // 
            this.errorProviders.ContainerControl = this;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.stafflevel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sgender);
            this.Controls.Add(this.staffperformance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saddress);
            this.Controls.Add(this.sage);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "staff";
            this.Text = "Staff Details";
            this.sgender.ResumeLayout(false);
            this.sgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox sgender;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox staffperformance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox saddress;
        private System.Windows.Forms.NumericUpDown sage;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stafflevel;
        private System.Windows.Forms.ErrorProvider errorProviders;
    }
}