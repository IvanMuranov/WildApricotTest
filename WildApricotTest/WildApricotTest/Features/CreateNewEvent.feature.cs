﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WildApricotTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateNewEvent")]
    public partial class CreateNewEventFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CreateNewEvent.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreateNewEvent", "\tFeature to test Create New Simple Event page functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
#line 4
#line 5
 testRunner.Given("I navigate to application web page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Password"});
            table1.AddRow(new string[] {
                        "peoplepower32@yandex.ru",
                        "fas55fas"});
#line 6
  testRunner.And("I enter username and password on application web page", ((string)(null)), table1, "And ");
#line 9
  testRunner.And("I click login on application web page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.And("I switch to admin view from application web page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And("I navigate to Events menu on admin view page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Provide a valid information to create new simple event")]
        public virtual void ProvideAValidInformationToCreateNewSimpleEvent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Provide a valid information to create new simple event", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 14
 testRunner.Given("I create new simple event on Event list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I enter title \'New fancy title\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
  testRunner.And("I enter tags \'Tag.Tag.Tag\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
  testRunner.And("I enter location \'Fun location\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
  testRunner.And("I enter start date \'30 May 2018\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
  testRunner.And("I enter end date \'30 May 2019\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
  testRunner.And("I enter start time \'5\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
  testRunner.And("I enter end time \'10\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
  testRunner.And("I choose enabled status for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
  testRunner.And("I enter available period from \'30 Jun 2018\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.And("I enter available period through \'30 Jun 2019\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
  testRunner.And("I allow guest registrations for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
  testRunner.And("I limit guests to \'5\' for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.And("I do not allow cancellation by registrants for new simple event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
  testRunner.And("I choose to show registrations who want to be listed to members only for new simp" +
                    "le event", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
