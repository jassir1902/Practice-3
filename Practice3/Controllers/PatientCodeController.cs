using Microsoft.AspNetCore.Mvc;
using UPB.Practice3Library.Managers;
using UPB.Practice3Library.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UPB.Practice3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientCodeController : ControllerBase
    {
        private readonly PatientCodeGenerator _patientCodeGenerator;

        public PatientCodeController()
        {
            _patientCodeGenerator = new PatientCodeGenerator();
        }

        [HttpPost]
        public ActionResult<string> GeneratePatientCode([FromBody] PatientData patientData)
        {
            // Verifica si los datos del paciente son válidos
            if (string.IsNullOrEmpty(patientData.Name) || string.IsNullOrEmpty(patientData.LastName) || string.IsNullOrEmpty(patientData.CI))
            {
                return BadRequest("Nombre, Apellido y CI son requeridos.");
            }

            // Genera el código del paciente utilizando la lógica de la biblioteca de clases
            var patientCode = _patientCodeGenerator.GeneratePatientCode(patientData.Name, patientData.LastName, patientData.CI);
            return Ok(patientCode);
        }
    }
}
