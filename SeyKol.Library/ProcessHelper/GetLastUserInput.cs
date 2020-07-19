using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SeyKol.StudyAnalysis.Library.Interface;

namespace SeyKol.StudyAnalysis.Library.ProcessHelper
{
    class GetLastUserInput
    {
        public class LastUserInput : IComputerTrace
        {
            public struct LastInputInfo
            {
                public uint CbSize;
                public uint DwTime;
            }
            private static LastInputInfo _lastInputInfo;

            static LastUserInput()
            {
                _lastInputInfo = new LastInputInfo();
                _lastInputInfo.CbSize = (uint)Marshal.SizeOf(_lastInputInfo);
            }

            [DllImport("User32.dll")]
            private static extern bool GetLastInputInfo(ref LastInputInfo plii);

            /// <summary>
            /// Idle time in ticks
            /// </summary>
            /// <returns></returns>
            public uint GetIdleTime()
            {
                return ((uint)Environment.TickCount - GetLastInputTime());
            }

            /// <summary>
            /// Last input time in ticks
            /// </summary>
            /// <returns></returns>
            public uint GetLastInputTime()
            {
                if (!GetLastInputInfo(ref _lastInputInfo))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error());
                }
                return _lastInputInfo.DwTime;
            }
        }

    }
}
