namespace Advent_of_Code_25.Problems;

public class Problem01 : IProblem<int, int>
{
  public int DoPartA()
  {
    var lines = Utils.InputToStringArray("01");
    var currentPosition = 50;
    var sum = 0;

    foreach (var line in lines)
    {
      var direction = line.First();
      var clicks = int.Parse(line[1..]);
      var normalizedClicks = clicks % 100;

      switch (direction)
      {
        case 'L':
          currentPosition -= normalizedClicks;

          if (currentPosition < 0)
          {
            currentPosition += 100;
          }

          break;
        case 'R':
          currentPosition += normalizedClicks;

          if (currentPosition >= 100)
          {
            currentPosition -= 100;
          }

          break;
      }

      if (currentPosition == 0)
        sum++;
    }

    return sum;
  }

  public int DoPartB()
  {
    var lines = Utils.InputToStringArray("01");
    var currentPosition = 50;
    var sum = 0;

    foreach (var line in lines)
    {
      var direction = line.First();
      var clicks = int.Parse(line[1..]);
      var normalizedClicks = clicks % 100;
      if (clicks >= 100)
      {
        sum += (clicks - normalizedClicks) / 100;
      }

      var dontCount = currentPosition == 0;

      switch (direction)
      {
        case 'L':
          currentPosition -= normalizedClicks;

          if (currentPosition < 0)
          {
            currentPosition += 100;
            if (currentPosition != 0 && !dontCount)
              sum++;
          }

          break;
        case 'R':
          currentPosition += normalizedClicks;

          if (currentPosition >= 100)
          {
            currentPosition -= 100;
            if (currentPosition != 0 && !dontCount)
              sum++;
          }

          break;
      }

      if (currentPosition == 0)
        sum++;
    }

    return sum;
  }
}