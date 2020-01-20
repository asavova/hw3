using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp08
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;
        public Form1()
        {
            InitializeComponent();
            folderCol = new System.Collections.Specialized.StringCollection();
            CreateHdrAndFillListView();
            PaintListView(@"C:\");
            folderCol.Add(@"C:\");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if(folderCol.Count>1)
            { PaintListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);

            }
            else
            {
                PaintListView(folderCol[0].ToString());
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.ListView.View = View.LargeIcon;
               
            }

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.ListView.View = View.SmallIcon;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.ListView.View = View.List;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.ListView.View = View.Details;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.ListView.View = View.Tile;
            }
        }
    }
}
