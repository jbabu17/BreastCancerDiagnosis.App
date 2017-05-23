using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreastCancerDiagnosis.App.Services;
using BreastCancerDiagnosis.App.ViewModels;
using BreastCancerDiagnosis.DAL;

namespace BreastCancerDiagnosis.App
{
    public class ViewModelLocator
    {
        private static IDialogService dialogService
            = new DialogService();
        private static IDiagnosisDataService diagnosisDataService
            = new DiagnosisDataService(new DiagnosisRepository());
        
        // Concrete implementations of dependencies(service names) are plugged to the application through VMLocator not VModels
        private static DiagnosisOverviewViewModel diagnosisOverviewViewModel
            = new DiagnosisOverviewViewModel(diagnosisDataService, dialogService);
        private static DiagnosisDetailViewModel diagnosisDetailViewModel
            = new DiagnosisDetailViewModel(diagnosisDataService, dialogService);

        // VMLocator : knows about all VMs and exposes each of them as a public "Property" 
        // so that the views can ask the particular viewmodel they want as DataContext
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
