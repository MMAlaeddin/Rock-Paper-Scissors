using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests 
{
  [TestClass]
  public class RPSTests
  {
    [TestMethod]
    public void Match_WillGetDraw_Draw()
    {
      Round newRound = new Round("rock", "rock");
      string result = newRound.Match();
      Assert.AreEqual(result, "DRAW");
    }
    [TestMethod]
    public void Match_WillGetP1Win_Draw()
    {
      Round newRound = new Round("scissors", "paper");
      string result = newRound.Match();
      Assert.AreEqual(result, "Player1 Wins!");
    }
    [TestMethod]
    public void Match_WillGetP2Win_Draw()
    {
      Round newRound = new Round("paper", "scissors");
      string result = newRound.Match();
      Assert.AreEqual(result, "Player2 Wins!");
    }
  }
}