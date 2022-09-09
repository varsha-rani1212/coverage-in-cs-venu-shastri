void GivenEmptyString0isExpected()
{
  int expectedValue = Assert.True(TypewiseAlert.add("") == TypewiseAlert.0)
}


//code implementation

class Calculate
{
  int add(string data)
    {
      if(data == "")
        return 0;
      
      throw new NotImplementedException();
    }
  
  public static void main(string[] args)
  {
    Calculate obj = new Calculate();
    obj.add();  
  }
}
