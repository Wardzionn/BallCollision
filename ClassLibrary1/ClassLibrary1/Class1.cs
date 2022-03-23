namespace ClassLibrary1
{
    public class Class1
    {
        public int age;
        public string name;
        public string description;

        public Class1(int age,string name, string description)
        {
            this.age = age;
            this.name=name;
            this.description = description;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return this.age;
        }
    }
}