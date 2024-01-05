namespace WinControl
{
    partial class FrmSaveRequest
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
            clbTabPages = new System.Windows.Forms.CheckedListBox();
            lblQuestion = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnNo = new System.Windows.Forms.Button();
            btnYes = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // clbTabPages
            // 
            clbTabPages.CheckOnClick = true;
            clbTabPages.FormattingEnabled = true;
            clbTabPages.IntegralHeight = false;
            clbTabPages.Location = new System.Drawing.Point(12, 27);
            clbTabPages.Name = "clbTabPages";
            clbTabPages.Size = new System.Drawing.Size(360, 200);
            clbTabPages.TabIndex = 1;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new System.Drawing.Point(9, 9);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(202, 15);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Save changes to the following items?";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(297, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            btnNo.Location = new System.Drawing.Point(216, 243);
            btnNo.Name = "btnNo";
            btnNo.Size = new System.Drawing.Size(75, 23);
            btnNo.TabIndex = 3;
            btnNo.Text = "&No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btnYes.Location = new System.Drawing.Point(135, 243);
            btnYes.Name = "btnYes";
            btnYes.Size = new System.Drawing.Size(75, 23);
            btnYes.TabIndex = 2;
            btnYes.Text = "&Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // FrmSaveRequest
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(384, 278);
            Controls.Add(btnYes);
            Controls.Add(btnNo);
            Controls.Add(btnCancel);
            Controls.Add(lblQuestion);
            Controls.Add(clbTabPages);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSaveRequest";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Save changes";
            Shown += FrmSaveRequest_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTabPages;
        internal System.Windows.Forms.Label lblQuestion;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnNo;
        internal System.Windows.Forms.Button btnYes;
    }
}