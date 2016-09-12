using Moq;
using NUnit.Framework;
using Prism.Navigation;
using XFPrism.Interface;
using XFPrism.ViewModels;

namespace XFPrism.UnitTest.ViewModels
{
    [TestFixture]
    public class HomePageViewModelTests
    {
        private Mock<ISayHello> _sayHelloService;
        private Mock<INavigationService> _navigationService;
        private MainPageViewModel _viewModel;
        
        [SetUp]
        public void Setup()
        {
            _sayHelloService = new Mock<ISayHello>();
            _navigationService = new Mock<INavigationService>();
            
            _viewModel = new MainPageViewModel(_sayHelloService.Object, _navigationService.Object);
        }
        [Test]
        public void Welcome_Toast_Is_Displayed()
        {
            _sayHelloService.Verify((h)=>h.SayHello(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Navigate_To_Home_Works()
        {
            _viewModel.HomeCommand.Execute();
            _navigationService.Verify((n)=>n.NavigateAsync(It.IsAny<string>(), null, null, true), Times.Once);
        }
        
        [TearDown]
        public void TearDown()
        {
            _viewModel = null;
            _sayHelloService = null;
            _navigationService = null;
        }
    }
}
