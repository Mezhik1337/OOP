using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel
{
    public partial class Form1 : Form
    {
        const int Measures = 200;
        int rowNum = 0;
        int columnNum = 0;
        public Dictionary<string, MyCell> dictionary = new Dictionary<string, MyCell>();
        public Form1()
        {
            InitializeComponent();
            OpenFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            SaveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            CreateDataGridView(Measures, Measures);
            for (int i = 0; i < rowNum; ++i)
            {
                for (int j; j < columnNum; ++j)
                {
                    string cellName = setCellName(j, i);
                    MyCell cell = new MyCell(cellName);
                    cell.Value = 0;
                    cell.exp = "0";
                    cell.column = j;
                    cell.row = i;
                    dictionary.Add(CellName, cell);
                }
            }
            this.ActivateControl = dgv;
        }
    }

    public class MyCell : DataGridViewTextBoxCell
    {
        double val;
        string name;
        string exp;
        private int row;
        private int column;
        private List<string> cellsIDependOn = new List<string>();
        private List<string> cellsDepentOnMe = new List<string>();

        public MyCell()
        {

        }

        public MyCell(string n) 
        {

        }
        public string Name;
        public string Exp;
        public double Value;
        public int Row;
        public int Column;
        public List<string> IDependOn;
        public List<string> DepentOnMe;

    }
    private void CreateDataGidView(int columns, int rows) 
    {
        for (int i = 0; i < columns; ++i) 
        {
            DataGridViewColumn A = new DataGridViewColumn();
            A.HeaderText = SetColumnName();
            A.Name = A.HeaderText;
            MyCell cellA = new MyCell();
            A.CellTemplate = cellA;
            dgv.Columns.Add(A);
            ++columnNum;
        }
    }
        
}




