using Builder;
using Builder.FacetedBuilder;
using Builder.FluentGeneric;
using Builder.Stepwise;

using Factory.FactoryMethod;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/// <summary>
/// Basic builder pattern. No order required. Cannot chain methods. One can add a Director class to enforce order and encapsulate business logic.
/// </summary>
/// 
#region Builder
var carBuilder = new CarBuilder();
carBuilder.BuildBody();
carBuilder.BuildChassis();
carBuilder.BuildElectronics();
carBuilder.BuildEngine();
carBuilder.BuildWindows();
var car = carBuilder.GetCar();
Console.WriteLine(car);
#endregion


/// <summary>
/// Basic Fluent builder pattern. No order required. Can chain methods.
/// </summary>
/// 
#region FluentBuilder
var fluentCarBuilder = new FluentCarBuilder();
fluentCarBuilder.BuildBody().BuildEngine().BuildWindows().BuildElectronics().BuildChassis();
var fluentCar = fluentCarBuilder.GetCar();
Console.WriteLine(fluentCar);
#endregion

/// <summary>
/// Basic Generic Fluent builder pattern (use inheritance of builders - just one branch not a tree -). No order required. Can chain methods.
/// </summary>
/// 
#region GenericFluentBuilder
var carBuilderGenericDirector = GenericCarBuilderDirector.NewCar.AddBody().AddWindows();
Console.WriteLine(carBuilderGenericDirector.Build());
#endregion


/// <summary>
/// Faceted builder pattern (use inheritance of builders - a tree of them -). No order required. Can chain methods.
/// </summary>
#region FacetedBuilder
var carBuilderFacade = new CarBuilderFacade()
	.Body
		.AddBody().AddWindows()
	.Mechanics
		.AddChassis().AddEngine();
	

Console.WriteLine(carBuilderFacade.Build());

#endregion


/// <summary>
/// Stepwise builder pattern. Order required. Must chain methods.
/// </summary>
/// 
#region StepwiseBuilder
var stepwiseCarBuilder = StepwiseCarBuilder.Create().BuildChassis().BuildEngine().BuildElectronics().BuildCarBody().Build();
Console.WriteLine(stepwiseCarBuilder);
#endregion



/// <summary>
/// Factory pattern.
/// </summary>
/// 
#region Factory
var factory = new CarFactory().ExecuteCreation(CarType.Normal, 100);
factory.StartEngine();
#endregion