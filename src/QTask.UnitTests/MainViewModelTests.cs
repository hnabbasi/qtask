using NUnit.Framework;
using QTask.ViewModels;

namespace QTask.UnitTests
{
    [TestFixture]
    public class MainViewModelTests
    {
        MainViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _viewModel = new MainViewModel();
        }

        [Test]
        public void GetTasks_Should_Return_Tasks()
        {
            _viewModel.GetTasks(); 
            Assert.NotZero(_viewModel.Tasks.Count);
        }

        [TearDown]
        public void Destroy()
        {
            _viewModel = null;
        }
    }
}
