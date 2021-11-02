using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager 
{
    public partial class FormExcel : FormatException
    {
        string colonki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "1234567890";
        int currRow, currCol;
        public Dictionary<string, MyCell> dictionary = new Dictionary<string, MyCell>();
        public Dictionary<string, MyCell> dictionary2 = new Dictionary<string, MyCell>();        public Dictionary<string, MyCell> dictionary = new Dictionary<string, MyCell>();
        public Dictionary<string, MyCell> dictionary3 = new Dictionary<string, MyCell>();

        public FormExcel() 
        {
            InitializeComponent();
            DataGridViewColumn A = new DataGridViewColumn();
            DataGridViewColumn B= new DataGridViewColumn();
            DataGridViewColumn C = new DataGridViewColumn();
            DataGridViewColumn D = new DataGridViewColumn();
            DataGridViewColumn E = new DataGridViewColumn();
            DataGridViewColumn F = new DataGridViewColumn();
            DataGridViewColumn G = new DataGridViewColumn();
            DataGridViewColumn H = new DataGridViewColumn();


            MyCellA = new MyCell(); A.CellTemplate = cellA;
            MyCellB = new MyCell(); A.CellTemplate = cellB;
            MyCellC = new MyCell(); A.CellTemplate = cellC;
            MyCellD = new MyCell(); A.CellTemplate = cellD;
            MyCellE = new MyCell(); A.CellTemplate = cellE;
            MyCellF = new MyCell(); A.CellTemplate = cellF;
            MyCellG = new MyCell(); A.CellTemplate = cellH;
            MyCellH = new MyCell(); A.CellTemplate = cellG;


            A.HeaderText = "A"; A.Name = "A";
            A.HeaderText = "B"; B.Name = "B";
            A.HeaderText = "C"; C.Name = "B";
            A.HeaderText = "D"; D.Name = "C";
            A.HeaderText = "E"; E.Name = "E";
            A.HeaderText = "F"; F.Name = "F";
            A.HeaderText = "G"; G.Name = "G";
            A.HeaderText = "H"; H.Name = "H";

            DataGridView.Columns.Add(A);
            DataGridView.Columns.Add(B);
            DataGridView.Columns.Add(C);
            DataGridView.Columns.Add(D);
            DataGridView.Columns.Add(E);
            DataGridView.Columns.Add(F);
            DataGridView.Columns.Add(G);
            DataGridView.Columns.Add(H);


            DataGridViewRow row = new DataGridViewRow();
            dataGridView.Rows.Add(row);
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            dataGridView.Rows.Add();
            SetRowNum(dataGridView);

            for (int i = 0; i < 10; i++) 
            {
                for (int j = 0; j < 10; j++)
                {
                    int k = j + 65;
                    string cell_name = (char)k + (i + 1).ToString;
                    MyCell cell = new MyCell();
                    cell.Value = "0";
                    cell.Exp = "0";
                    cell.Depends.Add("");
                    dictionary.Add(cell_name, cell);
                }
            }


        }
        private void FormExcel_Load(object sender, EventArgs e) 
        {

        }
    
    
    
    
    
    
    
    
    }
}
