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
	public class FI_AccGLegerFactory:Common.Business.FI_AccGLeger
    {
        public static Common.Business.FI_AccGLeger Fetch(FI_AccGLeger data)
        {
            Common.Business.FI_AccGLeger item = (Common.Business.FI_AccGLeger)Activator.CreateInstance(typeof(Common.Business.FI_AccGLeger));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AccYear = data.AccYear;
				                item.AccCode = data.AccCode;
				                item.LBAmt = data.LBAmt;
				                item.LDAmt01 = data.LDAmt01;
				                item.LDAmt02 = data.LDAmt02;
				                item.LDAmt03 = data.LDAmt03;
				                item.LDAmt04 = data.LDAmt04;
				                item.LDAmt05 = data.LDAmt05;
				                item.LDAmt06 = data.LDAmt06;
				                item.LDAmt07 = data.LDAmt07;
				                item.LDAmt08 = data.LDAmt08;
				                item.LDAmt09 = data.LDAmt09;
				                item.LDAmt10 = data.LDAmt10;
				                item.LDAmt11 = data.LDAmt11;
				                item.LDAmt12 = data.LDAmt12;
				                item.LDAmt13 = data.LDAmt13;
				                item.LDAmt14 = data.LDAmt14;
				                item.LDAmt15 = data.LDAmt15;
				                item.LDAmt16 = data.LDAmt16;
				                item.LCAmt01 = data.LCAmt01;
				                item.LCAmt02 = data.LCAmt02;
				                item.LCAmt03 = data.LCAmt03;
				                item.LCAmt04 = data.LCAmt04;
				                item.LCAmt05 = data.LCAmt05;
				                item.LCAmt06 = data.LCAmt06;
				                item.LCAmt07 = data.LCAmt07;
				                item.LCAmt08 = data.LCAmt08;
				                item.LCAmt09 = data.LCAmt09;
				                item.LCAmt10 = data.LCAmt10;
				                item.LCAmt11 = data.LCAmt11;
				                item.LCAmt12 = data.LCAmt12;
				                item.LCAmt13 = data.LCAmt13;
				                item.LCAmt14 = data.LCAmt14;
				                item.LCAmt15 = data.LCAmt15;
				                item.LCAmt16 = data.LCAmt16;
				                item.VBAmt = data.VBAmt;
				                item.VDAmt01 = data.VDAmt01;
				                item.VDAmt02 = data.VDAmt02;
				                item.VDAmt03 = data.VDAmt03;
				                item.VDAmt04 = data.VDAmt04;
				                item.VDAmt05 = data.VDAmt05;
				                item.VDAmt06 = data.VDAmt06;
				                item.VDAmt07 = data.VDAmt07;
				                item.VDAmt08 = data.VDAmt08;
				                item.VDAmt09 = data.VDAmt09;
				                item.VDAmt10 = data.VDAmt10;
				                item.VDAmt11 = data.VDAmt11;
				                item.VDAmt12 = data.VDAmt12;
				                item.VDAmt13 = data.VDAmt13;
				                item.VDAmt14 = data.VDAmt14;
				                item.VDAmt15 = data.VDAmt15;
				                item.VDAmt16 = data.VDAmt16;
				                item.VCAmt01 = data.VCAmt01;
				                item.VCAmt02 = data.VCAmt02;
				                item.VCAmt03 = data.VCAmt03;
				                item.VCAmt04 = data.VCAmt04;
				                item.VCAmt05 = data.VCAmt05;
				                item.VCAmt06 = data.VCAmt06;
				                item.VCAmt07 = data.VCAmt07;
				                item.VCAmt08 = data.VCAmt08;
				                item.VCAmt09 = data.VCAmt09;
				                item.VCAmt10 = data.VCAmt10;
				                item.VCAmt11 = data.VCAmt11;
				                item.VCAmt12 = data.VCAmt12;
				                item.VCAmt13 = data.VCAmt13;
				                item.VCAmt14 = data.VCAmt14;
				                item.VCAmt15 = data.VCAmt15;
				                item.VCAmt16 = data.VCAmt16;
				                item.BQty = data.BQty;
				                item.DQty01 = data.DQty01;
				                item.DQty02 = data.DQty02;
				                item.DQty03 = data.DQty03;
				                item.DQty04 = data.DQty04;
				                item.DQty05 = data.DQty05;
				                item.DQty06 = data.DQty06;
				                item.DQty07 = data.DQty07;
				                item.DQty08 = data.DQty08;
				                item.DQty09 = data.DQty09;
				                item.DQty10 = data.DQty10;
				                item.DQty11 = data.DQty11;
				                item.DQty12 = data.DQty12;
				                item.DQty13 = data.DQty13;
				                item.DQty14 = data.DQty14;
				                item.DQty15 = data.DQty15;
				                item.DQty16 = data.DQty16;
				                item.CQty01 = data.CQty01;
				                item.CQty02 = data.CQty02;
				                item.CQty03 = data.CQty03;
				                item.CQty04 = data.CQty04;
				                item.CQty05 = data.CQty05;
				                item.CQty06 = data.CQty06;
				                item.CQty07 = data.CQty07;
				                item.CQty08 = data.CQty08;
				                item.CQty09 = data.CQty09;
				                item.CQty10 = data.CQty10;
				                item.CQty11 = data.CQty11;
				                item.CQty12 = data.CQty12;
				                item.CQty13 = data.CQty13;
				                item.CQty14 = data.CQty14;
				                item.CQty15 = data.CQty15;
				                item.CQty16 = data.CQty16;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_AccGLeger>();
                var i = (from p in ctx.DataContext.FI_AccGLeger.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AccYear = i.AccYear;
										this.AccCode = i.AccCode;
										this.LBAmt = i.LBAmt;
										this.LDAmt01 = i.LDAmt01;
										this.LDAmt02 = i.LDAmt02;
										this.LDAmt03 = i.LDAmt03;
										this.LDAmt04 = i.LDAmt04;
										this.LDAmt05 = i.LDAmt05;
										this.LDAmt06 = i.LDAmt06;
										this.LDAmt07 = i.LDAmt07;
										this.LDAmt08 = i.LDAmt08;
										this.LDAmt09 = i.LDAmt09;
										this.LDAmt10 = i.LDAmt10;
										this.LDAmt11 = i.LDAmt11;
										this.LDAmt12 = i.LDAmt12;
										this.LDAmt13 = i.LDAmt13;
										this.LDAmt14 = i.LDAmt14;
										this.LDAmt15 = i.LDAmt15;
										this.LDAmt16 = i.LDAmt16;
										this.LCAmt01 = i.LCAmt01;
										this.LCAmt02 = i.LCAmt02;
										this.LCAmt03 = i.LCAmt03;
										this.LCAmt04 = i.LCAmt04;
										this.LCAmt05 = i.LCAmt05;
										this.LCAmt06 = i.LCAmt06;
										this.LCAmt07 = i.LCAmt07;
										this.LCAmt08 = i.LCAmt08;
										this.LCAmt09 = i.LCAmt09;
										this.LCAmt10 = i.LCAmt10;
										this.LCAmt11 = i.LCAmt11;
										this.LCAmt12 = i.LCAmt12;
										this.LCAmt13 = i.LCAmt13;
										this.LCAmt14 = i.LCAmt14;
										this.LCAmt15 = i.LCAmt15;
										this.LCAmt16 = i.LCAmt16;
										this.VBAmt = i.VBAmt;
										this.VDAmt01 = i.VDAmt01;
										this.VDAmt02 = i.VDAmt02;
										this.VDAmt03 = i.VDAmt03;
										this.VDAmt04 = i.VDAmt04;
										this.VDAmt05 = i.VDAmt05;
										this.VDAmt06 = i.VDAmt06;
										this.VDAmt07 = i.VDAmt07;
										this.VDAmt08 = i.VDAmt08;
										this.VDAmt09 = i.VDAmt09;
										this.VDAmt10 = i.VDAmt10;
										this.VDAmt11 = i.VDAmt11;
										this.VDAmt12 = i.VDAmt12;
										this.VDAmt13 = i.VDAmt13;
										this.VDAmt14 = i.VDAmt14;
										this.VDAmt15 = i.VDAmt15;
										this.VDAmt16 = i.VDAmt16;
										this.VCAmt01 = i.VCAmt01;
										this.VCAmt02 = i.VCAmt02;
										this.VCAmt03 = i.VCAmt03;
										this.VCAmt04 = i.VCAmt04;
										this.VCAmt05 = i.VCAmt05;
										this.VCAmt06 = i.VCAmt06;
										this.VCAmt07 = i.VCAmt07;
										this.VCAmt08 = i.VCAmt08;
										this.VCAmt09 = i.VCAmt09;
										this.VCAmt10 = i.VCAmt10;
										this.VCAmt11 = i.VCAmt11;
										this.VCAmt12 = i.VCAmt12;
										this.VCAmt13 = i.VCAmt13;
										this.VCAmt14 = i.VCAmt14;
										this.VCAmt15 = i.VCAmt15;
										this.VCAmt16 = i.VCAmt16;
										this.BQty = i.BQty;
										this.DQty01 = i.DQty01;
										this.DQty02 = i.DQty02;
										this.DQty03 = i.DQty03;
										this.DQty04 = i.DQty04;
										this.DQty05 = i.DQty05;
										this.DQty06 = i.DQty06;
										this.DQty07 = i.DQty07;
										this.DQty08 = i.DQty08;
										this.DQty09 = i.DQty09;
										this.DQty10 = i.DQty10;
										this.DQty11 = i.DQty11;
										this.DQty12 = i.DQty12;
										this.DQty13 = i.DQty13;
										this.DQty14 = i.DQty14;
										this.DQty15 = i.DQty15;
										this.DQty16 = i.DQty16;
										this.CQty01 = i.CQty01;
										this.CQty02 = i.CQty02;
										this.CQty03 = i.CQty03;
										this.CQty04 = i.CQty04;
										this.CQty05 = i.CQty05;
										this.CQty06 = i.CQty06;
										this.CQty07 = i.CQty07;
										this.CQty08 = i.CQty08;
										this.CQty09 = i.CQty09;
										this.CQty10 = i.CQty10;
										this.CQty11 = i.CQty11;
										this.CQty12 = i.CQty12;
										this.CQty13 = i.CQty13;
										this.CQty14 = i.CQty14;
										this.CQty15 = i.CQty15;
										this.CQty16 = i.CQty16;
					}
            }
        }
	}

	public class FI_AccGLegersFactory : Common.Business.FI_AccGLegers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_AccGLeger
                        select FI_AccGLegerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_AccGLeger
                        select FI_AccGLegerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_AccGLeger>();
                var i = (from p in ctx.DataContext.FI_AccGLeger.Where(exp)
                         select FI_AccGLegerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_AccGLeger>();
                var i = from p in ctx.DataContext.FI_AccGLeger.Where(exp)
                         select FI_AccGLegerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
