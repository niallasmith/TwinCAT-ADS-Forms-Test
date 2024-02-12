using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TwinCAT_ADS_Forms_Test
{

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }

    public void RefreshData() // refresh data in form
    {
        // called by timer1_Tick
        
        //System.Console.WriteLine("refresh data");
        readPosText.Text = Convert.ToString(readPosValue);
        readVelText.Text = Convert.ToString(readVelValue);
    }
}
}
