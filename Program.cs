using Adapter;

using Bridge;

using Builder;
using Builder.FacetedBuilder;
using Builder.FluentGeneric;
using Builder.Stepwise;

using ChainOfResponsability;

using Command;

using Composite;

using Factory.AbstractFactory;
using Factory.FactoryMethod;

using Mediator;

using Observer;

using System.Globalization;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
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


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
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

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
/// <summary>
/// Basic Generic Fluent builder pattern (use inheritance of builders - just one branch not a tree -). No order required. Can chain methods.
/// </summary>
/// 
#region GenericFluentBuilder
var carBuilderGenericDirector = GenericCarBuilderDirector.NewCar.AddBody().AddWindows();
Console.WriteLine(carBuilderGenericDirector.Build());
#endregion


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
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

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");

/// <summary>
/// Stepwise builder pattern. Order required. Must chain methods.
/// </summary>
/// 
#region StepwiseBuilder
var stepwiseCarBuilder = StepwiseCarBuilder.Create().BuildChassis().BuildEngine().BuildElectronics().BuildCarBody().Build();
Console.WriteLine(stepwiseCarBuilder);
#endregion



Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
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

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");

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

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
#region Adapter
// Create railroad
var railroad = new Adapter.Railroad();
IRailroadAdapter railroadAdapter = new Adapter.Car(railroad);
railroad.DriveOnRails();

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

railroadAdapter.SetInRailroad();
#endregion


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
#region Bridge
IPaitingFactory factory = new Bridge.MatePaintingFactory();
var mateRaceCar = new Bridge.RaceCar(factory);

Console.WriteLine(mateRaceCar.ToString());

factory = new Bridge.MetallicPaintingFactory();
var metallicRaceCar = new Bridge.RaceCar(factory);

Console.WriteLine(metallicRaceCar.ToString());
#endregion

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
#region Composite
var neuron1 = new Neuron(1);
var neuron2 = new Neuron(2);
var layer1 = new NeuronLayer();
var layer2 = new NeuronLayer();

neuron1.ConnectTo(neuron2);
neuron1.ConnectTo(layer1);
layer1.ConnectTo(layer2);


Console.WriteLine(neuron1.ToString());
#endregion

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
#region Decorator
var baseCar = new Decorator.BasicCar();
Console.WriteLine(baseCar.ToString());

var baseCarWithSport = new Decorator.SportPackage(baseCar);
Console.WriteLine(baseCarWithSport.ToString());


var carWithNight = new Decorator.NightPackage(baseCar);
Console.WriteLine(carWithNight.ToString());

var baseCarWithSportAndNight = new Decorator.NightPackage(baseCarWithSport);
Console.WriteLine(baseCarWithSportAndNight.ToString());

#endregion

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
#region Facade

Facade.Car myCar = new Facade.Car();
myCar.Start();

#endregion


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");

#region Flyweight
//Flyweight would resemble Singleton if you somehow managed to reduce all shared states of the objects to just one flyweight object. But there are two fundamental differences between these patterns:
//There should be only one Singleton instance, whereas a Flyweight class can have multiple instances with different intrinsic states.
//The Singleton object can be mutable. Flyweight objects are immutable.
//
#endregion

#region Proxy

// Protection proxy

#endregion


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
// Behavioral patterns

// Similar to the decorator pattern, but the decorator pattern adds additional responsibilities to an object, whereas the chain of responsibility pattern adds additional responsibilities to an object's request.
#region ChainOfResponsibility
var goblin = new Creature("Goblin", 2, 2);
Console.WriteLine(goblin);

var root = new CreatureModifier(goblin);
root.Add(new DoubleAttackModifier(goblin));

// Remember to call Handle() to propagate the request to the next handler
root.Handle();
Console.WriteLine(goblin);
#endregion


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");

// Mediator pattern is very similar to the observer pattern. The difference is that in the observer pattern, all observers are subscribed to the subject, and they are notified when any event occurs in the subject. In the mediator pattern, the observers are not subscribed to the subject. Instead, they are subscribed to the mediator, and the mediator notifies them when any event occurs in the subject.
#region Mediator
var room = new ChatRoom();

var john = new Person("John");
var jane = new Person("Jane");

room.Join(john);
room.Join(jane);

john.Say("hi room");
jane.Say("oh, hey john");

var simon = new Person("Simon");
room.Join(simon);
simon.Say("hi everyone!");

jane.PrivateMessage("Simon", "glad you could join us!");
#endregion


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");
#region Visitor
var listOfCars = new List<Visitor.ICar>
{
	new Visitor.SUV(),
	new Visitor.Sedan(),
	new Visitor.Truck()
};

var maintenanceVisitor = new Visitor.MaintenanceVisitor();

foreach (var carType in listOfCars)
{
	carType.AcceptVisitor(maintenanceVisitor);
}
#endregion


Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");

#region Command


var commandCar = new Command.Car();
var listOfCommands = new List<ICommand> {
	new Command.TurnOnHeadlightsCommand(commandCar), new Command.IncreaseAirConditioningCommand(commandCar), new Command.OpenWindowsCommand(commandCar) };

foreach (var command in listOfCommands)
{
	command.Execute();
}

#endregion

Console.WriteLine("------------------------------------------------------");
Console.WriteLine("------------------------------------------------------");


#region Observer
// Create a car
Observer.Car observerCar = new Observer.Car();

// Create drivers (observers)
Driver driver1 = new Driver("Alice", observerCar);
Driver driver2 = new Driver("Bob", observerCar);

// Change the car's state and notify observers
observerCar.SetCarState("Running");

// Detach an observer
observerCar.DetachDriver(driver1);

// Change the car's state again
observerCar.SetCarState("Stopped");
  


#endregion