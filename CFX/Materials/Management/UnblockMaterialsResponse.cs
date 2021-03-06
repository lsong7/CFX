﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Materials.Management
{
    public class UnblockMaterialsResponse : CFXMessage
    {
        public UnblockMaterialsResponse()
        {
            Result = new RequestResult();
        }

        RequestResult Result
        {
            get;
            set;
        }
    }
}
