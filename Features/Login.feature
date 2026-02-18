Feature: User Login

  As a registered user
  I want to log in to the application
  So that I can access the inventory page

  Background:
    Given the user is on the login page

  @smoke @positive
  Scenario: Successful login with valid credentials
    When the user enters username "Seetha_QAuser"
    And the user enters password "Summer@123"
    And the user clicks on the login button
    Then the user should be redirected to the inventory page

  @negative
  Scenario: Login fails with invalid credentials
    When the user enters username "invalid_user"
    And the user enters password "wrong_password"
    And the user clicks on the login button
    Then an authentication error message should be displayed
