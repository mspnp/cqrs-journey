﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.AllFeaturesEndToEnd
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature : Xunit.IUseFixture<SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SelfRegistrationEndToEndHappy.feature"
#line hidden
        
        public SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Self Registrant end to end scenario for making a Registration for a Conference si" +
                    "te (happy path)", "In order to register for a conference\r\nAs an Attendee\r\nI want to be able to regis" +
                    "ter for the conference, pay for the Registration Order and associate myself with" +
                    " the paid Order automatically", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 19
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 20
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 25
 testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        public virtual void SetFixture(SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        [Xunit.TraitAttribute("Description", "Make a reservation with the selected Order Items")]
        public virtual void MakeAReservationWithTheSelectedOrderItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a reservation with the selected Order Items", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 35
 testRunner.When("the Registrant proceed to make the Reservation");
#line 36
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "1"});
            table3.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 37
 testRunner.And("these Order Items should be reserved", ((string)(null)), table3);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table4.AddRow(new string[] {
                        "CQRS Workshop"});
#line 41
 testRunner.And("these Order Items should not be reserved", ((string)(null)), table4);
#line 44
 testRunner.And("the total should read $249");
#line 45
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        [Xunit.TraitAttribute("Description", "Checkout:Registrant Details")]
        public virtual void CheckoutRegistrantDetails()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Registrant Details", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 49
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table5.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 50
 testRunner.And("the Registrant enter these details", ((string)(null)), table5);
#line 53
 testRunner.When("the Registrant proceed to Checkout:Payment");
#line 54
 testRunner.Then("the payment options should be offered for a total of $249");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        [Xunit.TraitAttribute("Description", "Checkout:Payment and sucessfull Order completed")]
        public virtual void CheckoutPaymentAndSucessfullOrderCompleted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Checkout:Payment and sucessfull Order completed", ((string[])(null)));
#line 56
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 57
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table6.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 58
 testRunner.And("the Registrant enter these details", ((string)(null)), table6);
#line 61
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 62
 testRunner.When("the Registrant proceed to confirm the payment");
#line 63
    testRunner.Then("the Registration process was successful");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "General admission",
                        "1"});
            table7.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 64
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table7);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        [Xunit.TraitAttribute("Description", "Allocate all purchased Seats")]
        public virtual void AllocateAllPurchasedSeats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate all purchased Seats", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 71
 testRunner.Given("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table8.AddRow(new string[] {
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 72
 testRunner.And("the Registrant enter these details", ((string)(null)), table8);
#line 75
 testRunner.And("the Registrant proceed to Checkout:Payment");
#line 76
 testRunner.And("the Registrant proceed to confirm the payment");
#line 77
    testRunner.And("the Registration process was successful");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table9.AddRow(new string[] {
                        "General admission",
                        "1"});
            table9.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 78
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "first name",
                        "last name",
                        "email address"});
            table10.AddRow(new string[] {
                        "General admission",
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
            table10.AddRow(new string[] {
                        "Additional cocktail party",
                        "Gregory",
                        "Weber",
                        "gregoryweber@contoso.com"});
#line 82
 testRunner.When("the Registrant assign these seats", ((string)(null)), table10);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table11.AddRow(new string[] {
                        "General admission",
                        "1"});
            table11.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 86
 testRunner.Then("these seats are assigned", ((string)(null)), table11);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Self Registrant end to end scenario for making a Registration for a Conference si" +
            "te (happy path)")]
        [Xunit.TraitAttribute("Description", "Make a reservation with the selected Order Items and a Promo Code")]
        public virtual void MakeAReservationWithTheSelectedOrderItemsAndAPromoCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a reservation with the selected Order Items and a Promo Code", new string[] {
                        "Ignore"});
#line 94
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 95
 testRunner.Given("the Registrant apply the \'COPRESENTER\' Promotional Code");
#line 96
 testRunner.And("the \'COPRESENTER\' Promo code should show a value of -$5");
#line 97
 testRunner.When("the Registrant proceed to make the Reservation");
#line 98
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line 99
 testRunner.And("the total should read $244");
#line 100
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                SelfRegistrantEndToEndScenarioForMakingARegistrationForAConferenceSiteHappyPathFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
