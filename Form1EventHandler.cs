// Event handler for handling Form1 events e.g. buttons pressed etc.

namespace TwinCAT_ADS_Forms_Test;

public partial class Form1
{
    public NCAxis ncAxis;
    public ushort readPosValue;
    public ushort readVelValue;
    //public Program myPlc;
    private void initButton_Click(object sender, EventArgs e) // initialise button pressed
    {
        //MessageBox.Show("Initialise button event handler");
        ncAxis = new NCAxis(Program.myPLC);
    }
    
    private void newSetPos_Click(object sender, EventArgs e) // new set position button pressed
    {
        
        if (ncAxis is null)
        {
            MessageBox.Show("ncAxis is null, ensure initialistion");
            return;
        }
        // input validation TODO
        //MessageBox.Show("New position set event handler");
        ncAxis.WriteValue1(Program.myPLC, Convert.ToUInt16(setPosText.Text));
    }

    private void newVelCmd_Click(object sender, EventArgs e) // new velocity value button pressed
    {
        if (ncAxis is null)
        {
            MessageBox.Show("ncAxis is null, ensure initialistion");
            return;
        }

        // input validation TODO
        //MessageBox.Show("Velocity set event handler");
        ncAxis.WriteValue2(Program.myPLC, Convert.ToUInt16(setVelText.Text));
    }

    private void checkBox_Click(object sender, EventArgs e) // check box clicked
    {
        if (ncAxis is null)
        {
            MessageBox.Show("ncAxis is null, ensure initialistion");
            return;
        }

        if (checkBOX.Checked)
        {
            //myClient.WriteAny(bABCtestHandle,true);
            //myPLC
            //MessageBox.Show("checked");
            ncAxis.WriteValue3(Program.myPLC, true);

        } else {
            //myClient.WriteAny(bABCtestHandle,false);
            //MessageBox.Show("unchecked");
            ncAxis.WriteValue3(Program.myPLC, false);
        }
    }

    private void timer1_Tick(object sender, EventArgs e) // timer interval triggered
    {
        if (ncAxis is null)
        {
            //MessageBox.Show("ncAxis is null, ensure initialistion");
            return;
        }
        
        readPosValue = ncAxis.ReadValue1(Program.myPLC);
        readVelValue = ncAxis.ReadValue2(Program.myPLC);
        RefreshData();
    }

}