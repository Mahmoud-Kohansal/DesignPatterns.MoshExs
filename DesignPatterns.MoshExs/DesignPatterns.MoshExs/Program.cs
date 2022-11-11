
using DesignPatterns.MoshExs.Behavioral.Command;
using DesignPatterns.MoshExs.Behavioral.Iterator;
using DesignPatterns.MoshExs.Behavioral.Mediator;
using DesignPatterns.MoshExs.Behavioral.Observer;
using DesignPatterns.MoshExs.Behavioral.State;
using DesignPatterns.MoshExs.Behavioral.Strategy;
using DesignPatterns.MoshExs.Behavioral.TemplateMethod;

Console.WriteLine("**************** Iterator Pattern ***************");
IteratorPattern.Run();
Console.WriteLine("**************** State Pattern ***************");
StatePattern.Run();
Console.WriteLine("**************** Strategy Pattern ***************");
StrategyPattern.Run();

Console.WriteLine("**************** Template Method Pattern ***************");
TemplateMethodPattern.Run();

Console.WriteLine("**************** Command Pattern ***************");
CommandPattern.Run();

Console.WriteLine("**************** Observer Pattern ***************");
ObserverPattern.Run();

Console.WriteLine("**************** Mediator Pattern ***************");
MediatorPattern.Run();
