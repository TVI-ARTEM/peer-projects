using System;
using static System.Console;

namespace CalcMatrix
{
    /// <summary>
    /// Class matrix with own properties and methods.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Create random number.
        /// </summary>
        private static readonly Random Rand = new Random();

        /// <summary>
        /// Minimum bound for generating numbers.
        /// </summary>
        private const int MinRandom = -10;

        /// <summary>
        /// Maximum bound for generating numbers.
        /// </summary>
        private const int MaxRandom = 11;

        /// <summary>
        /// Number of matrix lines.
        /// </summary>
        public int NumLines => Data.GetLength(0);

        /// <summary>
        /// Number of matrix columns.
        /// </summary>
        public int NumColumns => Data.GetLength(1);

        /// <summary>
        /// Data of matrix elements.
        /// </summary>
        public double[,] Data { get; set; }


        /// <summary>
        /// Matrix constructor by size of matrix.
        /// </summary>
        /// <param name="numLines">Number of lines.</param>
        /// <param name="numColumns">Number of lines.</param>
        public Matrix(int numLines, int numColumns)
        {
            Data = new double[numLines, numColumns];
        }

        /// <summary>
        /// Matrix constructor by data of matrix.
        /// </summary>
        /// <param name="data">Data of matrix elements.</param>
        public Matrix(double[,] data)
        {
            Data = data;
        }


