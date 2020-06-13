namespace Нотариус
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlWindow = new System.Windows.Forms.TabControl();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.splitContainerClient = new System.Windows.Forms.SplitContainer();
            this.groupBoxClientId = new System.Windows.Forms.GroupBox();
            this.buttonClientEdit = new System.Windows.Forms.Button();
            this.buttonClientDelete = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.groupBoxClientSelect = new System.Windows.Forms.GroupBox();
            this.labelClientSelect = new System.Windows.Forms.Label();
            this.buttonClientCreate = new System.Windows.Forms.Button();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.tabPageDeal = new System.Windows.Forms.TabPage();
            this.splitContainerDeal = new System.Windows.Forms.SplitContainer();
            this.groupBoxDealId = new System.Windows.Forms.GroupBox();
            this.buttonDealReport = new System.Windows.Forms.Button();
            this.buttonDealEdit = new System.Windows.Forms.Button();
            this.buttonDealDelete = new System.Windows.Forms.Button();
            this.labelDeal = new System.Windows.Forms.Label();
            this.groupBoxDealSelect = new System.Windows.Forms.GroupBox();
            this.labelDealSelect = new System.Windows.Forms.Label();
            this.buttonDealCreate = new System.Windows.Forms.Button();
            this.comboBoxDeal = new System.Windows.Forms.ComboBox();
            this.dataGridViewDeal = new System.Windows.Forms.DataGridView();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.splitContainerService = new System.Windows.Forms.SplitContainer();
            this.groupBoxServiceId = new System.Windows.Forms.GroupBox();
            this.buttonServiceDelete = new System.Windows.Forms.Button();
            this.buttonServiceEdit = new System.Windows.Forms.Button();
            this.labelService = new System.Windows.Forms.Label();
            this.groupBoxServiceSelect = new System.Windows.Forms.GroupBox();
            this.labelServiceSelect = new System.Windows.Forms.Label();
            this.buttonServiceCreate = new System.Windows.Forms.Button();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.tabPageDiscont = new System.Windows.Forms.TabPage();
            this.splitContainerDiscont = new System.Windows.Forms.SplitContainer();
            this.groupBoxDiscontId = new System.Windows.Forms.GroupBox();
            this.buttonDiscontEdit = new System.Windows.Forms.Button();
            this.buttonDiscontDelete = new System.Windows.Forms.Button();
            this.labelDiscont = new System.Windows.Forms.Label();
            this.groupBoxDiscontSelect = new System.Windows.Forms.GroupBox();
            this.labelDiscontSelect = new System.Windows.Forms.Label();
            this.buttonDiscontCreate = new System.Windows.Forms.Button();
            this.comboBoxDiscont = new System.Windows.Forms.ComboBox();
            this.dataGridViewDiscont = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControlWindow.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerClient)).BeginInit();
            this.splitContainerClient.Panel1.SuspendLayout();
            this.splitContainerClient.Panel2.SuspendLayout();
            this.splitContainerClient.SuspendLayout();
            this.groupBoxClientId.SuspendLayout();
            this.groupBoxClientSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageDeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDeal)).BeginInit();
            this.splitContainerDeal.Panel1.SuspendLayout();
            this.splitContainerDeal.Panel2.SuspendLayout();
            this.splitContainerDeal.SuspendLayout();
            this.groupBoxDealId.SuspendLayout();
            this.groupBoxDealSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeal)).BeginInit();
            this.tabPageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerService)).BeginInit();
            this.splitContainerService.Panel1.SuspendLayout();
            this.splitContainerService.Panel2.SuspendLayout();
            this.splitContainerService.SuspendLayout();
            this.groupBoxServiceId.SuspendLayout();
            this.groupBoxServiceSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.tabPageDiscont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDiscont)).BeginInit();
            this.splitContainerDiscont.Panel1.SuspendLayout();
            this.splitContainerDiscont.Panel2.SuspendLayout();
            this.splitContainerDiscont.SuspendLayout();
            this.groupBoxDiscontId.SuspendLayout();
            this.groupBoxDiscontSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscont)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlWindow
            // 
            this.tabControlWindow.Controls.Add(this.tabPageClient);
            this.tabControlWindow.Controls.Add(this.tabPageDeal);
            this.tabControlWindow.Controls.Add(this.tabPageService);
            this.tabControlWindow.Controls.Add(this.tabPageDiscont);
            this.tabControlWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWindow.Location = new System.Drawing.Point(0, 0);
            this.tabControlWindow.Name = "tabControlWindow";
            this.tabControlWindow.SelectedIndex = 0;
            this.tabControlWindow.Size = new System.Drawing.Size(800, 450);
            this.tabControlWindow.TabIndex = 0;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.splitContainerClient);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(792, 424);
            this.tabPageClient.TabIndex = 0;
            this.tabPageClient.Text = "Клиенты";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // splitContainerClient
            // 
            this.splitContainerClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerClient.Location = new System.Drawing.Point(3, 3);
            this.splitContainerClient.Name = "splitContainerClient";
            this.splitContainerClient.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerClient.Panel1
            // 
            this.splitContainerClient.Panel1.Controls.Add(this.groupBoxClientId);
            this.splitContainerClient.Panel1.Controls.Add(this.groupBoxClientSelect);
            // 
            // splitContainerClient.Panel2
            // 
            this.splitContainerClient.Panel2.Controls.Add(this.dataGridViewClient);
            this.splitContainerClient.Size = new System.Drawing.Size(786, 418);
            this.splitContainerClient.SplitterDistance = 231;
            this.splitContainerClient.TabIndex = 0;
            // 
            // groupBoxClientId
            // 
            this.groupBoxClientId.Controls.Add(this.buttonClientEdit);
            this.groupBoxClientId.Controls.Add(this.buttonClientDelete);
            this.groupBoxClientId.Controls.Add(this.labelClient);
            this.groupBoxClientId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxClientId.Location = new System.Drawing.Point(0, 59);
            this.groupBoxClientId.Name = "groupBoxClientId";
            this.groupBoxClientId.Size = new System.Drawing.Size(786, 172);
            this.groupBoxClientId.TabIndex = 3;
            this.groupBoxClientId.TabStop = false;
            this.groupBoxClientId.Text = "Клиент";
            // 
            // buttonClientEdit
            // 
            this.buttonClientEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClientEdit.Location = new System.Drawing.Point(607, 143);
            this.buttonClientEdit.Name = "buttonClientEdit";
            this.buttonClientEdit.Size = new System.Drawing.Size(92, 23);
            this.buttonClientEdit.TabIndex = 1;
            this.buttonClientEdit.Text = "Редактировать";
            this.buttonClientEdit.UseVisualStyleBackColor = true;
            this.buttonClientEdit.Click += new System.EventHandler(this.buttonClientEdit_Click);
            // 
            // buttonClientDelete
            // 
            this.buttonClientDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClientDelete.Location = new System.Drawing.Point(705, 143);
            this.buttonClientDelete.Name = "buttonClientDelete";
            this.buttonClientDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonClientDelete.TabIndex = 0;
            this.buttonClientDelete.Text = "Удалить";
            this.buttonClientDelete.UseVisualStyleBackColor = true;
            this.buttonClientDelete.Click += new System.EventHandler(this.buttonClientDelete_Click);
            // 
            // labelClient
            // 
            this.labelClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClient.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClient.Location = new System.Drawing.Point(3, 16);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(780, 153);
            this.labelClient.TabIndex = 4;
            // 
            // groupBoxClientSelect
            // 
            this.groupBoxClientSelect.Controls.Add(this.labelClientSelect);
            this.groupBoxClientSelect.Controls.Add(this.buttonClientCreate);
            this.groupBoxClientSelect.Controls.Add(this.comboBoxClient);
            this.groupBoxClientSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxClientSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxClientSelect.MaximumSize = new System.Drawing.Size(0, 59);
            this.groupBoxClientSelect.MinimumSize = new System.Drawing.Size(0, 59);
            this.groupBoxClientSelect.Name = "groupBoxClientSelect";
            this.groupBoxClientSelect.Size = new System.Drawing.Size(786, 59);
            this.groupBoxClientSelect.TabIndex = 2;
            this.groupBoxClientSelect.TabStop = false;
            this.groupBoxClientSelect.Text = "Выбор клиента";
            // 
            // labelClientSelect
            // 
            this.labelClientSelect.AutoSize = true;
            this.labelClientSelect.Location = new System.Drawing.Point(6, 16);
            this.labelClientSelect.Name = "labelClientSelect";
            this.labelClientSelect.Size = new System.Drawing.Size(139, 13);
            this.labelClientSelect.TabIndex = 2;
            this.labelClientSelect.Text = "Выберите номер клиента:";
            // 
            // buttonClientCreate
            // 
            this.buttonClientCreate.Location = new System.Drawing.Point(151, 31);
            this.buttonClientCreate.Name = "buttonClientCreate";
            this.buttonClientCreate.Size = new System.Drawing.Size(75, 21);
            this.buttonClientCreate.TabIndex = 1;
            this.buttonClientCreate.Text = "Создать";
            this.buttonClientCreate.UseVisualStyleBackColor = true;
            this.buttonClientCreate.Click += new System.EventHandler(this.buttonClientCreate_Click);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(9, 32);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 0;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClient.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClient.MultiSelect = false;
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(786, 183);
            this.dataGridViewClient.TabIndex = 1;
            this.dataGridViewClient.SelectionChanged += new System.EventHandler(this.dataGridViewClient_SelectionChanged);
            // 
            // tabPageDeal
            // 
            this.tabPageDeal.Controls.Add(this.splitContainerDeal);
            this.tabPageDeal.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeal.Name = "tabPageDeal";
            this.tabPageDeal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeal.Size = new System.Drawing.Size(792, 424);
            this.tabPageDeal.TabIndex = 1;
            this.tabPageDeal.Text = "Сделки";
            this.tabPageDeal.UseVisualStyleBackColor = true;
            // 
            // splitContainerDeal
            // 
            this.splitContainerDeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDeal.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDeal.Name = "splitContainerDeal";
            this.splitContainerDeal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDeal.Panel1
            // 
            this.splitContainerDeal.Panel1.Controls.Add(this.groupBoxDealId);
            this.splitContainerDeal.Panel1.Controls.Add(this.groupBoxDealSelect);
            // 
            // splitContainerDeal.Panel2
            // 
            this.splitContainerDeal.Panel2.Controls.Add(this.dataGridViewDeal);
            this.splitContainerDeal.Size = new System.Drawing.Size(786, 418);
            this.splitContainerDeal.SplitterDistance = 231;
            this.splitContainerDeal.TabIndex = 1;
            // 
            // groupBoxDealId
            // 
            this.groupBoxDealId.Controls.Add(this.buttonDealReport);
            this.groupBoxDealId.Controls.Add(this.buttonDealEdit);
            this.groupBoxDealId.Controls.Add(this.buttonDealDelete);
            this.groupBoxDealId.Controls.Add(this.labelDeal);
            this.groupBoxDealId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDealId.Location = new System.Drawing.Point(0, 59);
            this.groupBoxDealId.Name = "groupBoxDealId";
            this.groupBoxDealId.Size = new System.Drawing.Size(786, 172);
            this.groupBoxDealId.TabIndex = 3;
            this.groupBoxDealId.TabStop = false;
            this.groupBoxDealId.Text = "Сделка";
            // 
            // buttonDealReport
            // 
            this.buttonDealReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDealReport.Location = new System.Drawing.Point(476, 143);
            this.buttonDealReport.Name = "buttonDealReport";
            this.buttonDealReport.Size = new System.Drawing.Size(125, 23);
            this.buttonDealReport.TabIndex = 5;
            this.buttonDealReport.Text = "Сформировать отчет";
            this.buttonDealReport.UseVisualStyleBackColor = true;
            this.buttonDealReport.Click += new System.EventHandler(this.buttonDealReport_Click);
            // 
            // buttonDealEdit
            // 
            this.buttonDealEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDealEdit.Location = new System.Drawing.Point(607, 143);
            this.buttonDealEdit.Name = "buttonDealEdit";
            this.buttonDealEdit.Size = new System.Drawing.Size(92, 23);
            this.buttonDealEdit.TabIndex = 1;
            this.buttonDealEdit.Text = "Редактировать";
            this.buttonDealEdit.UseVisualStyleBackColor = true;
            this.buttonDealEdit.Click += new System.EventHandler(this.buttonDealEdit_Click);
            // 
            // buttonDealDelete
            // 
            this.buttonDealDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDealDelete.Location = new System.Drawing.Point(705, 143);
            this.buttonDealDelete.Name = "buttonDealDelete";
            this.buttonDealDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDealDelete.TabIndex = 0;
            this.buttonDealDelete.Text = "Удалить";
            this.buttonDealDelete.UseVisualStyleBackColor = true;
            this.buttonDealDelete.Click += new System.EventHandler(this.buttonDealDelete_Click);
            // 
            // labelDeal
            // 
            this.labelDeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeal.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeal.Location = new System.Drawing.Point(3, 16);
            this.labelDeal.Name = "labelDeal";
            this.labelDeal.Size = new System.Drawing.Size(780, 153);
            this.labelDeal.TabIndex = 4;
            // 
            // groupBoxDealSelect
            // 
            this.groupBoxDealSelect.Controls.Add(this.labelDealSelect);
            this.groupBoxDealSelect.Controls.Add(this.buttonDealCreate);
            this.groupBoxDealSelect.Controls.Add(this.comboBoxDeal);
            this.groupBoxDealSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDealSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDealSelect.MaximumSize = new System.Drawing.Size(0, 59);
            this.groupBoxDealSelect.MinimumSize = new System.Drawing.Size(0, 59);
            this.groupBoxDealSelect.Name = "groupBoxDealSelect";
            this.groupBoxDealSelect.Size = new System.Drawing.Size(786, 59);
            this.groupBoxDealSelect.TabIndex = 2;
            this.groupBoxDealSelect.TabStop = false;
            this.groupBoxDealSelect.Text = "Выбор сделки";
            // 
            // labelDealSelect
            // 
            this.labelDealSelect.AutoSize = true;
            this.labelDealSelect.Location = new System.Drawing.Point(6, 16);
            this.labelDealSelect.Name = "labelDealSelect";
            this.labelDealSelect.Size = new System.Drawing.Size(134, 13);
            this.labelDealSelect.TabIndex = 2;
            this.labelDealSelect.Text = "Выберите номер сделки:";
            // 
            // buttonDealCreate
            // 
            this.buttonDealCreate.Location = new System.Drawing.Point(151, 31);
            this.buttonDealCreate.Name = "buttonDealCreate";
            this.buttonDealCreate.Size = new System.Drawing.Size(75, 21);
            this.buttonDealCreate.TabIndex = 1;
            this.buttonDealCreate.Text = "Создать";
            this.buttonDealCreate.UseVisualStyleBackColor = true;
            this.buttonDealCreate.Click += new System.EventHandler(this.buttonDealCreate_Click);
            // 
            // comboBoxDeal
            // 
            this.comboBoxDeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeal.FormattingEnabled = true;
            this.comboBoxDeal.Location = new System.Drawing.Point(9, 32);
            this.comboBoxDeal.Name = "comboBoxDeal";
            this.comboBoxDeal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeal.TabIndex = 0;
            this.comboBoxDeal.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeal_SelectedIndexChanged);
            // 
            // dataGridViewDeal
            // 
            this.dataGridViewDeal.AllowUserToAddRows = false;
            this.dataGridViewDeal.AllowUserToDeleteRows = false;
            this.dataGridViewDeal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDeal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDeal.MultiSelect = false;
            this.dataGridViewDeal.Name = "dataGridViewDeal";
            this.dataGridViewDeal.ReadOnly = true;
            this.dataGridViewDeal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeal.Size = new System.Drawing.Size(786, 183);
            this.dataGridViewDeal.TabIndex = 1;
            this.dataGridViewDeal.SelectionChanged += new System.EventHandler(this.dataGridViewDeal_SelectionChanged);
            // 
            // tabPageService
            // 
            this.tabPageService.Controls.Add(this.splitContainerService);
            this.tabPageService.Location = new System.Drawing.Point(4, 22);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(792, 424);
            this.tabPageService.TabIndex = 2;
            this.tabPageService.Text = "Услуги";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // splitContainerService
            // 
            this.splitContainerService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerService.Location = new System.Drawing.Point(3, 3);
            this.splitContainerService.Name = "splitContainerService";
            this.splitContainerService.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerService.Panel1
            // 
            this.splitContainerService.Panel1.Controls.Add(this.groupBoxServiceId);
            this.splitContainerService.Panel1.Controls.Add(this.groupBoxServiceSelect);
            // 
            // splitContainerService.Panel2
            // 
            this.splitContainerService.Panel2.Controls.Add(this.dataGridViewService);
            this.splitContainerService.Size = new System.Drawing.Size(786, 418);
            this.splitContainerService.SplitterDistance = 231;
            this.splitContainerService.TabIndex = 1;
            // 
            // groupBoxServiceId
            // 
            this.groupBoxServiceId.Controls.Add(this.buttonServiceDelete);
            this.groupBoxServiceId.Controls.Add(this.buttonServiceEdit);
            this.groupBoxServiceId.Controls.Add(this.labelService);
            this.groupBoxServiceId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxServiceId.Location = new System.Drawing.Point(0, 59);
            this.groupBoxServiceId.Name = "groupBoxServiceId";
            this.groupBoxServiceId.Size = new System.Drawing.Size(786, 172);
            this.groupBoxServiceId.TabIndex = 3;
            this.groupBoxServiceId.TabStop = false;
            this.groupBoxServiceId.Text = "Услуга";
            // 
            // buttonServiceDelete
            // 
            this.buttonServiceDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceDelete.Location = new System.Drawing.Point(705, 143);
            this.buttonServiceDelete.Name = "buttonServiceDelete";
            this.buttonServiceDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonServiceDelete.TabIndex = 0;
            this.buttonServiceDelete.Text = "Удалить";
            this.buttonServiceDelete.UseVisualStyleBackColor = true;
            this.buttonServiceDelete.Click += new System.EventHandler(this.buttonServiceDelete_Click);
            // 
            // buttonServiceEdit
            // 
            this.buttonServiceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonServiceEdit.Location = new System.Drawing.Point(607, 143);
            this.buttonServiceEdit.Name = "buttonServiceEdit";
            this.buttonServiceEdit.Size = new System.Drawing.Size(92, 23);
            this.buttonServiceEdit.TabIndex = 1;
            this.buttonServiceEdit.Text = "Редактировать";
            this.buttonServiceEdit.UseVisualStyleBackColor = true;
            this.buttonServiceEdit.Click += new System.EventHandler(this.buttonServiceEdit_Click);
            // 
            // labelService
            // 
            this.labelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelService.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.labelService.Location = new System.Drawing.Point(3, 16);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(780, 153);
            this.labelService.TabIndex = 3;
            // 
            // groupBoxServiceSelect
            // 
            this.groupBoxServiceSelect.Controls.Add(this.labelServiceSelect);
            this.groupBoxServiceSelect.Controls.Add(this.buttonServiceCreate);
            this.groupBoxServiceSelect.Controls.Add(this.comboBoxService);
            this.groupBoxServiceSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxServiceSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxServiceSelect.MaximumSize = new System.Drawing.Size(0, 59);
            this.groupBoxServiceSelect.MinimumSize = new System.Drawing.Size(0, 59);
            this.groupBoxServiceSelect.Name = "groupBoxServiceSelect";
            this.groupBoxServiceSelect.Size = new System.Drawing.Size(786, 59);
            this.groupBoxServiceSelect.TabIndex = 2;
            this.groupBoxServiceSelect.TabStop = false;
            this.groupBoxServiceSelect.Text = "Выбор услуги";
            // 
            // labelServiceSelect
            // 
            this.labelServiceSelect.AutoSize = true;
            this.labelServiceSelect.Location = new System.Drawing.Point(6, 16);
            this.labelServiceSelect.Name = "labelServiceSelect";
            this.labelServiceSelect.Size = new System.Drawing.Size(131, 13);
            this.labelServiceSelect.TabIndex = 2;
            this.labelServiceSelect.Text = "Выберите номер услуги:";
            // 
            // buttonServiceCreate
            // 
            this.buttonServiceCreate.Location = new System.Drawing.Point(151, 31);
            this.buttonServiceCreate.Name = "buttonServiceCreate";
            this.buttonServiceCreate.Size = new System.Drawing.Size(75, 21);
            this.buttonServiceCreate.TabIndex = 1;
            this.buttonServiceCreate.Text = "Создать";
            this.buttonServiceCreate.UseVisualStyleBackColor = true;
            this.buttonServiceCreate.Click += new System.EventHandler(this.buttonServiceCreate_Click);
            // 
            // comboBoxService
            // 
            this.comboBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(9, 32);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(121, 21);
            this.comboBoxService.TabIndex = 0;
            this.comboBoxService.SelectedIndexChanged += new System.EventHandler(this.comboBoxService_SelectedIndexChanged);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToDeleteRows = false;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewService.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewService.MultiSelect = false;
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(786, 183);
            this.dataGridViewService.TabIndex = 1;
            this.dataGridViewService.SelectionChanged += new System.EventHandler(this.dataGridViewService_SelectionChanged);
            // 
            // tabPageDiscont
            // 
            this.tabPageDiscont.Controls.Add(this.splitContainerDiscont);
            this.tabPageDiscont.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiscont.Name = "tabPageDiscont";
            this.tabPageDiscont.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDiscont.Size = new System.Drawing.Size(792, 424);
            this.tabPageDiscont.TabIndex = 3;
            this.tabPageDiscont.Text = "Скидки";
            this.tabPageDiscont.UseVisualStyleBackColor = true;
            // 
            // splitContainerDiscont
            // 
            this.splitContainerDiscont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDiscont.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDiscont.Name = "splitContainerDiscont";
            this.splitContainerDiscont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDiscont.Panel1
            // 
            this.splitContainerDiscont.Panel1.Controls.Add(this.groupBoxDiscontId);
            this.splitContainerDiscont.Panel1.Controls.Add(this.groupBoxDiscontSelect);
            // 
            // splitContainerDiscont.Panel2
            // 
            this.splitContainerDiscont.Panel2.Controls.Add(this.dataGridViewDiscont);
            this.splitContainerDiscont.Size = new System.Drawing.Size(786, 418);
            this.splitContainerDiscont.SplitterDistance = 231;
            this.splitContainerDiscont.TabIndex = 1;
            // 
            // groupBoxDiscontId
            // 
            this.groupBoxDiscontId.Controls.Add(this.buttonDiscontEdit);
            this.groupBoxDiscontId.Controls.Add(this.buttonDiscontDelete);
            this.groupBoxDiscontId.Controls.Add(this.labelDiscont);
            this.groupBoxDiscontId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDiscontId.Location = new System.Drawing.Point(0, 59);
            this.groupBoxDiscontId.Name = "groupBoxDiscontId";
            this.groupBoxDiscontId.Size = new System.Drawing.Size(786, 172);
            this.groupBoxDiscontId.TabIndex = 3;
            this.groupBoxDiscontId.TabStop = false;
            this.groupBoxDiscontId.Text = "Скидка";
            // 
            // buttonDiscontEdit
            // 
            this.buttonDiscontEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscontEdit.Location = new System.Drawing.Point(607, 143);
            this.buttonDiscontEdit.Name = "buttonDiscontEdit";
            this.buttonDiscontEdit.Size = new System.Drawing.Size(92, 23);
            this.buttonDiscontEdit.TabIndex = 1;
            this.buttonDiscontEdit.Text = "Редактировать";
            this.buttonDiscontEdit.UseVisualStyleBackColor = true;
            this.buttonDiscontEdit.Click += new System.EventHandler(this.buttonDiscontEdit_Click);
            // 
            // buttonDiscontDelete
            // 
            this.buttonDiscontDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiscontDelete.Location = new System.Drawing.Point(705, 143);
            this.buttonDiscontDelete.Name = "buttonDiscontDelete";
            this.buttonDiscontDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDiscontDelete.TabIndex = 0;
            this.buttonDiscontDelete.Text = "Удалить";
            this.buttonDiscontDelete.UseVisualStyleBackColor = true;
            this.buttonDiscontDelete.Click += new System.EventHandler(this.buttonDiscontDelete_Click);
            // 
            // labelDiscont
            // 
            this.labelDiscont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscont.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.labelDiscont.Location = new System.Drawing.Point(3, 16);
            this.labelDiscont.Name = "labelDiscont";
            this.labelDiscont.Size = new System.Drawing.Size(780, 153);
            this.labelDiscont.TabIndex = 4;
            // 
            // groupBoxDiscontSelect
            // 
            this.groupBoxDiscontSelect.Controls.Add(this.labelDiscontSelect);
            this.groupBoxDiscontSelect.Controls.Add(this.buttonDiscontCreate);
            this.groupBoxDiscontSelect.Controls.Add(this.comboBoxDiscont);
            this.groupBoxDiscontSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDiscontSelect.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDiscontSelect.MaximumSize = new System.Drawing.Size(0, 59);
            this.groupBoxDiscontSelect.MinimumSize = new System.Drawing.Size(0, 59);
            this.groupBoxDiscontSelect.Name = "groupBoxDiscontSelect";
            this.groupBoxDiscontSelect.Size = new System.Drawing.Size(786, 59);
            this.groupBoxDiscontSelect.TabIndex = 2;
            this.groupBoxDiscontSelect.TabStop = false;
            this.groupBoxDiscontSelect.Text = "Выбор скидки";
            // 
            // labelDiscontSelect
            // 
            this.labelDiscontSelect.AutoSize = true;
            this.labelDiscontSelect.Location = new System.Drawing.Point(6, 16);
            this.labelDiscontSelect.Name = "labelDiscontSelect";
            this.labelDiscontSelect.Size = new System.Drawing.Size(134, 13);
            this.labelDiscontSelect.TabIndex = 2;
            this.labelDiscontSelect.Text = "Выберите номер скидки:";
            // 
            // buttonDiscontCreate
            // 
            this.buttonDiscontCreate.Location = new System.Drawing.Point(151, 31);
            this.buttonDiscontCreate.Name = "buttonDiscontCreate";
            this.buttonDiscontCreate.Size = new System.Drawing.Size(75, 21);
            this.buttonDiscontCreate.TabIndex = 1;
            this.buttonDiscontCreate.Text = "Создать";
            this.buttonDiscontCreate.UseVisualStyleBackColor = true;
            this.buttonDiscontCreate.Click += new System.EventHandler(this.buttonDiscontCreate_Click);
            // 
            // comboBoxDiscont
            // 
            this.comboBoxDiscont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscont.FormattingEnabled = true;
            this.comboBoxDiscont.Location = new System.Drawing.Point(9, 32);
            this.comboBoxDiscont.Name = "comboBoxDiscont";
            this.comboBoxDiscont.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiscont.TabIndex = 0;
            this.comboBoxDiscont.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscont_SelectedIndexChanged);
            // 
            // dataGridViewDiscont
            // 
            this.dataGridViewDiscont.AllowUserToAddRows = false;
            this.dataGridViewDiscont.AllowUserToDeleteRows = false;
            this.dataGridViewDiscont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDiscont.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDiscont.MultiSelect = false;
            this.dataGridViewDiscont.Name = "dataGridViewDiscont";
            this.dataGridViewDiscont.ReadOnly = true;
            this.dataGridViewDiscont.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiscont.Size = new System.Drawing.Size(786, 183);
            this.dataGridViewDiscont.TabIndex = 1;
            this.dataGridViewDiscont.SelectionChanged += new System.EventHandler(this.dataGridViewDiscont_SelectionChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlWindow);
            this.Name = "FormMain";
            this.Text = "Нотариус 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlWindow.ResumeLayout(false);
            this.tabPageClient.ResumeLayout(false);
            this.splitContainerClient.Panel1.ResumeLayout(false);
            this.splitContainerClient.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerClient)).EndInit();
            this.splitContainerClient.ResumeLayout(false);
            this.groupBoxClientId.ResumeLayout(false);
            this.groupBoxClientSelect.ResumeLayout(false);
            this.groupBoxClientSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageDeal.ResumeLayout(false);
            this.splitContainerDeal.Panel1.ResumeLayout(false);
            this.splitContainerDeal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDeal)).EndInit();
            this.splitContainerDeal.ResumeLayout(false);
            this.groupBoxDealId.ResumeLayout(false);
            this.groupBoxDealSelect.ResumeLayout(false);
            this.groupBoxDealSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeal)).EndInit();
            this.tabPageService.ResumeLayout(false);
            this.splitContainerService.Panel1.ResumeLayout(false);
            this.splitContainerService.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerService)).EndInit();
            this.splitContainerService.ResumeLayout(false);
            this.groupBoxServiceId.ResumeLayout(false);
            this.groupBoxServiceSelect.ResumeLayout(false);
            this.groupBoxServiceSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.tabPageDiscont.ResumeLayout(false);
            this.splitContainerDiscont.Panel1.ResumeLayout(false);
            this.splitContainerDiscont.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDiscont)).EndInit();
            this.splitContainerDiscont.ResumeLayout(false);
            this.groupBoxDiscontId.ResumeLayout(false);
            this.groupBoxDiscontSelect.ResumeLayout(false);
            this.groupBoxDiscontSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWindow;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.TabPage tabPageDeal;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.TabPage tabPageDiscont;
        private System.Windows.Forms.GroupBox groupBoxClientSelect;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Label labelClientSelect;
        private System.Windows.Forms.Button buttonClientCreate;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.SplitContainer splitContainerClient;
        private System.Windows.Forms.GroupBox groupBoxClientId;
        private System.Windows.Forms.Button buttonClientEdit;
        private System.Windows.Forms.Button buttonClientDelete;
        private System.Windows.Forms.SplitContainer splitContainerDeal;
        private System.Windows.Forms.GroupBox groupBoxDealId;
        private System.Windows.Forms.Button buttonDealEdit;
        private System.Windows.Forms.Button buttonDealDelete;
        private System.Windows.Forms.GroupBox groupBoxDealSelect;
        private System.Windows.Forms.Label labelDealSelect;
        private System.Windows.Forms.Button buttonDealCreate;
        private System.Windows.Forms.ComboBox comboBoxDeal;
        private System.Windows.Forms.DataGridView dataGridViewDeal;
        private System.Windows.Forms.SplitContainer splitContainerService;
        private System.Windows.Forms.GroupBox groupBoxServiceId;
        private System.Windows.Forms.Button buttonServiceEdit;
        private System.Windows.Forms.Button buttonServiceDelete;
        private System.Windows.Forms.GroupBox groupBoxServiceSelect;
        private System.Windows.Forms.Label labelServiceSelect;
        private System.Windows.Forms.Button buttonServiceCreate;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.SplitContainer splitContainerDiscont;
        private System.Windows.Forms.GroupBox groupBoxDiscontId;
        private System.Windows.Forms.Button buttonDiscontEdit;
        private System.Windows.Forms.Button buttonDiscontDelete;
        private System.Windows.Forms.GroupBox groupBoxDiscontSelect;
        private System.Windows.Forms.Label labelDiscontSelect;
        private System.Windows.Forms.Button buttonDiscontCreate;
        private System.Windows.Forms.ComboBox comboBoxDiscont;
        private System.Windows.Forms.DataGridView dataGridViewDiscont;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelDeal;
        private System.Windows.Forms.Label labelDiscont;
        private System.Windows.Forms.Button buttonDealReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

