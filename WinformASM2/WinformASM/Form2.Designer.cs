namespace WinformASM
{
    partial class Form2
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
            this.lsv = new System.Windows.Forms.ListView();
            this.dSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dToC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dThisMR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dLastMR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dTB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_P = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_F = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_N = new System.Windows.Forms.TextBox();
            this.txb_LastMR = new System.Windows.Forms.TextBox();
            this.txb_ThisMR = new System.Windows.Forms.TextBox();
            this.txb_S = new System.Windows.Forms.TextBox();
            this.txb_TB = new System.Windows.Forms.TextBox();
            this.lb_S = new System.Windows.Forms.Label();
            this.lb_N = new System.Windows.Forms.Label();
            this.lb_ToC = new System.Windows.Forms.Label();
            this.lb_ThisMR = new System.Windows.Forms.Label();
            this.lb_LastMR = new System.Windows.Forms.Label();
            this.lb_TB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsv
            // 
            this.lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dSerial,
            this.dName,
            this.dToC,
            this.dThisMR,
            this.dLastMR,
            this.dTB});
            this.lsv.Font = new System.Drawing.Font("Calibri", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv.FullRowSelect = true;
            this.lsv.GridLines = true;
            this.lsv.HideSelection = false;
            this.lsv.Location = new System.Drawing.Point(2, 346);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(1001, 423);
            this.lsv.TabIndex = 0;
            this.lsv.UseCompatibleStateImageBehavior = false;
            this.lsv.View = System.Windows.Forms.View.Details;
            this.lsv.SelectedIndexChanged += new System.EventHandler(this.lsv_SelectedIndexChanged);
            // 
            // dSerial
            // 
            this.dSerial.Text = "Serial";
            this.dSerial.Width = 80;
            // 
            // dName
            // 
            this.dName.Text = "Name";
            this.dName.Width = 150;
            // 
            // dToC
            // 
            this.dToC.Text = "Type of Customer";
            this.dToC.Width = 250;
            // 
            // dThisMR
            // 
            this.dThisMR.Text = "ThisMonthReading";
            this.dThisMR.Width = 200;
            // 
            // dLastMR
            // 
            this.dLastMR.Text = "LastMonthReading";
            this.dLastMR.Width = 200;
            // 
            // dTB
            // 
            this.dTB.Text = "TotalBill";
            this.dTB.Width = 100;
            // 
            // btn_P
            // 
            this.btn_P.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P.Location = new System.Drawing.Point(157, 38);
            this.btn_P.Name = "btn_P";
            this.btn_P.Size = new System.Drawing.Size(150, 37);
            this.btn_P.TabIndex = 13;
            this.btn_P.Text = "Push";
            this.btn_P.UseVisualStyleBackColor = true;
            this.btn_P.Click += new System.EventHandler(this.btn_P_Click);
            // 
            // btn_D
            // 
            this.btn_D.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_D.Location = new System.Drawing.Point(746, 38);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(150, 37);
            this.btn_D.TabIndex = 14;
            this.btn_D.Text = "Delete";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_F
            // 
            this.btn_F.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_F.Location = new System.Drawing.Point(432, 38);
            this.btn_F.Name = "btn_F";
            this.btn_F.Size = new System.Drawing.Size(150, 37);
            this.btn_F.TabIndex = 15;
            this.btn_F.Text = "Fix";
            this.btn_F.UseVisualStyleBackColor = true;
            this.btn_F.Click += new System.EventHandler(this.btn_F_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_F);
            this.groupBox1.Controls.Add(this.btn_D);
            this.groupBox1.Controls.Add(this.btn_P);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 97);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optionals";
            // 
            // txb_N
            // 
            this.txb_N.Font = new System.Drawing.Font("Calibri", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_N.Location = new System.Drawing.Point(258, 103);
            this.txb_N.Multiline = true;
            this.txb_N.Name = "txb_N";
            this.txb_N.Size = new System.Drawing.Size(203, 36);
            this.txb_N.TabIndex = 1;
            this.txb_N.TextChanged += new System.EventHandler(this.txb_N_TextChanged);
            // 
            // txb_LastMR
            // 
            this.txb_LastMR.Font = new System.Drawing.Font("Calibri", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_LastMR.Location = new System.Drawing.Point(710, 103);
            this.txb_LastMR.Multiline = true;
            this.txb_LastMR.Name = "txb_LastMR";
            this.txb_LastMR.Size = new System.Drawing.Size(203, 36);
            this.txb_LastMR.TabIndex = 2;
            this.txb_LastMR.TextChanged += new System.EventHandler(this.tb_LastMR_TextChanged);
            // 
            // txb_ThisMR
            // 
            this.txb_ThisMR.Font = new System.Drawing.Font("Calibri", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ThisMR.Location = new System.Drawing.Point(710, 24);
            this.txb_ThisMR.Multiline = true;
            this.txb_ThisMR.Name = "txb_ThisMR";
            this.txb_ThisMR.Size = new System.Drawing.Size(203, 36);
            this.txb_ThisMR.TabIndex = 3;
            this.txb_ThisMR.TextChanged += new System.EventHandler(this.txb_ThisMR_TextChanged);
            // 
            // txb_S
            // 
            this.txb_S.Font = new System.Drawing.Font("Calibri", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_S.Location = new System.Drawing.Point(258, 24);
            this.txb_S.Multiline = true;
            this.txb_S.Name = "txb_S";
            this.txb_S.Size = new System.Drawing.Size(203, 36);
            this.txb_S.TabIndex = 5;
            this.txb_S.TextChanged += new System.EventHandler(this.txb_S_TextChanged);
            // 
            // txb_TB
            // 
            this.txb_TB.Font = new System.Drawing.Font("Calibri", 12.21429F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TB.Location = new System.Drawing.Point(710, 182);
            this.txb_TB.Multiline = true;
            this.txb_TB.Name = "txb_TB";
            this.txb_TB.Size = new System.Drawing.Size(203, 36);
            this.txb_TB.TabIndex = 6;
            this.txb_TB.TextChanged += new System.EventHandler(this.tb_TB_TextChanged);
            // 
            // lb_S
            // 
            this.lb_S.AutoSize = true;
            this.lb_S.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_S.Location = new System.Drawing.Point(182, 29);
            this.lb_S.Name = "lb_S";
            this.lb_S.Size = new System.Drawing.Size(62, 27);
            this.lb_S.TabIndex = 7;
            this.lb_S.Text = "Serial";
            // 
            // lb_N
            // 
            this.lb_N.AutoSize = true;
            this.lb_N.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_N.Location = new System.Drawing.Point(182, 108);
            this.lb_N.Name = "lb_N";
            this.lb_N.Size = new System.Drawing.Size(66, 27);
            this.lb_N.TabIndex = 8;
            this.lb_N.Text = "Name";
            // 
            // lb_ToC
            // 
            this.lb_ToC.AutoSize = true;
            this.lb_ToC.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ToC.Location = new System.Drawing.Point(56, 186);
            this.lb_ToC.Name = "lb_ToC";
            this.lb_ToC.Size = new System.Drawing.Size(173, 27);
            this.lb_ToC.TabIndex = 9;
            this.lb_ToC.Text = "Type of Customer";
            // 
            // lb_ThisMR
            // 
            this.lb_ThisMR.AutoSize = true;
            this.lb_ThisMR.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThisMR.Location = new System.Drawing.Point(487, 29);
            this.lb_ThisMR.Name = "lb_ThisMR";
            this.lb_ThisMR.Size = new System.Drawing.Size(194, 27);
            this.lb_ThisMR.TabIndex = 10;
            this.lb_ThisMR.Text = "This Month Reading";
            // 
            // lb_LastMR
            // 
            this.lb_LastMR.AutoSize = true;
            this.lb_LastMR.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastMR.Location = new System.Drawing.Point(487, 108);
            this.lb_LastMR.Name = "lb_LastMR";
            this.lb_LastMR.Size = new System.Drawing.Size(193, 27);
            this.lb_LastMR.TabIndex = 11;
            this.lb_LastMR.Text = "Last Month Reading";
            // 
            // lb_TB
            // 
            this.lb_TB.AutoSize = true;
            this.lb_TB.Font = new System.Drawing.Font("Calibri", 16.07143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TB.Location = new System.Drawing.Point(603, 187);
            this.lb_TB.Name = "lb_TB";
            this.lb_TB.Size = new System.Drawing.Size(88, 27);
            this.lb_TB.TabIndex = 12;
            this.lb_TB.Text = "Total Bill";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_Type);
            this.groupBox2.Controls.Add(this.lb_TB);
            this.groupBox2.Controls.Add(this.lb_LastMR);
            this.groupBox2.Controls.Add(this.lb_ThisMR);
            this.groupBox2.Controls.Add(this.lb_ToC);
            this.groupBox2.Controls.Add(this.lb_N);
            this.groupBox2.Controls.Add(this.lb_S);
            this.groupBox2.Controls.Add(this.txb_TB);
            this.groupBox2.Controls.Add(this.txb_S);
            this.groupBox2.Controls.Add(this.txb_ThisMR);
            this.groupBox2.Controls.Add(this.txb_LastMR);
            this.groupBox2.Controls.Add(this.txb_N);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 237);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "HouseHold",
            "Business",
            "Admin",
            "Produc"});
            this.cb_Type.Location = new System.Drawing.Point(258, 183);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(203, 31);
            this.cb_Type.TabIndex = 13;
            this.cb_Type.SelectedIndexChanged += new System.EventHandler(this.cb_Type_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 781);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsv);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsv;
        private System.Windows.Forms.ColumnHeader dSerial;
        private System.Windows.Forms.ColumnHeader dName;
        private System.Windows.Forms.ColumnHeader dToC;
        private System.Windows.Forms.ColumnHeader dThisMR;
        private System.Windows.Forms.ColumnHeader dLastMR;
        private System.Windows.Forms.ColumnHeader dTB;
        private System.Windows.Forms.Button btn_P;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_F;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_N;
        private System.Windows.Forms.TextBox txb_LastMR;
        private System.Windows.Forms.TextBox txb_ThisMR;
        private System.Windows.Forms.TextBox txb_S;
        private System.Windows.Forms.TextBox txb_TB;
        private System.Windows.Forms.Label lb_S;
        private System.Windows.Forms.Label lb_N;
        private System.Windows.Forms.Label lb_ToC;
        private System.Windows.Forms.Label lb_ThisMR;
        private System.Windows.Forms.Label lb_LastMR;
        private System.Windows.Forms.Label lb_TB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_Type;
    }
}