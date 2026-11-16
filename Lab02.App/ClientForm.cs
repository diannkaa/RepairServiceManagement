using Lab02.Data.Entities;
using Lab02.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02.App
{
    public partial class ClientForm : Form
    {
        private readonly RepairRequestService _requestService = new RepairRequestService();
        public int CreatedClientId { get; private set; }
        public ClientForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new Client
                {
                    FullName = textBoxFullName.Text.Trim(),
                    Phone = textBoxPhone.Text.Trim(),
                    Address = textBoxAddress.Text.Trim()
                };

                CreatedClientId = _requestService.AddClient(client);

                MessageBox.Show(
                    "Клієнта успішно додано!",
                    "Успіх",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Перевірте дані",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Сталася помилка під час додавання клієнта.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
