using BreastCancerDiagnosis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BreastCancerDiagnosis.App.Messages;
using BreastCancerDiagnosis.App.Services;
using BreastCancerDiagnosis.App.Utility;

namespace BreastCancerDiagnosis.App.ViewModels
{
    public class DiagnosisDetailViewModel:INotifyPropertyChanged
    {
        private IDiagnosisDataService diagnosisDataService;
        private IDialogService dialogService;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand SaveCommand { get; set; }

        public ICommand DeleteCommand { get; set; }

        private Diagnosis selectedDiagnosis;
        public Diagnosis SelectedDiagnosis
        {
            get { return selectedDiagnosis; }
            set
            {
                selectedDiagnosis = value;
                RaisePropertyChanged("SelectedDiagnosis");
            }
        }

        public DiagnosisDetailViewModel()
        {
            Messenger.Default.Register<Diagnosis>(this, OnDiagnosisReceived);
            
            diagnosisDataService = new DiagnosisDataService();

            SaveCommand = new CustomCommand(SaveDiagnosis, CanSaveDiagnosis);
            DeleteCommand = new CustomCommand(DeleteDiagnosis, CanDeleteDiagnosis);
            
        }

        public void OnDiagnosisReceived(Diagnosis diagnosis)
        {
            SelectedDiagnosis = diagnosis;
        }

        private void SaveDiagnosis(object obj)
        {
            diagnosisDataService.UpdateDiagnosis(SelectedDiagnosis);
            // Messenger 
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        private bool CanSaveDiagnosis(object obj)
        {
            return true;
        }

        private void DeleteDiagnosis(object obj)
        {
            diagnosisDataService.DeleteDiagnosis(SelectedDiagnosis);
            // Messenger 
            Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        private bool CanDeleteDiagnosis(object obj)
        {
            return true;
        }
    }
}
