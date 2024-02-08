﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
  public class Quack : IQuackBehavior
  {
    public void quack()
    {
      Console.WriteLine("Quack");
    }
  }
}
