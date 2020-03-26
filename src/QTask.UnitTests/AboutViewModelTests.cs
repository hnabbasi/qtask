using NUnit.Framework;
using Moq;
using Xamarin.Essentials.Interfaces;
using QTask.ViewModels;

namespace QTask.UnitTests
{
    [TestFixture]
    public class AboutViewModelTests
    {
        private Mock<IAppInfo> _mockAppInfo;
        private AboutViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _mockAppInfo = new Mock<IAppInfo>();
            _viewModel = new AboutViewModel(_mockAppInfo.Object);
        }

        [Test]
        public void AppName_Is_Set()
        {
            _mockAppInfo.Setup(s => s.Name).Returns("Test App");
            Assert.AreEqual("Test App", _viewModel.AppName);
        }

        [Test]
        public void AppVersion_Is_Set()
        {
            _mockAppInfo.Setup(s => s.VersionString).Returns("9.9.9");
            Assert.AreEqual("9.9.9", _viewModel.AppVersion);
        }

        [TearDown]
        public void Destroy()
        {
            _mockAppInfo = null;
            _viewModel = null;
        }
    }
}
