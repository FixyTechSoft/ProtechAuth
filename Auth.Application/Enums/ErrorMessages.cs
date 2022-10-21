using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Application.Enums
{
    public static class ErrorMessages
    {
        public static string AnUnexpectedErrorOcurred = "Error inesperado.";
        public static string CredentialsAreNotValid = "Las credenciales no son validas.";
        public static string AccessTokenIsNotValid = "Access token invalido.";
        public static string RefreshTokenIsNotActive = "Token inactivo.";
        public static string RefreshTokenHasExpired = "Token expirado.";
        public static string RefreshTokenIsNotCorrect = "Token incorrecto.";
        public static string UserDoesNotExist = "El usuario no existe.";
    }
}
