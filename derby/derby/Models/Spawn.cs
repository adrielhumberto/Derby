﻿using SampSharp.GameMode.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derby.Models
{
    public class Spawn
    {
        public Vector position { get; set; }

        public float rotation { get; set; }

        public int vehid { get; set; }

        public Spawn()
        { }
    }
}
