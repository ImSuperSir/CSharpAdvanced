namespace ImSuperSir.Patterns
{
    /// <summary>
    //      The: -->  where Child : class, Parent, new () <-- part
    //              is a type constraint on the generic parameter Child.
    //      class: Ensures that Child is a reference type.
    //      Parent: Requires that Child is assignable to Parent,
    //              meaning Child is either the same type as Parent or derived from Parent.
    //      new (): Specifies that Child must have a parameterless constructor.
    /// </summary>
    public static class FactoryPattern<Parent, Child> where Child : class, Parent, new()
    {
        public static Parent GetInstance()
        {
            Parent objK;
            objK = new Child();
            return objK;
        }
    }

}
