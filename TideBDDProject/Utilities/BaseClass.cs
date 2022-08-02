using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using NUnit.Framework;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace TideBDDProject.Utilities
{
    [Binding]
    public class BaseClass
    {
        public static IWebDriver driver;
        public static ExtentReports extents;
        public static ExtentTest obj;

        public static ExtentTest feature;
        public static ExtentTest scenario;

        
        [BeforeFeature]
        public static void featureBrowser(FeatureContext featureContext)
        {
            feature = extents.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            Log.Information("selecting feature file {0} to run", featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public static void OpenBrowser(ScenarioContext scenarioContext)
        {
            scenario = feature.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
            Log.Information("selecting scenario {0} to run", scenarioContext.ScenarioInfo.Title);
            driver = new ChromeDriver();
        }
        [BeforeTestRun]
        public static void GenerateReport()
        {
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\DELL\source\repos\TideBDDProject\TideBDDProject\MyFolder\index.html");
            htmlReport.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extents = new ExtentReports();
            extents.AttachReporter(htmlReport);
            LoggingLevelSwitch loggingLevel = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(levelSwitch: loggingLevel).WriteTo.File(
                @"C:\Users\DELL\source\repos\TideBDDProject\TideBDDProject\MyFolder\Logs", outputTemplate: "{TimeSpamp:yyyy-MM-dd HH:mm:ss.fff} | {Level:u3} | {Message}{NewLine}", rollingInterval: RollingInterval.Day).CreateLogger();
        }
        [AfterTestRun]
        public static void CloseExtentReport()
        {
            extents.Flush();
        }
        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);

            }
            if (scenarioContext.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(scenarioContext.TestError.Message);
            }
        }

        [AfterScenario]

        public static void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