        /// <summary>
        /// Fill matrix random data.
        /// </summary>
        public void FillWithRandomData()
        {
            // Fill each element random number.
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = 0; j < NumColumns; j++)
                {
                    Data[i, j] = Math.Round(Rand.NextDouble() * (MaxRandom - MinRandom) + MinRandom, 2);
                }
            }
        }


        /// <summary>
        /// Calculate square matrix trace.
        /// </summary>
        /// <returns>Matrix trace.</returns>
        public double CalculateTrace()
        {
            // Print error.
            if (NumLines != NumColumns)
            {
                throw new Exception("Matrix is not square.");
            }

            double trace = 0;
            // Calculate trace.
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = 0; j < NumColumns; j++)
                {
                    if (i == j)
                    {
                        trace += Data[i, j];
                    }
                }
            }

            return trace;
        }

        /// <summary>
        /// Calculate square matrix determinant.
        /// </summary>
        /// <returns>Matrix determinant.</returns>
        public double CalculateDeterminant()
        {
            // Print error.
            if (NumLines != NumColumns)
            {
                throw new Exception("Matrix is not square.");
            }

            // Transform matrix to stepped view.
            var steppedDataView = TransformToSteppedDataViewInternal();

            double determinant = 1;
            // Calculate determinant.
            for (var i = 0; i < steppedDataView.GetLength(0); i++)
            {
                for (var j = 0; j < steppedDataView.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        determinant *= steppedDataView[i, j];
                    }
                }
            }

            return determinant;
        }


        /// <summary>
        /// Transpose matrix.
        /// </summary>
        public void Transpose()
        {
            var transposeData = new double[NumColumns, NumLines];

            // Transpose matrix.
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = 0; j < NumColumns; j++)
                {
                    transposeData[j, i] = Data[i, j];
                }
            }

            Data = transposeData;
        }


        /// <summary>
        /// Transform matrix to stepped canonical view.
        /// </summary>
        public void TransformToSteppedCanonicalDataView()
        {
            Data = TransformToSteppedCanonicalDataViewInternal();
        }

        /// <summary>
        /// Internal method to transform matrix to stepped canonical view.
        /// </summary>
        /// <returns>Changed matrix data.</returns>
        private double[,] TransformToSteppedCanonicalDataViewInternal()
        {
            var steppedDataView = (double[,]) Data.Clone();
            var indexOfLeader = 0;
            // Transform matrix by Gaussian method
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = 0; j < NumLines; j++)
                {
                    var quotient = steppedDataView[i, indexOfLeader];

                    for (var k = indexOfLeader; k < NumColumns; k++)
                    {
                        steppedDataView[i, k] = quotient != 0 ? steppedDataView[i, k] / quotient : 0;
                        if (j == indexOfLeader)
                        {
                            continue;
                        }

                        steppedDataView[j, k] -= steppedDataView[i, k] * steppedDataView[j, indexOfLeader];
                    }
                }

                if (indexOfLeader < NumColumns - 1)
                {
                    indexOfLeader++;
                }
            }

            return steppedDataView;
        }

        /// <summary>
        /// Internal method to transform matrix to stepped view.
        /// </summary>
        /// <returns>Changed matrix data.</returns>
        private double[,] TransformToSteppedDataViewInternal()
        {
            var steppedDataView = (double[,]) Data.Clone();

            // Transform matrix by Gaussian method
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = i + 1; j < NumLines; j++)
                {
                    var quotient = steppedDataView[j, i] / steppedDataView[i, i];
                    for (var k = i; k < NumColumns; k++)
                    {
                        steppedDataView[j, k] -= steppedDataView[i, k] * quotient;
                    }
                }
            }

            return steppedDataView;
        }


        /// <summary>
        /// Matrix output to console.
        /// </summary>
        public void Print()
        {
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = 0; j < NumColumns; j++)
                {
                    Write($"{Data[i, j],11:F2}");
                }

                WriteLine();
            }

            WriteLine();
        }


        /// <summary>
        /// Matrix multiplication by number.
        /// </summary>
        /// <param name="number">The number by which the matrix is ​​multiplied.</param>
        public void Multiply(double number)
        {
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = 0; j < NumColumns; j++)
                {
                    Data[i, j] *= number;
                }
            }
        }

        /// <summary>
        /// Multiplication of two matrices.
        /// </summary>
        /// <param name="matrixFirst">First matrix.</param>
        /// <param name="matrixSecond">Second matrix.</param>
        /// <returns>Result matrix of multiplication of two matrices.</returns>
        public static Matrix Multiply(Matrix matrixFirst, Matrix matrixSecond)
        {
            // Error message.
            if (matrixFirst.NumColumns != matrixSecond.NumLines)
            {
                throw new Exception("Matrix product is impossible!");
            }

            var resultMatrix = new Matrix(matrixFirst.NumLines, matrixSecond.NumColumns);

            // Multiplication of two matrices.
            for (var i = 0; i < resultMatrix.NumLines; i++)
            {
                for (var j = 0; j < resultMatrix.NumColumns; j++)
                {
                    for (var k = 0; k < matrixFirst.NumColumns; k++)
                    {
                        resultMatrix.Data[i, j] += matrixFirst.Data[i, k] * matrixSecond.Data[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        /// <summary>
        /// Adding two matrices.
        /// </summary>
        /// <param name="matrixFirst">First matrix.</param>
        /// <param name="matrixSecond">Second matrix.</param>
        /// <returns>Result of adding two matrices.</returns>
        public static Matrix Add(Matrix matrixFirst, Matrix matrixSecond)
        {
            // Error message.
            if (matrixFirst.NumLines != matrixSecond.NumLines ||
                matrixFirst.NumColumns != matrixSecond.NumColumns)
            {
                throw new Exception("Matrix addition is impossible!");
            }

            var resultMatrix = new Matrix(matrixFirst.NumLines, matrixFirst.NumColumns);
            // Adding two matrices.
            for (var i = 0; i < resultMatrix.NumLines; i++)
            {
                for (var j = 0; j < resultMatrix.NumColumns; j++)
                {
                    resultMatrix.Data[i, j] = matrixFirst.Data[i, j] + matrixSecond.Data[i, j];
                }
            }

            return resultMatrix;
        }

        /// <summary>
        /// Subtraction of two matrices.
        /// </summary>
        /// <param name="matrixFirst">First matrix.</param>
        /// <param name="matrixSecond">Second matrix.</param>
        /// <returns>Result matrix of subtraction of two matrices.</returns>
        public static Matrix Subtract(Matrix matrixFirst, Matrix matrixSecond)
        {
            // Error message.
            if (matrixFirst.NumLines != matrixSecond.NumLines ||
                matrixFirst.NumColumns != matrixSecond.NumColumns)
            {
                throw new Exception("Matrix subtraction is impossible!");
            }

            var resultMatrix = new Matrix(matrixFirst.NumLines, matrixFirst.NumColumns);

            //Subtraction of two matrices.
            for (var i = 0; i < resultMatrix.NumLines; i++)
            {
                for (var j = 0; j < resultMatrix.NumColumns; j++)
                {
                    resultMatrix.Data[i, j] = matrixFirst.Data[i, j] - matrixSecond.Data[i, j];
                }
            }

            return resultMatrix;
        }


        /// <summary>
        /// Resolve system of linear equations and print it and its solution.
        /// </summary>
        public void SystemOfLineEquations()
        {
            // Error message.
            if (NumLines != NumColumns - 1)
            {
                throw new Exception(
                    "It is impossible to solve the System of Linear Equations - \nthe number of variables is not equal to the number of lines");
            }

            var solution = ResolveSLE();

            PrintSLE(solution);
        }

        /// <summary>
        /// Resolve system of linear equations.
        /// </summary>
        /// <returns>Solution of system of linear equations.</returns>
        private double[] ResolveSLE()
        {
            // Transform matrix to stepped canonical view by Gaussian method. 
            var steppedCanonicalDataView = TransformToSteppedCanonicalDataViewInternal();

            var solution = new double[NumLines];
            // Getting a solution of SLE.
            for (var i = 0; i < solution.Length; i++)
            {
                solution[i] = steppedCanonicalDataView[i, NumColumns - 1];
            }

            return solution;
        }

        /// <summary>
        /// Console display of a system of linear equations and its solution.
        /// </summary>
        /// <param name="solution">Solution of SLE.</param>
        private void PrintSLE(double[] solution)
        {
            ForegroundColor = ConsoleColor.Cyan;
            // Display SLE.
            for (var i = 0; i < NumLines; i++)
            {
                for (var j = 0; j < NumColumns; j++)
                {
                    if (j == NumColumns - 1)
                    {
                        Write($" = {Data[i, j]:F2}");
                        break;
                    }

                    Write($"{(char)('A' + j)}*({Data[i, j]:F2})");

                    if (j != NumColumns - 2)
                    {
                        Write(" + ");
                    }
                }

                WriteLine();
            }

            // Display SLE's solution.
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            Write("Solution of SLE: ");

            foreach (var variable in solution)
            {
                Write($"{variable:F2}; ");
            }
        }
    }
}