using Common.Views;

namespace Common.Presenters
{
    public class WelcomeMessagePresenter
    {
        IView _view;

        public WelcomeMessagePresenter(IView view)
        {
            _view = view;
        }

        public void SetLabelText()
        {
            _view.WelcomeMessage = "Hello, " + _view.YourName + "!";
        }
    }
}