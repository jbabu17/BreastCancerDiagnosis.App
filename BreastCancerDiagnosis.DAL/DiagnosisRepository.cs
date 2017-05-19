using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreastCancerDiagnosis.Model;

namespace BreastCancerDiagnosis.DAL
{
    public class DiagnosisRepository : IDiagnosisRepository
    {

        private static List<Diagnosis> diagnoses;

        public DiagnosisRepository()
        {
        }

        public Diagnosis GetADiagnosis()
        {
            if (diagnoses == null)
                LoadDiagnoses();
            return diagnoses.FirstOrDefault();
        }

        public List<Diagnosis> GetDiagnoses()
        {
            if (diagnoses == null)
                LoadDiagnoses();
            return diagnoses;
        }

        public void DeleteDiagnosis(Diagnosis diagnosis)
        {
            diagnoses.Remove(diagnosis);
        }

        // Check if implementation is correct
        public void UpdateDiagnosis(Diagnosis diagnosis)
        {
            Diagnosis diagnosisToUpdate = diagnoses.Where(c => c.DiagnosisId == diagnosis.DiagnosisId).FirstOrDefault();
            diagnosisToUpdate = diagnosis; // ??
        }

        private void LoadDiagnoses()
        {
            diagnoses = new List<Diagnosis>()
            {
                new Diagnosis()
                {
                    DiagnosisId = 1,
                    DiagnosisName = "Mammogram",
                    DiagnosisType = "non-invasive",
                    Description = "Mammography (also called mastography) is the process of using low-energy X-rays (usually around 30 kVp) to examine the human breast for diagnosis and screening. The goal of mammography is the early detection of breast cancer, typically through detection of characteristic masses or microcalcifications.",
                    ImageId = 1,
                    Cost = 80
                },
                new Diagnosis()
                {
                    DiagnosisId = 2,
                    DiagnosisName = "Ultrasound",
                    DiagnosisType = "non-invasive",
                    Description = "Medical ultrasound (also known as diagnostic sonography or ultrasonography) is a diagnostic imaging technique based on the application of ultrasound. It is used to see internal body structures such as tendons, muscles, joints, vessels and internal organs. Its aim is often to find a source of a disease or to exclude any pathology. The practice of examining pregnant women using ultrasound is called obstetric ultrasound, and is widely used.",
                    ImageId = 2,
                    Cost = 150
                },
                new Diagnosis()
                {
                    DiagnosisId = 3,
                    DiagnosisName = "Magnetic Resonance Imaging",
                    DiagnosisType = "non-invasive",
                    Description = "Magnetic resonance imaging (MRI) is a medical imaging technique used in radiology to form pictures of the anatomy and the physiological processes of the body in both health and disease. MRI scanners use strong magnetic fields, radio waves, and field gradients to generate images of the organs in the body.",
                    ImageId = 3,
                    Cost = 1500
                },
                new Diagnosis()
                {
                    DiagnosisId = 4,
                    DiagnosisName = "HistoPathology",
                    DiagnosisType = "invasive",
                    Description = "Medical ultrasound (also known as diagnostic sonography or ultrasonography) is a diagnostic imaging technique based on the application of ultrasound. It is used to see internal body structures such as tendons, muscles, joints, vessels and internal organs. Its aim is often to find a source of a disease or to exclude any pathology. The practice of examining pregnant women using ultrasound is called obstetric ultrasound, and is widely used.",
                    ImageId = 4,
                    Cost = 110
                },
                new Diagnosis()
                {
                    DiagnosisId = 5,
                    DiagnosisName = "ImmunoHistoChemistry",
                    DiagnosisType = "invasive",
                    Description = "IHC, or ImmunoHistoChemistry, is a special staining process performed on fresh or frozen breast cancer tissue removed during biopsy. IHC is used to show whether or not the cancer cells have HER2 receptors and/or hormone receptors (Estrogen - ER/ Progesterone - PR) on their surface. This information plays a critical role in treatment planning.",
                    ImageId = 5,
                    Cost = 5000
                },
                new Diagnosis()
                {
                    DiagnosisId = 6,
                    DiagnosisName = "OncotypeDx",
                    DiagnosisType = "invasive",
                    Description = "The Oncotype DX test is a genomic test that analyzes the activity of 21 genes that can affect how a cancer is likely to behave and respond to treatment. If you’ve been diagnosed with early-stage, estrogen-receptor-positive breast cancer, the Oncotype DX test can help you and your doctor make a more informed decision about whether or not you need chemotherapy. Oncotype DX test results assign a Recurrence Score — a number between 0 and 100 — to the early-stage breast cancer or DCIS.",
                    ImageId = 6,
                    Cost = 5000
                },
                new Diagnosis()
                {
                    DiagnosisId = 7,
                    DiagnosisName = "Liquid Biopsy",
                    DiagnosisType = "semi-invasive",
                    Description = "A test done on a sample of blood to look for cancer biomarkers circulation in the blood like CTC, CtDNA, CtRNA, Exosomes, miRNA, etc. A liquid biopsy may be used to help find cancer at an early stage. It may also be used to help plan treatment or to find out how well treatment is working or if cancer has come back. Being able to take multiple samples of blood over time may also help doctors understand what kind of molecular changes are taking place in a tumor.",
                    ImageId = 7,
                    Cost = 5800
                },
            };
        }
    }
}
