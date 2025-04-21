using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeamBrogden_FinalProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            LabelProblem.Text="";
            LabelSolution.Text="";
            Image2.Visible=false;

        }

        protected void MilesButton_Click(object sender, EventArgs e)
        {
            Image2.ImageUrl = "SudokuImage.png";
            Image2.Visible = true;
            LabelProblem.Text="Write a program to solve a Sudoku puzzle by filling the empty cells.\r\n\r\nA sudoku solution must satisfy all of the following rules:\r\n\r\nEach of the digits 1-9 must occur exactly once in each row.\r\nEach of the digits 1-9 must occur exactly once in each column.\r\nEach of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.\r\nThe '.' character indicates empty cells.";
            var solver = new SudokuSolver();
            LabelSolution.Text = solver.Run();
        }

        protected void AndrewButton_Click(object sender, EventArgs e)
        {

        }

        protected void JoeyButton_Click(object sender, EventArgs e)
        {

        }

        protected void RhodaButton_Click(object sender, EventArgs e)
        {

        }

    }
}
