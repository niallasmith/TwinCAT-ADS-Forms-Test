namespace TwinCAT_ADS_Forms_Test;

using System.Data;
using TwinCAT.Ads;

public class PLC 
{
    private AdsClient _tcADS = new AdsClient();
    public AdsClient TcADS
    {
        get { return _tcADS; }
        set { _tcADS = value; }
    }

    private AdsState _adsState;
    public AdsState AdsState
    {
        get { return _adsState; }
        set { _adsState = value; }
    }

    private string _id;
    public string ID
    {
        get { return _id; }
        set { _id = value; } // no validation on private id
    }

    private int _port;
    public int Port
    {
        get { return _port; }
        set { _port = value; }
    }
    
    public PLC(string AMSID, int port)
    {
            ID = AMSID;
            Port = port;
            try
            {
                TcADS.Connect(ID, port);
                uint bTestABChandle = TcADS.CreateVariableHandle("GVL_Vars.testABC");
                System.Console.WriteLine("created variable handles successfully");
            }
            catch
            {
                //Do Nothing - Usually means invalid AMS NET ID format
            }      
    }
    
    public bool checkConnection()
    {
        return TcADS.IsConnected;
    }

    public AdsState checkAdsState()
    {
        try
        {
            AdsState = TcADS.ReadState().AdsState;
            return AdsState;
        }
        catch
        {
            return AdsState.Invalid;
        }
    }
    
    public bool IsStateRun()
    {
        try
        {
            if(TcADS.ReadState().AdsState == AdsState.Run)
            {
                return true;
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    public AdsState setupPLC()
    {
        if(checkConnection())
        {
            System.Console.WriteLine("Port Open"); 
        };
        return checkAdsState();
    }
}
