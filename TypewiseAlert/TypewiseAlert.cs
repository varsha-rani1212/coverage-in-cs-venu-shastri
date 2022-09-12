using System;

namespace TypewiseAlert
{
  public class TypewiseAlert
  {
    public enum BreachType {
      NORMAL,
      TOO_LOW,
      TOO_HIGH
    };
    public static BreachType inferBreach(double value, double lowerLimit, double upperLimit) {
      if(value < lowerLimit) {
        return BreachType.TOO_LOW;
      }
      if(value > upperLimit) {
        return BreachType.TOO_HIGH;
      }
      return BreachType.NORMAL;
    }
    public enum CoolingType {
      PASSIVE_COOLING,
      HI_ACTIVE_COOLING,
      MED_ACTIVE_COOLING
    };
    public static BreachType classifyTemperatureBreach(
        CoolingType coolingType, double temperatureInC) {
    
      if(coolingType == CoolingType.PASSIVE_COOLING)
      {
        return inferBreach(temperatureInC, 0, 35);
      }
      
      if(coolingType == CoolingType.HI_ACTIVE_COOLING)
      {
        return inferBreach(temperatureInC, 0, 45);
      }
      
      if(coolingType == CoolingType.MED_ACTIVE_COOLING)
      {
        return inferBreach(temperatureInC, 0, 40);
      }
    }
    
    public enum AlertTarget{
      TO_CONTROLLER,
      TO_EMAIL
    };
    public struct BatteryCharacter {
      public CoolingType coolingType;
      public string brand;
    }
    public static void checkAndAlert(
        AlertTarget alertTarget, BatteryCharacter batteryChar, double temperatureInC) {

      BreachType breachType = classifyTemperatureBreach(
        batteryChar.coolingType, temperatureInC
      );

      switch(alertTarget) {
        case AlertTarget.TO_CONTROLLER:
          sendToController(breachType);
          break;
        case AlertTarget.TO_EMAIL:
          sendToEmail(breachType);
          break;
      }
    }
    public static void sendToController(BreachType breachType) {
      const ushort header = 0xfeed;
      Console.WriteLine("{} : {}\n", header, breachType);
    }
    
    public static void sendToEmail(BreachType breachType) {
      string recepient = "a.b@c.com";  
      if(breachType == BreachType.TOO_LOW){
        Console.WriteLine("To: {}\n", recepient);
        Console.WriteLine("Hi, the temperature is too low\n");
      }
      
      if(breachType == BreachType.TOO_HIGH){
        Console.WriteLine("To: {}\n", recepient);
        Console.WriteLine("Hi, the temperature is too high \n");
      }
   
      }
    }
  }
}
