using System;

namespace Alg_lab_6
{
    public class Service : IEquatable<Service>, IComparable<Service>
    {
        public string num { get; set; }
        public string car { get; set; }
        public string owner { get; set; }
        public DateTime lastDate { get; set; }
        public DateTime endDate { get; set; }

        public override string ToString()
        {
            return num + "||" + car + "||" + owner + "||" + lastDate + "||" + endDate;
        }

        public int SortByNumAscending(string num1, string num2)
        {
            return num1.CompareTo(num2);
        }

        public int CompareTo(Service compareService)
        {
            if (compareService == null)
                return 1;
            else
                return this.num.CompareTo(compareService.num);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Service objAsService = obj as Service;
            if (objAsService == null) return false;
            else return Equals(objAsService);
        }
        public bool Equals(Service other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
