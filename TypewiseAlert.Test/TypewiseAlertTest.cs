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
      
      Assert.AreEqual("Hello","Hello");
    }
  }
}
