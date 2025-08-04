using prjICE_Task_2;

namespace UnitTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
 
        public void testAuthor()
        {
            Books books = new Books("Jane Austen", "Emma", "Fiction", 1036, 1815);
            Assert.AreEqual(books["author"], "Jane Austen");
        }
        [TestMethod]

        public void testTitle()
        {
            Books books = new Books("Jane Austen", "Emma", "Fiction", 1036, 1815);
            Assert.AreEqual(books["title"], "Emma");
        }
        [TestMethod]

        public void testGenre()
        {
            Books books = new Books("Jane Austen", "Emma", "Fiction", 1036, 1815);
            Assert.AreEqual(books["genre"], "Fiction");
        }
        [TestMethod]

        public void updatePages()
        {
            Books book = new Books("Jane Austen", "Emma", "Fiction", 1036, 1815);
            book["pages"] = 1033;
            Assert.AreEqual(book["pages"], 1033);
        }
        [TestMethod]
        public void updatePublishYear()
        {
            Books book = new Books("Jane Austen", "Emma", "Fiction", 1036, 1815);
            book["year"] = 1816;
            Assert.AreEqual(book["year"], 1816);
        }
        

    }
}
