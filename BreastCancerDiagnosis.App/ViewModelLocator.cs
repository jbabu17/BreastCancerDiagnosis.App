using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreastCancerDiagnosis.App.ViewModels;

namespace BreastCancerDiagnosis.App
{
    public class ViewModelLocator
    {
        private static DiagnosisOverviewViewModel diagnosisOverviewViewModel
            = new DiagnosisOverviewViewModel();
        private static DiagnosisDetailViewModel diagnosisDetailViewModel
            = new DiagnosisDetailViewModel();

        public static DiagnosisOverviewViewModel DiagnosisOverviewViewModel
        {
            get{ return diagnosisOverviewViewModel;}
        }

        public static DiagnosisDetailViewModel DiagnosisDetailViewModel
        {
            get { return diagnosisDetailViewModel;}
        }

    }
}
