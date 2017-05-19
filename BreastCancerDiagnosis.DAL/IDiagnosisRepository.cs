using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreastCancerDiagnosis.Model;

namespace BreastCancerDiagnosis.DAL
{
    public interface IDiagnosisRepository
    {
        Diagnosis GetADiagnosis();
        List<Diagnosis> GetDiagnoses();
        void DeleteDiagnosis(Diagnosis diagnosis);
        void UpdateDiagnosis(Diagnosis diagnosis);
    }
}
