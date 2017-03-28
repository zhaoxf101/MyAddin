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
	public class CO_BookCostSumOutFactory:Common.Business.CO_BookCostSumOut
    {
        public static Common.Business.CO_BookCostSumOut Fetch(CO_BookCostSumOut data)
        {
            Common.Business.CO_BookCostSumOut item = (Common.Business.CO_BookCostSumOut)Activator.CreateInstance(typeof(Common.Business.CO_BookCostSumOut));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.LEDNR = data.LEDNR;
				                item.OBJNR = data.OBJNR;
				                item.AccYear = data.AccYear;
				                item.WRTTP = data.WRTTP;
				                item.VERSN = data.VERSN;
				                item.CostElem = data.CostElem;
				                item.HRKFT = data.HRKFT;
				                item.VRGNG = data.VRGNG;
				                item.VBUND = data.VBUND;
				                item.PARGB = data.PARGB;
				                item.IsBD = data.IsBD;
				                item.TCurr = data.TCurr;
				                item.PeriodF = data.PeriodF;
				                item.UnitCode = data.UnitCode;
				                item.WTG001 = data.WTG001;
				                item.WTG002 = data.WTG002;
				                item.WTG003 = data.WTG003;
				                item.WTG004 = data.WTG004;
				                item.WTG005 = data.WTG005;
				                item.WTG006 = data.WTG006;
				                item.WTG007 = data.WTG007;
				                item.WTG008 = data.WTG008;
				                item.WTG009 = data.WTG009;
				                item.WTG010 = data.WTG010;
				                item.WTG011 = data.WTG011;
				                item.WTG012 = data.WTG012;
				                item.WTG013 = data.WTG013;
				                item.WTG014 = data.WTG014;
				                item.WTG015 = data.WTG015;
				                item.WTG016 = data.WTG016;
				                item.WOG001 = data.WOG001;
				                item.WOG002 = data.WOG002;
				                item.WOG003 = data.WOG003;
				                item.WOG004 = data.WOG004;
				                item.WOG005 = data.WOG005;
				                item.WOG006 = data.WOG006;
				                item.WOG007 = data.WOG007;
				                item.WOG008 = data.WOG008;
				                item.WOG009 = data.WOG009;
				                item.WOG010 = data.WOG010;
				                item.WOG011 = data.WOG011;
				                item.WOG012 = data.WOG012;
				                item.WOG013 = data.WOG013;
				                item.WOG014 = data.WOG014;
				                item.WOG015 = data.WOG015;
				                item.WOG016 = data.WOG016;
				                item.WKG001 = data.WKG001;
				                item.WKG002 = data.WKG002;
				                item.WKG003 = data.WKG003;
				                item.WKG004 = data.WKG004;
				                item.WKG005 = data.WKG005;
				                item.WKG006 = data.WKG006;
				                item.WKG007 = data.WKG007;
				                item.WKG008 = data.WKG008;
				                item.WKG009 = data.WKG009;
				                item.WKG010 = data.WKG010;
				                item.WKG011 = data.WKG011;
				                item.WKG012 = data.WKG012;
				                item.WKG013 = data.WKG013;
				                item.WKG014 = data.WKG014;
				                item.WKG015 = data.WKG015;
				                item.WKG016 = data.WKG016;
				                item.WKF001 = data.WKF001;
				                item.WKF002 = data.WKF002;
				                item.WKF003 = data.WKF003;
				                item.WKF004 = data.WKF004;
				                item.WKF005 = data.WKF005;
				                item.WKF006 = data.WKF006;
				                item.WKF007 = data.WKF007;
				                item.WKF008 = data.WKF008;
				                item.WKF009 = data.WKF009;
				                item.WKF010 = data.WKF010;
				                item.WKF011 = data.WKF011;
				                item.WKF012 = data.WKF012;
				                item.WKF013 = data.WKF013;
				                item.WKF014 = data.WKF014;
				                item.WKF015 = data.WKF015;
				                item.WKF016 = data.WKF016;
				                item.PAG00 = data.PAG00;
				                item.PAG001 = data.PAG001;
				                item.PAG002 = data.PAG002;
				                item.PAG003 = data.PAG003;
				                item.PAG004 = data.PAG004;
				                item.PAG005 = data.PAG005;
				                item.PAG006 = data.PAG006;
				                item.PAG007 = data.PAG007;
				                item.PAG008 = data.PAG008;
				                item.PAG009 = data.PAG009;
				                item.PAG010 = data.PAG010;
				                item.PAG011 = data.PAG011;
				                item.PAG012 = data.PAG012;
				                item.PAG013 = data.PAG013;
				                item.PAG014 = data.PAG014;
				                item.PAG015 = data.PAG015;
				                item.PAG016 = data.PAG016;
				                item.MEG001 = data.MEG001;
				                item.MEG002 = data.MEG002;
				                item.MEG003 = data.MEG003;
				                item.MEG004 = data.MEG004;
				                item.MEG005 = data.MEG005;
				                item.MEG006 = data.MEG006;
				                item.MEG007 = data.MEG007;
				                item.MEG008 = data.MEG008;
				                item.MEG009 = data.MEG009;
				                item.MEG010 = data.MEG010;
				                item.MEG011 = data.MEG011;
				                item.MEG012 = data.MEG012;
				                item.MEG013 = data.MEG013;
				                item.MEG014 = data.MEG014;
				                item.MEG015 = data.MEG015;
				                item.MEG016 = data.MEG016;
				                item.MEF001 = data.MEF001;
				                item.MEF002 = data.MEF002;
				                item.MEF003 = data.MEF003;
				                item.MEF004 = data.MEF004;
				                item.MEF005 = data.MEF005;
				                item.MEF006 = data.MEF006;
				                item.MEF007 = data.MEF007;
				                item.MEF008 = data.MEF008;
				                item.MEF009 = data.MEF009;
				                item.MEF010 = data.MEF010;
				                item.MEF011 = data.MEF011;
				                item.MEF012 = data.MEF012;
				                item.MEF013 = data.MEF013;
				                item.MEF014 = data.MEF014;
				                item.MEF015 = data.MEF015;
				                item.MEF016 = data.MEF016;
				                item.MUV001 = data.MUV001;
				                item.MUV002 = data.MUV002;
				                item.MUV003 = data.MUV003;
				                item.MUV004 = data.MUV004;
				                item.MUV005 = data.MUV005;
				                item.MUV006 = data.MUV006;
				                item.MUV007 = data.MUV007;
				                item.MUV008 = data.MUV008;
				                item.MUV009 = data.MUV009;
				                item.MUV010 = data.MUV010;
				                item.MUV011 = data.MUV011;
				                item.MUV012 = data.MUV012;
				                item.MUV013 = data.MUV013;
				                item.MUV014 = data.MUV014;
				                item.MUV015 = data.MUV015;
				                item.MUV016 = data.MUV016;
				                item.BELTP = data.BELTP;
				                item.TIMESTMP = data.TIMESTMP;
				                item.FKBER = data.FKBER;
				                item.SEGMENT = data.SEGMENT;
				                item.GEBER = data.GEBER;
				                item.GRANT_NBR = data.GRANT_NBR;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<CO_BookCostSumOut>();
                var i = (from p in ctx.DataContext.CO_BookCostSumOut.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.LEDNR = i.LEDNR;
										this.OBJNR = i.OBJNR;
										this.AccYear = i.AccYear;
										this.WRTTP = i.WRTTP;
										this.VERSN = i.VERSN;
										this.CostElem = i.CostElem;
										this.HRKFT = i.HRKFT;
										this.VRGNG = i.VRGNG;
										this.VBUND = i.VBUND;
										this.PARGB = i.PARGB;
										this.IsBD = i.IsBD;
										this.TCurr = i.TCurr;
										this.PeriodF = i.PeriodF;
										this.UnitCode = i.UnitCode;
										this.WTG001 = i.WTG001;
										this.WTG002 = i.WTG002;
										this.WTG003 = i.WTG003;
										this.WTG004 = i.WTG004;
										this.WTG005 = i.WTG005;
										this.WTG006 = i.WTG006;
										this.WTG007 = i.WTG007;
										this.WTG008 = i.WTG008;
										this.WTG009 = i.WTG009;
										this.WTG010 = i.WTG010;
										this.WTG011 = i.WTG011;
										this.WTG012 = i.WTG012;
										this.WTG013 = i.WTG013;
										this.WTG014 = i.WTG014;
										this.WTG015 = i.WTG015;
										this.WTG016 = i.WTG016;
										this.WOG001 = i.WOG001;
										this.WOG002 = i.WOG002;
										this.WOG003 = i.WOG003;
										this.WOG004 = i.WOG004;
										this.WOG005 = i.WOG005;
										this.WOG006 = i.WOG006;
										this.WOG007 = i.WOG007;
										this.WOG008 = i.WOG008;
										this.WOG009 = i.WOG009;
										this.WOG010 = i.WOG010;
										this.WOG011 = i.WOG011;
										this.WOG012 = i.WOG012;
										this.WOG013 = i.WOG013;
										this.WOG014 = i.WOG014;
										this.WOG015 = i.WOG015;
										this.WOG016 = i.WOG016;
										this.WKG001 = i.WKG001;
										this.WKG002 = i.WKG002;
										this.WKG003 = i.WKG003;
										this.WKG004 = i.WKG004;
										this.WKG005 = i.WKG005;
										this.WKG006 = i.WKG006;
										this.WKG007 = i.WKG007;
										this.WKG008 = i.WKG008;
										this.WKG009 = i.WKG009;
										this.WKG010 = i.WKG010;
										this.WKG011 = i.WKG011;
										this.WKG012 = i.WKG012;
										this.WKG013 = i.WKG013;
										this.WKG014 = i.WKG014;
										this.WKG015 = i.WKG015;
										this.WKG016 = i.WKG016;
										this.WKF001 = i.WKF001;
										this.WKF002 = i.WKF002;
										this.WKF003 = i.WKF003;
										this.WKF004 = i.WKF004;
										this.WKF005 = i.WKF005;
										this.WKF006 = i.WKF006;
										this.WKF007 = i.WKF007;
										this.WKF008 = i.WKF008;
										this.WKF009 = i.WKF009;
										this.WKF010 = i.WKF010;
										this.WKF011 = i.WKF011;
										this.WKF012 = i.WKF012;
										this.WKF013 = i.WKF013;
										this.WKF014 = i.WKF014;
										this.WKF015 = i.WKF015;
										this.WKF016 = i.WKF016;
										this.PAG00 = i.PAG00;
										this.PAG001 = i.PAG001;
										this.PAG002 = i.PAG002;
										this.PAG003 = i.PAG003;
										this.PAG004 = i.PAG004;
										this.PAG005 = i.PAG005;
										this.PAG006 = i.PAG006;
										this.PAG007 = i.PAG007;
										this.PAG008 = i.PAG008;
										this.PAG009 = i.PAG009;
										this.PAG010 = i.PAG010;
										this.PAG011 = i.PAG011;
										this.PAG012 = i.PAG012;
										this.PAG013 = i.PAG013;
										this.PAG014 = i.PAG014;
										this.PAG015 = i.PAG015;
										this.PAG016 = i.PAG016;
										this.MEG001 = i.MEG001;
										this.MEG002 = i.MEG002;
										this.MEG003 = i.MEG003;
										this.MEG004 = i.MEG004;
										this.MEG005 = i.MEG005;
										this.MEG006 = i.MEG006;
										this.MEG007 = i.MEG007;
										this.MEG008 = i.MEG008;
										this.MEG009 = i.MEG009;
										this.MEG010 = i.MEG010;
										this.MEG011 = i.MEG011;
										this.MEG012 = i.MEG012;
										this.MEG013 = i.MEG013;
										this.MEG014 = i.MEG014;
										this.MEG015 = i.MEG015;
										this.MEG016 = i.MEG016;
										this.MEF001 = i.MEF001;
										this.MEF002 = i.MEF002;
										this.MEF003 = i.MEF003;
										this.MEF004 = i.MEF004;
										this.MEF005 = i.MEF005;
										this.MEF006 = i.MEF006;
										this.MEF007 = i.MEF007;
										this.MEF008 = i.MEF008;
										this.MEF009 = i.MEF009;
										this.MEF010 = i.MEF010;
										this.MEF011 = i.MEF011;
										this.MEF012 = i.MEF012;
										this.MEF013 = i.MEF013;
										this.MEF014 = i.MEF014;
										this.MEF015 = i.MEF015;
										this.MEF016 = i.MEF016;
										this.MUV001 = i.MUV001;
										this.MUV002 = i.MUV002;
										this.MUV003 = i.MUV003;
										this.MUV004 = i.MUV004;
										this.MUV005 = i.MUV005;
										this.MUV006 = i.MUV006;
										this.MUV007 = i.MUV007;
										this.MUV008 = i.MUV008;
										this.MUV009 = i.MUV009;
										this.MUV010 = i.MUV010;
										this.MUV011 = i.MUV011;
										this.MUV012 = i.MUV012;
										this.MUV013 = i.MUV013;
										this.MUV014 = i.MUV014;
										this.MUV015 = i.MUV015;
										this.MUV016 = i.MUV016;
										this.BELTP = i.BELTP;
										this.TIMESTMP = i.TIMESTMP;
										this.FKBER = i.FKBER;
										this.SEGMENT = i.SEGMENT;
										this.GEBER = i.GEBER;
										this.GRANT_NBR = i.GRANT_NBR;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class CO_BookCostSumOutsFactory : Common.Business.CO_BookCostSumOuts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_BookCostSumOut
                        select CO_BookCostSumOutFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_BookCostSumOut
                        select CO_BookCostSumOutFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_BookCostSumOut>();
                var i = (from p in ctx.DataContext.CO_BookCostSumOut.Where(exp)
                         select CO_BookCostSumOutFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_BookCostSumOut>();
                var i = from p in ctx.DataContext.CO_BookCostSumOut.Where(exp)
                         select CO_BookCostSumOutFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
