using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas9
{
    class KaryawanHarian : Karyawan
    {
        public double GajiPerJam { get; set; }
        public double JumlahJamKerja { get; set; }
        public override double Gaji()
        {
            return GajiPerJam * JumlahJamKerja;
        }
    }
}