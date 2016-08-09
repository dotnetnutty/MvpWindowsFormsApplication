using Common.Presenters;
using Common.Views;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class YourNamePresenterTests
    {
        IView _view;

        [SetUp]
        public void Setup()
        {
            _view = new MyFakeView { YourName = "Neil" };
        }

        [Test]
        public void SetLabelText_NameEntered_WelcomeMessageSetCorrectly()
        {
            // Arrange
            var presenter = new WelcomeMessagePresenter(_view);

            // Act
            presenter.SetLabelText();

            // Assert
            Assert.AreEqual("Hello, Neil!", _view.WelcomeMessage);
        }
    }

    public class MyFakeView : IView
    {
        public string WelcomeMessage
        {
            get; set;
        }

        public string YourName
        {
            get; set;
        }
    }
}


// Moq
// var viewMock = new Mock<IView>();
// viewMock.SetupGet(p => p.YourName).Returns("Neil");
// var view = viewMock.Object;
