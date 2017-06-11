using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM2Core_Tests {
	/// <summary>
	/// A fake RNG implementation for testing purposes only.
	/// Will always generate the number(s) provided in the constructor.
	/// </summary>
	public class FakeRandomSource: Random {
		public FakeRandomSource(int result) {
			intResults.Add(result);
			doubleResults.Add(0.0);
		}
		public FakeRandomSource(List<int> results) {
			foreach(int n in results)
				intResults.Add(n);
			doubleResults.Add(0.0);
		}
		public FakeRandomSource(double result) {
			if(result < 0 || result > 1)
				throw new ArgumentOutOfRangeException("result", "Double results must be within 0.0 and 1.0");
			intResults.Add(0);
			doubleResults.Add(result);
		}
		public FakeRandomSource(List<double> results) {
			foreach(int n in results) {
				if(n < 0 || n > 1)
					throw new ArgumentOutOfRangeException("results", "All double results must be within 0.0 and 1.0");
			}
			foreach(double n in results)
				doubleResults.Add(n);
			intResults.Add(0);
		}

		private List<int> intResults = new List<int>();
		private List<double> doubleResults = new List<double>();
		private int intCounter = -1, doubleCounter = -1;

		public void ResetCounter() { intCounter = doubleCounter = -1; }

		protected override double Sample() {
			doubleCounter = (doubleCounter + 1) % doubleResults.Count;
			return doubleResults[doubleCounter];
		}

		public override int Next() {
			intCounter = (intCounter + 1) % intResults.Count;
			return intResults[intCounter];
		}
		public override int Next(int minValue, int maxValue) {
			int buffer = Next();
			if(buffer < minValue)
				buffer = minValue;
			if(buffer >= maxValue)
				buffer = maxValue - 1;
			return buffer;
		}
		public override int Next(int maxValue) {
			return Next(0, maxValue);
		}
		public override void NextBytes(byte[] buffer) {
			for(int i = 0; i < buffer.Length; i++) {
				buffer[i] = (byte)(Next() % 256);
			}
		}
	}
}
