using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleThoughtWorks
{

    class Inheritance_Instantiation_Rules
    {
        /*
            +--------------+---+-------------------------+------------------+---------------------+
            |  Class Type  |   | Can inherit from others | Can be inherited | Can be instantiated | 
            |--------------|---|-------------------------+------------------+---------------------+
            | normal       | : |          YES            |        YES       |         YES         |
            | abstract     | : |          YES            |        YES       |         NO          |
            | sealed       | : |          YES            |        NO        |         YES         |
            | static       | : |          NO             |        NO        |         NO          |
            +--------------+---+-------------------------+------------------+---------------------+
        */
    }
}
