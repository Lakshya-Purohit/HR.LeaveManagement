using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Command
{
    public class CreateLeaveTypeCommand :IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
