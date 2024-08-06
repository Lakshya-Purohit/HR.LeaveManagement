using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Profiles
{
    internal class PublicProfile :Profile
    {
        public PublicProfile()
        {
            CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();   
        }
    }
}
