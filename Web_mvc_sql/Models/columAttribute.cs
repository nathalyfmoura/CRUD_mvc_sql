
namespace Web_mvc_sql.Models
{
    internal class columAttribute : Attribute
    {
        private string v;

        public columAttribute(string v)
        {
            this.v = v;
        }
    }
}