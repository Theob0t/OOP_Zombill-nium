using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace PFR
{
    class Fantome : Monstre
    {

        public Fantome(string fct, int mat, string n, string p, TypeSexe sexe, int cagn, string affect) : base(fct, mat, n, p, sexe, cagn, affect)
        {

        }

        public override string ToString()
        {
            string des = base.ToString();
            return des;
        }
    }
}
