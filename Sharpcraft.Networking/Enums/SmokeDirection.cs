﻿/*
 * SmokeDirection.cs
 * 
 * Copyright © 2011-2012 by Sijmen Schoon and Adam Hellberg.
 * 
 * This file is part of Sharpcraft.
 * 
 * Sharpcraft is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * Sharpcraft is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with Sharpcraft.  If not, see <http://www.gnu.org/licenses/>.
 * 
 * Disclaimer: Sharpcraft is in no way affiliated with Mojang AB and/or
 * any of its employees and/or licensors.
 * Sijmen Schoon and Adam Hellberg do not take responsibility for
 * any harm caused, direct or indirect, to your Minecraft account
 * via the use of Sharpcraft.
 * 
 * "Minecraft" is a trademark of Mojang AB.
 */

namespace Sharpcraft.Networking.Enums
{
	/// <summary>
	/// Different smoke directions.
	/// </summary>
	/// <remarks>http://wiki.vg/Protocol#Effects_2</remarks>
	public enum SmokeDirection
	{
		/// <summary>
		/// Direction South-East.
		/// </summary>
		SouthEast	= 0,

		/// <summary>
		/// Direction South.
		/// </summary>
		South		= 1,

		/// <summary>
		/// Direction South-West.
		/// </summary>
		SouthWest	= 2,

		/// <summary>
		/// DIrection East.
		/// </summary>
		East		= 3,

		/// <summary>
		/// Direction Up (or Middle).
		/// </summary>
		UpOrMiddle	= 4,

		/// <summary>
		/// Direction West.
		/// </summary>
		West		= 5,
		
		/// <summary>
		/// Direction North-East.
		/// </summary>
		NorthEast	= 6,

		/// <summary>
		/// Direction North.
		/// </summary>
		North		= 7,

		/// <summary>
		/// Direction North-West.
		/// </summary>
		NorthWest	= 8
	}
}
