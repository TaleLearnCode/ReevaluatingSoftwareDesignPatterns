/*
 * In this example, the client code uses factories (ConcreteFactoryA and
 * ConcreteFactoryB) to create products (ConcreteProductA and ConcreteProductB)
 * without knowing the specific classes of the products. This promotes
 * flexibility and simplifies the process of adding new products in the future.
 */

IFactory factoryA = new ConcreteFactoryA();
IProduct productA = factoryA.CreateProduct();
productA.Display();

IFactory factoryB = new ConcreteFactoryB();
IProduct productB = factoryB.CreateProduct();
productB.Display();