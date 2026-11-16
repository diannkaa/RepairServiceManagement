namespace Lab02.App
{
    partial class ClientForm
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
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            buttonSave = new Button();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            buttonCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(23, 122);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(86, 20);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "ПІБ клієнта";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(171, 119);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(125, 27);
            textBoxFullName.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.LightGray;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = Color.Black;
            buttonSave.Location = new Point(55, 307);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 40);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(23, 181);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(126, 20);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Номер телефону";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(171, 178);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 4;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(23, 237);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(59, 20);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Адреса";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(171, 230);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightGray;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(254, 307);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 40);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(110, 28);
            label1.Name = "label1";
            label1.Size = new Size(212, 41);
            label1.TabIndex = 8;
            label1.Text = "Новий клієнт";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(446, 377);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxPhone);
            Controls.Add(labelPhone);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            ForeColor = Color.Black;
            MaximizeBox = false;
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додавання клієнта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFullName;
        private TextBox textBoxFullName;
        private Button buttonSave;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Button buttonCancel;
        private Label label1;
    }
}