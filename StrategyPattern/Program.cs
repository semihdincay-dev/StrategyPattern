using StrategyPattern;

Duck mallard = new MallardDuck();
mallard.performQuack();
mallard.performFly();

Duck model = new ModelDuck();

// This first call to performFly() delegates to the flyBehavior object
// set in the ModelDuck's constructor, which is a FlyNoway instance
model.performFly();

// This invokes the model's inherited behavior setter method,
// The model suddenly has rocket-powered flying capability!
model.setFlyBehavior(new FlyRocketPowered());

// The model duck dynamically changed its flying behavior!
// You can't do that if th eimplementation lives inside the duck class
model.performFly();
