using BreastCancerDiagnosis.App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BreastCancerDiagnosis.App.Services
{
    public class DialogService : IDialogService
    {
        Window diagnosisDetailView = null; 

        public void ShowDetailDialog()
        {
            diagnosisDetailView = new DiagnosisDetailView();
            diagnosisDetailView.ShowDialog();
        }
        
        public void CloseDetailDialog()
        {
            if (diagnosisDetailView != null)
                diagnosisDetailView.Close();
        }
    }
}
