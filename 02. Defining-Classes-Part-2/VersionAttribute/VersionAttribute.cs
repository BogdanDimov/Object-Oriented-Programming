using System;

namespace DefiningClassesPart2.VersionAttribute
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class MyVersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public MyVersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public int Major
        {
            get
            {
                return major;
            }

            set
            {
                major = value;
            }
        }

        public int Minor
        {
            get
            {
                return minor;
            }

            set
            {
                minor = value;
            }
        }
    }
}
