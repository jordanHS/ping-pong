using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void IsPingPong_NumberDivisibleByThree_True()
    {
      Ping testPingPong = new Ping();
      Assert.AreEqual("ping", testPingPong.isPingPong(6));
    }
    [TestMethod]
    public void IsPingPong_NumberDivisibleByFive_True()
    {
      Ping testPingPong = new Ping();
      Assert.AreEqual("pong", testPingPong.isPingPong(10));
    }
    [TestMethod]
    public void IsPingPong_NumberDivisiblebyTheeAndFive_True()
    {
      Ping testPingPong = new Ping();
      Assert.AreEqual("ping-pong", testPingPong.isPingPong(15));
    }
  }
}
