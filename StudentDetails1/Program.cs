using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Student
    {

        private int rollno;
        public string Name { get; set; }//auto implemented
        private int sem;
        private string branch;
        private int marks;

        public int Rollno
        {
            get => rollno;
            set => rollno = value;
        }
        /* public string Name
         {
             get => name;
             set => name = value;
         }
         public int Rollno
         {
             get
             {
                 return rollno;
             }
             set
             {
                 rollno=value;
             }
         }
              */
        public int Sem
        {
            get => sem;
            set => sem = value;
        }
        private string Branch
        {
            get => branch;
            set => branch = value;
        }
        public int Marks
        {
            get => marks;
        }
        public Student()//default constructor
        {
            this.rollno = 0;
            this.Name = "";
            this.marks = 0;
            this.sem = 3;
            this.branch = "cse";
        }
        public Student(string name,int rollno,string branch,int sem,int marks)
        {
            this.Name = name;
            this.rollno = rollno;
            this.branch = branch;
            this.marks = marks;
            this.sem = sem;
        }
        public void AcceptStudentDetails()
        {
            Console.WriteLine("Enter the mark :");
            this.marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the branch :");
            this.Branch = Console.ReadLine();

        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student details are displayed");
            Console.WriteLine(this.Name + "\n" + this.Rollno + "\n" + this.Sem + "\n" + this.Branch + "\n" + this.Marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Student st1 = new Student("sai", 5, "ece", 2, 87);
            //st.Name = "Ram";
            //st.Rollno = 100;
            //st.Sem = 4;
            //st.AcceptStudentDetails();
            st.DisplayStudentDetails();
            st1.DisplayStudentDetails();
            Console.ReadKey();
        }
    }

}
