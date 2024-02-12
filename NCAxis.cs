using TwinCAT.PlcOpen;
using TwinCAT.Ads;
using System.Net.Sockets;

namespace TwinCAT_ADS_Forms_Test;

public class NCAxis
{
    //public PLC myPlc;
    public uint ftestValue1Handle;
    public uint ftestValue2Handle;
    public uint btestValue3Handle;

    private uint _axisID;
    public uint AxisID
    {
        get { return _axisID; }
        set { _axisID = value; }
    }

    public NCAxis(PLC plc)
    {
        UpdateAxisInstance(plc);
    }

    public void UpdateAxisInstance(PLC plc)
    {
        try
        {
            ftestValue1Handle = plc.TcADS.CreateVariableHandle("GVL_Vars.testValue1");
            ftestValue2Handle = plc.TcADS.CreateVariableHandle("GVL_Vars.testValue2");
            btestValue3Handle = plc.TcADS.CreateVariableHandle("GVL_Vars.testValue3");
            System.Console.WriteLine("created variable handles successfully");
        }
        catch
        {
            System.Console.WriteLine("unsuccessful in creating variable handles");
        }

    }

    public void WriteValue1(PLC plc, ushort value)
    {
        plc.TcADS.WriteAny(ftestValue1Handle,value);
    }

    public void WriteValue2(PLC plc, ushort value)
    {
        plc.TcADS.WriteAny(ftestValue2Handle,value);
    }

    public void WriteValue3(PLC plc, bool value)
    {
        plc.TcADS.WriteAny(btestValue3Handle,value);
    }

}