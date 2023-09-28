using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO50_28_NguyenQuangVinh.Model
{
    public abstract class DepartmentProvider
    {
        private static DepartmentProvider current;
        public static DepartmentProvider Current
        {
            get
            {
                if (current == null)
                {
                    current = new DefaultDepartmentProvider();
                }
                return current;
            }
            set
            {
                current = value ?? new DefaultDepartmentProvider();
            }
        }
        public virtual Department_28_NguyenQuangVinh Department { get;  }

    }

    public class DefaultDepartmentProvider : DepartmentProvider
    {
        public override Department_28_NguyenQuangVinh Department => new Engineering();
    }

    public class MarketingProvider : DepartmentProvider
    {
        public override Department_28_NguyenQuangVinh Department => new Marketing();
    }
}
