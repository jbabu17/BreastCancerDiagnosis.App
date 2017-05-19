using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreastCancerDiagnosis.App.Services
{
    public interface IDialogService
    {
        void ShowDetailDialog();
        void CloseDetailDialog();
    }
}
