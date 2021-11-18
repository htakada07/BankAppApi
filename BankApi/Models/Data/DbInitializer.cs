using System;
using System.Linq;

namespace BankApi.Models.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BankContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User
                {
                    FirstName = "Hiroyuki",
                    LastName = "Takada"
                },
                new User
                {
                    FirstName = "John",
                    LastName = "Almario"
                }
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            var balances = new Balance[]
            {
                new Balance
                {
                    CurrentBalance = 100000M,
                    UserId = 1
                },
                new Balance
                {
                    CurrentBalance = 20172.92M,
                    UserId = 2
                }
            };
            foreach (Balance b in balances)
            {
                context.Balances.Add(b);
            }
            context.SaveChanges();

            var payments = new PaymentListItem[]
            {
                new PaymentListItem
                {
                    Date = new DateTime(2021, 10, 1),
                    Amount = 12028.14M,
                    IsReason = false,
                    Reason = null,
                    Status = Enums.Status.Closed,
                    RemainingBalance = 3000M,
                    Currency = "Php",
                    UserId = 1
                },
                new PaymentListItem
                {
                    Date = new DateTime(2021, 8, 21),
                    Amount = 10000M,
                    IsReason = true,
                    Reason = "Delayed due to connection problem",
                    Status = Enums.Status.Pending,
                    RemainingBalance = 2500M,
                    Currency = "Php",
                    UserId = 1
                },
                new PaymentListItem
                {
                    Date = new DateTime(2021, 10, 2),
                    Amount = 8600M,
                    IsReason = false,
                    Reason = null,
                    Status = Enums.Status.Closed,
                    RemainingBalance = 5120M,
                    Currency = "Php",
                    UserId = 1
                },
                new PaymentListItem
                {
                    Date = new DateTime(2021, 9, 4),
                    Amount = 3891,
                    IsReason = true,
                    Reason = "Delayed due to bank system maintenance",
                    Status = Enums.Status.Pending,
                    RemainingBalance = 9131M,
                    Currency = "Php",
                    UserId = 2
                },
                new PaymentListItem
                {
                    Date = new DateTime(2021, 8, 8),
                    Amount = 2000M,
                    IsReason = false,
                    Reason = null,
                    Status = Enums.Status.Closed,
                    RemainingBalance = 982M,
                    Currency = "Php",
                    UserId = 2
                },
                new PaymentListItem
                {
                    Date = new DateTime(2021, 9, 4),
                    Amount = 5700M,
                    IsReason = true,
                    Reason = "Delayed due to bank system maintenance",
                    Status = Enums.Status.Pending,
                    RemainingBalance = 1240M,
                    Currency = "Php",
                    UserId = 2
                },
                new PaymentListItem
                {
                    Date = new DateTime(2021, 5, 18),
                    Amount = 7500M,
                    IsReason = false,
                    Reason = null,
                    Status = Enums.Status.Closed,
                    RemainingBalance = 120M,
                    Currency = "Php",
                    UserId = 1
                }
            };

            foreach (PaymentListItem e in payments)
            {
                context.PaymentListItems.Add(e);
            }
            context.SaveChanges();
        }
    }
}