namespace OsuVueAppApi.Exceptions
{
    public class NotAuthorizedException() : Exception(MESSAGE)
    {
        private const string MESSAGE = "User not authorized";
    }
}
