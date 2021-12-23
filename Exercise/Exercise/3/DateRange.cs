namespace Exercise
{
    public class DateRange
    {
        public DateRange(DateOnly from, DateOnly to)
        {
            From = from;
            To = to;
        }
        public DateOnly From { get; set; }
        public DateOnly To { get; set; }
        
        public void Deconstruct(out DateOnly from, out DateOnly to)
        {
            from = From;
            to = To;
        }
    }
}
