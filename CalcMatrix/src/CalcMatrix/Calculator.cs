using System;
using System.Globalization;
using System.IO;
using static System.Console;

namespace CalcMatrix
{
    /// <summary>
    /// The main class for working with matrices.
    /// </summary>
    partial class Calculator
    {
        /// <summary>
        /// Create random number.
        /// </summary>
        private static readonly Random Rand = new Random();

        /// <summary>
        /// Maximum bound number of matrix lines for creating matrix.
        /// </summary>
        private const int MAX_MATRIX_LINES = 10;

        /// <summary>
        /// Maximum bound number of matrix columns for creating matrix.
        /// </summary>
        private const int MAX_MATRIX_COLUMNS = 10;

        /// <summary>
        /// Path for saving data about created matrices.
        /// </summary>
        private const string PATH = "DATA.txt";

        /// <summary>
        /// The separator is used when saving matrices.
        /// </summary>
        private const string MATRICES_SEPARATOR = "====";


        /// <summary>
        /// The default constructor when creating a class object.
        /// </summary>
        public Calculator()
        {
            // Check file exist.
            if (File.Exists(PATH))
            {
                File.Delete(PATH);
            }

            // Creation of file and close it. 
            File.Create(PATH).Dispose();
        }


        #region Creation matrix

        /// <summary>
        /// Change matrix by different methods.
        /// </summary>
        /// <param name="matrix">Changing matrix.</param>
        /// <param name="option">Method for changing.</param>
        /// <param name="number">The number by which the matrix is ​​multiplied, if user chose multiply by number.</param>
        private static void ChangeMatrix(ref Matrix matrix, int option = 5, double number = 0)
        {
            // Changing of matrix.
            switch (option)
            {
                case 1:
                    matrix.Transpose();
                    break;
                case 2:
                    matrix.Multiply(number);
                    break;
                case 3:
                    matrix.TransformToSteppedCanonicalDataView();
                    break;
                case 4:
                    matrix.FillWithRandomData();
                    break;
                case 5:
                    matrix = MethodOfCreationMatrix();
                    break;
            }

            // Check matrix for null and save it.
            if (matrix != null)
            {
                SaveMatrix(matrix);
            }

            Clear();
        }

        /// <summary>
        /// Selection to creation the matrix.
        /// </summary>
        /// <returns>Matrix</returns>
        private static Matrix MethodOfCreationMatrix()
        {
            int userOption, lines, columns;

            // Help messages.
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Select option to create matrix.");

            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(" 1. Create random matrix.");
            WriteLine(" 2. Fill matrix random numbers.");
            WriteLine(" 3. Create matrix manually.");
            WriteLine(" 4. Read matrix from file.");
            WriteLine(" 5. Select matrix from previous.");
            WriteLine(" 6. Back to Main menu.");

            // User choice.
            do
            {
                ForegroundColor = ConsoleColor.Green;
                Write("\nSelect correct option to create matrix: ");
                ResetColor();
            } while (!int.TryParse(ReadLine(), out userOption) || userOption < 1 || userOption > 6);

            switch (userOption)
            {
                case 1:
                    return CreateMatrix(userOption);
                case 2:
                    CheckSizeOfMatrix(out lines, out columns);
                    return CreateMatrix(userOption, lines, columns);
                case 3:
                    CheckSizeOfMatrix(out lines, out columns);
                    return CreateMatrix(userOption, lines, columns);
                case 4:
                    WriteLine("Write direct path to file:");
                    return CreateMatrix(userOption, 0, 0, ReadLine());
                case 5:
                    return CreateMatrix(userOption);
                case 6:
                    return null;
            }

            return null;
        }

        /// <summary>
        /// Internal method for creation matrix.
        /// </summary>
        /// <param name="option">Method of creation.</param>
        /// <param name="lines">Number of matrix lines.</param>
        /// <param name="columns">Number of matrix columns.</param>
        /// <param name="path">Path to file containing matrices.</param>
        /// <returns>Matrix</returns>
        private static Matrix CreateMatrix(int option, int lines = MAX_MATRIX_LINES, int columns = MAX_MATRIX_COLUMNS, string path = null)
        {
            switch (option)
            {
                case 1:
                    return CreateRandomMatrix();
                case 2:
                    return CreateRandomMatrix(lines, columns);
                case 3:
                    return CreateMatrixFromInput(lines, columns);
                case 4:
                    return CreateMatrixFromFile(path);
                case 5:
                    return CreateMatrixFromFile(PATH);
                default:
                    throw new Exception("Incorrect input");
            }
        }

