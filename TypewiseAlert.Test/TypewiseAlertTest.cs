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
      
      Assert.True(TypewiseAlert.inferBreach(15, 10, 20) ==
           TypewiseAlert.BreachType.NORMAL);
      
      Assert.True(TypewiseAlert.classifyTemperatureBreach(CoolingType.PASSIVE_COOLING, 15) ==
           TypewiseAlert.BreachType.NORMAL);
      
     // Assert.True(TypewiseAlert.sendToEmail(BreachType.TOO_LOW));
      
      //TypewiseAlert.sendToController(TOO_LOW);
      
      
      //checkAndAlert(TO_CONTROLLER,{PASSIVE_COOLING,"tata"}, 123);
    }
  }
}
