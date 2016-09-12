using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using Prism.Navigation;
using XFPrism.Interface;
using XFPrism.ViewModels;

namespace XFPrism.UnitTest.ViewModels
{
    [TestFixture]
    public class SecondPageViewModelTests
    {
        private Mock<ISayHello> _sayHelloService;
        private Mock<INavigationService> _navigationService;
        private SecondPageViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _sayHelloService = new Mock<ISayHello>();
            _navigationService = new Mock<INavigationService>();

            _viewModel = new SecondPageViewModel(_navigationService.Object, _sayHelloService.Object);
        }

        [Test][TestCategory("Login")]
        public void Login_Button_Calls_LoginPage()
        {
            _viewModel.LoginCommand.Execute();
            _navigationService.Verify(n=>n.NavigateAsync(It.IsAny<string>(), null, true, true),
                Times.AtLeastOnce);
        }

        [Test]
        [TestCategory("Alerts")]
        public void Returned_Login_Status_Is_Displayed()
        {
            var navParams = new NavigationParameters { {"sender", ""}, {"login-success", false} };
            _viewModel.OnNavigatedTo(navParams);
            _sayHelloService.Verify(x=>x.SayHello(It.IsAny<string>()), Times.AtLeastOnce);
        }

        [Test]
        public void OnNavigatedTo_Is_Called_With_No_Parameters()
        {
            _viewModel.OnNavigatedTo(new NavigationParameters());
            _sayHelloService.Verify(x => x.SayHello(It.IsAny<string>()), Times.Never);
        }

        [TearDown]
        public void TearDown()
        {
            _navigationService = null;
            _sayHelloService = null;
            _viewModel = null;
        }
    }
}
