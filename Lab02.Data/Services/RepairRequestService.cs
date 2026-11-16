using Lab02.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Data.Services
{
    public class RepairRequestService
    {
        public List<RepairRequest> GetAllRequests()
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
                return context.RepairRequests.Include(r => r.Client).Include(r => r.Master).OrderBy(r => r.RequestDate).ToList();
        }

        public List<RepairRequest> GetNewRequests()
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
                return context.RepairRequests.Where(r => r.Status == "Нова").OrderBy(r => r.RequestDate).ToList();
        }

        private void ValidateRequest(AppDbContext context, RepairRequest request)
        {
            var results = new List<ValidationResult>();
            var validationContext = new ValidationContext(request);

            if (!Validator.TryValidateObject(request, validationContext, results, true))
                throw new ValidationException(string.Join("\n", results.Select(r => r.ErrorMessage)));

            if (!context.Clients.Any(c => c.ClientId == request.ClientId))
                throw new ValidationException("Оберіть клієнта.");

            if (!context.Masters.Any(m => m.MasterId == request.MasterId))
                throw new ValidationException("Оберіть майстра.");

            if (request.RequestDate == default)
                throw new ValidationException("Вкажіть дату заявки.");

            if (request.RepairCost < 0)
                throw new ValidationException("Вартість не може бути від'ємною.");
        }

        public void AddRequest(RepairRequest request)
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
            {
                ValidateRequest(context, request);
                context.RepairRequests.Add(request);
                context.SaveChanges();
            }
        }

        public void UpdateRequest(RepairRequest request)
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
            {
                ValidateRequest(context, request);

                var existingRequest = context.RepairRequests.FirstOrDefault(r => r.RequestId == request.RequestId);

                if (existingRequest == null)
                    throw new InvalidOperationException("Заявку не знайдено.");

                existingRequest.ClientId = request.ClientId;
                existingRequest.MasterId = request.MasterId;
                existingRequest.DeviceModel = request.DeviceModel;
                existingRequest.Problem = request.Problem;
                existingRequest.RequestDate = request.RequestDate;
                existingRequest.Status = request.Status;
                existingRequest.RepairCost = request.RepairCost;

                context.SaveChanges();
            }
        }

        public void DeleteRequest(int requestId)
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
            {
                var request = context.RepairRequests.FirstOrDefault(r => r.RequestId == requestId);

                if (request == null)
                    throw new InvalidOperationException("Заявку не знайдено.");

                context.RepairRequests.Remove(request);
                context.SaveChanges();
            }
        }

        public List<Client> GetAllClients()
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
                return context.Clients.OrderBy(c => c.FullName).ToList();
        }

        public List<Master> GetAllMasters()
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
                return context.Masters.OrderBy(m => m.FullName).ToList();
        }

        public int AddClient(Client client)
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
            {
                var results = new List<ValidationResult>();
                var validationContext = new ValidationContext(client);

                if (!Validator.TryValidateObject(client, validationContext, results, true))
                    throw new ValidationException(string.Join("\n", results.Select(r => r.ErrorMessage)));

                context.Clients.Add(client);

                context.SaveChanges();

                return client.ClientId;
            }
        }

        public void DeleteClient(int clientId)
        {
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
            {
                var client = context.Clients.FirstOrDefault(c => c.ClientId == clientId);

                if (client == null)
                    throw new InvalidOperationException("Клієнта не знайдено.");

                bool hasRequests = context.RepairRequests.Any(r => r.ClientId == clientId);

                if (hasRequests)
                    throw new InvalidOperationException("Неможливо видалити клієнта, оскільки за ним закріплені заявки.");

                context.Clients.Remove(client);
                context.SaveChanges();
            }
        }

    }
}
