using System.CodeDom;

namespace SharpProject.Lab51
{
    public class Lab51Init
    {
        public Lab51Init()
        {
            InOutOperation operation = new InOutOperation();
//            operation.ReadAsync();
            operation.ChangeLocation("E:/temp");
            operation.WriteData("test.txt", "this is testing!");
            operation.ReadData("E:/temp", "test.txt");
            operation.WriteZip("E:/temp");
            operation.ReadZip("E:/temp", "test.txt.gz");
            operation.WriteToFileFromMemoryStream
        }
    }
}