﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:24:38
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using Northwind.DAL;
using Northwind.DAL.HelperClasses;
using System.Collections.Generic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.FactoryClasses
{
	/// <summary>Generates IEntityFields instances for different kind of Entities.</summary>
	public static partial  class EntityFieldsFactory
	{
		private static readonly Dictionary<Northwind.DAL.EntityType, string> _entityTypeNamesCache = new Dictionary<Northwind.DAL.EntityType, string>();

		/// <summary>static ctor which initializes the static entity type cache.</summary>
		static EntityFieldsFactory()
		{
			foreach(Northwind.DAL.EntityType value in Enum.GetValues(typeof(Northwind.DAL.EntityType)))
			{
				_entityTypeNamesCache.Add(value, Enum.GetName(typeof(Northwind.DAL.EntityType), value));
			}
		}	
	
		/// <summary>General factory entrance method which will return an EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedEntityType">The type of entity the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields CreateEntityFieldsObject(Northwind.DAL.EntityType relatedEntityType)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFields(InheritanceInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance(), _entityTypeNamesCache[relatedEntityType]);
		}
		
		/// <summary>General method which will return an array of IEntityFieldCore objects, used by the InheritanceInfoProvider. Only the fields defined in the entity are returned, no inherited fields.</summary>
		/// <param name="entityName">the name of the entity to get the fields for. Example: "CustomerEntity"</param>
		/// <returns>array of IEntityFieldCore fields, defined in the entity with the name specified</returns>
		internal static IEntityFieldCore[] CreateFields(string entityName)
		{
			return FieldInfoProviderSingleton.GetInstance().GetEntityFieldsArray(entityName, PersistenceInfoProviderSingleton.GetInstance());
		}

		/// <summary>General factory entrance method which will return a TypedView EntityFields object with the format generated by the factory specified</summary>
		/// <param name="relatedTypedViewType">The type of typed view the fields are for</param>
		/// <returns>The IEntityFields instance requested</returns>
		public static IEntityFields CreateTypedViewEntityFieldsObject(TypedViewType relatedTypedViewType)
		{
			IEntityFields fieldsToReturn=null;
			switch(relatedTypedViewType)
			{
				case TypedViewType.AlphabeticalListOfProductTypedView:
					fieldsToReturn = CreateAlphabeticalListOfProductTypedViewEntityFields();
					break;
				case TypedViewType.CategorySalesFor1997TypedView:
					fieldsToReturn = CreateCategorySalesFor1997TypedViewEntityFields();
					break;
				case TypedViewType.CurrentProductListTypedView:
					fieldsToReturn = CreateCurrentProductListTypedViewEntityFields();
					break;
				case TypedViewType.CustomerAndSuppliersByCityTypedView:
					fieldsToReturn = CreateCustomerAndSuppliersByCityTypedViewEntityFields();
					break;
				case TypedViewType.InvoiceTypedView:
					fieldsToReturn = CreateInvoiceTypedViewEntityFields();
					break;
				case TypedViewType.OrderDetailsExtendedTypedView:
					fieldsToReturn = CreateOrderDetailsExtendedTypedViewEntityFields();
					break;
				case TypedViewType.OrdersQryTypedView:
					fieldsToReturn = CreateOrdersQryTypedViewEntityFields();
					break;
				case TypedViewType.OrderSubtotalTypedView:
					fieldsToReturn = CreateOrderSubtotalTypedViewEntityFields();
					break;
				case TypedViewType.ProductsAboveAveragePriceTypedView:
					fieldsToReturn = CreateProductsAboveAveragePriceTypedViewEntityFields();
					break;
				case TypedViewType.ProductSalesFor1997TypedView:
					fieldsToReturn = CreateProductSalesFor1997TypedViewEntityFields();
					break;
				case TypedViewType.ProductsByCategoryTypedView:
					fieldsToReturn = CreateProductsByCategoryTypedViewEntityFields();
					break;
				case TypedViewType.QuarterlyOrderTypedView:
					fieldsToReturn = CreateQuarterlyOrderTypedViewEntityFields();
					break;
				case TypedViewType.SalesByCategoryTypedView:
					fieldsToReturn = CreateSalesByCategoryTypedViewEntityFields();
					break;
				case TypedViewType.SalesTotalsByAmountTypedView:
					fieldsToReturn = CreateSalesTotalsByAmountTypedViewEntityFields();
					break;
				case TypedViewType.SummaryOfSalesByQuarterTypedView:
					fieldsToReturn = CreateSummaryOfSalesByQuarterTypedViewEntityFields();
					break;
				case TypedViewType.SummaryOfSalesByYearTypedView:
					fieldsToReturn = CreateSummaryOfSalesByYearTypedViewEntityFields();
					break;
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the AlphabeticalListOfProductEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateAlphabeticalListOfProductTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)AlphabeticalListOfProductFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("AlphabeticalListOfProductTypedView"));
			for(int i=0;i<(int)AlphabeticalListOfProductFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((AlphabeticalListOfProductFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the CategorySalesFor1997Entity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateCategorySalesFor1997TypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)CategorySalesFor1997FieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("CategorySalesFor1997TypedView"));
			for(int i=0;i<(int)CategorySalesFor1997FieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((CategorySalesFor1997FieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the CurrentProductListEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateCurrentProductListTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)CurrentProductListFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("CurrentProductListTypedView"));
			for(int i=0;i<(int)CurrentProductListFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((CurrentProductListFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the CustomerAndSuppliersByCityEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateCustomerAndSuppliersByCityTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)CustomerAndSuppliersByCityFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("CustomerAndSuppliersByCityTypedView"));
			for(int i=0;i<(int)CustomerAndSuppliersByCityFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((CustomerAndSuppliersByCityFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the InvoiceEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateInvoiceTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)InvoiceFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("InvoiceTypedView"));
			for(int i=0;i<(int)InvoiceFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((InvoiceFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the OrderDetailsExtendedEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateOrderDetailsExtendedTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)OrderDetailsExtendedFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("OrderDetailsExtendedTypedView"));
			for(int i=0;i<(int)OrderDetailsExtendedFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((OrderDetailsExtendedFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the OrdersQryEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateOrdersQryTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)OrdersQryFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("OrdersQryTypedView"));
			for(int i=0;i<(int)OrdersQryFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((OrdersQryFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the OrderSubtotalEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateOrderSubtotalTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)OrderSubtotalFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("OrderSubtotalTypedView"));
			for(int i=0;i<(int)OrderSubtotalFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((OrderSubtotalFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the ProductsAboveAveragePriceEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateProductsAboveAveragePriceTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)ProductsAboveAveragePriceFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("ProductsAboveAveragePriceTypedView"));
			for(int i=0;i<(int)ProductsAboveAveragePriceFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((ProductsAboveAveragePriceFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the ProductSalesFor1997Entity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateProductSalesFor1997TypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)ProductSalesFor1997FieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("ProductSalesFor1997TypedView"));
			for(int i=0;i<(int)ProductSalesFor1997FieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((ProductSalesFor1997FieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the ProductsByCategoryEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateProductsByCategoryTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)ProductsByCategoryFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("ProductsByCategoryTypedView"));
			for(int i=0;i<(int)ProductsByCategoryFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((ProductsByCategoryFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the QuarterlyOrderEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateQuarterlyOrderTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)QuarterlyOrderFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("QuarterlyOrderTypedView"));
			for(int i=0;i<(int)QuarterlyOrderFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((QuarterlyOrderFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SalesByCategoryEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateSalesByCategoryTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)SalesByCategoryFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SalesByCategoryTypedView"));
			for(int i=0;i<(int)SalesByCategoryFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SalesByCategoryFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SalesTotalsByAmountEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateSalesTotalsByAmountTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)SalesTotalsByAmountFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SalesTotalsByAmountTypedView"));
			for(int i=0;i<(int)SalesTotalsByAmountFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SalesTotalsByAmountFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SummaryOfSalesByQuarterEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateSummaryOfSalesByQuarterTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)SummaryOfSalesByQuarterFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SummaryOfSalesByQuarterTypedView"));
			for(int i=0;i<(int)SummaryOfSalesByQuarterFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SummaryOfSalesByQuarterFieldIndex)i);
			}
			return fieldsToReturn;
		}

		/// <summary>Creates a complete EntityFields instance for the SummaryOfSalesByYearEntity.</summary>
		/// <returns></returns>
		private static IEntityFields CreateSummaryOfSalesByYearTypedViewEntityFields()
		{
			IEntityFields fieldsToReturn = new EntityFields((int)SummaryOfSalesByYearFieldIndex.AmountOfFields, null, FieldInfoProviderSingleton.GetInstance().GetFieldIndexes("SummaryOfSalesByYearTypedView"));
			for(int i=0;i<(int)SummaryOfSalesByYearFieldIndex.AmountOfFields;i++)
			{
				fieldsToReturn[i] = EntityFieldFactory.Create((SummaryOfSalesByYearFieldIndex)i);
			}
			return fieldsToReturn;
		}

		#region Included Code

		#endregion
	}
}