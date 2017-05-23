using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreastCancerDiagnosis.DAL;
using BreastCancerDiagnosis.Model;

namespace BreastCancerDiagnosis.App.Services
{
    public class DiagnosisDataService : IDiagnosisDataService
    {
        IDiagnosisRepository repository;
        //IDiagnosisRepository repository = new DiagnosisRepository();

        public DiagnosisDataService(IDiagnosisRepository repository)
        //public DiagnosisDataService()
        {
            this.repository = repository;
        }

        public List<Diagnosis> GetAllDiagnoses()
        {
            return repository.GetDiagnoses();
        }

        public void UpdateDiagnosis(Diagnosis diagnosis)
        {
            repository.UpdateDiagnosis(diagnosis);
        }

        public void DeleteDiagnosis(Diagnosis diagnosis)
        {
            repository.DeleteDiagnosis(diagnosis);
        }
    }
}
