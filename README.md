# TwinCAT-ADS-Forms-Test

Opens a Windows Form that allows the user to write to test variables on Beckhoff XAE, running on the local machine.
Communicates using ADS.
Used as a proof of concept for writing to, and reading from PLC variables over network from PC, with a GUI.

Create new global variable list named GVL_Vars
1. Required variables within that list:
2. testValue1 (uint, init = 0)
3. testValue2 (uint, init = 0)
4. testValue3 (bool, init = false)