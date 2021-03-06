using System.Collections.Generic;

namespace EpiserverIoc.Core.Tests
{
    public interface IFoo { }

    public class Foo : IFoo { }

    public class Foo2 : IFoo
    {
        public Foo2(IFoo foo)
        {
            Foo = foo;
        }

        public IFoo Foo { get; }
    }

    public class Foo3 : IFoo
    {
        public Foo3(IFoo foo)
        {
            Foo = foo;
        }

        public IFoo Foo { get; }
    }

    public interface IForwardTest { }

    public abstract class BaseTest : IForwardTest
    {
        protected BaseTest()
        {
        }
    }

    public class ConcreteTest : BaseTest { }

    [EPiServer.ServiceLocation.Options]
    public class Options
    {
        public bool IsSet { get; set; }

        public List<string> Strings { get; set; } = new List<string>();
    }
}