        #endregion

        #region Creation matrix manually and randomly

        /// <summary>
        /// Create random matrix with random size.
        /// </summary>
        /// <returns>Matrix</returns>
        private static Matrix CreateRandomMatrix()
        {
            // Generating random matrix size.
            var lines = Rand.Next(1, MAX_MATRIX_LINES + 1);
            var columns = Rand.Next(1, MAX_MATRIX_COLUMNS + 1);
            // Fill matrix by random numbers.
            return CreateRandomMatrix(lines, columns);
        }

        /// <summary>
        /// Create random matrix with given size.
        /// </summary>
        /// <param name="lines">Number of matrix lines.</param>
        /// <param name="columns">Number of matrix columns.</param>
        /// <returns>Matrix</returns>
        private static Matrix CreateRandomMatrix(int lines, int columns)
        {
            // Generating matrix by random data.
            var matrix = new Matrix(lines, columns);
            matrix.FillWithRandomData();

            return matrix;
        }

        /// <summary>
        /// Create matrix from user input.
        /// </summary>
        /// <param name="lines">Number of matrix lines.</param>
        /// <param name="columns">Number of matrix columns.</param>
        /// <returns>Matrix</returns>
        private static Matrix CreateMatrixFromInput(int lines, int columns)
        {
            var data = new double[lines, columns];
            var indexLine = 0;
            // Help message.
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine();
            WriteLine("Example input:");
            WriteLine("1.1;2.2;3.3");
            WriteLine("4.4;5.5;6.6");
            WriteLine();
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Enter matrix:");
            WriteLine();

            while (indexLine != lines)
            {
                ForegroundColor = ConsoleColor.Yellow;
                // Check string for correct.
                if (!CheckString(ReadLine()?.Split(';'), out var elementsOfLine, columns))
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Incorrect input.");
                    ResetColor();
                    continue;
                }

                for (var indexColumn = 0; indexColumn < columns; indexColumn++)
                {
                    data[indexLine, indexColumn] = elementsOfLine[indexColumn];
                }

                indexLine++;
                ResetColor();
            }


            return new Matrix(data);
        }

        #endregion

        #region Working with files

        /// <summary>
        /// Create matrix from file.
        /// </summary>
        /// <param name="path">Path to file containing matrices.</param>
        /// <returns>Matrix</returns>
        public static Matrix CreateMatrixFromFile(string path)
        {
            // A set of matrices from a file
            var matrices = CreateMatrixFromFileInternal(path);

            // Display matrices from file.
            for (var i = 0; i < matrices.Length; i++, WriteLine())
            {
                WriteLine($"Matrix № {i + 1}");

                ForegroundColor = ConsoleColor.Cyan;
                matrices[i].Print();
                ResetColor();
            }

            // Error message.
            if (matrices.Length == 0)
            {
                throw new Exception("Any matrix was not found");
            }

            int userChoose;

            // User choice.
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Choose matrix");
            while (!int.TryParse(ReadLine(), out userChoose) || userChoose < 1 || userChoose > matrices.Length)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Incorrect input. Try again.");

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Choose matrix");
                ResetColor();
            }

            ResetColor();

