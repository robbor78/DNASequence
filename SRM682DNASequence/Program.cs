using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRM682DNASequence
{
  public class Program
  {
    static void Main(string[] args)
    {
    }

    public int longestDNASequence(String sequence)
    {
      int max = 0;
      int count = 0;

      string allowed = "ACGT";

      for (int i=0; i<sequence.Length; i++)
      {
        char c = sequence[i];
        if (allowed.Contains(c))
        {
          count++;
        } else
        {
          max = count > max ? count : max;
          count = 0;
        }
      }

      if (count!=0)
      {
        max = count > max ? count : max;
      }

      return max;
    }
  }
}
