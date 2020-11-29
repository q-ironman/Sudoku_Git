using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Git
{
    class SudokuCell : Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateCells();
            StartNewGame();
        }

        private void StartNewGame()
        {
            loadValues();

            //ShowRandomValuesHints(45);
            var hintsCount = 0;
            if (beginnerLevel.Checked)
                hintsCount = 45;
            if (intermediateLevel.Checked)
                hintsCount = 30;
            if (advancedLevel.Checked)
                hintsCount = 15;
            

            ShowRandomValuesHints(hintsCount);
        }
        Random random = new Random();
        private void ShowRandomValuesHints(int hintsCount)
        {
            for(int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }


        }

        private void loadValues()
        {
            foreach(var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
                findValueforNextcell(0, -1);
            }
        }
        
        private bool findValueforNextcell(int i,int j)
        {
            if(++j>8)
            {
                j = 0;
                if (++i > 8)
                    return true;
            }
            var value = 0;
            var numsleft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            do
            {
                if (numsleft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }
                value = numsleft[random.Next(0, numsleft.Count)];
                cells[i, j].Value = value;

                numsleft.Remove(value);
            } while (!isValidNumber(value, i, j) || !findValueforNextcell(i, j));
            //cells[i, j].Text = value.ToString();

            return true;
        }
        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Check all the cells in the specific block
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;



            
        }
        SudokuCell[,] cells = new SudokuCell[9, 9];
        private void CreateCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(45, 45);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 45, j * 45);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    
                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            
            if (cell.IsLocked)
                return;

            int value;
            int i = 0;
            
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {

                if (value == cell.Value)
                {
                    cell.Text = value.ToString();
                    i++;
                }
                else if (value == 0)
                    cell.Clear();
                else
                {
                    MessageBox.Show("Wrong input");

                }
                cell.ForeColor = SystemColors.ControlDarkDark;
            }
            if (i == 81)
                MessageBox.Show("You won!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Height = 430;
            panel1.Width = 430;
            panel1.Location = new Point(50, 20);
            label1.Location = new Point(480, 200);
            beginnerLevel.Location = new Point(480, 220);
            intermediateLevel.Location = new Point(480, 240);
            advancedLevel.Location = new Point(480, 260);
            newGameButton.Location = new Point(480, 300);
            this.Controls.Remove(clearButton);
            this.Controls.Remove(checkButton);
        }
        /*private void checkButton_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();
            
            int counter = 0;

            foreach (var cell in cells)
            {
                
                if(cell.Text != string.Empty)
                {
                    counter++;
                    if (!string.Equals(cell.Value.ToString(), cell.Text))
                    {
                        wrongCells.Add(cell);
                    }
                }
            }
            if (counter == 81)
                MessageBox.Show("You Won");
            if (wrongCells.Any())
            {
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong Inputs");
                wrongCells.ForEach(x => x.Text = string.Empty);
            }
            
        }*/
        /*private void clearButton_Click(object sender, EventArgs e)
        {
            foreach(var cell in cells)
            {
                if (cell.IsLocked == false)
                    cell.Clear();

            }
        }*/
        private void newGameButton_Click(object sender, EventArgs e)
        {
            StartNewGame();
            if (!beginnerLevel.Checked && !intermediateLevel.Checked && !advancedLevel.Checked)
                MessageBox.Show("Please, select a level for starting the game.");
        }
    }
}
