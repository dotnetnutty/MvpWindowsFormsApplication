using System;
using System.Windows.Forms;
using Common.Views;
using Common.Presenters;

namespace MvpWindowsFormsApplication
{
    public partial class Form1 : Form, IView
    {
        WelcomeMessagePresenter _presenter;

        public Form1()
        {
            _presenter = new WelcomeMessagePresenter(this);
            InitializeComponent();
        }

        public string WelcomeMessage
        {
            get
            {
                return lblOutput.Text;
            }
            set
            {
                lblOutput.Text = value;
            }
        }

        public string YourName
        {
            get
            {
                return txtName.Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _presenter.SetLabelText();
        }
    }
}
