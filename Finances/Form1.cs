using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Finances
{
    public partial class Form1 : Form
    {
        ListBox ListBoxBackHold = new ListBox();
        public Form1()
        {
            InitializeComponent();
        }


        class Expense {
            public string name { get; set; }
            public double price { get; set; }
            private List<Expense> ExpenseList = new List<Expense>();
            public Expense(string name, double price) {
                this.name = name;
                this.price = price;
            }
  

            public void InitializeExpense(string name, double amount)
            {
                ExpenseList.Add(new Expense(name, amount));
            }
            public string GetInfo()
            {
                String temp = "";
                foreach (var expense in ExpenseList)
                {
                    temp += expense.name + " - " + expense.price + "\n";
                }
                return temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Expense exp1 = new Expense(textBox1.Text, Convert.ToDouble(numericUpDown1.Value));
            exp1.InitializeExpense(exp1.name, Convert.ToDouble(exp1.price));
            listBox1.Items.Add(exp1.GetInfo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var a = listBox1.Items;
            var arrayMagic = new String[listBox1.Items.Count];
            a.CopyTo(arrayMagic, 0);
            var y = arrayMagic.Select(entry => (entry.Split('-')[0] ,Convert.ToDouble(entry.Split('-')[1].Trim()))).ToArray();
            var result = y.Where(x => x.Item2 >= Convert.ToDouble(numericUpDown2.Value));
            foreach (var entry in listBox1.Items)
            {
                ListBoxBackHold.Items.Add(entry);
            }
            listBox1.Items.Clear();
            foreach (var entry in result)
            {
                var output = entry.Item1 + " - " + entry.Item2.ToString();
                listBox1.Items.Add(output);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var entry in ListBoxBackHold.Items)
            {
                listBox1.Items.Add(entry);
            }
        }
    }
}
