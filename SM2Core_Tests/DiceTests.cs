using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SM2Core_Tests {
	[TestClass]
	public class DiceTests {
		[TestMethod]
		public void FakeGeneratorAutoTestInt() {
			FakeRandomSource frng = new FakeRandomSource((int)4);
			Assert.AreEqual(4, frng.Next());
			Assert.AreEqual(4, frng.Next());
			Assert.AreEqual(4, frng.Next());
		}

		[TestMethod]
		public void FakeGeneratorAutoTestIntRange() {
			FakeRandomSource frng = new FakeRandomSource(new List<int> { 1, 2, 3, 4, 5 });
			Assert.AreEqual(1, frng.Next());
			Assert.AreEqual(2, frng.Next());
			Assert.AreEqual(3, frng.Next());
			Assert.AreEqual(4, frng.Next());
			Assert.AreEqual(5, frng.Next());
			Assert.AreEqual(1, frng.Next());
			Assert.AreEqual(2, frng.Next());
			Assert.AreEqual(3, frng.Next());
			Assert.AreEqual(4, frng.Next());
			Assert.AreEqual(5, frng.Next());
		}

		[TestMethod]
		public void FakeGeneratorAutoTestDouble() {
			FakeRandomSource frng = new FakeRandomSource(0.1);
			Assert.AreEqual(0.1, frng.NextDouble(), 0.0001);
			Assert.AreEqual(0.1, frng.NextDouble(), 0.0001);
			Assert.AreEqual(0.1, frng.NextDouble(), 0.0001);
		}

		[TestMethod]
		public void FakeGeneratorAutoTestDoubleRange() {
			FakeRandomSource frng = new FakeRandomSource(new List<double> { 0, 0.5, 0.999 });
			Assert.AreEqual(0.0, frng.NextDouble(), 0.0001);
			Assert.AreEqual(0.5, frng.NextDouble(), 0.0001);
			Assert.AreEqual(0.999, frng.NextDouble(), 0.0001);
			Assert.AreEqual(0.0, frng.NextDouble(), 0.0001);
			Assert.AreEqual(0.5, frng.NextDouble(), 0.0001);
			Assert.AreEqual(0.999, frng.NextDouble(), 0.0001);
		}

		[TestMethod]
		public void D6RangeTest() {
			FakeRandomSource frng = new FakeRandomSource(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
			SM2Core.GameMechanics.RandomnessProvider rp = new SM2Core.GameMechanics.RandomnessProvider();
#pragma warning disable CS0618	// "only use this function for tests" - check!
			rp.OverrideRng(frng);
#pragma warning restore CS0618
			SM2Core.GameMechanics.D6 die = new SM2Core.GameMechanics.D6();
			die.RNG = rp;
			Assert.AreEqual(1, die.Roll());
			Assert.AreEqual(2, die.Roll());
			Assert.AreEqual(3, die.Roll());
			Assert.AreEqual(4, die.Roll());
			Assert.AreEqual(5, die.Roll());
			Assert.AreEqual(6, die.Roll());
		}

		[TestMethod]
		public void D6StatisticalTest() {
			SM2Core.GameMechanics.D6 die = new SM2Core.GameMechanics.D6();
			int total = 1000000, sum = 0, roll;
			Dictionary<int, int> counts = new Dictionary<int, int>();
			for(int i = 1; i <= 6; i++)
				counts[i] = 0;

			for(int i = 0; i < total; i++) {
				roll = die.Roll();
				sum += roll;
				counts[roll]++;
			}
			double avg = (double)sum / total;
			Assert.AreEqual(3.5, avg, 0.5);

			double avgCount = 0;
			int minCount = total + 1, maxCount = -1;
			for(int i = 1; i <= 6; i++) {
				avgCount += counts[i] / 6.0;
				if(counts[i] > maxCount)
					maxCount = counts[i];
				if(counts[i] < minCount)
					minCount = counts[i];
			}

			Assert.AreEqual(total / 6.0, avgCount, total / 100.0);
			Assert.IsTrue(minCount >= (total / 6 - total / 100));
			Assert.IsTrue(maxCount <= (total / 6 + total / 100));
		}

	}
}
