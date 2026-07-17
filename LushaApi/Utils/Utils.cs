using System;

namespace LushaApi.Utils {

    internal class Utils {
        /// <summary>Require a parameter to not be null</summary>
        /// <param name="argument">Value of the parameter</param>
        /// <param name="paramName">Name of the parameter</param>
        public static void RequireArgument(object? argument, string paramName) {
            if (argument == null)
                throw new ArgumentNullException(paramName);
        }

        public static void RequireStringArgument(string? argument, string paramName) {
            if (string.IsNullOrWhiteSpace(argument))
                throw new ArgumentNullException(paramName);
        }
    }
}
