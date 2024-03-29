﻿using Core.Utilities;
using OpenQA.Selenium;

namespace SharelaneAutomation.Pages
{
    public class StartPage : HeaderPage
    {
        By signUpLinkLocator = By.XPath("//a[.='Sign up']");
        private By emaiilInputLocator = By.Name("email");
        private By passwordInputLocator = By.Name("password");
        private By loginButtonLocator = By.XPath("//input[@value='Login']");

        public StartPage() : base() { }

        public bool CheckStartPagePresented()
        {
            return ChromeDriver.FindElement(signUpLinkLocator).Displayed;
        }

        private void SetEmail(string email)
        {
            ChromeDriver.FindElement(emaiilInputLocator).SendKeys(email);
        }

        private void SetPassword(string password)
        {
            ChromeDriver.FindElement(passwordInputLocator).SendKeys(password);
        }

        private void ClickLoginButton()
        {
            ChromeDriver.FindElement(loginButtonLocator).Click();
        }

        public MainPage Login(User user)
        {
            TryToLogin(user);
            return new MainPage();
        }

        public LoginPage LoginInvalid(User user)
        {
            TryToLogin(user);
            return new LoginPage();
        }

        private void TryToLogin(User user)
        {
            SetEmail(user.Name);
            SetPassword(user.Password);
            ClickLoginButton();
        }

        public SignUpPage SignUp()
        {
            ChromeDriver.FindElement(signUpLinkLocator).Click();
            return new SignUpPage();
        }
    }
}
