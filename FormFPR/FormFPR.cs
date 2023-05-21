using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



namespace FormFPR
{
    public partial class FormFPR : Form
    {
        public FormFPR()
        {
            InitializeComponent();
        }

        private void cB_annualFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (IWebDriver driver = new ChromeDriver())
            {

                driver.Navigate().GoToUrl("https://card-search.naver.com/list");

                if (cB_annualFee.SelectedItem.ToString() == "all")
                {
                    tB1.Text = "전체";
                }
                else if (cB_annualFee.SelectedItem.ToString() == "~10000")
                {
                    tB1.Text = "1";
                }
                else if (cB_annualFee.SelectedItem.ToString() == "~30000")
                {
                    tB1.Text = "3";
                }
                else if (cB_annualFee.SelectedItem.ToString() == "~100000")
                {
                    tB1.Text = "10";
                }
                else if (cB_annualFee.SelectedItem.ToString() == "100000~")
                {
                    string targetText = "10만원~";
                    IWebElement spanElement = driver.FindElement(By.XPath($"//span[contains(text(), '{targetText}')]"));
                    tB1.Text = "10+";
                }
            }
        }

        private void cB_monthlyUsage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_monthlyUsage.SelectedItem.ToString() == "all")
            {
                tB1.Text = "전체";
            }
            else if (cB_monthlyUsage.SelectedItem.ToString() == "~30000")
            {
                tB1.Text = "10";
            }
            else if (cB_monthlyUsage.SelectedItem.ToString() == "~50000")
            {
                tB1.Text = "30";
            }

        }

        private void FormFPR_Load(object sender, EventArgs e)
        {
            try
            {
                using (IWebDriver driver = new ChromeDriver())
                {
                    // Navigate to the website
                    driver.Navigate().GoToUrl("https://card-search.naver.com/list");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while fetching the webpage: " + ex.Message);
            }
        }
    }

}
