using System;
using System.Text;
using static System.Console;

namespace CalcMatrix
{
    /// <summary>
    /// The main class for working with matrices.
    /// </summary>
    partial class Calculator
    {
        #region Main menu and switch programm options

        /// <summary>
        /// Start program.
        /// </summary>
        public void Start()
        {
            Hello();

            MainMenu();
        }

        /// <summary>
        /// Output of the greeting.
        /// </summary>
        private static void Hello()
        {
            ForegroundColor = ConsoleColor.Red;

            WriteLine(new StringBuilder().Insert(0, "#", 35).ToString());
            WriteLine("## WELCOME TO CALCULATOR MATRIX! ##");
            WriteLine(new StringBuilder().Insert(0, "#", 35).ToString());
            WriteLine();

            ForegroundColor = ConsoleColor.Green;

            WriteLine("Enter any key to continue...");

            ResetColor();

            ReadKey();
        }

        /// <summary>
        /// Main menu of program, choosing the type of work
        /// </summary>
        private static void MainMenu()
        {
            uint userChooseCommand;

            do
            {
                Clear();
                // Help message.
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine(new StringBuilder().Insert(0, "#", 35).ToString());
                WriteLine("##\t     Main menu\t         ##");
                WriteLine(new StringBuilder().Insert(0, "#", 35).ToString());
                WriteLine();
                ResetColor();

                ForegroundColor = ConsoleColor.Magenta;
                WriteLine(
                    " 1. Working with one matrix \n 2. Working with two matrices \n 3. Resolve SLE \n 4. Info \n 5. Exit\n");

                ForegroundColor = ConsoleColor.Green;
                Write("Choose command: ");
                ResetColor();
                // User choice.
                while (!uint.TryParse(ReadLine(), out userChooseCommand) || userChooseCommand > 5)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Incorrect input. Try again.");
                    WriteLine();

                    ForegroundColor = ConsoleColor.Green;
                    Write("Choose command: ");
                    ResetColor();
                }
            } while (SwitchCommand(userChooseCommand));
        }

        /// <summary>
        /// Display some notes of program.
        /// </summary>
        private static void HelpInfo()
        {
            Clear();
            // Help message.

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Notes:");
            WriteLine("1. Entering numbers with a fractional part is carried out with a dot '.' or a comma','. Example: 3.5 or 3,5");
            WriteLine("2. System of linear equations only solves a system where the number of lines is equal to the number of variables.");
            WriteLine("   The last column is a vector column. Example:");
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("   1;2;3 <==> A*1+B*2=3");
            WriteLine("   2;4;5 <==> A*2+B*4=5");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine();
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Enter any key...");
            ReadKey();
        }

        /// <summary>
        /// Go to the main functionality of the program.
        /// </summary>
        /// <param name="option">User choice</param>
        /// <returns>False, if user chose command "exit", others command return true.</returns>
        private static bool SwitchCommand(uint option)
        {
            switch (option)
            {
                case 1:
                    WorkWithOneMatrix();
                    return true;
                case 2:
                    WorkWithTwoMatrices();
                    return true;
                case 3:
                    ResolveSystemOfLinearEquations();
                    return true;
                case 4:
                    HelpInfo();
                    return true;
                case 5:
                    return false;
                default:
                    return true;
            }
        }

        #endregion

        #region The main functionality of the program

        /// <summary>
        /// Working with one matrix: change matrix and get its info.
        /// </summary>
        private static void WorkWithOneMatrix()
        {
            try
            {
                Clear();
                // Help message.
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Working with one matrix.");
                WriteLine();
                ResetColor();

                var matrix = new Matrix(null);
                ChangeMatrix(ref matrix);
                // Check matrix for null to exit.
                if (matrix == null) return;
                // Working with matrix.
                InfoAndChangeMatrix(ref matrix);
            }
            catch (Exception exception)
            {
                // Error message.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {exception.Message}");
                WriteLine();

                // Help message.
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Enter any key...");
                ReadKey();

                WorkWithOneMatrix();
            }
        }


