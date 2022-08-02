using System;
using TechTalk.SpecFlow;
using TideBDDProject.CommonObjectMethod;

namespace TideBDDProject.CommonObjectMethod
{
    [Binding]
    public class TideSteps
    {
        commonMethod obj = new commonMethod();

        [Given(@"I open URL of TideWebSite")]
        public void GivenIOpenURLOfTideWebSite()
        {
            obj.OpenTideURL();
        }

        [Given(@"Click On Register")]
        public void GivenClickOnRegister()
        {
            obj.Register();
        }

        [When(@"I Click on SignUP Button")]
        public void WhenIClickOnSignUPButton()
        {
            obj.SignUP();
        }

        [Then(@"Account is Created")]
        public void ThenAccountIsCreated()
        {
            obj.ClickOnCreateAccount();
        }


        [Given(@"I open Tide Website")]
        public void GivenIOpenTideWebsite()
        {
            obj.OpenTideURL1();
        }

        [Given(@"I Open Login Page")]
        public void GivenIOpenLoginPage()
        {
            obj.OpenLoginPage();
            
        }

        [When(@"Enter Login Information")]
        public void WhenEnterLoginInformation()
        {
            obj.EnterInformation();
        }

        [Then(@"Click on Login Button")]
        public void ThenClickOnLoginButton()
        {
            obj.ClickOnLogin();
        }

        [Given(@"I open Website")]
        public void GivenIOpenWebsite()
        {
            obj.Url();
        }

        [Given(@"Click On How to wash clothes")]
        public void GivenClickOnHowToWashClothes()
        {
            obj.ClickOnWashClothes();
        }

        [Then(@"Find how to removal stain")]
        public void ThenFindHowToRemovalStain()
        {
            obj.FindStainRemoval();
        }

        [Given(@"Open Website")]
        public void GivenOpenWebsite()
        {
            obj.Url2();
        }

        [Then(@"Click On Location")]
        public void ThenClickOnLocation()
        {
            obj.ClickOnLocation();
        }

        [Given(@"Page URL")]
        public void GivenPageURL()
        {
            obj.Url3();
        }

        [Given(@"Click on ShopProducts")]
        public void GivenClickOnShopProducts()
        {
            obj.ClickOnShopProduct();
        }

        [When(@"shope Product By Rating")]
        public void WhenShopeProductByRating()
        {
            obj.FindProductByRating();
        }

        [Then(@"Select Rating of the Product")]
        public void ThenSelectRatingOfTheProduct()
        {
            obj.SelectProductRating();
        }


        [Given(@"Tide URL")]
        public void GivenTideURL()
        {
            obj.Url4();
        }

        [Then(@"Click on ContactUs")]
        public void ThenClickOnContactUs()
        {
            obj.ContactUs();
        }

        [Given(@"open tide url")]
        public void GivenOpenTideUrl()
        {
            obj.Url5();
        }

        [Then(@"Search product")]
        public void ThenSearchProduct()
        {
            obj.SearchProduct();
        }

        [Given(@"website url")]
        public void GivenWebsiteUrl()
        {
            obj.Url6();
        }

        [Then(@"Click on Live Chat")]
        public void ThenClickOnLiveChat()
        {
            obj.OpenLiveChat();
        }


        [Given(@"Tide website")]
        public void GivenTideWebsite()
        {
            obj.Site();
        }

        [Given(@"Find Latest News about Products")]
        public void GivenFindLatestNewsAboutProducts()
        {
            obj.FindNewProducts();
        }

        [Then(@"Search Latest Articles section")]
        public void ThenSearchLatestArticlesSection()
        {
            obj.SearchArticleSection();
        }



        [Given(@"open website Url")]
        public void GivenOpenWebsiteUrl()
        {
            obj.TideUrl3();
        }

        [Given(@"Open Coupons And Rewards")]
        public void GivenOpenCouponsAndRewards()
        {
            obj.OpenCouponAndRewards();
        }

        [When(@"Save Rewards")]
        public void WhenSaveRewards()
        {
            obj.Save();
        }

        [Then(@"Login Account")]
        public void ThenLoginAccount()
        {
            obj.LoginAccount();
        }














    }
}
