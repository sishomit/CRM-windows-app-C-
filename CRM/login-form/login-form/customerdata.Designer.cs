namespace login_form
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.cage = new System.Windows.Forms.NumericUpDown();
            this.caddress = new System.Windows.Forms.TextBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.CheckBox();
            this.y = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cgeneralhobbies = new System.Windows.Forms.GroupBox();
            this.kk = new System.Windows.Forms.CheckBox();
            this.cgender = new System.Windows.Forms.GroupBox();
            this.cviplevel = new System.Windows.Forms.ComboBox();
            this.cinterestedproducts = new System.Windows.Forms.ListBox();
            this.errorProvidern = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cage)).BeginInit();
            this.cgeneralhobbies.SuspendLayout();
            this.cgender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidern)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accept Customer Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(369, 68);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(151, 20);
            this.cname.TabIndex = 4;
            this.cname.Validating += new System.ComponentModel.CancelEventHandler(this.cname_Validating);
            // 
            // cage
            // 
            this.cage.Location = new System.Drawing.Point(369, 105);
            this.cage.Name = "cage";
            this.cage.Size = new System.Drawing.Size(151, 20);
            this.cage.TabIndex = 6;
            this.cage.Validating += new System.ComponentModel.CancelEventHandler(this.cage_Validating);
            // 
            // caddress
            // 
            this.caddress.Location = new System.Drawing.Point(369, 131);
            this.caddress.Multiline = true;
            this.caddress.Name = "caddress";
            this.caddress.Size = new System.Drawing.Size(151, 53);
            this.caddress.TabIndex = 7;
            this.caddress.TextChanged += new System.EventHandler(this.add_TextChanged);
            this.caddress.Validating += new System.ComponentModel.CancelEventHandler(this.caddress_Validating);
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
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(118, 42);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(65, 17);
            this.Female.TabIndex = 9;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vip Level";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(179, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Interested Products";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(28, 39);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(73, 17);
            this.t.TabIndex = 18;
            this.t.Text = "Reading";
            this.t.UseVisualStyleBackColor = true;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.Location = new System.Drawing.Point(28, 62);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(113, 17);
            this.y.TabIndex = 19;
            this.y.Text = "Play Basketball";
            this.y.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(353, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cgeneralhobbies
            // 
            this.cgeneralhobbies.Controls.Add(this.kk);
            this.cgeneralhobbies.Controls.Add(this.t);
            this.cgeneralhobbies.Controls.Add(this.y);
            this.cgeneralhobbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgeneralhobbies.Location = new System.Drawing.Point(169, 445);
            this.cgeneralhobbies.Name = "cgeneralhobbies";
            this.cgeneralhobbies.Size = new System.Drawing.Size(351, 127);
            this.cgeneralhobbies.TabIndex = 22;
            this.cgeneralhobbies.TabStop = false;
            this.cgeneralhobbies.Text = "General Hobbies:";
            // 
            // kk
            // 
            this.kk.AutoSize = true;
            this.kk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kk.Location = new System.Drawing.Point(28, 85);
            this.kk.Name = "kk";
            this.kk.Size = new System.Drawing.Size(148, 17);
            this.kk.TabIndex = 20;
            this.kk.Text = "Walking and Running";
            this.kk.UseVisualStyleBackColor = true;
            // 
            // cgender
            // 
            this.cgender.Controls.Add(this.Male);
            this.cgender.Controls.Add(this.Female);
            this.cgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgender.Location = new System.Drawing.Point(183, 202);
            this.cgender.Name = "cgender";
            this.cgender.Size = new System.Drawing.Size(337, 90);
            this.cgender.TabIndex = 23;
            this.cgender.TabStop = false;
            this.cgender.Text = "Gender";
            this.cgender.Enter += new System.EventHandler(this.d_Enter);
            this.cgender.Validating += new System.ComponentModel.CancelEventHandler(this.cgender_Validating);
            // 
            // cviplevel
            // 
            this.cviplevel.FormattingEnabled = true;
            this.cviplevel.Items.AddRange(new object[] {
            "Low",
            "Mid",
            "High",
            "Very High"});
            this.cviplevel.Location = new System.Drawing.Point(369, 316);
            this.cviplevel.Name = "cviplevel";
            this.cviplevel.Size = new System.Drawing.Size(151, 21);
            this.cviplevel.TabIndex = 24;
            this.cviplevel.Validating += new System.ComponentModel.CancelEventHandler(this.cviplevel_Validating);
            // 
            // cinterestedproducts
            // 
            this.cinterestedproducts.AllowDrop = true;
            this.cinterestedproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinterestedproducts.FormattingEnabled = true;
            this.cinterestedproducts.Items.AddRange(new object[] {
            "Ball",
            "Bat",
            "Gloves",
            "Stumps"});
            this.cinterestedproducts.Location = new System.Drawing.Point(369, 375);
            this.cinterestedproducts.Name = "cinterestedproducts";
            this.cinterestedproducts.Size = new System.Drawing.Size(151, 30);
            this.cinterestedproducts.TabIndex = 14;
            this.cinterestedproducts.Validating += new System.ComponentModel.CancelEventHandler(this.cinterestedproducts_Validating);
            // 
            // errorProvidern
            // 
            this.errorProvidern.ContainerControl = this;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(816, 678);
            this.Controls.Add(this.cviplevel);
            this.Controls.Add(this.cgender);
            this.Controls.Add(this.cgeneralhobbies);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cinterestedproducts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.caddress);
            this.Controls.Add(this.cage);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Text = "Customer Details";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cage)).EndInit();
            this.cgeneralhobbies.ResumeLayout(false);
            this.cgeneralhobbies.PerformLayout();
            this.cgender.ResumeLayout(false);
            this.cgender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvidern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.NumericUpDown cage;
        private System.Windows.Forms.TextBox caddress;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox t;
        private System.Windows.Forms.CheckBox y;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox cgeneralhobbies;
        private System.Windows.Forms.GroupBox cgender;
        private System.Windows.Forms.CheckBox kk;
        private System.Windows.Forms.ComboBox cviplevel;
        private System.Windows.Forms.ListBox cinterestedproducts;
        private System.Windows.Forms.ErrorProvider errorProvidern;
    }
}