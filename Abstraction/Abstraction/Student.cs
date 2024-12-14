using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Student : ICloneable, IComparable<Student>
    {


        public Student() { } 
        public Student(string fnm, string lnm, int id) 
        {
            Fname = fnm;
            Lname = lnm;
            Id = id;
        }
        public Student(string fnm, string lnm, int id,
        int test1, int test2) 
        {
            Fname = fnm;
            Lname = lnm;
            Id = id;
            TestScores[0] = test1;
            TestScores[1] = test2;
        }
        public int[] TestScores { get; set; } = new int[2];
        protected string Fname { get; set; }
        protected string Lname { get; set; }
        public int Id { get; set; }
        public Address Addr { get; set; } = new Address();

        public int CompareTo(Student? other)
        {
            if (other != null)
            {
                int lastNameComparison = this.Lname.CompareTo(other.Lname);
                if (lastNameComparison == 0)
                {
                    return this.Id.CompareTo(other.Id);
                }
                return lastNameComparison;
            }
            return 0;
        }




        public override string ToString()
        {
            return "Fname=" + Fname +
            " Lname=" + Lname + " ID=" + Id.ToString() +
            " Test1=" + TestScores[0].ToString() + " Test2=" +
            TestScores[1].ToString() + "\n" + Addr.Street + "," + Addr.City;
        }

        public virtual string GetGrade()
        {
            string grade = "";
            
        double avg = 0.4 * TestScores[0] + 0.6 * TestScores[1];
            if (avg > 90)
                grade = "A";
            else if (avg > 85)
                grade = "A-";
            else if (avg > 80)
                grade = "B+";
            else
                grade = "B";
            return grade;
        }
        public object Clone()
        {
            Student snew = new Student();
            snew = (Student)this.MemberwiseClone();
            snew.TestScores = (int[])this.TestScores.Clone();
            snew.Addr = (Address)this.Addr.Clone();
            return snew;
        }


    }

}
