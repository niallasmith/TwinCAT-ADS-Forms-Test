# TwinCAT-ADS-Forms-Test

Opens a Windows Form that allows the user to write to test variables on Beckhoff XAE, running on the local machine.
Communicates using ADS.
Used as a proof of concept for writing to, and reading from PLC variables over network from PC, with a GUI.

Create new global variable list named GVL_Vars
Required variables within that list:
1. testValue1 (uint, init = 0)
2. testValue2 (uint, init = 0)
3. testValue3 (bool, init = false)