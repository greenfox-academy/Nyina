﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_of_Things
{
    class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }


    }
}
