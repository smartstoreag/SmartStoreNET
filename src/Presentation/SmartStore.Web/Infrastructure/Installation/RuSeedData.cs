﻿using System.Collections.Generic;
using SmartStore.Core.Configuration;
using SmartStore.Data.Setup;

namespace SmartStore.Web.Infrastructure.Installation
{
	public class RuSeedData : InvariantSeedData
	{
		public RuSeedData() { }

		#region Overrides of InvariantSeedData
		/// <inheritdoc />
		protected override void Alter(IList<ISettings> settings)
		{
			base.Alter(settings);
		}
		#endregion
	}
}