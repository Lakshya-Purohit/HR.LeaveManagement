using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Queries
{
    public class GetLeaveTypeListRequest :IRequest<List<LeaveTypeDto>>
    {
    }
}
