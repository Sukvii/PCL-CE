namespace PCL;

internal static class RestrictedFeaturePolicy
{
    internal static bool IsRestricted => false;

    internal static bool Check(string feature, bool showHint = true) => true;

    internal static void ThrowIfRestricted(string feature)
    {
    }
}