        /// <summary>
        /// Working with two matrices: change matrices get their info, adding, subtract and multiply of them.
        /// </summary>
        private static void WorkWithTwoMatrices()
        {
            try
            {
                Clear();
                // Help message.
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Working with two matrices.");
                WriteLine();
                ResetColor();

                var matrixA = new Matrix(null);
                ChangeMatrix(ref matrixA);

                // Check matrix for null to exit.
                if (matrixA == null) return;

                // Help message for null to exit.
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Working with two matrices.");
                WriteLine();
                ResetColor();

                var matrixB = new Matrix(null);
                ChangeMatrix(ref matrixB);

                // Check matrix for null to exit.
                if (matrixB == null) return;

                // Working with two matrices.
                WorkWithTwoMatricesInternal(matrixA, matrixB);
            }
            catch (Exception exception)
            {
                // Error message.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {exception.Message}");
                WriteLine();

                // Help message.
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Enter any key...");
                ReadKey();

                WorkWithTwoMatrices();
            }
        }

        /// <summary>
        /// Internal method for working with two matrices.
        /// </summary>
        /// <param name="matrixA">First matrix</param>
        /// <param name="matrixB">Second matrix</param>
        private static void WorkWithTwoMatricesInternal(Matrix matrixA, Matrix matrixB)
        {
            do
            {
                Clear();
                // Help message.
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Working with two matrices.");
                WriteLine();
                ResetColor();

                // Check matrix for null to exit.
                if (matrixA == null || matrixB == null) return;

                WriteLine("Matrix A:");
                ForegroundColor = ConsoleColor.Cyan;
                matrixA.Print();
                ResetColor();

                WriteLine("Matrix B:");
                ForegroundColor = ConsoleColor.Cyan;
                matrixB.Print();
                // Help message about functions.
                ForegroundColor = ConsoleColor.DarkMagenta;
                WriteLine(" 1. Add two matrices.");
                WriteLine(" 2. Subtract two matrices.");
                WriteLine(" 3. Multiply two matrices.");
                WriteLine(" 4. Change one of matrices.");
                WriteLine(" 5. Back to menu.");
                WriteLine();

                int userChoose;
                // User choice.
                do
                {
                    ForegroundColor = ConsoleColor.Green;
                    Write("Choose correct option: ");
                    ResetColor();
                } while (!int.TryParse(ReadLine(), out userChoose) || userChoose < 1 || userChoose > 5);

                // Executing commands.
                if (CommandsWithMatrices(ref matrixA, ref matrixB, userChoose)) break;

                ForegroundColor = ConsoleColor.Green;
                WriteLine("Enter any key...");
                ReadKey();
                ResetColor();
            } while (true);
        }

         
        /// <summary>
        /// Changing matrix or getting info about it.
        /// </summary>
        /// <param name="matrix">Matrix</param>
        /// <param name="userChoose">User choice</param>
        /// <param name="number">The number by which the matrix is ​​multiplied, if user chose multiply by number.</param>
        /// <returns></returns>
        private static bool CommandWithMatrix(ref Matrix matrix, int userChoose, double number = 0)
        {
            if (userChoose < 6)
            {
                if (userChoose == 2)
                {
                    // User number fo multiplying.
                    do
                    {
                        ForegroundColor = ConsoleColor.Green;
                        Write("Enter the correct number to multiply: ");
                        ResetColor();
                    } while (!double.TryParse(ReadLine(), out number));
                }

                ChangeMatrix(ref matrix, userChoose, number);
                // Check matrix for null to exit.
                if (matrix == null) return true;

                // Help message.
                WriteLine("Changed matrix:");
                ForegroundColor = ConsoleColor.Cyan;
                matrix.Print();
            }
            else if (userChoose < 8)
            {
                // Help message.
                WriteLine(userChoose == 6 ? matrix.CalculateTrace() : matrix.CalculateDeterminant());
            }
            else
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Changing matrices and and mathematical operations on them.
        /// </summary>
        /// <param name="matrixA">First matrix.</param>
        /// <param name="matrixB">Second matrix.</param>
        /// <param name="userChoose">User chosen command.</param>
        /// <returns>False, if user chose command "Back to menu.", others command return true.</returns>
        private static bool CommandsWithMatrices(ref Matrix matrixA, ref Matrix matrixB, int userChoose)
        {
            Matrix resultMatrix;
            switch (userChoose)
            {
                case 1:
                    // Help messages.
                    WriteLine("Result:");
                    ForegroundColor = ConsoleColor.Cyan;
                    resultMatrix = Matrix.Add(matrixA, matrixB);
                    resultMatrix.Print();
                    SaveMatrix(resultMatrix);
                    break;
                case 2:
                    // Help messages.
                    WriteLine("Result:");
                    ForegroundColor = ConsoleColor.Cyan;
                    resultMatrix = Matrix.Subtract(matrixA, matrixB);
                    resultMatrix.Print();
                    SaveMatrix(resultMatrix);
                    break;
                case 3:
                    // Help messages.
                    WriteLine("Result:");
                    ForegroundColor = ConsoleColor.Cyan;
                    resultMatrix = Matrix.Multiply(matrixA, matrixB);
                    resultMatrix.Print();
                    SaveMatrix(resultMatrix);
                    break;
                case 4:
                    // User choice.
                    do
                    {
                        ForegroundColor = ConsoleColor.Green;
                        Write("Choose matrix 1 (Matrix A) or 2 (Matrix B):");
                        ResetColor();
                    } while (!int.TryParse(ReadLine(), out userChoose) || userChoose < 1 || userChoose > 2);

                    // Changing one of matrix.
                    switch (userChoose)
                    {
                        case 1:
                            InfoAndChangeMatrix(ref matrixA);
                            break;
                        case 2:
                            InfoAndChangeMatrix(ref matrixB, "Matrix B");
                            break;
                    }

                    break;
                case 5:
                    return true;
            }

            return false;
        }


        /// <summary>
        /// Internal method for working with one matrix: changing and getting info about it.
        /// </summary>
        /// <param name="matrix">Matrix.</param>
        /// <param name="matrixName">Name of matrix.</param>
        private static void InfoAndChangeMatrix(ref Matrix matrix, string matrixName = "Matrix A")
        {
            do
            {
                Clear();
                // Help messages.
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("Working with one matrix.");
                WriteLine();
                ResetColor();

                WriteLine($"{matrixName}: ");
                ForegroundColor = ConsoleColor.Cyan;
                matrix.Print();
                // Help message about commands.
                ForegroundColor = ConsoleColor.Magenta;
                WriteLine(" 1. Transpose");
                WriteLine(" 2. Multiply by number");
                WriteLine(" 3. Transform matrix to stepped canonical view.");
                WriteLine(" 4. Fill with random elements.");
                WriteLine(" 5. Change matrix.");
                WriteLine(" 6. Calculate trace of matrix.");
                WriteLine(" 7. Calculate determinant of matrix.");
                WriteLine(" 8. Back.");
                WriteLine();

                int userChoose;
                double number = 0;
                // User choice.
                do
                {
                    ForegroundColor = ConsoleColor.Green;
                    Write("Choose correct option: ");
                    ResetColor();
                } while (!int.TryParse(ReadLine(), out userChoose) || userChoose < 1 || userChoose > 8);

                // Check for command to exit.
                if (CommandWithMatrix(ref matrix, userChoose, number)) break;

                // Help message.
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Enter any key...");
                ReadKey();
                ResetColor();
            } while (true);
        }

       
        /// <summary>
        /// Resolving system of linear equations.
        /// </summary>
        private static void ResolveSystemOfLinearEquations()
        {
            try
            {
                do
                {
                    Clear();
                    // Help message.
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("Resolve system of linear equations.");
                    WriteLine();
                    ResetColor();
                    ForegroundColor = ConsoleColor.Cyan;
                    WriteLine(
                        "The number of rows must be equal to the number of variables and the last column is a vector column");
                    WriteLine("Example:");
                    WriteLine("1;2;3 <==> A*1+B*2=3");
                    WriteLine("2;4;5 <==> A*2+B*4=5");
                    WriteLine();

                    var matrix = new Matrix(null);
                    ChangeMatrix(ref matrix);
                    // Check matrix for null to exit.
                    if (matrix == null) break;

                    // Help messages.
                    matrix.SystemOfLineEquations();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\nEnter ESC to back to menu, other keys to repeat...");
                    ResetColor();
                } while (ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception exception)
            {
                // Error message.
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error: {exception.Message}");
                WriteLine();

                // Error message.
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Enter any key...");
                ReadKey();

                ResolveSystemOfLinearEquations();
            }
        }

        #endregion
    }
}