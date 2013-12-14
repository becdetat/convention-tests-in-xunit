namespace MyApp.Shared
{
    public interface IDomainObject
    {
    }

    public class PassingDomainObject : IDomainObject
    {
    }

    public class AnotherPassingDomainObject : IDomainObject
    {
    }

    public class PassingChildDomainObject : AnotherPassingDomainObject
    {
    }

    public abstract class AbstractClass : IDomainObject
    {
        public AbstractClass(string s)
        {
        }
    }

    public class PassingInheritorOfAbstractClass : AbstractClass
    {
        public PassingInheritorOfAbstractClass()
            : base("")
        {
        }
    }

    //public class FailingDomainObject : IDomainObject
    //{
    //    public FailingDomainObject(string s)
    //    {
    //    }
    //}
}