﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDD.Examples.TePrestamos.Specs.Features.OtorgarBeneficios
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Calculo de tasa de interés")]
    public partial class CalculoDeTasaDeInteresFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CalcularTasaDeInterés.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("es-CO"), "Calculo de tasa de interés", "Para apoyar el desarrollo económico de comunidades de escasos recursos\r\nComo un d" +
                    "irectivo del banco\r\nYo quiero conceder una tasa de interés más baja a personas d" +
                    "esfavorecidas", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Cliente desplazado por la violencia")]
        public virtual void ClienteDesplazadoPorLaViolencia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cliente desplazado por la violencia", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("que el cliente es desplazado por la violencia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 8
 testRunner.When("se calcule su interés", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 9
 testRunner.Then("deberían descontársele 5 puntos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line 10
  testRunner.And("el total no debería exceder 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Cliente madre cabeza de familia")]
        public virtual void ClienteMadreCabezaDeFamilia()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cliente madre cabeza de familia", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("que el cliente es madre cabeza de hogar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
 testRunner.When("se calcule su interés", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 15
 testRunner.Then("deberían descontársele 4 puntos", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line 16
  testRunner.And("el total no debería exceder 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Y ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No aplican beneficios")]
        public virtual void NoAplicanBeneficios()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No aplican beneficios", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("que el cliente no es desplazado ni madre cabeza de hogar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 20
 testRunner.When("se calcule su interés", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Cuando ");
#line 21
 testRunner.Then("no deberían realizarse descuentos a su tasa de interés", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entonces ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
