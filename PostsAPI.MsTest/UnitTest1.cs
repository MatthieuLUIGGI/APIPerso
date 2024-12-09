using PostsAPI.Tools;
using System.Text.Json;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace PostsAPI.MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class UnitTestMethod1
        {
            [TestMethod]
            public void TestMethod1()
            {
                Call call = new Call();
                var url = "https://jsonplaceholder.typicode.com/posts/5";
                var result = call.GetDataFromApi(url);
                Assert.IsNotNull(result);
                Posts posts = JsonSerializer.Deserialize<Posts>(result);
                Assert.IsNotNull(posts);
                Assert.IsNotNull(posts.body);
            }
        }
    }
}