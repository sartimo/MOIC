/* MOIC - Medium Orbit Ion Cannon
 * Released to the public domain
 * Enjoy getting v&, kids.
 */

using System;

namespace MOIC
{
	public enum ReqState
	{
		Ready,
		Connecting,
		Requesting,
		Downloading,
		Completed,
		Failed
	};
}