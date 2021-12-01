﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Entities;

namespace GameDemo.Abstract
{
    interface IGamerCheckService
    {
        bool Check(Gamer gamer);
    }
}
