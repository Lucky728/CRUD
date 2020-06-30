using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas9
{
    class KaryawanTetap : Karyawan
    {
        public double GajiPerBulan { get; set; }
        public override double Gaji()
        {
            return GajiPerBulan;
        }
    }
}