using Xunit;

namespace BugTracker.Tests
{
    public class BugTests
    {
        [Fact]
        public void Bug_WithAttachmentUrl_CanSetAndGet()
        {
            // Arrange
            var bug = new Bug
            {
                Id = 1,
                Title = "Test Bug",
                Description = "This is a test bug",
                Status = "New",
                Priority = "High"
            };

            // Act
            string testUrl = "https://example.com/attachment.pdf";
            bug.AttachmentUrl = testUrl;

            // Assert
            Assert.Equal(testUrl, bug.AttachmentUrl);
        }

        [Fact]
        public void Bug_NewBug_HasCreationDate()
        {
            // Arrange & Act
            var bug = new Bug();

            // Assert
            Assert.True(bug.CreatedDate <= DateTime.Now);
        }

        [Fact]
        public void Bug_ToString_ReturnsExpectedFormat()
        {
            // Arrange
            var bug = new Bug
            {
                Id = 1,
                Title = "Test Bug",
                Status = "New"
            };

            // Act
            var result = bug.ToString();

            // Assert
            Assert.Equal("Bug 1: Test Bug - New", result);
        }
    }
}
