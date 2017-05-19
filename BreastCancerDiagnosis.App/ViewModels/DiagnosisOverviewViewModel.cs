using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BreastCancerDiagnosis.App.Extensions;
using BreastCancerDiagnosis.App.Messages;
using BreastCancerDiagnosis.App.Services;
using BreastCancerDiagnosis.App.Utility;
using BreastCancerDiagnosis.Model;

namespace BreastCancerDiagnosis.App.ViewModels
{
    public class DiagnosisOverviewViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IDiagnosisDataService diagnosisDataService;
        //private IDialogService dialogService;
        private DialogService dialogService = new DialogService();

        public ICommand EditCommand { get; set; }

        private ObservableCollection<Diagnosis> diagnoses;
        public ObservableCollection<Diagnosis> Diagnoses
        {
            get { return diagnoses; }
            set
            {
                diagnoses = value;
                RaisePropertyChanged("Diagnoses");
            }
        }
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

        public DiagnosisOverviewViewModel()
        {
            diagnosisDataService = new DiagnosisDataService();
            //dialogService = new DialogService();
            LoadData();
            LoadCommands();
            Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);
        }

        private void OnUpdateListMessageReceived(UpdateListMessage obj)
        {
            LoadData();
            dialogService.CloseDetailDialog();
        }

        private void LoadCommands()
        {
            EditCommand = new CustomCommand(EditDiagnosis, CanEditDiagnosis);
        }

        
        public void EditDiagnosis(object obj)
        {
            // Messenger - broadcast SelectedDiagnosis
            Messenger.Default.Send<Diagnosis>(selectedDiagnosis);
            // open the dialog for Detailed view
            dialogService.ShowDetailDialog(); 
        }

        public bool CanEditDiagnosis(object obj)
        {
            // check whether or not command is available for execution
            if (SelectedDiagnosis != null)
                return true;
            else
                return false;
        }

        private void LoadData()
        {
            Diagnoses = diagnosisDataService.GetAllDiagnoses().ToObservableCollection();
        }

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
