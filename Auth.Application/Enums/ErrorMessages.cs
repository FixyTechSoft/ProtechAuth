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
        public static string UserRegisterExist = "El usuario ya esta registrado.";

        /** 
         * LOGIN
         * **/

        public static string EmailNoEmpty = "El email es requerido.";
        public static string EmailInvalid = "El email es invalido.";

        public static string PasswordLen = "El password debe contener entre 8 y 15 caracteres.";
        public static string PasswordLogic = "El password debe contener caracteres en minuscula, mayuscula, numeros y alguno de estos simbolos ($%&!#).";
        public static string PasswordNoEmpty = "El password es requerido.";


    }
}
