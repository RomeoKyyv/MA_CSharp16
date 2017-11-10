namespace SharpProject.Lab63
{
    public class TestSubject
    {
        public int ProcessInt(int input)
        {
            return input * 2;
        }

        public void ProcessContainer(ref Container container)
        {
            container.getSomeInt()++;
            container.getSomeString() = "new String";
        }
    }

    public class Container
    {
        private int SomeInt;
        private string SomeString;

        public Container(int someInt, string someString)
        {
            this.SomeInt = someInt;
            this.SomeString = someString;
        }

        public ref int getSomeInt()
        {
            return ref SomeInt;
        }

        public ref string getSomeString()
        {
            return ref SomeString;
        }
    }
}