﻿using Xunit;
using Xunit.Gherkin.Quick;

/*
Feature: FoodPrimaryLicenseeRepresentative
    As a logged in business user
    I want to submit a Food Primary Licensee Representative application for different business types

@foodprimarylicenseerepresentative @privatecorporation
Scenario: Food Primary Licensee Representative (Private Corporation)
    Given I am logged in to the dashboard as a private corporation
    And I click on the Start Application button for Food Primary
    And I review the account profile for a private corporation
    And I complete the Food Primary application for a private corporation
    And I click on the Submit button
    And I enter the payment information
    And I confirm the payment receipt for a Food Primary application
    And I click on the Dashboard tab
    And the dashboard status is updated as Application Under Review
    And the application is approved
    And I click on the Licences tab
    And I request a licensee representative
    And the account is deleted
    Then I see the login page
*/

namespace bdd_tests
{
    [FeatureFile("./FoodPrimaryLicenseeRepresentative.feature")]
    [Collection("Liquor")]
    public sealed class FoodPrimaryLicenseeRepresentative : TestBase
    {
        [Given(@"I am logged in to the dashboard as a(.*)")]
        public void LogInToDashboard(string businessType)
        {
            NavigateToFeatures();

            CheckFeatureFlagsLiquorOne();

            CheckFeatureFlagsLiquorTwo();

            CheckFeatureFlagsLiquorThree();

            CheckFeatureFlagsLGIN();

            CheckFeatureFlagsIN();

            CheckFeatureFlagsLicenseeChanges();

            CheckFeatureFlagsSecurityScreening();

            CheckFeatureLEConnections();

            IgnoreSynchronizationFalse();

            CarlaLogin(businessType);
        }
    }
}