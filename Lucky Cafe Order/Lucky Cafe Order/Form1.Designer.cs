namespace Lucky_Cafe_Order
{
    partial class LuckyCafeOrder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbldef = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStudentMember = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoJuice = new System.Windows.Forms.RadioButton();
            this.rdoCoffee = new System.Windows.Forms.RadioButton();
            this.rdoTea = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstOrderList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLucky = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lucky Cafe Order";
            // 
            // lbldef
            // 
            this.lbldef.AutoSize = true;
            this.lbldef.Location = new System.Drawing.Point(6, 61);
            this.lbldef.Name = "lbldef";
            this.lbldef.Size = new System.Drawing.Size(308, 20);
            this.lbldef.TabIndex = 1;
            this.lbldef.Text = "Midterm Project - Design your form like this";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.chkStudentMember);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblOrder);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(10, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 358);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // chkStudentMember
            // 
            this.chkStudentMember.AutoSize = true;
            this.chkStudentMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStudentMember.Location = new System.Drawing.Point(210, 265);
            this.chkStudentMember.Name = "chkStudentMember";
            this.chkStudentMember.Size = new System.Drawing.Size(226, 24);
            this.chkStudentMember.TabIndex = 6;
            this.chkStudentMember.Text = "Student Member (10% Off)";
            this.chkStudentMember.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(102, 265);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(80, 28);
            this.txtQuantity.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(10, 269);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(72, 20);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(26, 114);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(98, 22);
            this.lblOrder.TabIndex = 3;
            this.lblOrder.Text = "Drink Type";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoJuice);
            this.panel1.Controls.Add(this.rdoCoffee);
            this.panel1.Controls.Add(this.rdoTea);
            this.panel1.Location = new System.Drawing.Point(13, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 125);
            this.panel1.TabIndex = 2;
            // 
            // rdoJuice
            // 
            this.rdoJuice.AutoSize = true;
            this.rdoJuice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoJuice.ForeColor = System.Drawing.Color.Black;
            this.rdoJuice.Location = new System.Drawing.Point(17, 84);
            this.rdoJuice.Name = "rdoJuice";
            this.rdoJuice.Size = new System.Drawing.Size(103, 24);
            this.rdoJuice.TabIndex = 2;
            this.rdoJuice.TabStop = true;
            this.rdoJuice.Text = "Juice ($3)";
            this.rdoJuice.UseVisualStyleBackColor = true;
            // 
            // rdoCoffee
            // 
            this.rdoCoffee.AutoSize = true;
            this.rdoCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCoffee.ForeColor = System.Drawing.Color.Black;
            this.rdoCoffee.Location = new System.Drawing.Point(17, 54);
            this.rdoCoffee.Name = "rdoCoffee";
            this.rdoCoffee.Size = new System.Drawing.Size(114, 24);
            this.rdoCoffee.TabIndex = 1;
            this.rdoCoffee.TabStop = true;
            this.rdoCoffee.Text = "Coffee ($2)";
            this.rdoCoffee.UseVisualStyleBackColor = true;
            // 
            // rdoTea
            // 
            this.rdoTea.AutoSize = true;
            this.rdoTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTea.ForeColor = System.Drawing.Color.Black;
            this.rdoTea.Location = new System.Drawing.Point(17, 24);
            this.rdoTea.Name = "rdoTea";
            this.rdoTea.Size = new System.Drawing.Size(93, 24);
            this.rdoTea.TabIndex = 0;
            this.rdoTea.TabStop = true;
            this.rdoTea.Text = "Tea ($1)";
            this.rdoTea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(11, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(463, 28);
            this.txtName.TabIndex = 0;
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.ForeColor = System.Drawing.Color.Navy;
            this.lblOrderList.Location = new System.Drawing.Point(568, 108);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(99, 22);
            this.lblOrderList.TabIndex = 4;
            this.lblOrderList.Text = "Order List";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(10, 485);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(240, 47);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate Order";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(236, 47);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save To File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLoadFromFile.Location = new System.Drawing.Point(565, 485);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(216, 47);
            this.btnLoadFromFile.TabIndex = 7;
            this.btnLoadFromFile.Text = "Load From File";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClear.Location = new System.Drawing.Point(812, 486);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 47);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstOrderList
            // 
            this.lstOrderList.FormattingEnabled = true;
            this.lstOrderList.ItemHeight = 20;
            this.lstOrderList.Location = new System.Drawing.Point(565, 135);
            this.lstOrderList.Name = "lstOrderList";
            this.lstOrderList.Size = new System.Drawing.Size(489, 324);
            this.lstOrderList.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.lblLucky);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Location = new System.Drawing.Point(6, 564);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 133);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lblLucky
            // 
            this.lblLucky.AutoSize = true;
            this.lblLucky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLucky.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblLucky.Location = new System.Drawing.Point(20, 69);
            this.lblLucky.Name = "lblLucky";
            this.lblLucky.Size = new System.Drawing.Size(156, 25);
            this.lblLucky.TabIndex = 1;
            this.lblLucky.Text = "Lucky Message:";
            this.lblLucky.Click += new System.EventHandler(this.lblLucky_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Navy;
            this.lblTotal.Location = new System.Drawing.Point(18, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(129, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Price: ";
            // 
            // LuckyCafeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1123, 721);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstOrderList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblOrderList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbldef);
            this.Controls.Add(this.lblTitle);
            this.Name = "LuckyCafeOrder";
            this.Text = "Lucky Cafe Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbldef;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.RadioButton rdoJuice;
        private System.Windows.Forms.RadioButton rdoCoffee;
        private System.Windows.Forms.RadioButton rdoTea;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.CheckBox chkStudentMember;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstOrderList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLucky;
    }
}

