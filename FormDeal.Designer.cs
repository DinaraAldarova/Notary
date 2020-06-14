namespace Нотариус
{
    partial class FormDeal
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.labelClientId = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxClientId = new System.Windows.Forms.ComboBox();
            this.checkedListBoxService = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDiscont = new System.Windows.Forms.CheckedListBox();
            this.labelService = new System.Windows.Forms.Label();
            this.labelDiscont = new System.Windows.Forms.Label();
            this.labelReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(552, 560);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(15, 65);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(693, 20);
            this.textBoxDescription.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(12, 49);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(57, 13);
            this.Description.TabIndex = 7;
            this.Description.Text = "Описание";
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(12, 9);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(43, 13);
            this.labelClientId.TabIndex = 5;
            this.labelClientId.Text = "Клиент";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(633, 560);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxClientId
            // 
            this.comboBoxClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClientId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientId.FormattingEnabled = true;
            this.comboBoxClientId.Location = new System.Drawing.Point(15, 25);
            this.comboBoxClientId.Name = "comboBoxClientId";
            this.comboBoxClientId.Size = new System.Drawing.Size(693, 21);
            this.comboBoxClientId.TabIndex = 13;
            // 
            // checkedListBoxService
            // 
            this.checkedListBoxService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxService.CheckOnClick = true;
            this.checkedListBoxService.FormattingEnabled = true;
            this.checkedListBoxService.Location = new System.Drawing.Point(15, 104);
            this.checkedListBoxService.Name = "checkedListBoxService";
            this.checkedListBoxService.Size = new System.Drawing.Size(693, 154);
            this.checkedListBoxService.TabIndex = 16;
            this.checkedListBoxService.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxService_SelectedIndexChanged);
            // 
            // checkedListBoxDiscont
            // 
            this.checkedListBoxDiscont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxDiscont.CheckOnClick = true;
            this.checkedListBoxDiscont.FormattingEnabled = true;
            this.checkedListBoxDiscont.Location = new System.Drawing.Point(15, 277);
            this.checkedListBoxDiscont.Name = "checkedListBoxDiscont";
            this.checkedListBoxDiscont.Size = new System.Drawing.Size(693, 79);
            this.checkedListBoxDiscont.TabIndex = 16;
            this.checkedListBoxDiscont.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDiscont_SelectedIndexChanged);
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(12, 88);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(43, 13);
            this.labelService.TabIndex = 7;
            this.labelService.Text = "Услуги";
            // 
            // labelDiscont
            // 
            this.labelDiscont.AutoSize = true;
            this.labelDiscont.Location = new System.Drawing.Point(12, 261);
            this.labelDiscont.Name = "labelDiscont";
            this.labelDiscont.Size = new System.Drawing.Size(44, 13);
            this.labelDiscont.TabIndex = 7;
            this.labelDiscont.Text = "Скидки";
            // 
            // labelReport
            // 
            this.labelReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReport.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.labelReport.Location = new System.Drawing.Point(15, 359);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(693, 198);
            this.labelReport.TabIndex = 17;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 595);
            this.Controls.Add(this.labelReport);
            this.Controls.Add(this.checkedListBoxDiscont);
            this.Controls.Add(this.checkedListBoxService);
            this.Controls.Add(this.comboBoxClientId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDiscont);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.labelClientId);
            this.Name = "FormDeal";
            this.Text = "Клиент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDeal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxClientId;
        private System.Windows.Forms.CheckedListBox checkedListBoxService;
        private System.Windows.Forms.CheckedListBox checkedListBoxDiscont;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelDiscont;
        private System.Windows.Forms.Label labelReport;
    }
}