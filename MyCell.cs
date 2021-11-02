using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager 
{
    public class MyCell : DataGridTextBoxCell 
    {
        string val;
        string name;
        string exp;
        List<string> dep = new List<string>();

        purblic MyCell() 
        {
            name = "A" + "1";
            val = "";
            exp = "";
            //dep.Add("");
        }

        public string Name 
        {
            get { string name; }
        }
        public string Value 
        {
            get { return val; }
            set { val = value; }
        }
        public string Exp
        {
            get { return exp; }
            set { exp = value; }

        public List<string> Depends 
        {
            get { return dep; }
            set { dep = value; }
        }
    }
}


