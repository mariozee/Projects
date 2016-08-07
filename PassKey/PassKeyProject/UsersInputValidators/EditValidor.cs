namespace PassKey.UsersInputValidators
{
    using Exceptions;
    using Data;

    public class EditValidor
    {
        public void Validate(string hostName, LoggedUser user)
        {
            if (string.IsNullOrWhiteSpace(hostName))
            {
                throw new InvalidHostNameException(GlobalMessages.HostNameEmpty);
            }

            if (user.UserData.ContainsKey(hostName))
            {
                throw new InvalidHostNameException(GlobalMessages.HostNameAlreadyExist);
            }
        }
    }
}