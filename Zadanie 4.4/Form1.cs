using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource sortBindingSource;
        private void Form1_Load(object sender, EventArgs e)
        {
            поставщикиTableAdapter.Fill(rBProductDataSet.Поставщики);
            sortBindingSource = new BindingSource(rBProductDataSet, "Поставщики");
            FamtextBox.DataBindings.Add("Text", sortBindingSource, "Код поставщика");
            NametextBox.DataBindings.Add("Text", sortBindingSource, "Поставщик");
            SectiontextBox.DataBindings.Add("Text", sortBindingSource, "Адрес поставщика");
            phoneTextBox.DataBindings.Add("Text", sortBindingSource, "Телефон");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sortBindingSource.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sortBindingSource.MoveNext();
        }
    }
}
