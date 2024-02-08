using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
  public abstract class Duck
  {
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public Duck()
    {
      flyBehavior = new FlyWithWings();
      quackBehavior = new Quack();
    }

    public void setFlyBehavior(IFlyBehavior fb)
    {
      flyBehavior = fb;
    }

    public void setQuackBehavior(IQuackBehavior qb)
    {
      quackBehavior = qb;
    }

    public abstract void display();

    public void performFly()
    {
      flyBehavior.fly();
    }
    public void performQuack()
    {
      quackBehavior.quack();
    }


    public void swim()
    {
      Console.WriteLine("“All ducks float, even decoys!”");
    }
  }
}
