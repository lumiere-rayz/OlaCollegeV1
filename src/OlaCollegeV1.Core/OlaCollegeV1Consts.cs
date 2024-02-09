using OlaCollegeV1.Debugging;

namespace OlaCollegeV1
{
    public class OlaCollegeV1Consts
    {
        public const string LocalizationSourceName = "OlaCollegeV1";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "be2517cc469d4f1e8ca7c14356b41e73";
    }
}
