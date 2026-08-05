namespace StudentManagement{
    class StudentCollection{
        Student[] s = new Student[50];

        public Student this[int i]{
            get { return s[i];}
            set { s[i] = value;}
        }
    }
}