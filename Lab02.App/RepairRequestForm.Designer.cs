namespace Lab02.App
{
    partial class RepairRequestForm
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
            dataGridViewRequests = new DataGridView();
            labelDeviceModel = new Label();
            textBoxDeviceModel = new TextBox();
            labelClient = new Label();
            labelProblem = new Label();
            textBoxRepairCost = new TextBox();
            textBoxProblem = new TextBox();
            comboBoxClient = new ComboBox();
            labelRequestDate = new Label();
            labelMaster = new Label();
            labelStatus = new Label();
            labelRepairCost = new Label();
            comboBoxMaster = new ComboBox();
            dateTimePickerRequestDate = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            buttonRefresh = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonAddClient = new Button();
            buttonDeleteClient = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(20, 20);
            dataGridViewRequests.MultiSelect = false;
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.ReadOnly = true;
            dataGridViewRequests.RowHeadersWidth = 51;
            dataGridViewRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRequests.Size = new Size(1040, 250);
            dataGridViewRequests.TabIndex = 0;
            // 
            // labelDeviceModel
            // 
            labelDeviceModel.AutoSize = true;
            labelDeviceModel.Location = new Point(20, 291);
            labelDeviceModel.Name = "labelDeviceModel";
            labelDeviceModel.Size = new Size(137, 20);
            labelDeviceModel.TabIndex = 1;
            labelDeviceModel.Text = "Модель пристрою";
            // 
            // textBoxDeviceModel
            // 
            textBoxDeviceModel.Location = new Point(163, 288);
            textBoxDeviceModel.Name = "textBoxDeviceModel";
            textBoxDeviceModel.Size = new Size(125, 27);
            textBoxDeviceModel.TabIndex = 2;
            // 
            // labelClient
            // 
            labelClient.AutoSize = true;
            labelClient.Location = new Point(21, 427);
            labelClient.Name = "labelClient";
            labelClient.Size = new Size(56, 20);
            labelClient.TabIndex = 3;
            labelClient.Text = "Клієнт ";
            // 
            // labelProblem
            // 
            labelProblem.AutoSize = true;
            labelProblem.Location = new Point(20, 362);
            labelProblem.Name = "labelProblem";
            labelProblem.Size = new Size(121, 20);
            labelProblem.TabIndex = 4;
            labelProblem.Text = "Опис проблеми";
            // 
            // textBoxRepairCost
            // 
            textBoxRepairCost.Location = new Point(642, 419);
            textBoxRepairCost.Name = "textBoxRepairCost";
            textBoxRepairCost.Size = new Size(125, 27);
            textBoxRepairCost.TabIndex = 5;
            // 
            // textBoxProblem
            // 
            textBoxProblem.Location = new Point(163, 341);
            textBoxProblem.Multiline = true;
            textBoxProblem.Name = "textBoxProblem";
            textBoxProblem.Size = new Size(250, 60);
            textBoxProblem.TabIndex = 6;
            // 
            // comboBoxClient
            // 
            comboBoxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(163, 419);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(151, 28);
            comboBoxClient.TabIndex = 7;
            // 
            // labelRequestDate
            // 
            labelRequestDate.AutoSize = true;
            labelRequestDate.Location = new Point(487, 335);
            labelRequestDate.Name = "labelRequestDate";
            labelRequestDate.Size = new Size(85, 20);
            labelRequestDate.TabIndex = 8;
            labelRequestDate.Text = "Дата заяви";
            // 
            // labelMaster
            // 
            labelMaster.AutoSize = true;
            labelMaster.Location = new Point(487, 288);
            labelMaster.Name = "labelMaster";
            labelMaster.Size = new Size(69, 20);
            labelMaster.TabIndex = 9;
            labelMaster.Text = "Майстер";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(487, 381);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Статус";
            // 
            // labelRepairCost
            // 
            labelRepairCost.AutoSize = true;
            labelRepairCost.Location = new Point(487, 422);
            labelRepairCost.Name = "labelRepairCost";
            labelRepairCost.Size = new Size(129, 20);
            labelRepairCost.TabIndex = 11;
            labelRepairCost.Text = "Вартість ремонту";
            // 
            // comboBoxMaster
            // 
            comboBoxMaster.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaster.FormattingEnabled = true;
            comboBoxMaster.Location = new Point(642, 285);
            comboBoxMaster.Name = "comboBoxMaster";
            comboBoxMaster.Size = new Size(151, 28);
            comboBoxMaster.TabIndex = 12;
            // 
            // dateTimePickerRequestDate
            // 
            dateTimePickerRequestDate.Location = new Point(642, 328);
            dateTimePickerRequestDate.Name = "dateTimePickerRequestDate";
            dateTimePickerRequestDate.Size = new Size(250, 27);
            dateTimePickerRequestDate.TabIndex = 13;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(642, 373);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 14;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.LightGray;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Location = new Point(849, 493);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(130, 40);
            buttonRefresh.TabIndex = 15;
            buttonRefresh.Text = "Оновити";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.LightGray;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Location = new Point(594, 493);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(130, 40);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.LightGray;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(348, 493);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(130, 40);
            buttonEdit.TabIndex = 17;
            buttonEdit.Text = "Редагувати";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LightGray;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Location = new Point(100, 493);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(130, 40);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonAddClient
            // 
            buttonAddClient.BackColor = Color.LightGray;
            buttonAddClient.FlatAppearance.BorderSize = 0;
            buttonAddClient.FlatStyle = FlatStyle.Flat;
            buttonAddClient.Location = new Point(298, 551);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(180, 40);
            buttonAddClient.TabIndex = 19;
            buttonAddClient.Text = "Додати клієнта";
            buttonAddClient.UseVisualStyleBackColor = false;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.BackColor = Color.LightGray;
            buttonDeleteClient.FlatAppearance.BorderSize = 0;
            buttonDeleteClient.FlatStyle = FlatStyle.Flat;
            buttonDeleteClient.Location = new Point(594, 551);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(180, 40);
            buttonDeleteClient.TabIndex = 20;
            buttonDeleteClient.Text = "Видалити клієнта";
            buttonDeleteClient.UseVisualStyleBackColor = false;
            buttonDeleteClient.Click += buttonDeleteClient_Click;
            // 
            // RepairRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1082, 603);
            Controls.Add(buttonDeleteClient);
            Controls.Add(buttonAddClient);
            Controls.Add(buttonAdd);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonRefresh);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimePickerRequestDate);
            Controls.Add(comboBoxMaster);
            Controls.Add(labelRepairCost);
            Controls.Add(labelStatus);
            Controls.Add(labelMaster);
            Controls.Add(labelRequestDate);
            Controls.Add(comboBoxClient);
            Controls.Add(textBoxProblem);
            Controls.Add(textBoxRepairCost);
            Controls.Add(labelProblem);
            Controls.Add(labelClient);
            Controls.Add(textBoxDeviceModel);
            Controls.Add(labelDeviceModel);
            Controls.Add(dataGridViewRequests);
            MaximizeBox = false;
            Name = "RepairRequestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Керування заявами";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRequests;
        private Label labelDeviceModel;
        private TextBox textBoxDeviceModel;
        private Label labelClient;
        private Label labelProblem;
        private TextBox textBoxRepairCost;
        private TextBox textBoxProblem;
        private ComboBox comboBoxClient;
        private Label labelRequestDate;
        private Label labelMaster;
        private Label labelStatus;
        private Label labelRepairCost;
        private ComboBox comboBoxMaster;
        private DateTimePicker dateTimePickerRequestDate;
        private ComboBox comboBoxStatus;
        private Button buttonRefresh;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private Button buttonAddClient;
        private Button buttonDeleteClient;
    }
}