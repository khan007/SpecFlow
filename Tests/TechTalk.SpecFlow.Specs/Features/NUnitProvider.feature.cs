﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("NUnit unit test provider")]
    public partial class NUnitUnitTestProviderFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "NUnitProvider.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NUnit unit test provider", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to execute scenarios with basic results")]
        [NUnit.Framework.TestCaseAttribute("Succeeded", "pass", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Failed", "fail", new string[0])]
        public virtual void ShouldBeAbleToExecuteScenariosWithBasicResults(string result, string stepDefinitionStatus, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to execute scenarios with basic results", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("there is a SpecFlow project");
#line 5
 testRunner.And("the project is configured to use the NUnit provider");
#line hidden
#line 6
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)));
#line 10
 testRunner.And(string.Format("all steps are bound and {0}", stepDefinitionStatus));
#line 11
 testRunner.When("I execute the tests with NUnit");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Total",
                        string.Format("{0}", result)});
            table1.AddRow(new string[] {
                        "1",
                        "1"});
#line 12
 testRunner.Then("the execution summary should contain", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should handle scenario outlines")]
        [NUnit.Framework.TestCaseAttribute("Normal testing", "disabled", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Row testing", "enabled", new string[0])]
        public virtual void ShouldHandleScenarioOutlines(string @case, string rowTest, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should handle scenario outlines", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("there is a SpecFlow project");
#line 23
 testRunner.And("the project is configured to use the NUnit provider");
#line 24
 testRunner.And(string.Format("row testing is {0}", rowTest));
#line hidden
#line 25
 testRunner.Given("there is a feature file in the project as", "\tFeature: Simple Feature\r\n\tScenario Outline: Simple Scenario Outline\r\n\t\tGiven the" +
                    "re is something\r\n\t\tWhen I do <what>\r\n\t\tThen something should happen\r\n\tExamples: " +
                    "\r\n\t\t| what           |\r\n\t\t| something      |\r\n\t\t| somethign else |", ((TechTalk.SpecFlow.Table)(null)));
#line 37
 testRunner.And("all steps are bound and pass");
#line 38
 testRunner.When("I execute the tests with NUnit");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table2.AddRow(new string[] {
                        "2"});
#line 39
 testRunner.Then("the execution summary should contain", ((string)(null)), table2);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should be able to specify NUnit provider in the configuration")]
        [NUnit.Framework.CategoryAttribute("config")]
        public virtual void ShouldBeAbleToSpecifyNUnitProviderInTheConfiguration()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should be able to specify NUnit provider in the configuration", new string[] {
                        "config"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("there is a SpecFlow project");
#line hidden
#line 51
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)));
#line 55
 testRunner.And("all steps are bound and pass");
#line hidden
#line 56
 testRunner.And("the specflow configuration is", "<specFlow>\r\n\t<unitTestProvider name=\"NUnit\"/>\r\n</specFlow>", ((TechTalk.SpecFlow.Table)(null)));
#line 62
 testRunner.When("I execute the tests with NUnit");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Total"});
            table3.AddRow(new string[] {
                        "1"});
#line 63
 testRunner.Then("the execution summary should contain", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion