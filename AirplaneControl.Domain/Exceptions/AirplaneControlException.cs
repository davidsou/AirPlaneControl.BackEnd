using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain.Exceptions
{
   public class AirplaneControlException : Exception
    {
        public static Dictionary<Error, string> ErrorMessages = new Dictionary<Error, string>()
        {
            { Error.NotAuthorized, "O usuário precisa estar logado para efetuar essa ação." },
            { Error.Forbidden, "Usuário não tem as permissões necessárias para efetuar esta ação." },
            { Error.NotFound, "Entidade não encontrada. Por favor, verifique." }
        };

        public enum Error
        {
            BadRequest = 400,
            NotAuthorized = 401,
            Forbidden = 403,
            NotFound = 404
        }

        public Error ErrorType { get; set; }

        public AirplaneControlException(string message) : this(Error.BadRequest, message) { }
        public AirplaneControlException(Error error) : this(error, ErrorMessages[error]) { }
        public AirplaneControlException(Error error, string message) : base(message)
        {
            ErrorType = error;
        }
    }
}
