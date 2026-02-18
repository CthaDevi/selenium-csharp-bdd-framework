Feature: User Login

  As a registered user
  I want to log in to the application
  So that I can securely access my dashboard and features

  Background:
    Given the application is available

  @smoke @critical
  Scenario: Successful login with valid credentials
    Given the user is on the Login page
    When the user logs in with valid credentials
    Then the user should be redirected to the Dashboard

  @negative
  Scenario: Login fails with invalid credentials
    Given the user is on the Login page
    When the user logs in with invalid credentials
    Then an authentication error message should be displayed
