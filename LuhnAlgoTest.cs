using System;
using Xunit;

//Test implementation

namespace LuhnTest{

 public class LuhnTestAlgorithm{

 void checkCardlength()
 {
   Assert.True(LuhnAlgorithm.checkLengthOfCardNumber("") == LuhnAlgorithm."NotCorrect");
   Assert.True(LuhnAlgorithm.checkLengthOfCardNumber("123456789123456756778") == LuhnAlgorithm."NotCorrect");
   Assert.True(LuhnAlgorithm.checkLengthOfCardNumber("1234567") == LuhnAlgorithm."NotCorrect");
   Assert.True(LuhnAlgorithm.checkLengthOfCardNumber("1234567891234567") == LuhnAlgorithm."Correct"); 
  }

  void checkCardValidity()
  {
   Assert.True(LuhnAlgorithm.checkLuhn("2222420000001113") == LuhnAlgorithm."Valid");
   Assert.True(LuhnAlgorithm.checkLuhn("1234567891234567") == LuhnAlgorithm."Invalid");
  }

 }

}
