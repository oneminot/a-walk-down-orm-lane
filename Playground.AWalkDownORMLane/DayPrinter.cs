namespace Playground.AWalkDownORMLane
{
    public class DayPrinter
    {
        public enum DayName
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public DayName Name { get; set; }

        public void PrintDayName()
        {
            switch (Name)
            {
                case DayName.Monday:
                    break;
                case DayName.Tuesday:
                    break;
                case DayName.Wednesday:
                    break;
                case DayName.Thursday:
                    break;
                case DayName.Friday:
                    break;
                case DayName.Saturday:
                    break;
                case DayName.Sunday:
                    break;
                default:
                    break;
            }
        }
    }
}