namespace Advent_of_Code_25.Problems;

public class Problem02 : IProblem<long, long>
{
  public long DoPartA()
  {
    var ranges = Utils.InputToStringArray("02").First().Split(',');
    var sum = 0L;

    foreach (var range in ranges)
    {
      var parts = range.Split('-');
      var start = long.Parse(parts[0]);
      var end = long.Parse(parts[1]);

      for (var i = start; i <= end; i++)
      {
        var current = i.ToString();
        if (current.Length % 2 == 0 && current[(current.Length / 2)..] == current[..(current.Length / 2)])
        {
          sum += i;
        }
      }
    }

    return sum;
  }

  public long DoPartB()
  {
    var ranges = Utils.InputToStringArray("02").First().Split(',');
    var sum = 0L;

    foreach (var range in ranges)
    {
      var parts = range.Split('-');
      var start = long.Parse(parts[0]);
      var end = long.Parse(parts[1]);

      for (var i = start; i <= end; i++)
      {
        var current = i.ToString();

        if (MatchesPattern(current))
        {
          sum += i;
        }
      }
    }

    return sum;
  }

  private static bool HasEqualParts(string text, int partCount)
  {
    if (text.Length % partCount != 0)
      return false;

    var partLength = text.Length / partCount;
    var firstPart = text[..partLength];

    for (var i = 1; i < partCount; i++)
    {
      var start = i * partLength;
      var part = text[start..(start + partLength)];
      if (part != firstPart)
        return false;
    }

    return true;
  }

  private static bool MatchesPattern(string text)
  {
    int[] divisors = [2, 3, 5, 7];

    return divisors.Any(divisor => HasEqualParts(text, divisor));
  }
}