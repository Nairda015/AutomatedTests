using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public static class Validator
    {
        /// <summary>
        /// Returns true value if the input date ranges are not overlapping
        /// </summary>
        /// <returns></returns>
        public static bool ValidateOverlapping(List<DateRange> dateRanges, DateRange input)
        {
            if (!dateRanges.Any()) return true;

            var overlappingDateRange = dateRanges.FirstOrDefault(dr => dr.IsOverlapping(input));
            if (overlappingDateRange is not null) return true;

            var outerOverlappingDateRange = dateRanges.FirstOrDefault(dr => dr.IsInside(input));
            if (outerOverlappingDateRange != null) return true;

            var innerOverlappingDateRange = dateRanges.FirstOrDefault(input.IsInside);
            return innerOverlappingDateRange is not null;
        }

        private static bool IsOverlapping(this DateRange booked, DateRange newReservation)
        {
            var (from, to) = newReservation;
            return booked.IsBetween(from) || booked.IsBetween(to);
        }
        
        private static bool IsBetween(this DateRange booked, DateOnly date)
        {
            var (from, to) = booked;
            return from <= date && to >= date;
        }
        
        private static bool IsInside(this DateRange booked, DateRange newReservation)
        {
            var (from, to) = newReservation;
            return booked.From <= from && booked.To >= to;
        }
    }
}
