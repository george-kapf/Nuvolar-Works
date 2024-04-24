# Amazon Web Automation Project

## Project Structure

### Features
Contains feature files written in Gherkin syntax describing scenarios and steps for understanding and reading easily.

### Hooks
Setup the driver configuration that runs before and after tests.

### Pages
For more readable and understandable code, the project uses the page objects model. All methods used in the step definitions are defined here.

### StepDefinition
Methods mapped from Gherkin feature files. These methods implement the actions described in the feature files.

### Utility
Contains C# code for extent reports.

## Prerequisites & Tools

### Installation Steps:
1. Install Visual Studio.
2. Open Visual Studio and continue without a project.
3. Go to Extensions and click on Manage Extensions.
4. Install SpecFlow by searching in the search box. Close it; it will open automatically and modify itself.
5. Import an existing Project you have.
6. Project folders are displayed. Right-click on the dependencies and click on Manage NuGet.
7. Install Selenium WebDriver (stable version) and Extent Reports (v4.1.0).

## Running the Project

1. Run the project from the test explorer.

## Automated Scenario: 

### Scenario: Verify that the product is added to the cart successfully according to the requirement

1. **Given** go to amazon website 
2. **When** click on the search input field and search "hats for men"
3. **And** click on the search button
4. **And** add the first hat to Cart with a quantity of two
5. **Then** open the cart and assert total price and quantity are correct
6. **When** search "hats for women"
7. **And** click on the search button
8. **And** add the first hat to Cart with a quantity of one
9. **And** click on the cart and check that quantity is correct
10. **And** change the quantity for the item selected at step three from two to one item in the Cart
11. **Then** assert total price and quantity are changed correctly

## Expected Result

Result should be as per requirements.

## Actual Result

As Expected.
