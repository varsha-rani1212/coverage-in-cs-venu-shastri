using System;
using Xunit;

namespace TypewiseAlert.Test
{
  public class TypewiseAlertTest
  {
    [Fact]
    public void InfersBreachAsPerLimits()
    {
      Assert.True(TypewiseAlert.inferBreach(12, 20, 30) ==
           TypewiseAlert.BreachType.TOO_LOW);
      
      Assert.True(TypewiseAlert.inferBreach(50, 10, 45) ==
           TypewiseAlert.BreachType.TOO_HIGH);
      
      //checkAndAlert(TO_CONTROLLER,{PASSIVE_COOLING,"tata"}, 123);
    }
  }
}
