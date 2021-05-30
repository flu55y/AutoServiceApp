using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceApp.Model.Entities
{
    abstract class Person
    {
        public abstract string FIO { get; set; }

        public abstract string Display();

    }
}
