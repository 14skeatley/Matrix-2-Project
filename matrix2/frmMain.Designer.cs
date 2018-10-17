namespace matrix2
{
    partial class frmMain
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
            this.txtBRows = new System.Windows.Forms.TextBox();
            this.txtACols = new System.Windows.Forms.TextBox();
            this.txtBCols = new System.Windows.Forms.TextBox();
            this.txtARows = new System.Windows.Forms.TextBox();
            this.gBoxOperations = new System.Windows.Forms.GroupBox();
            this.rBtnAEqualsB = new System.Windows.Forms.RadioButton();
            this.rBtnSubtract = new System.Windows.Forms.RadioButton();
            this.rBtnMultiply = new System.Windows.Forms.RadioButton();
            this.rBtnAdd = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearMatricies = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMakeBIdentity = new System.Windows.Forms.Button();
            this.btnMakeMatrixB = new System.Windows.Forms.Button();
            this.btnMakeMatrixA = new System.Windows.Forms.Button();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.lblMatrixC = new System.Windows.Forms.Label();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.txtMatrixC = new System.Windows.Forms.TextBox();
            this.txtMatrixB = new System.Windows.Forms.TextBox();
            this.txtMatrixA = new System.Windows.Forms.TextBox();
            this.btnMakeBA = new System.Windows.Forms.Button();
            this.gBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBRows
            // 
            this.txtBRows.Location = new System.Drawing.Point(256, 365);
            this.txtBRows.Name = "txtBRows";
            this.txtBRows.Size = new System.Drawing.Size(130, 26);
            this.txtBRows.TabIndex = 36;
            // 
            // txtACols
            // 
            this.txtACols.Location = new System.Drawing.Point(423, 297);
            this.txtACols.Name = "txtACols";
            this.txtACols.Size = new System.Drawing.Size(130, 26);
            this.txtACols.TabIndex = 35;
            // 
            // txtBCols
            // 
            this.txtBCols.Location = new System.Drawing.Point(423, 365);
            this.txtBCols.Name = "txtBCols";
            this.txtBCols.Size = new System.Drawing.Size(130, 26);
            this.txtBCols.TabIndex = 34;
            // 
            // txtARows
            // 
            this.txtARows.Location = new System.Drawing.Point(256, 297);
            this.txtARows.Name = "txtARows";
            this.txtARows.Size = new System.Drawing.Size(130, 26);
            this.txtARows.TabIndex = 33;
            // 
            // gBoxOperations
            // 
            this.gBoxOperations.Controls.Add(this.rBtnAEqualsB);
            this.gBoxOperations.Controls.Add(this.rBtnSubtract);
            this.gBoxOperations.Controls.Add(this.rBtnMultiply);
            this.gBoxOperations.Controls.Add(this.rBtnAdd);
            this.gBoxOperations.Location = new System.Drawing.Point(67, 428);
            this.gBoxOperations.Name = "gBoxOperations";
            this.gBoxOperations.Size = new System.Drawing.Size(406, 79);
            this.gBoxOperations.TabIndex = 32;
            this.gBoxOperations.TabStop = false;
            this.gBoxOperations.Text = "Select Operation";
            // 
            // rBtnAEqualsB
            // 
            this.rBtnAEqualsB.AutoSize = true;
            this.rBtnAEqualsB.Location = new System.Drawing.Point(319, 43);
            this.rBtnAEqualsB.Name = "rBtnAEqualsB";
            this.rBtnAEqualsB.Size = new System.Drawing.Size(74, 24);
            this.rBtnAEqualsB.TabIndex = 15;
            this.rBtnAEqualsB.Text = "A==B";
            this.rBtnAEqualsB.UseVisualStyleBackColor = true;
            // 
            // rBtnSubtract
            // 
            this.rBtnSubtract.AutoSize = true;
            this.rBtnSubtract.Location = new System.Drawing.Point(218, 43);
            this.rBtnSubtract.Name = "rBtnSubtract";
            this.rBtnSubtract.Size = new System.Drawing.Size(95, 24);
            this.rBtnSubtract.TabIndex = 14;
            this.rBtnSubtract.Text = "Subtract";
            this.rBtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rBtnMultiply
            // 
            this.rBtnMultiply.AutoSize = true;
            this.rBtnMultiply.Location = new System.Drawing.Point(20, 43);
            this.rBtnMultiply.Name = "rBtnMultiply";
            this.rBtnMultiply.Size = new System.Drawing.Size(86, 24);
            this.rBtnMultiply.TabIndex = 12;
            this.rBtnMultiply.Text = "Multiply";
            this.rBtnMultiply.UseVisualStyleBackColor = true;
            this.rBtnMultiply.CheckedChanged += new System.EventHandler(this.rBtnMultiply_CheckedChanged);
            // 
            // rBtnAdd
            // 
            this.rBtnAdd.AutoSize = true;
            this.rBtnAdd.Location = new System.Drawing.Point(132, 43);
            this.rBtnAdd.Name = "rBtnAdd";
            this.rBtnAdd.Size = new System.Drawing.Size(63, 24);
            this.rBtnAdd.TabIndex = 13;
            this.rBtnAdd.Text = "Add";
            this.rBtnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(67, 538);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 36);
            this.btnCalculate.TabIndex = 31;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearMatricies
            // 
            this.btnClearMatricies.Location = new System.Drawing.Point(326, 538);
            this.btnClearMatricies.Name = "btnClearMatricies";
            this.btnClearMatricies.Size = new System.Drawing.Size(130, 36);
            this.btnClearMatricies.TabIndex = 30;
            this.btnClearMatricies.Text = "Clear &Matricies";
            this.btnClearMatricies.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(584, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 36);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMakeBIdentity
            // 
            this.btnMakeBIdentity.Location = new System.Drawing.Point(574, 361);
            this.btnMakeBIdentity.Name = "btnMakeBIdentity";
            this.btnMakeBIdentity.Size = new System.Drawing.Size(161, 35);
            this.btnMakeBIdentity.TabIndex = 28;
            this.btnMakeBIdentity.Text = "Make B Identity";
            this.btnMakeBIdentity.UseVisualStyleBackColor = true;
            this.btnMakeBIdentity.Click += new System.EventHandler(this.btnMakeBIdentity_Click);
            // 
            // btnMakeMatrixB
            // 
            this.btnMakeMatrixB.Location = new System.Drawing.Point(67, 361);
            this.btnMakeMatrixB.Name = "btnMakeMatrixB";
            this.btnMakeMatrixB.Size = new System.Drawing.Size(130, 35);
            this.btnMakeMatrixB.TabIndex = 27;
            this.btnMakeMatrixB.Text = "Make Matrix B";
            this.btnMakeMatrixB.UseVisualStyleBackColor = true;
            this.btnMakeMatrixB.Click += new System.EventHandler(this.btnMakeMatrixB_Click);
            // 
            // btnMakeMatrixA
            // 
            this.btnMakeMatrixA.Location = new System.Drawing.Point(67, 293);
            this.btnMakeMatrixA.Name = "btnMakeMatrixA";
            this.btnMakeMatrixA.Size = new System.Drawing.Size(130, 35);
            this.btnMakeMatrixA.TabIndex = 26;
            this.btnMakeMatrixA.Text = "Make Matrix A";
            this.btnMakeMatrixA.UseVisualStyleBackColor = true;
            this.btnMakeMatrixA.Click += new System.EventHandler(this.btnMakeMatrixA_Click);
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(276, 69);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(66, 20);
            this.lblMatrixB.TabIndex = 25;
            this.lblMatrixB.Text = "Matrix B";
            // 
            // lblMatrixC
            // 
            this.lblMatrixC.AutoSize = true;
            this.lblMatrixC.Location = new System.Drawing.Point(487, 69);
            this.lblMatrixC.Name = "lblMatrixC";
            this.lblMatrixC.Size = new System.Drawing.Size(66, 20);
            this.lblMatrixC.TabIndex = 24;
            this.lblMatrixC.Text = "Matrix C";
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(63, 69);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(66, 20);
            this.lblMatrixA.TabIndex = 23;
            this.lblMatrixA.Text = "Matrix A";
            // 
            // txtMatrixC
            // 
            this.txtMatrixC.Location = new System.Drawing.Point(491, 98);
            this.txtMatrixC.Multiline = true;
            this.txtMatrixC.Name = "txtMatrixC";
            this.txtMatrixC.ReadOnly = true;
            this.txtMatrixC.Size = new System.Drawing.Size(223, 150);
            this.txtMatrixC.TabIndex = 22;
            // 
            // txtMatrixB
            // 
            this.txtMatrixB.Location = new System.Drawing.Point(280, 98);
            this.txtMatrixB.Multiline = true;
            this.txtMatrixB.Name = "txtMatrixB";
            this.txtMatrixB.ReadOnly = true;
            this.txtMatrixB.Size = new System.Drawing.Size(193, 150);
            this.txtMatrixB.TabIndex = 21;
            // 
            // txtMatrixA
            // 
            this.txtMatrixA.Location = new System.Drawing.Point(67, 98);
            this.txtMatrixA.Multiline = true;
            this.txtMatrixA.Name = "txtMatrixA";
            this.txtMatrixA.ReadOnly = true;
            this.txtMatrixA.Size = new System.Drawing.Size(195, 150);
            this.txtMatrixA.TabIndex = 20;
            // 
            // btnMakeBA
            // 
            this.btnMakeBA.Location = new System.Drawing.Point(574, 293);
            this.btnMakeBA.Name = "btnMakeBA";
            this.btnMakeBA.Size = new System.Drawing.Size(161, 35);
            this.btnMakeBA.TabIndex = 37;
            this.btnMakeBA.Text = "Make B Copy of A";
            this.btnMakeBA.UseVisualStyleBackColor = true;
            this.btnMakeBA.Click += new System.EventHandler(this.btnMakeBA_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(765, 639);
            this.Controls.Add(this.btnMakeBA);
            this.Controls.Add(this.txtBRows);
            this.Controls.Add(this.txtACols);
            this.Controls.Add(this.txtBCols);
            this.Controls.Add(this.txtARows);
            this.Controls.Add(this.gBoxOperations);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClearMatricies);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMakeBIdentity);
            this.Controls.Add(this.btnMakeMatrixB);
            this.Controls.Add(this.btnMakeMatrixA);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixC);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.txtMatrixC);
            this.Controls.Add(this.txtMatrixB);
            this.Controls.Add(this.txtMatrixA);
            this.Name = "frmMain";
            this.Text = "Matrix Ops With Objects";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gBoxOperations.ResumeLayout(false);
            this.gBoxOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBRows;
        private System.Windows.Forms.TextBox txtACols;
        private System.Windows.Forms.TextBox txtBCols;
        private System.Windows.Forms.TextBox txtARows;
        private System.Windows.Forms.GroupBox gBoxOperations;
        private System.Windows.Forms.RadioButton rBtnSubtract;
        private System.Windows.Forms.RadioButton rBtnMultiply;
        private System.Windows.Forms.RadioButton rBtnAdd;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearMatricies;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMakeBIdentity;
        private System.Windows.Forms.Button btnMakeMatrixB;
        private System.Windows.Forms.Button btnMakeMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.Label lblMatrixC;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.TextBox txtMatrixC;
        private System.Windows.Forms.TextBox txtMatrixB;
        private System.Windows.Forms.TextBox txtMatrixA;
        private System.Windows.Forms.RadioButton rBtnAEqualsB;
        private System.Windows.Forms.Button btnMakeBA;
    }
}

