using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix2
{
    public partial class frmMain : Form
    {
        private Matrix A;
        private Matrix B;
        private Matrix C;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rBtnMultiply.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (this.rBtnMultiply.Checked)
            {
                this.C = this.A * this.B;
                this.txtMatrixC.Text = this.C.ToString();
            }
            else if (this.rBtnAdd.Checked)
            {
                this.C = this.A + this.B;
                this.txtMatrixC.Text = this.C.ToString();
            }
            else if(this.rBtnSubtract.Checked)
            {
                this.C = this.A - this.B;
                this.txtMatrixC.Text = this.C.ToString();
            }
            else if (this.rBtnAEqualsB.Checked)
            {
                if(this.A == this.B)
                {
                    this.txtMatrixC.Text = "A and B are equal";
                }
                else
                {
                    this.txtMatrixC.Text = "A and B are not equal";
                }
            }
        }
        

        private void btnMakeMatrixA_Click(object sender, EventArgs e)
        {
            int rowsA = Convert.ToInt32(this.txtARows.Text);
            int colsA = Convert.ToInt32(this.txtACols.Text);

            this.A = new Matrix(rowsA, colsA);
            this.A.populateRand();
            this.txtMatrixA.Text = this.A.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMakeMatrixB_Click(object sender, EventArgs e)
        {
            int rowsB = Convert.ToInt32(this.txtBRows.Text);
            int colsB = Convert.ToInt32(this.txtBCols.Text);

            this.B = new Matrix(rowsB, colsB);
            this.B.populateRand();
            this.txtMatrixB.Text = this.B.ToString();
        }

        private void btnMakeBIdentity_Click(object sender, EventArgs e)
        {
            int rowsB = Convert.ToInt32(this.txtBRows.Text);
            int colsB = Convert.ToInt32(this.txtBCols.Text);

            this.B = new Matrix(rowsB, colsB);
            this.B.makeID();
            this.txtMatrixB.Text = this.B.ToString();
        }

        private void btnMakeBA_Click(object sender, EventArgs e)
        {
            this.B = this.A.clone();
            this.txtMatrixB.Text = this.B.ToString();
        }

        private void rBtnMultiply_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
