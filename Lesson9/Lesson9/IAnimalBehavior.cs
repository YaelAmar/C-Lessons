﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    interface IAnimalBehavior
    {
        void MakeSound();
        int Age();
        string Description();
    }
}
