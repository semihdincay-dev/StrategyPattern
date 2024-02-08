using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
  public class MallardDuck : Duck
  {
    public MallardDuck()
    {
      IQuackBehavior quackBehavior = new Quack();
      IFlyBehavior flyBehavior = new FlyWithWings();
    }

    public override void display()
    {
      Console.WriteLine("I'm a real Mallard duck!");
    }
  }
}