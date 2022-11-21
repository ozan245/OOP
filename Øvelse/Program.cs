using Øvelse;

List<Student> students = new List<Student>()
        {
             new Student {StudentId=1,FirstName="Alexander", LastName="K. H. Runge", DateofBird=new DateTime(02/02/2020)},
             new Student {StudentId=2,FirstName="Rune", LastName="Røddik Hansen", DateofBird=new DateTime(10/05/1998)},
             new Student {StudentId=3,FirstName="Amanda", LastName="Gudmand", DateofBird=new DateTime(02/04/2001)},
             new Student {StudentId=4,FirstName="Dennis", LastName="Paaske", DateofBird=new DateTime(01/01/1997)},
             new Student {StudentId=5,FirstName="Mikkel", LastName="Jensen", DateofBird=new DateTime(02/02/1999)}
        };

List<Teacher> teachers = new List<Teacher>()
        {
             new Teacher {Department="Programmering Underviser",FirstName="Niels",LastName="Olesen", DateofBird=new DateTime(02/02/1975)}
             
        };
List<Course> courses = new List<Course>()
        {
             new Course {CourseName="OOP", TeacherInfo=teachers.Find(t => t.FirstName == "Niels")},
             new Course {CourseName="Grundlæggende Programmering", TeacherInfo=teachers.Find(t => t.FirstName == "Niels")},
             new Course {CourseName="Studie Teknik", TeacherInfo=teachers.Find(t => t.FirstName == "Niels")}


        };

List<Enrollment> enrollments = new List<Enrollment>()
        {
            
        new Enrollment{StudentInfo=students, CourseInfo=courses.Find(c => c.CourseName=="OOP")},
        new Enrollment{StudentInfo=students, CourseInfo=courses.Find(c => c.CourseName=="Grundlæggende Programmering")},
        new Enrollment{StudentInfo=students.FindAll(s =>s.StudentId!=4 && s.StudentId!=5), CourseInfo=courses.Find(c => c.CourseName=="Studie Teknik")}

        };

foreach (var course in enrollments)
{
    if (course.CourseInfo!=null && course.StudentInfo!=null && course.CourseInfo.t)
    {

    }
    Console.WriteLine("Elever for fag: " + course.CourseInfo.CourseName);
}
