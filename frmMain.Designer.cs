namespace Auto_Flashcards
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Header = new System.Windows.Forms.Label();
            this.Paragraph = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectDoc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDownloadLastResult = new System.Windows.Forms.Button();
            this.lbDownloadLastResult = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lbDocTypesNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Header.Location = new System.Drawing.Point(280, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(240, 36);
            this.Header.TabIndex = 0;
            this.Header.Text = "Auto Flashcards";
            // 
            // Paragraph
            // 
            this.Paragraph.AutoSize = true;
            this.Paragraph.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paragraph.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Paragraph.Location = new System.Drawing.Point(19, 70);
            this.Paragraph.Name = "Paragraph";
            this.Paragraph.Size = new System.Drawing.Size(759, 23);
            this.Paragraph.TabIndex = 1;
            this.Paragraph.Text = "Elevate Your Learning with AI-Driven Flashcard Creation from Comprehensive Summar" +
    "ies";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "1) Select Document:";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // btnSelectDoc
            // 
            this.btnSelectDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectDoc.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDoc.ForeColor = System.Drawing.Color.Navy;
            this.btnSelectDoc.Location = new System.Drawing.Point(249, 174);
            this.btnSelectDoc.Name = "btnSelectDoc";
            this.btnSelectDoc.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDoc.TabIndex = 3;
            this.btnSelectDoc.Text = "Click";
            this.btnSelectDoc.UseVisualStyleBackColor = true;
            this.btnSelectDoc.Click += new System.EventHandler(this.btnSelectDoc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "2) Check The Result:";
            // 
            // btnDownload
            // 
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Enabled = false;
            this.btnDownload.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.Navy;
            this.btnDownload.Location = new System.Drawing.Point(249, 221);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDownloadLastResult
            // 
            this.btnDownloadLastResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadLastResult.Enabled = false;
            this.btnDownloadLastResult.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadLastResult.ForeColor = System.Drawing.Color.Navy;
            this.btnDownloadLastResult.Location = new System.Drawing.Point(654, 221);
            this.btnDownloadLastResult.Name = "btnDownloadLastResult";
            this.btnDownloadLastResult.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadLastResult.TabIndex = 7;
            this.btnDownloadLastResult.Text = "Download";
            this.btnDownloadLastResult.UseVisualStyleBackColor = true;
            this.btnDownloadLastResult.Visible = false;
            this.btnDownloadLastResult.Click += new System.EventHandler(this.btnDownloadLastResult_Click);
            // 
            // lbDownloadLastResult
            // 
            this.lbDownloadLastResult.AutoSize = true;
            this.lbDownloadLastResult.Enabled = false;
            this.lbDownloadLastResult.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDownloadLastResult.Location = new System.Drawing.Point(399, 219);
            this.lbDownloadLastResult.Name = "lbDownloadLastResult";
            this.lbDownloadLastResult.Size = new System.Drawing.Size(249, 25);
            this.lbDownloadLastResult.TabIndex = 6;
            this.lbDownloadLastResult.Text = "Download Last Result:";
            this.lbDownloadLastResult.Visible = false;
            // 
            // lbDocTypesNotes
            // 
            this.lbDocTypesNotes.AutoSize = true;
            this.lbDocTypesNotes.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbDocTypesNotes.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbDocTypesNotes.Location = new System.Drawing.Point(400, 174);
            this.lbDocTypesNotes.Name = "lbDocTypesNotes";
            this.lbDocTypesNotes.Size = new System.Drawing.Size(338, 23);
            this.lbDocTypesNotes.TabIndex = 8;
            this.lbDocTypesNotes.Text = "⚠️This version supports PDF docs only!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDocTypesNotes);
            this.Controls.Add(this.btnDownloadLastResult);
            this.Controls.Add(this.lbDownloadLastResult);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Paragraph);
            this.Controls.Add(this.Header);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label Paragraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnSelectDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDownloadLastResult;
        private System.Windows.Forms.Label lbDownloadLastResult;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label lbDocTypesNotes;
    }
}

