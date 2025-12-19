using System;
using System.Collections.Generic;
using System.Text;

namespace PatternPractice.ChainOfResponsibility.ApproveFlow
{
    public sealed class LeaveRequest
    {
        public string EmployeeName { get; set; }
        public int LeaveDays { get; set; }
        public string Reason { get; set; }
        public LeaveStatus Status { get; set; }= LeaveStatus.Padding;

        public List<Log> logs { get; set; }= new List<Log>();
    }

    public sealed record Log(string Step,DateTimeOffset time, string Approver, LeaveStatus Action, string Comment);

    public enum LeaveStatus
    {
        Padding,
        Approved,
        Rejected        
    }
}
