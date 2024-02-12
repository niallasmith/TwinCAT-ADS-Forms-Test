using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TwinCAT_ADS_Forms_Test
{

public partial class Form1 : Form
{
    public Button newSetPos;
    public Button newVelCmd;
    public TextBox setPosText;
    public TextBox readPosText;
    public TextBox setVelText;
    public TextBox readVelText;
    public CheckBox checkBOX;
    public Button initButton;
    public Form1()
    {
        InitializeComponent();

        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        timer1.Interval=5000; // 5 seconds
        timer1.Tick += new EventHandler(timer1_Tick);
        timer1.Start();

        initButton = new Button();
        initButton.Size = new Size(150,40);
        initButton.Location = new Point(25,25);
        initButton.Text = "Initialise PLC";
        this.Controls.Add(initButton);
        initButton.Click += new EventHandler(initButton_Click);

        setPosText = new TextBox();
        setPosText.Size = new Size(100,50);
        setPosText.Location = new Point(25,105);
        this.Controls.Add(setPosText);

        readPosText = new TextBox();
        readPosText.Size = new Size(75,50);
        readPosText.Location = new Point(250,105);
        readPosText.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Italic);
        this.Controls.Add(readPosText);

        setVelText = new TextBox();
        setVelText.Size = new Size(100,50);
        setVelText.Location = new Point(25,175);
        this.Controls.Add(setVelText);

        readVelText = new TextBox();
        readVelText.Size = new Size(75,50);
        readVelText.Location = new Point(250,175);
        readVelText.Font = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Italic);
        this.Controls.Add(readVelText);

        newSetPos = new Button();
        newSetPos.Size = new Size(80, 60);
        newSetPos.Location = new Point(150, 85);
        newSetPos.Text = "Set Position";
        this.Controls.Add(newSetPos);
        newSetPos.Click += new EventHandler(newSetPos_Click);

        newVelCmd = new Button();
        newVelCmd.Size = new Size(80, 60);
        newVelCmd.Location = new Point(150, 160);
        newVelCmd.Text = "Set Velocity";
        this.Controls.Add(newVelCmd);
        newVelCmd.Click += new EventHandler(newVelCmd_Click);

        checkBOX = new CheckBox();
        checkBOX.Size = new Size(20,20);
        checkBOX.Location = new Point(180,250);
        this.Controls.Add(checkBOX);
        checkBOX.Click += new EventHandler(checkBox_Click);
    }

    public void RefreshData()
    {
        System.Console.WriteLine("refresh data");
        // refresh form data
        // called by timer1_Tick
        readPosText.Text = Convert.ToString(readPosValue);
        readVelText.Text = Convert.ToString(readVelValue);
    }
}
}
