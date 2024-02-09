namespace TwinCAT_ADS_Forms_Test;

using System.Net;
using TwinCAT.Ads;
using TwinCAT.PlcOpen;

public class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    //[STAThread]

    public static PLC myPLC = new PLC(Convert.ToString(AmsNetId.Local),851);
    public uint bTestABChandle;
    public static Form1 form1 = new Form1();
    static void Main()
    {
        //PLC myPLC = new PLC(Convert.ToString(AmsNetId.Local),851);
        //PLC myPLC = new PLC();
        /*
        AdsClient myPLC = new AdsClient();
        myPLC.Connect(AmsNetId.Local,851);
        try{
            bTestABChandle = myPLC.CreateVariableHandle("GVL_Vars.testABC");
            System.Console.WriteLine("created variable handles successfully");
        } 
        catch
        {
            System.Console.WriteLine("unable to create variable handle");
        }
        */

        ApplicationConfiguration.Initialize();
        Application.Run(form1);

        //myPLC = new PLC(Convert.ToString(AmsNetId.Local),851);
        //myPLC.setupPLC();
        //Program.form1.newSetPos.Click;
        
    }    

}