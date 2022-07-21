using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace UI
{
    class StudentManagement : IEnumerable<StudentManagement>
    {
        private List<Person> list = new List<Person>();

        public StudentManagement()

        {

        }
        public StudentManagement(List<Person> persons)
        {
            list = new List<Person>(persons);
        }

        public List<Person> List
        {
            get { return list; }
            set { list = value; }
        }
        public void AddPerson(Person p)
        {
            this.list.Add(p);
        }
        public void RemovePerson(Person  p)
        {
            list.Remove(p);
        }
        public void RemovePerson(int i)
        {
            list.RemoveAt(i);
        }
        public Person GetIndex(int i)
        {
            return list[i];
        }
        public void ReadFilePerson(string path)
        {
            StreamReader re = new StreamReader(path);
            while(!re.EndOfStream)
            {
                Person tmp = new Person();
                tmp.ReadDataAPerson(re);
                list.Add(tmp);
            }
            re.Close();  
        }
        public void WriteFilePerson(string path)
        {
           StreamWriter wr = new StreamWriter(path);
           foreach(var i in list)
            {
                i.WriteDataAPerson(wr);
                Console.WriteLine(i.Name);
            }
            wr.Close();
        }
        public List<Person> SearchPersons(string name)
        {
            List<Person> p = new List<Person>();
            foreach (var i in list)
            {
                if(i.Name.Contains(name))
                {
                    p.Add(i);
                }
            }

            return p;
        }



        internal void ReadFilePerson()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<StudentManagement> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
   
}
