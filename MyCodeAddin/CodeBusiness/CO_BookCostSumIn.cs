using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_BookCostSumIn))]
#if Dev
    [RunLocal]
#endif

	public class CO_BookCostSumIn:ReadOnlyBase<CO_BookCostSumIn>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string LEDNR
        {
            get ;
            set ;
        }

		
        public string OBJNR
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string WRTTP
        {
            get ;
            set ;
        }

		
        public string VERSN
        {
            get ;
            set ;
        }

		
        public string CostElem
        {
            get ;
            set ;
        }

		
        public string HRKFT
        {
            get ;
            set ;
        }

		
        public string VRGNG
        {
            get ;
            set ;
        }

		
        public string PAROB
        {
            get ;
            set ;
        }

		
        public string USPOB
        {
            get ;
            set ;
        }

		
        public bool? IsBD
        {
            get ;
            set ;
        }

		
        public string TCurr
        {
            get ;
            set ;
        }

		
        public int? PeriodF
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public decimal? WTG001
        {
            get ;
            set ;
        }

		
        public decimal? WTG002
        {
            get ;
            set ;
        }

		
        public decimal? WTG003
        {
            get ;
            set ;
        }

		
        public decimal? WTG004
        {
            get ;
            set ;
        }

		
        public decimal? WTG005
        {
            get ;
            set ;
        }

		
        public decimal? WTG006
        {
            get ;
            set ;
        }

		
        public decimal? WTG007
        {
            get ;
            set ;
        }

		
        public decimal? WTG008
        {
            get ;
            set ;
        }

		
        public decimal? WTG009
        {
            get ;
            set ;
        }

		
        public decimal? WTG010
        {
            get ;
            set ;
        }

		
        public decimal? WTG011
        {
            get ;
            set ;
        }

		
        public decimal? WTG012
        {
            get ;
            set ;
        }

		
        public decimal? WTG013
        {
            get ;
            set ;
        }

		
        public decimal? WTG014
        {
            get ;
            set ;
        }

		
        public decimal? WTG015
        {
            get ;
            set ;
        }

		
        public decimal? WTG016
        {
            get ;
            set ;
        }

		
        public decimal? WOG001
        {
            get ;
            set ;
        }

		
        public decimal? WOG002
        {
            get ;
            set ;
        }

		
        public decimal? WOG003
        {
            get ;
            set ;
        }

		
        public decimal? WOG004
        {
            get ;
            set ;
        }

		
        public decimal? WOG005
        {
            get ;
            set ;
        }

		
        public decimal? WOG006
        {
            get ;
            set ;
        }

		
        public decimal? WOG007
        {
            get ;
            set ;
        }

		
        public decimal? WOG008
        {
            get ;
            set ;
        }

		
        public decimal? WOG009
        {
            get ;
            set ;
        }

		
        public decimal? WOG010
        {
            get ;
            set ;
        }

		
        public decimal? WOG011
        {
            get ;
            set ;
        }

		
        public decimal? WOG012
        {
            get ;
            set ;
        }

		
        public decimal? WOG013
        {
            get ;
            set ;
        }

		
        public decimal? WOG014
        {
            get ;
            set ;
        }

		
        public decimal? WOG015
        {
            get ;
            set ;
        }

		
        public decimal? WOG016
        {
            get ;
            set ;
        }

		
        public decimal? WKG001
        {
            get ;
            set ;
        }

		
        public decimal? WKG002
        {
            get ;
            set ;
        }

		
        public decimal? WKG003
        {
            get ;
            set ;
        }

		
        public decimal? WKG004
        {
            get ;
            set ;
        }

		
        public decimal? WKG005
        {
            get ;
            set ;
        }

		
        public decimal? WKG006
        {
            get ;
            set ;
        }

		
        public decimal? WKG007
        {
            get ;
            set ;
        }

		
        public decimal? WKG008
        {
            get ;
            set ;
        }

		
        public decimal? WKG009
        {
            get ;
            set ;
        }

		
        public decimal? WKG010
        {
            get ;
            set ;
        }

		
        public decimal? WKG011
        {
            get ;
            set ;
        }

		
        public decimal? WKG012
        {
            get ;
            set ;
        }

		
        public decimal? WKG013
        {
            get ;
            set ;
        }

		
        public decimal? WKG014
        {
            get ;
            set ;
        }

		
        public decimal? WKG015
        {
            get ;
            set ;
        }

		
        public decimal? WKG016
        {
            get ;
            set ;
        }

		
        public decimal? WKF001
        {
            get ;
            set ;
        }

		
        public decimal? WKF002
        {
            get ;
            set ;
        }

		
        public decimal? WKF003
        {
            get ;
            set ;
        }

		
        public decimal? WKF004
        {
            get ;
            set ;
        }

		
        public decimal? WKF005
        {
            get ;
            set ;
        }

		
        public decimal? WKF006
        {
            get ;
            set ;
        }

		
        public decimal? WKF007
        {
            get ;
            set ;
        }

		
        public decimal? WKF008
        {
            get ;
            set ;
        }

		
        public decimal? WKF009
        {
            get ;
            set ;
        }

		
        public decimal? WKF010
        {
            get ;
            set ;
        }

		
        public decimal? WKF011
        {
            get ;
            set ;
        }

		
        public decimal? WKF012
        {
            get ;
            set ;
        }

		
        public decimal? WKF013
        {
            get ;
            set ;
        }

		
        public decimal? WKF014
        {
            get ;
            set ;
        }

		
        public decimal? WKF015
        {
            get ;
            set ;
        }

		
        public decimal? WKF016
        {
            get ;
            set ;
        }

		
        public decimal? PAG001
        {
            get ;
            set ;
        }

		
        public decimal? PAG002
        {
            get ;
            set ;
        }

		
        public decimal? PAG003
        {
            get ;
            set ;
        }

		
        public decimal? PAG004
        {
            get ;
            set ;
        }

		
        public decimal? PAG005
        {
            get ;
            set ;
        }

		
        public decimal? PAG006
        {
            get ;
            set ;
        }

		
        public decimal? PAG007
        {
            get ;
            set ;
        }

		
        public decimal? PAG008
        {
            get ;
            set ;
        }

		
        public decimal? PAG009
        {
            get ;
            set ;
        }

		
        public decimal? PAG010
        {
            get ;
            set ;
        }

		
        public decimal? PAG011
        {
            get ;
            set ;
        }

		
        public decimal? PAG012
        {
            get ;
            set ;
        }

		
        public decimal? PAG013
        {
            get ;
            set ;
        }

		
        public decimal? PAG014
        {
            get ;
            set ;
        }

		
        public decimal? PAG015
        {
            get ;
            set ;
        }

		
        public decimal? PAG016
        {
            get ;
            set ;
        }

		
        public decimal? PAF001
        {
            get ;
            set ;
        }

		
        public decimal? PAF002
        {
            get ;
            set ;
        }

		
        public decimal? PAF003
        {
            get ;
            set ;
        }

		
        public decimal? PAF004
        {
            get ;
            set ;
        }

		
        public decimal? PAF005
        {
            get ;
            set ;
        }

		
        public decimal? PAF006
        {
            get ;
            set ;
        }

		
        public decimal? PAF007
        {
            get ;
            set ;
        }

		
        public decimal? PAF008
        {
            get ;
            set ;
        }

		
        public decimal? PAF009
        {
            get ;
            set ;
        }

		
        public decimal? PAF010
        {
            get ;
            set ;
        }

		
        public decimal? PAF011
        {
            get ;
            set ;
        }

		
        public decimal? PAF012
        {
            get ;
            set ;
        }

		
        public decimal? PAF013
        {
            get ;
            set ;
        }

		
        public decimal? PAF014
        {
            get ;
            set ;
        }

		
        public decimal? PAF015
        {
            get ;
            set ;
        }

		
        public decimal? PAF016
        {
            get ;
            set ;
        }

		
        public decimal? MEG001
        {
            get ;
            set ;
        }

		
        public decimal? MEG002
        {
            get ;
            set ;
        }

		
        public decimal? MEG003
        {
            get ;
            set ;
        }

		
        public decimal? MEG004
        {
            get ;
            set ;
        }

		
        public decimal? MEG005
        {
            get ;
            set ;
        }

		
        public decimal? MEG006
        {
            get ;
            set ;
        }

		
        public decimal? MEG007
        {
            get ;
            set ;
        }

		
        public decimal? MEG008
        {
            get ;
            set ;
        }

		
        public decimal? MEG009
        {
            get ;
            set ;
        }

		
        public decimal? MEG010
        {
            get ;
            set ;
        }

		
        public decimal? MEG011
        {
            get ;
            set ;
        }

		
        public decimal? MEG012
        {
            get ;
            set ;
        }

		
        public decimal? MEG013
        {
            get ;
            set ;
        }

		
        public decimal? MEG014
        {
            get ;
            set ;
        }

		
        public decimal? MEG015
        {
            get ;
            set ;
        }

		
        public decimal? MEG016
        {
            get ;
            set ;
        }

		
        public decimal? MEF001
        {
            get ;
            set ;
        }

		
        public decimal? MEF002
        {
            get ;
            set ;
        }

		
        public decimal? MEF003
        {
            get ;
            set ;
        }

		
        public decimal? MEF004
        {
            get ;
            set ;
        }

		
        public decimal? MEF005
        {
            get ;
            set ;
        }

		
        public decimal? MEF006
        {
            get ;
            set ;
        }

		
        public decimal? MEF007
        {
            get ;
            set ;
        }

		
        public decimal? MEF008
        {
            get ;
            set ;
        }

		
        public decimal? MEF009
        {
            get ;
            set ;
        }

		
        public decimal? MEF010
        {
            get ;
            set ;
        }

		
        public decimal? MEF011
        {
            get ;
            set ;
        }

		
        public decimal? MEF012
        {
            get ;
            set ;
        }

		
        public decimal? MEF013
        {
            get ;
            set ;
        }

		
        public decimal? MEF014
        {
            get ;
            set ;
        }

		
        public decimal? MEF015
        {
            get ;
            set ;
        }

		
        public decimal? MEF016
        {
            get ;
            set ;
        }

		
        public decimal? MUV001
        {
            get ;
            set ;
        }

		
        public decimal? MUV002
        {
            get ;
            set ;
        }

		
        public decimal? MUV003
        {
            get ;
            set ;
        }

		
        public decimal? MUV004
        {
            get ;
            set ;
        }

		
        public decimal? MUV005
        {
            get ;
            set ;
        }

		
        public decimal? MUV006
        {
            get ;
            set ;
        }

		
        public decimal? MUV007
        {
            get ;
            set ;
        }

		
        public decimal? MUV008
        {
            get ;
            set ;
        }

		
        public decimal? MUV009
        {
            get ;
            set ;
        }

		
        public decimal? MUV010
        {
            get ;
            set ;
        }

		
        public decimal? MUV011
        {
            get ;
            set ;
        }

		
        public decimal? MUV012
        {
            get ;
            set ;
        }

		
        public decimal? MUV013
        {
            get ;
            set ;
        }

		
        public decimal? MUV014
        {
            get ;
            set ;
        }

		
        public decimal? MUV015
        {
            get ;
            set ;
        }

		
        public decimal? MUV016
        {
            get ;
            set ;
        }

		
        public int? BELTP
        {
            get ;
            set ;
        }

		
        public DateTime? TIMESTMP
        {
            get ;
            set ;
        }

		
        public string FKBER
        {
            get ;
            set ;
        }

		
        public string SEGMENT
        {
            get ;
            set ;
        }

		
        public string GEBER
        {
            get ;
            set ;
        }

		
        public string GRANT_NBR
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CO_BookCostSumIn Create()
        {
            return EF.DataPortal.Create<CO_BookCostSumIn>();
        }

		public static CO_BookCostSumIn Fetch(System.Linq.Expressions.Expression<Func<CO_BookCostSumIn, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_BookCostSumIn>(exp,values);
            return EF.DataPortal.Fetch<CO_BookCostSumIn>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_BookCostSumIns))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_BookCostSumIns:ReadOnlyListBase<CO_BookCostSumIns,CO_BookCostSumIn>
    {
        #region Factory Methods

        public static CO_BookCostSumIns Fetch()
        {
            return EF.DataPortal.Fetch<CO_BookCostSumIns>();
        }

		public static CO_BookCostSumIns Fetch(System.Linq.Expressions.Expression<Func<CO_BookCostSumIn, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_BookCostSumIn>(exp,values);
            return EF.DataPortal.Fetch<CO_BookCostSumIns>(lambda);
		}

		public static CO_BookCostSumIns Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_BookCostSumIns>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_BookCostSumIns Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_BookCostSumIn, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_BookCostSumIns>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_BookCostSumIn>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
