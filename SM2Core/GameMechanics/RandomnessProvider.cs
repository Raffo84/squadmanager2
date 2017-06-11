using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM2Core.GameMechanics {
	public class RandomnessProvider {
		private Random RNG = new Random();
		/// <summary>
		/// Override the random number generator base for every function in SM2.
		/// Be very careful when using this! Do not override the RNG outside of testing and debugging!
		/// </summary>
		[Obsolete("Do not use this function outside of testing and debugging!")]
		public void OverrideRng(Random rng) { RNG = rng; }

		/// <summary>
		/// Generates a pseudo-random integer, uniformly drawn between 0 (inclusive) and exclusiveMax (exclusive)
		/// </summary>
		/// <param name="exclusiveMax">The exclusive upper bound of the generated random number</param>
		public int NextUniformInt(int exclusiveMax = Int32.MaxValue) { return RNG.Next(exclusiveMax); }

		/// <summary>
		/// Generates a pseudo-random double, uniformly drawn between 0.0 (inclusive) and 1.0 (exclusive)
		/// </summary>
		public double NextUniformDouble() { return RNG.NextDouble(); }

		/// <summary>
		/// Generates a pseudo-random double of gaussian normal distribution, zero mean, unit deviation.
		/// </summary>
		public double NextNormalDouble() {
			// Adapted from Numerical Recipe page 289: Normal (Gaussian) Deviates
			if(_hasAnotherDeviate) {
				//we have an extra deviate handy. Reset the flag and return it
				_hasAnotherDeviate = false;
				return _otherGaussianDeviate;
			}

			double rsq, v1, v2;
			do {
				//pick two uniform numbers in the square extending from -1 to +1
				v1 = 2.0 * RNG.NextDouble() - 1;
				v2 = 2.0 * RNG.NextDouble() - 1;

				rsq = v1 * v1 + v2 * v2;    //see if they are in the unit circle
			} while(rsq >= 1.0 || rsq == 0.0);

			//now make the box-muller transformation to get two normal deviates.
			double fac = Math.Sqrt(-2.0 * Math.Log(rsq) / rsq);

			//Return one and save one for next time
			_otherGaussianDeviate = v1 * fac;
			_hasAnotherDeviate = true;
			return v2 * fac;
		}
		private bool _hasAnotherDeviate;
		private double _otherGaussianDeviate;
	}
}
