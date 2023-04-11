
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FitnessClub1.BD;
using FitnessClub1.Windows;

namespace FitnessClub1.ClassHelper
{
    public class EFClass
    {
        public static Entities context { get; set; } = new Entities();
    }
}

