using Demo.DataAccess.Data.Contexts;

namespace Demo.DataAccess.Data.Repositories
{
    internal class ApplicationDbConsext
    {
        internal readonly object Departments;

        public static implicit operator ApplicationDbConsext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}