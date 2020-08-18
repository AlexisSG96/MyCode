using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = false;
      int counter = 0;

      for (int i = 0; i <= 10; i++)
      {
      if (i < 9)
      {  
        continue;
      }
      // this will be skipped until i is no longer less than 9
      Console.WriteLine(i);
      }

      do
      {
        Console.WriteLine("BLARRRRR");
        counter++;
        
        if (counter == 3)
        {
          break;
        }
      } while(!buttonClick);

      string outcome1 = doThatThing(3);
      Console.WriteLine(outcome1);
      string outcome2 = doThatThing(6);
      Console.WriteLine(outcome2);
    }

    static string doThatThing(int i){
        for(int j = 0; j < i ; j++){
            Console.WriteLine("Doing that thing: {0}", (j+1));
            if(j == 4){
                return "Doing that thing overloaded";
            }
        }
        return "Finished doing that thing";
    }
  }
}
