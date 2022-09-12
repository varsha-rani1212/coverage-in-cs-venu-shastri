//code implementation

using System;
 
public class LuhnAlgorithm {
    
public static string checkLuhn(String cardNo)
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
    
    if(result == true)
     return "Valid";
    else
     return "Invalid";
  }
  
  public static int checkLengthOfCardNumber(string cardNo){ 
  
     if(cardNo.Length == 0)
     return "Empty";
     
    if(cardNo.Length < 16)
     return "LessThan16";
    
    if(cardNo.Length > 16)
     return "MoreThan16";
     
    if(cardNo.Length == 16)
     return "Correct";
  }
  
   public static public void Main()
    {
        String cardNo = "1234567891234567";
        string cardNoValidity = false;
        string lengthOfCardNumberResult = checkLengthOfCardNumber(cardNo);
        
        if(lengthOfCardNumberResult == "Correct")
        {
           cardNoValidity = checkLuhn(cardNo);   
        }    
    }
}