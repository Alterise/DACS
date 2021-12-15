namespace DACS.WPF.MVVM.Converter
{
    public enum AritmeticOperators
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Remainder
    }
    
    public enum EqualityOperators
    {
        Equal,
        NotEqual
    }
    
    public enum RelationalOperators
    {
        Greater,
        Less,
        GreaterOrEqual,
        LessOrEqual
    }
    
    public enum LogicalOperators
    {
        Or,
        And
    }
    
    public enum LogicalUnaryOperators
    {
        Negate
    }
    
    public enum BitwiseOperators
    {
        Or,
        And,
        Xor
    }
    
    public enum BitwiseUnaryOperators
    {
        Complement
    }
    
    public enum BoolOperators
    {
        Bool
    }
    
    public enum NullOperators
    {
        Null
    }
}