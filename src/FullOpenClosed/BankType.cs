using Shared;

namespace FullOpenClosed;

internal readonly struct BankType : IEquatable<BankType>
{ 
    private readonly Bank bank;
    private readonly PaymentType type;

    public BankType(Bank bank,
                    PaymentType type)
    {
        this.bank = bank;
        this.type = type;
    }

    public override bool Equals(object? obj) 
        => obj is BankType choice
           && Equals(choice);

    public bool Equals(BankType other)
    {
        return type == other.type &&
               bank == other.bank;
    }

    public override int GetHashCode() 
        => HashCode.Combine(type, bank);

    public static bool operator ==(BankType left,
                                   BankType right) 
        => left.Equals(right);

    public static bool operator !=(BankType left,
                                   BankType right) 
        => !(left == right);
}
