using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix2
{
    class Matrix
    {

        public int Cols => this.matrix.GetLength(1);
        public int Rows => this.matrix.GetLength(0);
        
        //j = 0
        public double this[int i, int j] { get { return this.matrix[i, j]; }  set { this.matrix[i, j] = value; } }
        
        public double[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new double[rows, cols];
        }//end of constructor

        public Matrix add(Matrix A)
        {
            Matrix addRet = new Matrix(this.Rows, this.Cols);
            int rows = this.Rows;
            int cols = this.Cols;
            double sum = 0.0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum = A[i, j] + this[i, j];
                    addRet[i, j] = sum;
                }
                sum = 0;
            }
            return addRet;
        }//end of add

        public void clone(Matrix A)
        {
            int rows = this.Rows;
            int cols = this.Cols;

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    this.matrix[i, j] = A[i, j];
                }
            }
        }//end of clone(Matrix)

        public Matrix clone()
        {
            Matrix clone = new Matrix(this.Rows, this.Cols);
            int rows = this.Rows;
            int cols = this.Cols;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    clone[i, j] = this.matrix[i, j];
                }
            }
            return clone;
        }//end of clone

        public bool colsEqual(Matrix A)
        {
            bool colsBool = false;

            if(this.Cols == A.Cols)
            {
                colsBool = true;
            }
            return colsBool;
        }//end of colsEqual

        public bool dimsEqual(Matrix A)
        {
            return(colsEqual(A) && rowsEqual(A));
        }//ends of dimsEqual

        public override bool Equals(object obj)
        {
            bool equalBool = true;
            Matrix temp = (Matrix)obj;
            int rows = this.Rows;
            int cols = this.Cols;

            if (obj == null  && this.matrix == null)
            {
                return equalBool;
            }
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    if(temp[i, j] == this.matrix[i, j])
                    {
                        equalBool = true;
                    }
                    else
                    {
                        equalBool = false;
                    }
                }
            }
            /*if(this.colsEqual(temp) && this.rowsEqual(temp))
            {
                equalBool = true;
            }*/
            return equalBool;
        }//end of Equals

        public override int GetHashCode()
        {
            return sum().GetHashCode();
        }//end of GetHashCode

        public void makeID()
        {
            int rows = this.Rows;
            int cols = this.Cols;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j)
                    {
                        this.matrix[i, j] = 1.0;
                    }
                    else
                    {
                        this.matrix[i, j] = 0.0;
                    }
                }
            }
        }//end of makeID

        public Matrix multiply(Matrix A)
        {
            if(Equals(A, null))
            {
                throw new ArgumentNullException();
            }

            int rows = this.Rows;
            int cols = this.Cols;
            Matrix multiplyRet = new Matrix(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; i < rows; k++)
                    {
                        Matrix temp = multiplyRet;
                        int holderA = i;
                        int holderB = j;
                        temp[i, j] += this[k, i] * A[k, j];
                    }
                }
            }
            return multiplyRet;
        }//end of multiply

        public static Matrix operator -(Matrix A, Matrix B)
        {
            Matrix subtractRet = new Matrix(B.Rows, A.Cols);
            if (A.dimsEqual(B))
            {
                if ((Equals(A, null)) || (Equals(B, null)))
                {
                    subtractRet = A.subtract(B);
                }
                else
                {
                    //throw null value exception
                }
            }
            else
            {
                //throw dims not equal exception
            }
            return subtractRet;
        }//end of -

        public static Matrix operator +(Matrix A, Matrix B)
        {
            Matrix addRet = new Matrix(B.Rows, A.Cols);
            if (A.dimsEqual(B))
            {
                if((Equals(A, null)) || (Equals(B, null)))
                {
                    addRet = A.add(B); 
                }
                else
                {
                    //throw null value exception
                }
            }
            else
            {
                //throw dims not equal exception
            }
            return addRet;
        }//end of +

        public static bool operator !=(Matrix A, Matrix B)
        {
            return !(A == B);
        }//end of !=

        public static Matrix operator *(Matrix A, Matrix B)
        {
            if((A.Rows != B.Cols) || (A.Cols != B.Rows)) {
                //throw dim exception
            }
            if((Equals(A, null)) || (Equals(B, null)))
            {
                //throw null exception
            }
            return A.multiply(B);
        }//end of *

        public static bool operator ==(Matrix A, Matrix B)
        {
            if(Equals(A, null))
            {
                return Equals(B, null);
            }
            return A.Equals(B);
        }//end of ==

        public void populateOrd()
        {
            int increment = 1;

            for (int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Cols; j++)
                {
                    this.matrix[i, j] = increment;
                    increment++;
                }
            }
        }//end of populateOrd

        public void populateRand()
        {
            Random rand = new Random();

            for(int i = 0; i < this.Rows; i++)
            {
                for(int j = 0; j < this.Cols; j++)
                {
                    this.matrix[i, j] = rand.NextDouble() * 10.0;
                }
            }
        }//end of populateRand

        public bool rowsEqual(Matrix A)
        {
            bool rowsBool = false;

            if(this.Rows == A.Rows)
            {
                rowsBool = true;
            }
            return rowsBool;
        }//end of rowsEqual

        public Matrix subtract(Matrix A)
        {
            Matrix subtractRet = new Matrix(this.Rows, this.Cols);
            int rows = this.Rows;
            int cols = this.Cols;
            double difference = 0.0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    difference = this[i, j] - A[i, j];
                    subtractRet[i, j] = difference;
                }
                difference = 0;
            }
            return subtractRet;
        }//end of subtract

        public double sum()
        {
            double sum = 0;
            int cols = this.Cols;
            int rows = this.Rows;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    sum += this.matrix[i, j];
                }
            }
            return sum;
        }//end of sum

        public override string ToString()
        {
            /*StringBuilder matrixString = new StringBuilder();
            int rows = this.Rows;
            int cols = this.Cols;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrixString.Append(this.matrix[i, j]);
                    matrixString.Append("    ");
                }
                matrixString.AppendLine();
            }
            return matrixString.ToString();*/
            string retString = "";

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    retString = retString + this.matrix[i, j].ToString("F1") + "\t";
                }
                retString = retString + "\r\n";
            }
            return retString;
        }//end of ToString
    }//end of class
}//end of namespace
