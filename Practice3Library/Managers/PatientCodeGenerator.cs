using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPB.Practice3Library.Managers
{
    public class PatientCodeGenerator
    {
        public string GeneratePatientCode(string name, string lastName, string ci)
        {
            // Tomamos las iniciales del nombre y apellido y las convertimos a mayúsculas
            string initials = $"{name.Substring(0, 1)}{lastName.Substring(0, 1)}".ToUpper();

            // Generamos el código del paciente concatenando las iniciales y el número de CI
            string patientCode = $"{initials}-{ci}";

            return patientCode;
        }
    }
}
