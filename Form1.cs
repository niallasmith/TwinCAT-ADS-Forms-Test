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
    public TextBox setVelText;
    public CheckBox checkBOX;
    public Button initButton;
    public Form1()
    {
        InitializeComponent();

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

        setVelText = new TextBox();
        setVelText.Size = new Size(100,50);
        setVelText.Location = new Point(25,175);
        this.Controls.Add(setVelText);

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
        checkBOX.Location = new Point(250,125);
        this.Controls.Add(checkBOX);
        checkBOX.Click += new EventHandler(checkBox_Click);
    }
}
}
