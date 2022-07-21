using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace UI
{
    class Person
    {
        private string name;

        private string sex;
        private DateTime birthDay;
        public Person()
        {

        }
        public Person(string name, string sex, DateTime birthDay)
        {
            this.name = name;

            this.sex = sex;// male 1, female 0
            this.birthDay = birthDay;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Sex
        {
            get { return sex; }
            set
            {
                sex = value;
            }
        }
        public DateTime BirthDay
        {
            get { return birthDay; }
            set
            {
                birthDay = value;

            }
        }
        public void ReadDataAPerson(StreamReader read)
        {
            this.name = read.ReadLine();
            this.sex = read.ReadLine();
            this.birthDay = Convert.ToDateTime(read.ReadLine());
        }
        public void WriteDataAPerson(StreamWriter write)
        {
            write.WriteLine(this.name);
            write.WriteLine(this.Sex);
            write.WriteLine(this.birthDay.ToString());
        }




    }
}
