using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreastCancerDiagnosis.Model;

namespace BreastCancerDiagnosis.App.Services
{
    public interface IDiagnosisDataService
    {
        List<Diagnosis> GetAllDiagnoses();
        void DeleteDiagnosis(Diagnosis diagnosis);
        void UpdateDiagnosis(Diagnosis diagnosis);
    }
}
