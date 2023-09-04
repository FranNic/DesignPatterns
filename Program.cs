using Adapter;

using Builder;
using Builder.FacetedBuilder;
using Builder.FluentGeneric;
using Builder.Stepwise;

using Factory.AbstractFactory;
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
/// Factory method pattern.
/// </summary>
/// 
#region Factory
// Create factories
Factory.FactoryMethod.CarFactory normalCarFactory = new Factory.FactoryMethod.NormalCarFactory();
Factory.FactoryMethod.CarFactory raceCarFactory = new Factory.FactoryMethod.RaceCarFactory();

// Create cars
AbstractCar normalCar = normalCarFactory.CreateCar();
AbstractCar raceCar = raceCarFactory.CreateCar();

// Use the cars
normalCar.Drive();
raceCar.Drive();
#endregion


/// <summary>
/// Abstract Factory pattern.
/// </summary>
/// 
#region AbstractFactory
// Create factories
Factory.AbstractFactory.CarFactory normalCarAbstractFactory = new Factory.AbstractFactory.NormalCarFactory();
Factory.AbstractFactory.CarFactory raceCarAbstractFactory = new Factory.AbstractFactory.RaceCarFactory();
Factory.AbstractFactory.CarFactory electricCarAbstractFactory = new Factory.AbstractFactory.ElectricCarFactory();

// Create cars
// englobe into a method to avoid repeating code
var normalCarCreated = CreateCar(normalCarAbstractFactory);
var raceCarCreated = CreateCar(raceCarAbstractFactory);
var electricCarCreated = CreateCar(electricCarAbstractFactory);
	
// Note that the type of the variable is the abstract type, not the concrete type.
static Factory.AbstractFactory.Car CreateCar(Factory.AbstractFactory.CarFactory car)
{
	return car.CreateCar();
}

normalCarCreated.Drive();
raceCarCreated.Drive();
electricCarCreated.Drive();

#endregion

#region Adapter
// Create railroad
var railroad = new Adapter.Railroad();
IRailroadAdapter railroadAdapter = new Adapter.Car(railroad);


Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

railroadAdapter.SetInRailroad();
#endregion
