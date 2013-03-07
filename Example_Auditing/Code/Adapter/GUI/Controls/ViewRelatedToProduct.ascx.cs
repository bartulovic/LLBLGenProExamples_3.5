﻿
using System;

using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;

public partial class Controls_ViewRelatedToProduct : System.Web.UI.UserControl, IViewRelatedControl
{
	private PredicateExpression _filterToUse;

	protected void Page_Load(object sender, EventArgs e)
	{
		if(_filterToUse != null)
		{
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				ProductEntity instance = (ProductEntity)adapter.FetchNewEntity(new ProductEntityFactory(), new RelationPredicateBucket(_filterToUse));
				if(instance != null)
				{
					
				}
			}
		}
	}


	/// <summary>
	/// Sets the filter to use for the control's entity fetch routine
	/// </summary>
	public PredicateExpression FilterToUse 
	{
		set { _filterToUse = value; }
	}
}