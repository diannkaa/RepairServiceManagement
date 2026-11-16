using Lab02.Data;
using Lab02.Data.Services;

namespace Lab02.App
{
    public partial class Form1 : Form
    {
        private readonly RepairRequestService _requestService = new RepairRequestService();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadNewRequests()
        {
            var requests = _requestService.GetNewRequests();

            var result = requests.Select(r => new
            {
                r.DeviceModel,
                r.Problem,
                r.RequestDate,
                r.Status,
                r.RepairCost
            }).ToList();

            dataGridView1.DataSource = result;

            dataGridView1.Columns["DeviceModel"].HeaderText = "Модель пристрою";
            dataGridView1.Columns["Problem"].HeaderText = "Опис проблеми";
            dataGridView1.Columns["RequestDate"].HeaderText = "Дата звернення";
            dataGridView1.Columns["Status"].HeaderText = "Статус";
            dataGridView1.Columns["RepairCost"].HeaderText = "Вартість ремонту";

            dataGridView1.Columns["Problem"].DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.Columns["Problem"].Width = 350;
        }

        private void buttonNewRequests_Click(object sender, EventArgs e)
        {
            LoadNewRequests();
        }

        private void buttonManageRequests_Click(object sender, EventArgs e)
        {
            RepairRequestForm form = new RepairRequestForm();
            form.ShowDialog();

            LoadNewRequests();
        }
    }
}
