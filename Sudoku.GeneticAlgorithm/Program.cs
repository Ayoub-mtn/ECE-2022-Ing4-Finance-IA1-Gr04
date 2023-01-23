// See https://aka.ms/new-console-template for more information
using Sudoku.Shared;

namespace Sudoku.GeneticAlgorithm

{
    public class Program :  ISolverSudoku
    {
        public GridSudoku Solve(GridSudoku s)
        {
            return s.CloneSudoku();
        }
    }
}
