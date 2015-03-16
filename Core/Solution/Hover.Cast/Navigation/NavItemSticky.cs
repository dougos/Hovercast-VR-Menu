﻿namespace Hover.Cast.Navigation {

	/*================================================================================================*/
	public class NavItemSticky : NavItem {

		
		////////////////////////////////////////////////////////////////////////////////////////////////
		/*--------------------------------------------------------------------------------------------*/
		public NavItemSticky() : base(ItemType.Sticky ) {
		}

		/*--------------------------------------------------------------------------------------------*/
		protected override bool UsesStickySelection() {
			return true;
		}

	}

}