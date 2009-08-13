namespace libeveapi
{
    /// <summary>
    /// Represents the seven wallet divisions available to corporations.
    /// Casting from int to WalletDivision is possible because WalletDivision is numbered 1000 till 1006.
    /// </summary>
    public enum WalletDivision
    {
        Master = 1000,
        Two = 1001,
        Three = 1002,
        Four = 1003,
        Five = 1004,
        Six = 1005,
        Seven = 1006
    }
}