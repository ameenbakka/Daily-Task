﻿namespace Task2.Model
{
    public class EmployeeShift
    {
        public int EmployeeShiftId { get; set; }
        public int EmployeeId { get; set; }
        public int ShiftId { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }

        public Employee Employee { get; set; }
        public Shift Shift { get; set; }
    }
}
