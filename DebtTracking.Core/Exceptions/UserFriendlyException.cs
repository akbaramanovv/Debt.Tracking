namespace DebtTracking.Core.Exceptions
{
    public class UserFriendlyException : Exception
    {
        public UserFriendlyException(string errorMessage) : this(errorMessage, null)
        {

        }
        public UserFriendlyException(string errorMessage, Exception ex) : base($"The following exception has occured. {errorMessage}", ex)
        {

        }
    }
}
