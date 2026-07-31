using System;
using System.Collections.Generic;

namespace ApprovalSystem
{
    public class ExpenseRequest
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public string Purpose { get; set; }

        public ExpenseRequest(int id, double amount, string purpose)
        {
            Id = id;
            Amount = amount;
            Purpose = purpose;
        }
    }

    public abstract class Approver
    {
        protected Approver? nextApprover;

        public void SetNext(Approver approver)
        {
            nextApprover = approver;
        }

        public abstract void ApproveRequest(ExpenseRequest request);
    }

    public class TeamLead : Approver
    {
        public override void ApproveRequest(ExpenseRequest request)
        {
            if (request.Amount <= 10000)
            {
                Console.WriteLine($"Team Lead approved Request {request.Id} (₹{request.Amount})");
            }
            else if (nextApprover != null)
            {
                nextApprover.ApproveRequest(request);
            }
        }
    }

    public class Manager : Approver
    {
        public override void ApproveRequest(ExpenseRequest request)
        {
            if (request.Amount <= 50000)
            {
                Console.WriteLine($"Manager approved Request {request.Id} (₹{request.Amount})");
            }
            else if (nextApprover != null)
            {
                nextApprover.ApproveRequest(request);
            }
        }
    }

    public class Director : Approver
    {
        public override void ApproveRequest(ExpenseRequest request)
        {
            Console.WriteLine($"Director approved Request {request.Id} (₹{request.Amount})");
        }
    }

    public class Program
    {
        public static void Main()
        {
            TeamLead teamLead = new TeamLead();
            Manager manager = new Manager();
            Director director = new Director();

            teamLead.SetNext(manager);
            manager.SetNext(director);

            List<ExpenseRequest> requests = new List<ExpenseRequest>()
            {
                new ExpenseRequest(1, 5000, "Stationery"),
                new ExpenseRequest(2, 25000, "Laptop"),
                new ExpenseRequest(3, 90000, "Renovation"),
                new ExpenseRequest(4, 8000, "Travel"),
                new ExpenseRequest(5, 45000, "License")
            };

            foreach (ExpenseRequest request in requests)
            {
                teamLead.ApproveRequest(request);
            }
        }
    }
}