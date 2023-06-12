using DddInPractice.Logic;
using NHibernate;
using Xunit;

namespace DddInPractice.Logic.Tests
{
    public class TemporaryTest
    {
        [Fact]
        public void Test()
        {
            SessionFactory.Init(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DddInPractice;Integrated Security=True;");

            using(ISession session = SessionFactory.OpenSession())
            {
                long id = 1;
                var snackMachine = session.Get<SnackMachine>(id);
            }
        }
    }
}
