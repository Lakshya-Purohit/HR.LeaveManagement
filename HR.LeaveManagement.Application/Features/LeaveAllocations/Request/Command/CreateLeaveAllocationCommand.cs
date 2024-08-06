using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Request.Command
{
    public class CreateLeaveAllocationCommand:IRequest<int>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
