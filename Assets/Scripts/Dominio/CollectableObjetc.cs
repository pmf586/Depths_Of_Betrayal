﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class CollectableObjetc
{
    public abstract MapSpot Position { get; set; }

    public abstract void pickedUp(Character c);

}