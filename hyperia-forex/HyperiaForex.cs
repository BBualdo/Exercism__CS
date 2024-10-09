using System;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }
    
    public static bool operator ==(CurrencyAmount ca1, CurrencyAmount ca2) =>
        ca1.currency != ca2.currency ? throw new ArgumentException() : ca1.amount == ca2.amount;
    
    public static bool operator !=(CurrencyAmount ca1, CurrencyAmount ca2) =>
        ca1.currency != ca2.currency ? throw new ArgumentException() : ca1.amount != ca2.amount;
    
    public static bool operator >(CurrencyAmount ca1, CurrencyAmount ca2) =>
        ca1.currency != ca2.currency ? throw new ArgumentException() : ca1.amount > ca2.amount;
    
    public static bool operator <(CurrencyAmount ca1, CurrencyAmount ca2) =>
        ca1.currency != ca2.currency ? throw new ArgumentException() : ca1.amount < ca2.amount;
    
    public static CurrencyAmount operator +(CurrencyAmount ca1, CurrencyAmount ca2) =>
        ca1.currency != ca2.currency 
            ? throw new ArgumentException() 
            : new CurrencyAmount(ca1.amount + ca2.amount, ca1.currency);

    public static CurrencyAmount operator -(CurrencyAmount ca1, CurrencyAmount ca2) =>
        ca1.currency != ca2.currency
            ? throw new ArgumentException()
            : new CurrencyAmount(ca1.amount - ca2.amount, ca1.currency);

    public static CurrencyAmount operator *(CurrencyAmount ca1, decimal factor) => new(ca1.amount * factor, ca1.currency);

    public static CurrencyAmount operator /(CurrencyAmount ca1, decimal factor) =>
         factor == 0 
             ? throw new DivideByZeroException()
             : new CurrencyAmount(ca1.amount / factor, ca1.currency);
    
    public static explicit operator double(CurrencyAmount ca) => (double)ca.amount;

    public static implicit operator decimal(CurrencyAmount ca) => ca.amount;
}
