using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace project
{
    public partial class FormFPR : Form
    {
        FormMain main;
        WebDriver driver;
        const string url = "https://card-search.naver.com/list";
        const string xAnnualFees = "//*[@id=\"app\"]/div[1]/div/div[4]/div/button";
        List<string> annualFees = new List<string>();
        List<IWebElement> clickFees = new List<IWebElement>();
        const string xBasePayment = "//*[@id=\"app\"]/div[1]/div/div[5]/div[2]/button";
        List<string> basePayments = new List<string>();
        List<IWebElement> clickPayments = new List<IWebElement>();
        const string xCardImage = "//*[@id=\"app\"]/div[2]/div/div[2]/ul/li[1]/div[1]/a[1]/figure/img";
        const string xCardName = "//*[@id=\"app\"]/div[2]/div/div[2]/ul/li[1]/div[2]/a/b";
        const string xCardBenefit = "//*[@id=\"app\"]/div[2]/div/div[2]/ul/li[1]/div[2]/p";

        public FormFPR(FormMain main)
        {
            InitializeComponent();
            this.main = main;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(url);

            IList<IWebElement> fees = driver.FindElements(By.XPath(xAnnualFees));
            foreach (IWebElement fee in fees)
                {
                    string text = fee.Text;
                    if(text != string.Empty) {
                        annualFees.Add(text);
                        clickFees.Add(fee);
                    }
                }
            cboxAnnualFee.DataSource = annualFees;
            cboxAnnualFee.SelectedIndex = 0;
            cboxAnnualFee.SelectedIndexChanged += changed_annualfee;

            IList<IWebElement> basepayments = driver.FindElements(By.XPath(xBasePayment));
            foreach (IWebElement basepayment in basepayments)
                {
                    string text = basepayment.Text;
                    if (text != string.Empty)
                    {
                        basePayments.Add(text);
                        clickPayments.Add(basepayment);
                    }
                }
            cboxBasePayment.DataSource = basePayments;
            cboxBasePayment.SelectedIndex = 0;
            cboxBasePayment.SelectedIndexChanged += changed_basepayment;

            IWebElement cardImage = driver.FindElement(By.XPath(xCardImage));
            pboxCard.ImageLocation = cardImage.GetAttribute("src");
            IWebElement cardName = driver.FindElement(By.XPath (xCardName));
            lblProductName.Text = $"< Recommand Product >\n{cardName.Text}";
            IWebElement cardBenefit = driver.FindElement(By.XPath(xCardBenefit));
            txtProductBenefit.Text = cardBenefit.Text;
        }

        private void changed_annualfee(object sender, EventArgs e)
        {
            clickFees[cboxAnnualFee.SelectedIndex].Click();

            By reloadImage = By.XPath(xCardImage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement changedImage = wait.Until(ExpectedConditions.ElementExists(reloadImage));
            pboxCard.ImageLocation = changedImage.GetAttribute("src");

            By reloadName = By.XPath(xCardName);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement changedName = wait.Until(ExpectedConditions.ElementExists(reloadName));
            lblProductName.Text = $"< Recommand Product >\n{changedName.Text} ";

            By reloadBenefit = By.XPath(xCardBenefit);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement changedBenefit = wait.Until(ExpectedConditions.ElementExists(reloadBenefit));
            txtProductBenefit.Text = changedBenefit.Text;
        }

        private void changed_basepayment(object sender, EventArgs e)
        {
            clickPayments[cboxBasePayment.SelectedIndex].Click();

            By reloadImage = By.XPath(xCardImage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement changedImage = wait.Until(ExpectedConditions.ElementExists(reloadImage));
            pboxCard.ImageLocation = changedImage.GetAttribute("src");

            By reloadName = By.XPath(xCardName);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement changedName = wait.Until(ExpectedConditions.ElementExists(reloadName));
            lblProductName.Text = $"< Recommand Product >\n{changedName.Text}";

            By reloadBenefit = By.XPath(xCardBenefit);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement changedBenefit = wait.Until(ExpectedConditions.ElementExists(reloadBenefit));
            txtProductBenefit.Text = changedBenefit.Text;
        }

        private void FormFPR_FormClosing(object sender, FormClosingEventArgs e)
        {
            driver.Quit();
        }  
    }
}