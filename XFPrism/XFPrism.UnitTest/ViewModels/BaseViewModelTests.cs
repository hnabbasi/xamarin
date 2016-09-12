using NUnit.Framework;
using Prism.Navigation;
using XFPrism.ViewModels;

namespace XFPrism.UnitTest.ViewModels
{
    [TestFixture]
    public class BaseViewModelTests
    {
        private BaseViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _viewModel = new BaseViewModel();      
        }

        [Test]
        public void Set_And_Get_Title()
        {
            _viewModel.Title = "Testing";
            var s = _viewModel.Title;
            Assert.AreEqual(_viewModel.Title, s);
        }

        [Test]
        public void Set_And_Get_IsBusy()
        {
            _viewModel.IsBusy = false;
            var s = _viewModel.IsBusy;
            Assert.AreEqual(_viewModel.IsBusy, s);
        }

        [Test]
        public void OnNavigatedFrom_Gets_Called()
        {
            _viewModel.OnNavigatedFrom(new NavigationParameters());
        }

        [Test]
        public void OnNavigatedTo_Gets_Called()
        {
            _viewModel.OnNavigatedTo(new NavigationParameters());
        }
        [TearDown]
        public void TearDown()
        {
            _viewModel = null;
        }
    }
}