            return matrices[userChoose - 1];
        }

        /// <summary>
        /// Internal method for creation matrix from file.
        /// </summary>
        /// <param name="path">Path to file containing matrices.</param>
        /// <returns>Matrix</returns>
        private static Matrix[] CreateMatrixFromFileInternal(string path)
        {
            try
            {
                // Error messages.
                if (!File.Exists(path))
                {
                    throw new Exception("Incorrect path");
                }

                if (!path.Contains(".txt"))
                {
                    throw new Exception("Incorrect file extension");
                }

                // Reading matrices from file.
                var matrices = ReadMatrixDataFile(path);

                var numOfRealMatrices = 0;
                var arrayOfMatrices = new Matrix[numOfRealMatrices];

                foreach (var matrix in matrices)
                {
                    var lines = matrix.Length;
                    var columns = matrix[0].Split(';').Length;

                    var matrixData = new double[lines, columns];
                    var indexLine = 0;

                    while (indexLine != lines)
                    {
                        // Check string for correct.
                        if (!CheckString(matrix[indexLine].Split(';'), out var elementsOfLine, columns))
                        {
                            matrixData = null;
                            break;
                        }

                        // Writing elements to matrix line.
                        for (var indexColumn = 0; indexColumn < columns; indexColumn++)
                        {
                            matrixData[indexLine, indexColumn] = elementsOfLine[indexColumn];
                        }

                        indexLine++;
                    }

                    if (matrixData == null) continue;
                    // Creating a set of matrices.
                    Array.Resize(ref arrayOfMatrices, numOfRealMatrices + 1);

                    arrayOfMatrices[numOfRealMatrices++] = new Matrix(matrixData);
                }

                return arrayOfMatrices;
            }
            catch (Exception exception)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {exception.Message}");
                WriteLine();
                return null;
            }
        }

        /// <summary>
        /// Reading file and getting matrix from it.
        /// </summary>
        /// <param name="path">Path to file containing matrices.</param>
        /// <returns>Matrix</returns>
        private static string[][] ReadMatrixDataFile(string path)
        {
            // Reading matrices.
            var matricesElements =
                File.ReadAllText(path).Split(MATRICES_SEPARATOR, StringSplitOptions.RemoveEmptyEntries);
            var numMatrices = matricesElements.Length;

            var matrices = new string[numMatrices][];
            // Writing matrices data.
            for (var i = 0; i < numMatrices; i++)
            {
                matrices[i] = matricesElements[i].Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            }

            return matrices;
        }

        /// <summary>
        /// Save all matrix in data file "DATA.txt"
        /// </summary>
        /// <param name="matrix">Matrix to be saved.</param>
        private static void SaveMatrix(Matrix matrix)
        {
            var matrixData = new string[matrix.NumLines + 1];

            // Transform matrix data to string.
            for (var indexLine = 0; indexLine < matrixData.Length; indexLine++)
            {
                if (indexLine == 0)
                {
                    matrixData[indexLine] = MATRICES_SEPARATOR;
                    continue;
                }

                for (var indexColumn = 0; indexColumn < matrix.NumColumns; indexColumn++)
                {
                    matrixData[indexLine] += indexColumn != matrix.NumColumns - 1
                        ? matrix.Data[indexLine - 1, indexColumn].ToString(CultureInfo.InvariantCulture) + ";"
                        : matrix.Data[indexLine - 1, indexColumn].ToString(CultureInfo.InvariantCulture);
                }
            }

            // Adding matrix to file "DATA.txt"
            File.AppendAllLines(PATH, matrixData);
        }

        #endregion

        #region Internal methods

        /// <summary>
        /// Check user size for correct.
        /// </summary>
        /// <param name="lines">Number of matrix lines.</param>
        /// <param name="columns">Number of matrix columns.</param>
        private static void CheckSizeOfMatrix(out int lines, out int columns)
        {
            // Help message.
            ForegroundColor = ConsoleColor.Green;
            WriteLine();
            WriteLine("Enter the dimensions of the MxN matrix");

            // User size of matrix.
            ForegroundColor = ConsoleColor.Yellow;
            do
            {
                Write($"Enter correct value of lines(1 to {MAX_MATRIX_LINES}): ");
            } while (!int.TryParse(ReadLine(), out lines) || lines < 1 || lines > MAX_MATRIX_LINES);

            do
            {
                Write($"Enter correct value of columns(1 to {MAX_MATRIX_COLUMNS}): ");
            } while (!int.TryParse(ReadLine(), out columns) || columns < 1 || columns > MAX_MATRIX_COLUMNS);

            ResetColor();
        }

        /// <summary>
        /// Check input string for correct.
        /// </summary>
        /// <param name="inputString">String to be checking.</param>
        /// <param name="elementsOfLine">Elements of matrix line.</param>
        /// <param name="matrixColumns">Number of matrix columns.</param>
        /// <returns>Result of checking.</returns>
        private static bool CheckString(string[] inputString, out double[] elementsOfLine, int matrixColumns = 0)
        {
            elementsOfLine = new double[inputString.Length];

            // Check string for correct size.
            if (inputString.Length != matrixColumns) return false;

            for (var i = 0; i < inputString.Length; i++)
            {
                // Check string's element for correct.
                var elementTryParse = double.TryParse(inputString[i].Replace(",",".").Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out var elementResult);

                if (elementTryParse)
                {
                    elementsOfLine[i] = elementResult;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}