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
	public class EF_TreeStructFactory:Common.Business.EF_TreeStruct
    {
        public static Common.Business.EF_TreeStruct Fetch(EF_TreeStruct data)
        {
            Common.Business.EF_TreeStruct item = (Common.Business.EF_TreeStruct)Activator.CreateInstance(typeof(Common.Business.EF_TreeStruct));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TableName = data.TableName;
				                item.ObjectId = data.ObjectId;
				                item.ParentId = data.ParentId;
				                item.NodeLevel = data.NodeLevel;
				                item.SortOrder = data.SortOrder;
				                item.EndNode = data.EndNode;
				                item.DText = data.DText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_TreeStruct>();
                var i = (from p in ctx.DataContext.EF_TreeStruct.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TableName = i.TableName;
										this.ObjectId = i.ObjectId;
										this.ParentId = i.ParentId;
										this.NodeLevel = i.NodeLevel;
										this.SortOrder = i.SortOrder;
										this.EndNode = i.EndNode;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_TreeStructsFactory : Common.Business.EF_TreeStructs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_TreeStruct
                        select EF_TreeStructFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_TreeStruct
                        select EF_TreeStructFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_TreeStruct>();
                var i = (from p in ctx.DataContext.EF_TreeStruct.Where(exp)
                         select EF_TreeStructFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_TreeStruct>();
                var i = from p in ctx.DataContext.EF_TreeStruct.Where(exp)
                         select EF_TreeStructFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
