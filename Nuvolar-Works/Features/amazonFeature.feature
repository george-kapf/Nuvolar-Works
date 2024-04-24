Feature: product adding to the cart


@test
Scenario: verify that the product is added to the cart successfully
	Given go to amazon website 
	When click on the search input field and search "hats for men"
	And Click on the search button
	And Add first hat to Cart with quantity two
	Then Open cart and assert total price and quantity are correct
	When search "hats for women"
	And Click on the search button
	And Add first hat to Cart with quantity one
	And Click on the cart and check that quantity is correct
	And Change the quantity for item selected at step three from two to one item in Cart