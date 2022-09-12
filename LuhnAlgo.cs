//code implementation
using System;
 
public class LuhnAlgorithm {
    
public static bool checkLuhn(String cardNo)
{
    int cardNumberDigitSum = 0;
    bool isSecond = false;
    for (int i = 15; i >= 0; i--)
    {
         int currentCardNumberDigit = cardNo[i] - '0';
 
        if (isSecond == true)
            d = d * 2;
            
        cardNumberDigitSum += currentCardNumberDigit / 10;
        cardNumberDigitSum += currentCardNumberDigit % 10;
 
        isSecond = !isSecond;
    }
    bool result = (nSum % 10 == 0);
    
     return result;
  }
  
  public static int checkLengthOfCardNumber(string cardNo){ 
     
    if(cardNo.Length == 16)
     return "Correct";
   
   return "NotCorrect";
  }
  
   public static public void Main()
    {
        String cardNo = "1234567891234567";
        bool cardNoValidity = false;
        string lengthOfCardNumberResult = checkLengthOfCardNumber(cardNo);
        
        if(lengthOfCardNumberResult == "Correct")
        {
           cardNoValidity = checkLuhn(cardNo);   
        }    
    }
}
