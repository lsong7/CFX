﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.ResourcePerformance
{
    /// <summary>
    /// An informational message sent by a process endpoint regarding the something that has occurred at the station. 
    /// Information about the criticality of the information should also be given (information, warning, error etc.).
    /// <code language="none">
    /// {
    ///   "InformationId": "INF21321321",
    ///   "Message": "Beam 1 Zeroed and Homed",
    ///   "Importance": "Information",
    ///   "Lane": "1",
    ///   "Stage": "STAGE1"
    /// }
    /// </code>
    /// </summary>
    public class LogEntryRecorded : CFXMessage
    {
        public LogEntryRecorded()
        {
            Importance = LogImportance.Information;
        }

        /// <summary>
        /// An endpoint-specific string that defines the nature of the log entry
        /// </summary>
        public string InformationId
        {
            get;
            set;
        }

        /// <summary>
        /// A human-friendly description of the log entry
        /// </summary>
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// The relative importance of the log entry
        /// </summary>
        public LogImportance Importance
        {
            get;
            set;
        }

        /// <summary>
        /// The production lane related to the log entry (where applicable)
        /// </summary>
        public string Lane
        {
            get;
            set;
        }

        /// The production stage related to the log entry (where applicable)
        public string Stage
        {
            get;
            set;
        }
    }
}
