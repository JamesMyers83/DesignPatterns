using System;
using DesignPatterns.Clients;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = false;

            while (!exitLoop)
            {
                Console.WriteLine();
                Console.WriteLine("Please type the number of type of design patterns to veiw");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Creational");
                Console.WriteLine("2 - Structural");
                Console.WriteLine("3 - Behaivoral");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.KeyChar.ToString())
                {
                    case "0":
                        exitLoop = true;
                        break;
                    case "1":
                        while (!exitLoop)
                        {
                            Console.WriteLine("Please select Creational Pattern to demo:");
                            Console.WriteLine("0 - Exit");
                            Console.WriteLine("1 - Simple Factory");
                            Console.WriteLine("2 - Factory Method");
                            Console.WriteLine("3 - Abstract Factory");
                            Console.WriteLine("4 - Builder");
                            Console.WriteLine("5 - Fluent Interface");
                            Console.WriteLine("6 - Prototype");
                            Console.WriteLine("7 - Singleton");

                            keyInfo = Console.ReadKey();
                            Console.WriteLine();

                            switch (keyInfo.KeyChar.ToString())
                            {
                                case "0":
                                    exitLoop = true;
                                    break;
                                case "1":
                                    SimpleFactoryClient simpleFactoryClient = new SimpleFactoryClient();
                                    simpleFactoryClient.PrintSimpleFactory();
                                    break;
                                case "2":
                                    FactoryMethodClient factoryMethodClient = new FactoryMethodClient();
                                    factoryMethodClient.PrintFactoryMethod();
                                    break;
                                case "3":
                                    AbstractFactoryClient abstractFactoryClient = new AbstractFactoryClient();
                                    abstractFactoryClient.PrintAbstractFactory();
                                    break;
                                case "4":
                                    BuilderClient builderClient = new BuilderClient();
                                    builderClient.PrintBuilder();
                                    break;
                                case "5":
                                    FluentInterfaceClient fluentInterfaceClient = new FluentInterfaceClient();
                                    fluentInterfaceClient.PrintFluentInterface();
                                    break;
                                case "6":
                                    PrototypeClient prototypeClient = new PrototypeClient();
                                    prototypeClient.PrintPrototype();
                                    break;
                                case "7":
                                    SingletonClient singletonClient = new SingletonClient();
                                    singletonClient.PrintSingleton();
                                    break;
                                default:
                                    Console.WriteLine("Selection must be 0-7");
                                    break;
                            }
                        }

                        exitLoop = false;
                        break;
                    case "2":
                        while (!exitLoop)
                        {
                            Console.WriteLine("Please select Structural Pattern to demo:");
                            Console.WriteLine("0 - Exit");
                            Console.WriteLine("1 - Adapter");
                            Console.WriteLine("2 - Facade");
                            Console.WriteLine("3 - Decorator");
                            Console.WriteLine("4 - Bridge");
                            Console.WriteLine("5 - Composite");
                            Console.WriteLine("6 - Proxy");
                            Console.WriteLine("7 - Flyweight");

                            keyInfo = Console.ReadKey();
                            Console.WriteLine();

                            switch (keyInfo.KeyChar.ToString())
                            {
                                case "0":
                                    exitLoop = true;
                                    break;
                                case "1":
                                    AdapterClient adapterClient = new AdapterClient();
                                    adapterClient.PrintAdapter();
                                    break;
                                case "2":
                                    FacadeClient facadeClient = new FacadeClient();
                                    facadeClient.PrintFacade();
                                    break;
                                case "3":
                                    DecoratorClient decoratorClient = new DecoratorClient();
                                    decoratorClient.PrintDecorator();
                                    break;
                                case "4":
                                    BridgeClient bridgeClient = new BridgeClient();
                                    bridgeClient.PrintBridge();
                                    break;
                                case "5":
                                    CompositeClient compositeClient = new CompositeClient();
                                    compositeClient.PrintComposite();
                                    break;
                                case "6":
                                    ProxyClient proxyClient = new ProxyClient();
                                    proxyClient.PrintProxy();
                                    break;
                                case "7":
                                    FlyweightClient flyweightClient = new FlyweightClient();
                                    flyweightClient.PrintFlyweight();
                                    break;
                                default:
                                    Console.WriteLine("Selection must be 0-7");
                                    break;
                            }
                        }

                        exitLoop = false;
                        break;
                    case "3":
                        while (!exitLoop)
                        {
                            Console.WriteLine("Please select Behaivoral Pattern to demo:");
                            Console.WriteLine("0 - Exit");
                            Console.WriteLine("1 - Iterator");
                            Console.WriteLine("2 - Observer");
                            Console.WriteLine("3 - Chain Of Responsibility");
                            Console.WriteLine("4 - State");
                            Console.WriteLine("5 - Template");
                            Console.WriteLine("6 - Command");
                            Console.WriteLine("7 - Visitor");
                            Console.WriteLine("8 - Strategy");
                            Console.WriteLine("9 - Interpreter");
                            Console.WriteLine("10 - Mediator");
                            Console.WriteLine("11 - Memento");

                            string entered = Console.ReadLine();
                            Console.WriteLine();

                            switch (entered)
                            {
                                case "0":
                                    exitLoop = true;
                                    break;
                                case "1":
                                    IteratorClient iteratorClient = new IteratorClient();
                                    iteratorClient.PrintIterator();
                                    break;
                                case "2":
                                    ObserverClient observerClient = new ObserverClient();
                                    observerClient.PrintObserver();
                                    break;
                                case "3":
                                    ChainOfResponsibilityClient chainOfResponsibilityClient = new ChainOfResponsibilityClient();
                                    chainOfResponsibilityClient.PrintChainOfResponsibility();
                                    break;
                                case "4":
                                    StateClient stateClient = new StateClient();
                                    stateClient.PrintState();
                                    break;
                                case "5":
                                    TemplateClient templateClient = new TemplateClient();
                                    templateClient.PrintTemplate();
                                    break;
                                case "6":
                                    CommandClient commandClient = new CommandClient();
                                    commandClient.PrintCommand();
                                    break;
                                case "7":
                                    VisitorClient visitorClient = new VisitorClient();
                                    visitorClient.PrintVisitor();
                                    break;
                                case "8":
                                    StrategyClient strategyClient = new StrategyClient();
                                    strategyClient.PrintStrategy();
                                    break;
                                case "9":
                                    InterpreterClient interpreterClient = new InterpreterClient();
                                    interpreterClient.PrintInterpreter();
                                    break;
                                case "10":
                                    MediatorClient mediatorClient = new MediatorClient();
                                    mediatorClient.PrintMediator();
                                    break;
                                case "11":
                                    MementoClient mementoClient = new MementoClient();
                                    mementoClient.PrintMemento();
                                    break;
                                default:
                                    Console.WriteLine("Selection must be 0-11");
                                    break;
                            }
                        }

                        exitLoop = false;
                        break;
                    default:
                        Console.WriteLine("Must enter number 0 -3");
                        break;
                }
            }

            Console.WriteLine("End of Design Patterns examples");
            Console.WriteLine("Type any key to exit");
            Console.ReadKey();
        }
    }
}
