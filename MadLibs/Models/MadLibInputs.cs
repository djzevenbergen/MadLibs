using System.Collections.Generic;
namespace MadLibs.Models
{
  public class MadLibInputs
  {
    public Dictionary<int, string> WordListDictionary { get; set; }


    public MadLibInputs(Dictionary<int, string> userInput)
    {
      WordListDictionary = userInput;
    }

  }
}