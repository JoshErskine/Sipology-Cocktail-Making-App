using AutoFixture;
using AutoFixture.AutoNSubstitute;

namespace EntityFrameworkIntroduction.Tests.Common
{
    public class AutoDataAttribute : AutoFixture.NUnit3.AutoDataAttribute
    {
        public AutoDataAttribute()
            : base(() =>
            {
                var fixture = new Fixture().Customize(customization: new AutoNSubstituteCustomization { ConfigureMembers = true });
                fixture.Behaviors.Add(new OmitOnRecursionBehavior());
                return fixture;
            })
        {
        }
    }

    public class InlineAutoDataAttribute : AutoFixture.NUnit3.InlineAutoDataAttribute
    {
        public InlineAutoDataAttribute(params object[] arguments)
            : base(() =>
            {
                var fixture = new Fixture().Customize(customization: new AutoNSubstituteCustomization { ConfigureMembers = true });
                fixture.Behaviors.Add(new OmitOnRecursionBehavior());
                return fixture;
            }, arguments)
        {
        }
    }
}