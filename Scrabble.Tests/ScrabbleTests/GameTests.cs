
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;
using System.Collections.Generic;

namespace Game.Tests 
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void ScoreCalculator_ReturnsScoreOfWord_Int()
        {
            int result = Score.ScoreCalculator("boat");
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ScoreCalculator_ReturnsError_Int()
        {
            int result = Score.ScoreCalculator("fds2");
            Assert.AreEqual(-1, result);
        }
    }
}