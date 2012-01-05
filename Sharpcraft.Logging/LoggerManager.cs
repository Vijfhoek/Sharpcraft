﻿/* 
 * Sharpcraft.Logging
 * Copyright (c) 2012 by Sijmen Schoon and Adam Hellberg.
 * All Rights Reserved.
 */

using System;
using System.IO;

using log4net;
using log4net.Config;

namespace Sharpcraft.Logging
{
	public static class LoggerManager
	{
		private static bool _loaded;
		private const string ConfigFile = @"configs\LoggerConfig.xml";
		private const string DebugConfigFile = @"configs\LoggerDebugConfig.xml";

		public static void LoadConfig(bool debug = false)
		{
			XmlConfigurator.Configure(new FileInfo(debug ? DebugConfigFile : ConfigFile));
			_loaded = true;
		}

		public static ILog GetLogger(object sender)
		{
			if (!_loaded)
				LoadConfig();
			return LogManager.GetLogger(sender.GetType().ToString() == "System.RuntimeType" ? (Type) sender : sender.GetType());
		}
	}
}
