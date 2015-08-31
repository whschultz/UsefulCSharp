// Useful C#
// Copyright (C) 2014-2015 Nicholas Randal
// 
// Useful C# is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

using System.ComponentModel.DataAnnotations;

namespace Randal.Sql.Deployer.Shared
{
	public enum RunnerResolution
	{
		[Display(Name = "Committed", Description = "Changes committed to the database.")]
		Committed		= -1,

		[Display(Name = "Validation Only", Description = "The deployment was set to validation only.")]
		ValidationOnly	= -2,

		[Display(Name = "Rollback", Description = "Changes Rolled Back!")]
		RolledBack		= -3,

		[Display(Name = "Exception Thrown", Description = "An unexpected exception was thrown!")]
		ExceptionThrown = -999
	}
}