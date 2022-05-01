namespace TechniServIT.ISRT.IK.Common
{
    /// <summary>
    /// Slouží pro uložení a načtení surového těla requestu.
    /// Voláno v <see cref="RawRequestResponseMiddleware"/>
    /// Ukládá i KomunikaceId.
    /// </summary>
    public interface IRawRequestStore
    {
        void SaveRequestRawBody(string body);
        string GetRequestRawBody();

        void SaveKomunikaceId(long komunikaceId);
        long GetKomunikaceId();
    }
}
