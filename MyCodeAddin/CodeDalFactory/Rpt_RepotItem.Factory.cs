using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF;
using EF.Data;
using EF.Linq;
using EF.Server;
using EFramework.DalLinq;

namespace Common.DalFactory
{
	public class Rpt_RepotItemFactory:Common.Business.Rpt_RepotItem
    {
        public static Common.Business.Rpt_RepotItem Fetch(Rpt_RepotItem data)
        {
            Common.Business.Rpt_RepotItem item = (Common.Business.Rpt_RepotItem)Activator.CreateInstance(typeof(Common.Business.Rpt_RepotItem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.RepotCode = data.RepotCode;
				                item.ItemId = data.ItemId;
				                item.ColId = data.ColId;
				                item.ItemName = data.ItemName;
				                item.IsValue = data.IsValue;
				                item.IsSum = data.IsSum;
				                item.IsView = data.IsView;
				                item.ParentId = data.ParentId;
				                item.RptLevel = data.RptLevel;
				                item.Sort = data.Sort;
				                item.VievItem = data.VievItem;
				                item.SumType = data.SumType;
				                item.GetValueObjectName = data.GetValueObjectName;
				                item.IsSyn = data.IsSyn;
				                item.GetItemObjectName = data.GetItemObjectName;
				                item.AccType = data.AccType;
				                item.RuleId = data.RuleId;
				                item.IsAmt1 = data.IsAmt1;
				                item.IsAmt2 = data.IsAmt2;
				                item.IsAmt3 = data.IsAmt3;
				                item.IsAmt4 = data.IsAmt4;
				                item.IsAmt5 = data.IsAmt5;
				                item.IsAmt6 = data.IsAmt6;
				                item.IsAmt7 = data.IsAmt7;
				                item.IsAmt8 = data.IsAmt8;
				                item.IsAmt9 = data.IsAmt9;
				                item.IsAmt10 = data.IsAmt10;
				                item.IsAmt11 = data.IsAmt11;
				                item.IsAmt12 = data.IsAmt12;
				                item.IsAmt13 = data.IsAmt13;
				                item.IsAmt14 = data.IsAmt14;
				                item.FunctionAmt1 = data.FunctionAmt1;
				                item.FunctionAmt2 = data.FunctionAmt2;
				                item.FunctionAmt3 = data.FunctionAmt3;
				                item.FunctionAmt4 = data.FunctionAmt4;
				                item.FunctionAmt5 = data.FunctionAmt5;
				                item.FunctionAmt6 = data.FunctionAmt6;
				                item.FunctionAmt7 = data.FunctionAmt7;
				                item.FunctionAmt8 = data.FunctionAmt8;
				                item.FunctionAmt9 = data.FunctionAmt9;
				                item.FunctionAmt10 = data.FunctionAmt10;
				                item.FunctionAmt11 = data.FunctionAmt11;
				                item.FunctionAmt12 = data.FunctionAmt12;
				                item.FunctionAmt13 = data.FunctionAmt13;
				                item.FunctionAmt14 = data.FunctionAmt14;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Rpt_RepotItem>();
                var i = (from p in ctx.DataContext.Rpt_RepotItem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.RepotCode = i.RepotCode;
										this.ItemId = i.ItemId;
										this.ColId = i.ColId;
										this.ItemName = i.ItemName;
										this.IsValue = i.IsValue;
										this.IsSum = i.IsSum;
										this.IsView = i.IsView;
										this.ParentId = i.ParentId;
										this.RptLevel = i.RptLevel;
										this.Sort = i.Sort;
										this.VievItem = i.VievItem;
										this.SumType = i.SumType;
										this.GetValueObjectName = i.GetValueObjectName;
										this.IsSyn = i.IsSyn;
										this.GetItemObjectName = i.GetItemObjectName;
										this.AccType = i.AccType;
										this.RuleId = i.RuleId;
										this.IsAmt1 = i.IsAmt1;
										this.IsAmt2 = i.IsAmt2;
										this.IsAmt3 = i.IsAmt3;
										this.IsAmt4 = i.IsAmt4;
										this.IsAmt5 = i.IsAmt5;
										this.IsAmt6 = i.IsAmt6;
										this.IsAmt7 = i.IsAmt7;
										this.IsAmt8 = i.IsAmt8;
										this.IsAmt9 = i.IsAmt9;
										this.IsAmt10 = i.IsAmt10;
										this.IsAmt11 = i.IsAmt11;
										this.IsAmt12 = i.IsAmt12;
										this.IsAmt13 = i.IsAmt13;
										this.IsAmt14 = i.IsAmt14;
										this.FunctionAmt1 = i.FunctionAmt1;
										this.FunctionAmt2 = i.FunctionAmt2;
										this.FunctionAmt3 = i.FunctionAmt3;
										this.FunctionAmt4 = i.FunctionAmt4;
										this.FunctionAmt5 = i.FunctionAmt5;
										this.FunctionAmt6 = i.FunctionAmt6;
										this.FunctionAmt7 = i.FunctionAmt7;
										this.FunctionAmt8 = i.FunctionAmt8;
										this.FunctionAmt9 = i.FunctionAmt9;
										this.FunctionAmt10 = i.FunctionAmt10;
										this.FunctionAmt11 = i.FunctionAmt11;
										this.FunctionAmt12 = i.FunctionAmt12;
										this.FunctionAmt13 = i.FunctionAmt13;
										this.FunctionAmt14 = i.FunctionAmt14;
					}
            }
        }
	}

	public class Rpt_RepotItemsFactory : Common.Business.Rpt_RepotItems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Rpt_RepotItem
                        select Rpt_RepotItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Paging page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = (from p in ctx.DataContext.Rpt_RepotItem
                        select Rpt_RepotItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

        private void DataPortal_Fetch(PagigExpress page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = page.Lambda.Resolve<Rpt_RepotItem>();
                var i = (from p in ctx.DataContext.Rpt_RepotItem.Where(exp)
                         select Rpt_RepotItemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = lambda.Resolve<Rpt_RepotItem>();
                var i = from p in ctx.DataContext.Rpt_RepotItem.Where(exp)
                         select Rpt_RepotItemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
