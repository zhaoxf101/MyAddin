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
	public class Test_DataFactory:Common.Business.Test_Data
    {
        public static Common.Business.Test_Data Fetch(Test_Data data)
        {
            Common.Business.Test_Data item = (Common.Business.Test_Data)Activator.CreateInstance(typeof(Common.Business.Test_Data));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.DataCode = data.DataCode;
				                item.DataName = data.DataName;
				                item.DataAmt = data.DataAmt;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Test_Data>();
                var i = (from p in ctx.DataContext.Test_Data.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.DataCode = i.DataCode;
										this.DataName = i.DataName;
										this.DataAmt = i.DataAmt;
					}
            }
        }
	}

	public class Test_DatasFactory : Common.Business.Test_Datas
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Test_Data
                        select Test_DataFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Test_Data
                        select Test_DataFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Test_Data>();
                var i = (from p in ctx.DataContext.Test_Data.Where(exp)
                         select Test_DataFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Test_Data>();
                var i = from p in ctx.DataContext.Test_Data.Where(exp)
                         select Test_DataFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
