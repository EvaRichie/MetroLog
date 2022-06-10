﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroLog.Layouts;
using MetroLog.Targets;

namespace MetroLog.Tests
{
    class BrokenTarget : SyncTarget
    {
        internal BrokenTarget()
            : base(new SingleLineLayout())
        {
        }

        protected override void Write(LogWriteContext context, LogEventInfo entry)
        {
            // broken...
            throw new NotImplementedException();
        }
    }
}
