using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal static partial class Error
    {
        public static byte GetErrorCode(bool validation1)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation1, 1);
            return errorCode;
        }
        public static byte GetErrorCode(bool validation1, bool validation2)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation2, 2);
            errorCode |= GetErrorCode(validation1);
            return errorCode;
        }
        public static byte GetErrorCode(bool validation1, bool validation2, bool validation3)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation3, 4);
            errorCode |= GetErrorCode(validation1, validation2);
            return errorCode;
        }
        public static byte GetErrorCode(bool validation1, bool validation2, bool validation3, bool validation4)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation4, 8);
            errorCode |= GetErrorCode(validation1, validation2, validation3);
            return errorCode;
        }
        public static byte GetErrorCode(bool validation1, bool validation2, bool validation3, bool validation4, bool validation5)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation5, 16);
            errorCode |= GetErrorCode(validation1, validation2, validation3, validation4);
            return errorCode;
        }
        public static byte GetErrorCode(bool validation1, bool validation2, bool validation3, bool validation4, bool validation5, bool validation6)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation6, 32);
            errorCode |= GetErrorCode(validation1, validation2, validation3, validation4, validation5);
            return errorCode;
        }
        public static byte GetErrorCode(bool validation1, bool validation2, bool validation3, bool validation4, bool validation5, bool validation6, bool validation7)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation7, 64);
            errorCode |= GetErrorCode(validation1, validation2, validation3, validation4, validation5, validation6);
            return errorCode;
        }
        public static byte GetErrorCode(bool validation1, bool validation2, bool validation3, bool validation4, bool validation5, bool validation6, bool validation7, bool validation8)
        {
            byte errorCode = 0;
            errorCode |= TryCode(validation8, 128);
            errorCode |= GetErrorCode(validation1, validation2, validation3, validation4, validation5, validation6, validation7);
            return errorCode;
        }
        private static byte TryCode(bool validation, byte bitLevel)
        {
            byte errorCode = 0;
            if (!validation)
            {
                errorCode |= bitLevel;
            }
            return errorCode;
        }


        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1)
        {
            return TryError(errorCode, baseMsg, error1, 1);
        }
        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1, string error2)
        {
            baseMsg = TryError(errorCode, baseMsg, error2, 2);
            return GetErrorMsg(errorCode, baseMsg, error1);
        }
        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1, string error2, string error3)
        {
            baseMsg = TryError(errorCode, baseMsg, error3, 4);
            return GetErrorMsg(errorCode, baseMsg, error1, error2);
        }
        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1, string error2, string error3, string error4)
        {
            baseMsg = TryError(errorCode, baseMsg, error4, 8);
            return GetErrorMsg(errorCode, baseMsg, error1, error2, error3);
        }
        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1, string error2, string error3, string error4, string error5)
        {
            baseMsg = TryError(errorCode, baseMsg, error5, 16);
            return GetErrorMsg(errorCode, baseMsg, error1, error2, error3, error4);
        }
        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1, string error2, string error3, string error4, string error5, string error6)
        {
            baseMsg = TryError(errorCode, baseMsg, error6, 32);
            return GetErrorMsg(errorCode, baseMsg, error1, error2, error3, error4, error5);
        }
        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1, string error2, string error3, string error4, string error5, string error6, string error7)
        {
            baseMsg = TryError(errorCode, baseMsg, error7, 64);
            return GetErrorMsg(errorCode, baseMsg, error1, error2, error3, error4, error5, error6);
        }
        public static string GetErrorMsg(byte errorCode, string baseMsg, string error1, string error2, string error3, string error4, string error5, string error6, string error7, string error8)
        {
            baseMsg = TryError(errorCode, baseMsg, error8, 128);
            return GetErrorMsg(errorCode, baseMsg, error1, error2, error3, error4, error5, error6, error7);
        }
        private static string TryError(byte errorCode, string baseMsg, string error, byte errorLevel)
        {
            if ((errorCode & errorLevel) == errorLevel)
            {
                baseMsg = error;
            }

            return baseMsg;
        }


        public static bool IsErrorFree(byte errorCode1)
        {
            return (errorCode1 == 0);
        }
        public static bool IsErrorFree(byte errorCode1, byte errorCode2)
        {
            return (errorCode1 == 0 && IsErrorFree(errorCode2));
        }
        public static bool IsErrorFree(byte errorCode1, byte errorCode2, byte errorCode3)
        {
            return (errorCode1 == 0 && IsErrorFree(errorCode2, errorCode3));
        }
        public static bool IsErrorFree(byte errorCode1, byte errorCode2, byte errorCode3, byte errorCode4)
        {
            return (errorCode1 == 0 && IsErrorFree(errorCode2, errorCode3, errorCode4));
        }
        public static bool IsErrorFree(byte errorCode1, byte errorCode2, byte errorCode3, byte errorCode4, byte errorCode5)
        {
            return (errorCode1 == 0 && IsErrorFree(errorCode2, errorCode3, errorCode4, errorCode5));
        }
        public static bool IsErrorFree(byte errorCode1, byte errorCode2, byte errorCode3, byte errorCode4, byte errorCode5, byte errorCode6)
        {
            return (errorCode1 == 0 && IsErrorFree(errorCode2, errorCode3, errorCode4, errorCode5, errorCode6));
        }
        public static bool IsErrorFree(byte errorCode1, byte errorCode2, byte errorCode3, byte errorCode4, byte errorCode5, byte errorCode6, byte errorCode7)
        {
            return (errorCode1 == 0 && IsErrorFree(errorCode2, errorCode3, errorCode4, errorCode5, errorCode6, errorCode7));
        }
        public static bool IsErrorFree(byte errorCode1, byte errorCode2, byte errorCode3, byte errorCode4, byte errorCode5, byte errorCode6, byte errorCode7, byte errorCode8)
        {
            return (errorCode1 == 0 && IsErrorFree(errorCode2, errorCode3, errorCode4, errorCode5, errorCode6, errorCode7, errorCode8));
        }
    }
}
