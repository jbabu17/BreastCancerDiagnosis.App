using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreastCancerDiagnosis.Model
{
    public class Diagnosis : INotifyPropertyChanged
    {
        private int diagnosisId;
        private String diagnosisName;
        private int cost;

        public int DiagnosisId
        {
            get { return diagnosisId; }
            set
            {
                diagnosisId = value;
                RaisePropertyChanged("DiagnosisId");
            }
        }

        public string DiagnosisName
        {
            get { return diagnosisName; }
            set
            {
                diagnosisName = value;
                RaisePropertyChanged("DiagnosisName");
            }
        }

        public string Description { get; set; }
        public string DiagnosisType { get; set; }
        public int ImageId { get; set; }

        public int Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                RaisePropertyChanged("Cost");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
