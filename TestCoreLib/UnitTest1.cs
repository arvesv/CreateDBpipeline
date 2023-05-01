namespace TestCoreLib
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(42, CoreLib.MyTools.Answer());

        }
    }
}