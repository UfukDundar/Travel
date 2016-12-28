using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> placeList = new List<string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strPlace = txtPlaces.Text;
            placeList.Add(strPlace);
            lstAllPlaces.Items.Add(strPlace);
            txtPlaces.Text = ""; //txtPlaces.Text=string.Empty;  -- Same thing
            txtPlaces.Focus();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue <= placeList.Count && e.NewValue>0)
            {
                string newPlace = placeList[e.NewValue-1];
                txtNextPlace.Text = newPlace;
            }
            else
            {
                MessageBox.Show("There is No Such Place");
            }
        }
    }
}
