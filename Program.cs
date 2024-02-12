namespace TwinCAT_ADS_Forms_Test;

using System.Net;
using TwinCAT.Ads;
using TwinCAT.PlcOpen;

public class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>

    public static PLC myPLC = new PLC(Convert.ToString(AmsNetId.Local),851);
    //public static myPLC;
    public uint bTestABChandle;
    public static Form1 form1 = new Form1();
    static void Main()
    {
        //PLC myPLC = new PLC(Convert.ToString(AmsNetId.Local),851);
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        ApplicationConfiguration.Initialize();
        Application.Run(form1);
    }    

}