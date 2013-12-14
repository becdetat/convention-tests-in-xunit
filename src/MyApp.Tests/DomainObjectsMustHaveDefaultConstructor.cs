using System;
using System.Collections.Generic;
using System.Linq;
using MyApp.Shared;
using MyApp.Shared.Extensions;
using Xunit;
using Xunit.Extensions;

namespace MyApp.Tests
{
    public class DomainObjectsMustHaveDefaultConstructor
    {
        public static IEnumerable<object[]> DomainObjectClasses
        {
            get
            {
                return 
                    from type in typeof (IDomainObject).Assembly.GetTypes()
                    where type.IsAssignableTo<IDomainObject>()
                    where !type.IsAbstract
                    select new[]
                    {
                        type
                    };
            }
        }

        [Theory]
        [PropertyData("DomainObjectClasses")]
        public void DomainObjectHasDefaultConstructor(Type type)
        {
            Assert.NotNull(type.GetConstructor(Type.EmptyTypes));
        }
    }
}