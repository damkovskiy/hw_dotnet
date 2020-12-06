using System;

namespace AssemblyOne
{
    public class Program1
    {
        public static void Main(string[] args)
        {
            // Program program = new Program(); объект не можем создать, потому что ссылка на проект в другом направлении работает. 
        }

        public void ShowPublic() 
        {
        }

        private void ShowPrivate()
        {
        }

        internal void ShowInternal()
        {
        }

        protected void ShowProtected()
        {
        }

        protected internal void ShowProtectedInternal()
        {
        }

        protected private void ShowProtectedPrivate()
        {
        }
    }
}
