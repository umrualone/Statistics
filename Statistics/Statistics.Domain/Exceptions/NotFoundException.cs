namespace Statistics.Domain.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string file) : base(file) { }
    }
}