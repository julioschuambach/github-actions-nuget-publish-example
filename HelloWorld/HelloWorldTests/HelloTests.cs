using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloTests
    {
        [TestMethod]
        [DataRow("Hello World!")]
        public void SayTest(string speech)
        {
            var hello = new Hello();
            var helloSpeech = hello.Say();

            Assert.AreEqual(speech, helloSpeech);
        }
    }
}