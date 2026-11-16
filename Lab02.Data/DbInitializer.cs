using Lab02.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Data
{
    public static class DbInitializer
    {
        public static void SeedData(AppDbContext context)
        {
            if (context.Clients.Any())
                return;

            var clients = new List<Client>
            {
                new Client
                {
                    FullName = "Олена Коваленко",
                    Phone = "0671112233",
                    Address = "м. Рівне, вул. Соборна, 10"
                },
                new Client
                {
                    FullName = "Андрій Мельник",
                    Phone = "0502223344",
                    Address = "м. Рівне, вул. Київська, 15"
                },
                new Client
                {
                    FullName = "Марія Шевченко",
                    Phone = "0633334455",
                    Address = "м. Рівне, вул. Шевченка, 20"
                },
                new Client
                {
                    FullName = "Іван Бондар",
                    Phone = "0974445566",
                    Address = "м. Рівне, вул. Дубенська, 5"
                },
                new Client
                {
                    FullName = "Софія Ткаченко",
                    Phone = "0995556677",
                    Address = "м. Рівне, вул. Чорновола, 30"
                }
            };

            var masters = new List<Master>
            {
                new Master
                {
                    FullName = "Олександр Петренко",
                    Phone = "0681112233"
                },
                new Master
                {
                    FullName = "Максим Іваненко",
                    Phone = "0503334455"
                },
                new Master
                {
                    FullName = "Дмитро Сидоренко",
                    Phone = "0935556677"
                }
            };


            var requests = new List<RepairRequest>
            {
                new RepairRequest
                {
                    Client = clients[0],
                    Master = masters[0],
                    DeviceModel = "Samsung WW60",
                    Problem = "Не зливає воду",
                    RequestDate = DateTime.Today.AddDays(-10),
                    Status = "Завершена",
                    RepairCost = 1200
                },
                new RepairRequest
                {
                    Client = clients[1],
                    Master = masters[1],
                    DeviceModel = "LG F2J3",
                    Problem = "Не нагріває воду",
                    RequestDate = DateTime.Today.AddDays(-5),
                    Status = "У процесі",
                    RepairCost = 900
                },
                new RepairRequest
                {
                    Client = clients[2],
                    Master = masters[2],
                    DeviceModel = "Bosch KGN",
                    Problem = "Не охолоджує продукти",
                    RequestDate = DateTime.Today.AddDays(-3),
                    Status = "Очікує запчастин",
                    RepairCost = 3500
                },
                new RepairRequest
                {
                    Client = clients[3],
                    Master = masters[0],
                    DeviceModel = "Indesit IWSC",
                    Problem = "Сильний шум під час роботи",
                    RequestDate = DateTime.Today.AddDays(-2),
                    Status = "Нова",
                    RepairCost = 700
                },
                new RepairRequest
                {
                    Client = clients[4],
                    Master = masters[1],
                    DeviceModel = "Atlant XM",
                    Problem = "Не працює термостат",
                    RequestDate = DateTime.Today.AddDays(-1),
                    Status = "Завершена",
                    RepairCost = 800
                },
                new RepairRequest
                {
                    Client = clients[0],
                    Master = masters[2],
                    DeviceModel = "Samsung MS23",
                    Problem = "Не вмикається мікрохвильова піч",
                    RequestDate = DateTime.Today,
                    Status = "Нова",
                    RepairCost = 500
                }
            };

            context.Clients.AddRange(clients);
            context.Masters.AddRange(masters);
            context.RepairRequests.AddRange(requests);

            context.SaveChanges();
        }
    }
}
