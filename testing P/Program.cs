using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace testing_P
{
  [Serializable]
    class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double EmpSel;

        public void setEmpNo(int EmpNo)
        {
            this.EmpNo = EmpNo;
        }
        public void setEmpName(string EmpName)
        {
            this.EmpName = EmpName;
        }
        public void setEmpSel(double EmpSel)
        {
            this.EmpSel = EmpSel;
        }
        public override string ToString()
        {
            return EmpNo + " " + EmpName + " " + EmpSel;
        }
    }
    class Program {


        static void Main(string[] args)
        {
           /* Employee obj = new Employee();
            obj.setEmpNo(101);
            obj.setEmpName("akshay");
            obj.setEmpSel(20.90);

            FileStream o = new FileStream("D:\\saini1.txt",FileMode.OpenOrCreate);

            BinaryFormatter bt = new BinaryFormatter();
            bt.Serialize(o, obj);
            o.Close();
            Console.WriteLine("save  :");*/

            FileStream f = new FileStream("d:\\saini.txt", FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            Employee e = (Employee)b.Deserialize(f);
            Console.WriteLine(e);
            f.Close();



        }
            
    }
}
