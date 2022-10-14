
using System.IO;


namespace StudentAdmission
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            
            if(!File.Exists("College/Studentdetails.csv"))
            {
                System.Console.WriteLine("creating File");
                File.Create("College/Studentdetails.csv");

            }

            if(!File.Exists("College/Department.csv"))
            {
                System.Console.WriteLine("creating File");
                File.Create("College/Department.csv");

            }
            
            if(!File.Exists("College/Admission.csv"))
            {
                System.Console.WriteLine("creating File");
                File.Create("College/Admission.csv");

            }
            
        }
        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/Studentdetails.csv");

            foreach(string data in students)
            {
                StudentDetails student=new StudentDetails(data);
                Operation.studentList.Add(student);
            }

            string[] depts=File.ReadAllLines("College/Department.csv");
             foreach (string Dept in depts)
             {
                DepartmentDetails dept=new DepartmentDetails(Dept);
                Operation.departList.Add(dept);
             }

             string[] add=File.ReadAllLines("College/Admission.csv");
             foreach (string item in add)
             {
                AdmissionDetails one=new AdmissionDetails(item);
                Operation.add.Add(one);
             }
        }

        public static void WriteToFiles()
        {
            string[] studentDetails=new string[Operation.studentList.Count];
            for (int i = 0; i < Operation.studentList.Count; i++)
            {
               studentDetails[i]=Operation.studentList[i].StudentId+","+Operation.studentList[i].StudentName+","+Operation.studentList[i].FatherName+","+Operation.studentList[i].Gender+","+Operation.studentList[i].DOB.ToShortDateString()+","+Operation.studentList[i].Physics+","+Operation.studentList[i].Chemistry+","+Operation.studentList[i].Maths;
            }
            File.WriteAllLines("College/Studentdetails.csv",studentDetails);

            string[] DepartmentDetails=new string[Operation.departList.Count];

            for (int i = 0; i < Operation.departList.Count ; i++)
            {
                DepartmentDetails[i]=Operation.departList[i].DeptId+","+Operation.departList[i].DepartmentName+","+Operation.departList[i].SeatsAvailable;
            }
            File.WriteAllLines("College/Department.csv",DepartmentDetails);

            string[] AdmissionDetails=new string[Operation.add.Count];

            for (int i = 0; i < Operation.add.Count; i++)
            {
                AdmissionDetails[i]=Operation.add[i].AdmissionId+","+Operation.add[i].StudentId+","+Operation.add[i].AdmisisonStatus+","+Operation.add[i].DateBooked+","+Operation.add[i].DeptId;
            }
            File.WriteAllLines("College/Admission.csv",AdmissionDetails);

        }
    }
}