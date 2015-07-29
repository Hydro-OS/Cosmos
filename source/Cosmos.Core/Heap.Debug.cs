﻿using System;
using Cosmos.Debug.Kernel;

namespace Cosmos.Core
{
    partial class Heap
    {
        public static bool EnableDebug = true;
        private static void Debug(string message)
        {
            if (!EnableDebug)
            {
                return;
            }

            //Debugger.DoSend(message);
        }

        private static int mConsoleX = 0;

        private static void DebugHex(string message, uint value, byte bits)
        {
            if (!EnableDebug)
            {
                return;
            }
            //Console.Write("Heap: ");
            //Console.Write(message);
            //WriteNumberHex(value, bits);
            //NewLine();
        }

        private static void DebugAndHalt(string message)
        {
            Debug(message);
            while (true)
                ;
        }
    }
}
