/* MOIC - Medium Orbit Ion Cannon
 * Released to the public domain
 * Enjoy getting v&, kids.
 */

using System;

namespace MOIC
{
	interface IFlooder
	{
		#region Properties
		int Delay       { get; set; }
		bool IsFlooding { get; set; }
		#endregion

		#region Methods
		void Start();
		void Stop();
		#endregion
	}
}