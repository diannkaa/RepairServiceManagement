using Lab02.Data.Entities;
using Lab02.Data.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02.App
{
    public partial class RepairRequestForm : Form
    {
        private readonly RepairRequestService _requestService = new RepairRequestService();
        private List<RepairRequest> _requests = new List<RepairRequest>();
        public RepairRequestForm()
        {
            InitializeComponent();

            LoadRelatedData();
            LoadRequests();
            ClearFields();
        }
        private void LoadRelatedData()
        {
            try
            {
                comboBoxClient.DataSource = _requestService.GetAllClients();
                comboBoxClient.DisplayMember = "FullName";
                comboBoxClient.ValueMember = "ClientId";
                comboBoxClient.SelectedIndex = -1;

                comboBoxMaster.DataSource = _requestService.GetAllMasters();
                comboBoxMaster.DisplayMember = "FullName";
                comboBoxMaster.ValueMember = "MasterId";
                comboBoxMaster.SelectedIndex = -1;

                comboBoxStatus.Items.Clear();
                comboBoxStatus.Items.Add("Нова");
                comboBoxStatus.Items.Add("В роботі");
                comboBoxStatus.Items.Add("Завершена");
                comboBoxStatus.Items.Add("Скасована");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Детальна помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadRequests()
        {
            try
            {
                _requests = _requestService.GetAllRequests();

                var result = _requests.Select(r => new
                {
                    r.RequestId,
                    ClientName = r.Client.FullName,
                    MasterName = r.Master.FullName,
                    r.DeviceModel,
                    r.Problem,
                    r.RequestDate,
                    r.Status,
                    r.RepairCost
                }).ToList();

                dataGridViewRequests.DataSource = null;
                dataGridViewRequests.DataSource = result;

                dataGridViewRequests.Columns["RequestId"].Visible = false;

                dataGridViewRequests.Columns["ClientName"].HeaderText = "Клієнт";
                dataGridViewRequests.Columns["MasterName"].HeaderText = "Майстер";
                dataGridViewRequests.Columns["DeviceModel"].HeaderText = "Модель пристрою";
                dataGridViewRequests.Columns["Problem"].HeaderText = "Опис проблеми";
                dataGridViewRequests.Columns["RequestDate"].HeaderText = "Дата звернення";
                dataGridViewRequests.Columns["Status"].HeaderText = "Статус";
                dataGridViewRequests.Columns["RepairCost"].HeaderText = "Вартість ремонту";

                dataGridViewRequests.Columns["Problem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewRequests.Columns["Problem"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dataGridViewRequests.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridViewRequests.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridViewRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                dataGridViewRequests.ClearSelection();
                dataGridViewRequests.CurrentCell = null;

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "Детальна помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetSelectedRequestId()
        {
            if (dataGridViewRequests.SelectedRows.Count == 0)
                throw new InvalidOperationException("Спочатку виберіть заявку в таблиці.");

            return Convert.ToInt32(dataGridViewRequests.SelectedRows[0].Cells["RequestId"].Value);
        }
        private void dataGridViewRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;

            int id = Convert.ToInt32(dataGridViewRequests.Rows[e.RowIndex].Cells["RequestId"].Value);

            var request = _requests.FirstOrDefault(r => r.RequestId == id);

            if (request == null) 
                return;

            textBoxDeviceModel.Text = request.DeviceModel;
            textBoxProblem.Text = request.Problem;
            dateTimePickerRequestDate.Value = request.RequestDate;

            textBoxRepairCost.Text = request.RepairCost?.ToString(CultureInfo.CurrentCulture) ?? "";

            comboBoxClient.SelectedValue = request.ClientId;
            comboBoxMaster.SelectedValue = request.MasterId;
            comboBoxStatus.SelectedItem = request.Status;
        }

        private RepairRequest GetRequestFromFields()
        {
            if (comboBoxClient.SelectedValue == null)
                throw new ValidationException("Оберіть клієнта.");

            if (comboBoxMaster.SelectedValue == null)
                throw new ValidationException("Оберіть майстра.");

            if (comboBoxStatus.SelectedItem == null)
                throw new ValidationException("Оберіть статус заявки.");

            decimal? cost = null;

            if (!string.IsNullOrWhiteSpace(textBoxRepairCost.Text))
            {
                if (!decimal.TryParse(textBoxRepairCost.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal parsedCost))
                    throw new ValidationException("Введіть правильну вартість ремонту.");

                cost = parsedCost;
            }

            return new RepairRequest
            {
                ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                MasterId = Convert.ToInt32(comboBoxMaster.SelectedValue),
                DeviceModel = textBoxDeviceModel.Text.Trim(),
                Problem = textBoxProblem.Text.Trim(),
                RequestDate = dateTimePickerRequestDate.Value,
                Status = comboBoxStatus.SelectedItem.ToString()!,
                RepairCost = cost
            };
        }

        private void ClearFields()
        {
            textBoxDeviceModel.Clear();
            textBoxProblem.Clear();
            textBoxRepairCost.Clear();

            comboBoxClient.SelectedIndex = -1;
            comboBoxMaster.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;

            dateTimePickerRequestDate.Value = DateTime.Now;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var request = GetRequestFromFields();

                _requestService.AddRequest(request);

                MessageBox.Show("Заявку успішно додано!");

                LoadRequests();
                ClearFields();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Перевірте дані");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Не вдалося зберегти заявку в базі даних.");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час додавання заявки.");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedRequestId();

                var request = GetRequestFromFields();
                request.RequestId = id;

                _requestService.UpdateRequest(request);

                MessageBox.Show("Заявку успішно змінено!");

                LoadRequests();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Перевірте дані");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Не вдалося змінити заявку в базі даних.");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час редагування.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedRequestId();

                var result = MessageBox.Show(
                    "Ви дійсно хочете видалити цю заявку?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _requestService.DeleteRequest(id);

                    LoadRequests();
                    ClearFields();

                    MessageBox.Show("Заявку видалено!");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Не вдалося видалити заявку. Можливо, з нею пов'язані інші записи.");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час видалення.");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadRelatedData();
            LoadRequests();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            using (var form = new ClientForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    int newClientId = form.CreatedClientId;

                    comboBoxClient.DataSource = null;
                    comboBoxClient.DataSource = _requestService.GetAllClients();

                    comboBoxClient.DisplayMember = "FullName";
                    comboBoxClient.ValueMember = "ClientId";

                    comboBoxClient.SelectedValue = newClientId;
                }
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClient.SelectedValue == null)
                {
                    MessageBox.Show("Спочатку оберіть клієнта.");
                    return;
                }

                int clientId = Convert.ToInt32(comboBoxClient.SelectedValue);

                var result = MessageBox.Show(
                    "Ви дійсно хочете видалити цього клієнта?",
                    "Підтвердження видалення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                _requestService.DeleteClient(clientId);

                comboBoxClient.DataSource = null;
                comboBoxClient.DataSource = _requestService.GetAllClients();

                comboBoxClient.DisplayMember = "FullName";
                comboBoxClient.ValueMember = "ClientId";
                comboBoxClient.SelectedIndex = -1;

                MessageBox.Show("Клієнта успішно видалено!");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Неможливо видалити");
            }
            catch (Exception)
            {
                MessageBox.Show("Сталася помилка під час видалення клієнта.");
            }
        }
    }
}
