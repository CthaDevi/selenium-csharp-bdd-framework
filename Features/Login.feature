Feature: User Login

  As a registered user
  I want to log in to the application
  So that I can access the inventory page

  Background:
    Given the user is on the login page

  @smoke @positive
  Scenario: Successful login
    When the user logs in with valid credentials
    Then the user should be redirected to the inventory page

  @negative
  Scenario: Login fails with invalid credentials
    When the user logs in with invalid credentials
    Then an authentication error message should be displayed
