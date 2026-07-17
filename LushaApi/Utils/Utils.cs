using System;

namespace LushaApi.Utils;

internal class Utils {
    /// <summary>Require a parameter to not be null</summary>
    /// <param name="argument">Value of the parameter</param>
    /// <param name="paramName">Name of the parameter</param>
    public static void RequireArgument(
        [System.Diagnostics.CodeAnalysis.NotNull] object? argument,
        [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(argument))] string? paramName = null
    ) {
        if (argument == null)
            throw new ArgumentNullException(paramName);
    }

    public static void RequireStringArgument(
        [System.Diagnostics.CodeAnalysis.NotNull] string? argument,
        [System.Runtime.CompilerServices.CallerArgumentExpression(nameof(argument))] string? paramName = null
    ) {
        if (string.IsNullOrWhiteSpace(argument))
            throw new ArgumentNullException(paramName);
        if (argument == null) // satisfy warning
            throw new ArgumentNullException(paramName);
    }
}
