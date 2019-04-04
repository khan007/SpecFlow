﻿using TechTalk.SpecFlow.Configuration;
using TechTalk.SpecFlow.Configuration.AppConfig;
using TechTalk.SpecFlow.TestProjectGenerator;
using TechTalk.SpecFlow.TestProjectGenerator.Data;
using TechTalk.SpecFlow.TestProjectGenerator.Driver;
using TechTalk.SpecFlow.TestProjectGenerator.NewApi._1_Memory;

namespace TechTalk.SpecFlow.Specs.Drivers
{
    public class XmlConfigurationLoaderDriver
    {
        private readonly ConfigurationDriver _configurationDriver;
        private readonly SolutionDriver _solutionDriver;

        public XmlConfigurationLoaderDriver(ConfigurationDriver configurationDriver, SolutionDriver solutionDriver)
        {
            _configurationDriver = configurationDriver;
            _solutionDriver = solutionDriver;
        }

        

        public void AddFromXmlSpecFlowSection(string specFlowSection)
        {
            ProjectBuilder project = _solutionDriver.DefaultProject;
            var configSection = ConfigurationSectionHandler.CreateFromXml(specFlowSection);
            var appConfigConfigurationLoader = new AppConfigConfigurationLoader();

            var specFlowConfiguration = appConfigConfigurationLoader.LoadAppConfig(ConfigurationLoader.GetDefault(), configSection);

            foreach (string stepAssemblyName in specFlowConfiguration.AdditionalStepAssemblies)
            {
                _configurationDriver.AddStepAssembly(new StepAssembly(stepAssemblyName));
            }

            _configurationDriver.SetBindingCulture(project, specFlowConfiguration.BindingCulture);
            _configurationDriver.SetFeatureLanguage(project, specFlowConfiguration.FeatureLanguage);
        }
    }
}
