using System;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
using Business_Logic;

namespace Auto_Flashcards
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponentForDownload()
        {
            //Disable Select Doc Button
            btnSelectDoc.Enabled = false;
            //Anable Download Result Button
            btnDownload.Enabled = true;
            btnDownload.Focus();
        }

        private void InitializeComponentForUpload()
        {
            //Anable Select Doc Button
            btnSelectDoc.Enabled = true;
            //Disable Download Result Button
            btnDownload.Enabled = false;

            //Anable Download last Reuslt Button
            btnDownloadLastResult.Enabled = true;
            btnDownloadLastResult.Visible = true;
            lbDownloadLastResult.Visible = true;
            lbDownloadLastResult.Enabled = true;

            //Foucs on SelectDoc Button
            btnSelectDoc.Focus();
        }

        private bool SendDocToBackend()
        {
            /*
             This is the first version of "Auto Flashcards" app, 
             It only supports PDF user input, and without notes, prompts or instructions about the document for better results.
             
             Note: The OpenFileDialog's filters must be updated in future verions
            */

            //Auto Flashcards 1.0 Document upload filters
            // Set filter to only show PDF files
            OpenFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            OpenFileDialog.FilterIndex = 1; // Default to the first filter (PDF)
            OpenFileDialog.Title = "Select a PDF File";

            // Select Document
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Pass Docmument to the backend
                bool IsSuccessed = Business_Logic.clsMain.GetDocFromUI(OpenFileDialog.FileName, out bool IsSupported);

                // Show Error Message if not supported
                if (!IsSupported)
                {
                    MessageBox.Show("This type of files is still not supported yet!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                return IsSuccessed;
            }

            return false;
        }

        private void SaveCurrentExeleFileFromGlobalToDisk()
        {
            //SaveFileDialog. = clsGlobal.Result;

            if(SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                clsGlobalFileManager.SaveExcelToDisk(SaveFileDialog.FileName, out string message);
                MessageBox.Show(message);
            }
        }

        private void btnSelectDoc_Click(object sender, EventArgs e)
        {
            if (SendDocToBackend())
            {
                InitializeComponentForDownload();
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveCurrentExeleFileFromGlobalToDisk();
            InitializeComponentForUpload();
        }

        private void btnDownloadLastResult_Click(object sender, EventArgs e)
        {
            SaveCurrentExeleFileFromGlobalToDisk();
        }
    }
}