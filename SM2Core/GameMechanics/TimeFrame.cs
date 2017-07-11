using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM2Core.GameMechanics {
	public interface TimeFrame {
		/// <summary>
		/// The name of this system's base unit, for compatibility.
		/// Should usually be something like "second".
		/// </summary>
		string BaseUnitName { get; }

		/// <summary>
		/// The intended duration, expressed in the defined base unit.
		/// E.g.: In order to store the duration of a week in base units of seconds,
		/// this should hold 7*24*60*60 = 604.800
		/// </summary>
		long BaseAmount { get; set; }

		/// <summary>
		/// Create a time frame given a specific unit.
		/// </summary>
		/// <param name="amount">The duration in the given time units (e.g. "7").</param>
		/// <param name="unit">The unit, in which the duration is given (e.g. "Days").</param>
		/// <returns></returns>
		TimeFrame FromBase(int amount, TimeFrameUnitBase unit);

		/// <summary>
		/// Return the duration stored in this time frame in the given units.
		/// This function can be used to convert times between units.
		/// </summary>
		/// <param name="unit">The unit, in which this time frame should be returned.</param>
		/// <returns>The stored time frame, returned in the given units.</returns>
		int ToBase(TimeFrameUnitBase unit);
	}

	public class TimeFrameUnitBase {
		//public static readonly TimeFrameUnitBase Second = new TimeFrameUnitBase(1, "Second");
		//public static readonly TimeFrameUnitBase Minute = new TimeFrameUnitBase(2, "Minute");
		//public static readonly TimeFrameUnitBase Hour = new TimeFrameUnitBase(3, "Hour");
		//public static readonly TimeFrameUnitBase Day = new TimeFrameUnitBase(4, "Day");
		//public static readonly TimeFrameUnitBase Week = new TimeFrameUnitBase(5, "Week");
		//public static readonly TimeFrameUnitBase Month = new TimeFrameUnitBase(6, "Month");
		//public static readonly TimeFrameUnitBase Year = new TimeFrameUnitBase(7, "Year");
		//public static readonly TimeFrameUnitBase CombatRound = new TimeFrameUnitBase(101, "CombatRound");

		public int InternalValue { get; protected set; }
		public string InternalName { get; protected set; }
		protected TimeFrameUnitBase(int magic, string name) { InternalValue = magic; InternalName = name; }
	}
}
