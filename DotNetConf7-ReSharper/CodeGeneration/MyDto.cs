namespace DotNetConf.Seventh.ReSharper.Examples.CodeGeneration
{
    public class MyDto
    {
        public MyDto(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        protected bool Equals(MyDto other)
        {
            return string.Equals(Lastname, other.Lastname) && 
                string.Equals(Firstname, other.Firstname);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MyDto) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Firstname != null
                    ? Firstname.GetHashCode()
                    : 0)*397) ^ (Lastname != null
                        ? Lastname.GetHashCode()
                        : 0);
            }
        }

        public static bool operator ==(MyDto left, MyDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MyDto left, MyDto right)
        {
            return !Equals(left, right);
        }
    }
}