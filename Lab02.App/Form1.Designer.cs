namespace Lab02.App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonNewRequests = new Button();
            buttonManageRequests = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(926, 219);
            dataGridView1.TabIndex = 0;
            // 
            // buttonNewRequests
            // 
            buttonNewRequests.BackColor = Color.LightGray;
            buttonNewRequests.FlatAppearance.BorderSize = 0;
            buttonNewRequests.FlatStyle = FlatStyle.Flat;
            buttonNewRequests.Location = new Point(620, 139);
            buttonNewRequests.Name = "buttonNewRequests";
            buttonNewRequests.Size = new Size(180, 40);
            buttonNewRequests.TabIndex = 1;
            buttonNewRequests.Text = "Показати нові заяви";
            buttonNewRequests.UseVisualStyleBackColor = false;
            buttonNewRequests.Click += buttonNewRequests_Click;
            // 
            // buttonManageRequests
            // 
            buttonManageRequests.BackColor = Color.LightGray;
            buttonManageRequests.FlatAppearance.BorderSize = 0;
            buttonManageRequests.FlatStyle = FlatStyle.Flat;
            buttonManageRequests.Location = new Point(79, 139);
            buttonManageRequests.Name = "buttonManageRequests";
            buttonManageRequests.Size = new Size(180, 40);
            buttonManageRequests.TabIndex = 2;
            buttonManageRequests.Text = "Керувати заявами";
            buttonManageRequests.UseVisualStyleBackColor = false;
            buttonManageRequests.Click += buttonManageRequests_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(354, 38);
            label1.Name = "label1";
            label1.Size = new Size(228, 41);
            label1.TabIndex = 3;
            label1.Text = "Головне меню";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(927, 450);
            Controls.Add(label1);
            Controls.Add(buttonManageRequests);
            Controls.Add(buttonNewRequests);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сервісний центр";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonNewRequests;
        private Button buttonManageRequests;
        private Label label1;
    }
}
