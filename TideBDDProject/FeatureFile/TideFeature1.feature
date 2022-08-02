Feature: Tide
Automate the Tide WebSite using BDD

@01SingnUpAccount
Scenario: SignUP
	Given I open URL of TideWebSite
	And Click On Register
	When I Click on SignUP Button
	Then Account is Created

@02LoginAccount
Scenario: Login
    Given I open Tide Website
	And I Open Login Page
	When Enter Login Information
	Then Click on Login Button

 @03HowTOWashClothes
Scenario: wash clothes
     Given I open Website
	 And Click On How to wash clothes
	 Then Find how to removal stain 

@04SelectLocation
Scenario: Select Location
     Given Open Website
	 Then Click On Location

@05ShopeProducts
Scenario: Shop Products
     Given Page URL
	 And Click on ShopProducts
	 When shope Product By Rating
	 Then Select Rating of the Product

@06ContectUs
Scenario: ContactUs
     Given Tide URL
	 Then Click on ContactUs


@07SearchProduct
Scenario: Search 
      Given open tide url
	  Then Search product


@08DoLiveChat
Scenario: Live Chat
        Given website url 
		Then Click on Live Chat
	
@09FindNewProducts
Scenario: New Products
         Given Tide website 
		 And Find Latest News about Products
		 Then Search Latest Articles section

@10CouponsAndRewards
Scenario: Coupons And Rewards
         Given open website Url
		 And Open Coupons And Rewards
		 When Save Rewards
		 Then Login Account
