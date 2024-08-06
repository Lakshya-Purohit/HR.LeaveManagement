using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task <LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task<LeaveAllocation> GetLeaveAllocationWithDetails();
    }
}
