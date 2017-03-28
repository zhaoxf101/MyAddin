using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_PurVouchSub))]
#if Dev
    [RunLocal]
#endif

	public class MM_PurVouchSub:ReadOnlyBase<MM_PurVouchSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PurVouchNo
        {
            get ;
            set ;
        }

		
        public int? PVItemNo
        {
            get ;
            set ;
        }

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
        public string Materialcode
        {
            get ;
            set ;
        }

		
        public string Warehouse
        {
            get ;
            set ;
        }

		
        public string BEDNR
        {
            get ;
            set ;
        }

		
        public string MatType
        {
            get ;
            set ;
        }

		
        public string INFNR
        {
            get ;
            set ;
        }

		
        public string IDNLF
        {
            get ;
            set ;
        }

		
        public decimal? KTMNG
        {
            get ;
            set ;
        }

		
        public decimal? MENGE
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public string PUnitCode
        {
            get ;
            set ;
        }

		
        public int? BPUMZ
        {
            get ;
            set ;
        }

		
        public int? BPUMN
        {
            get ;
            set ;
        }

		
        public decimal? Price
        {
            get ;
            set ;
        }

		
        public decimal? NETWR
        {
            get ;
            set ;
        }

		
        public decimal? BRTWR
        {
            get ;
            set ;
        }

		
        public string MWSKZ
        {
            get ;
            set ;
        }

		
        public string BONUS
        {
            get ;
            set ;
        }

		
        public string INSMK
        {
            get ;
            set ;
        }

		
        public string BWTAR
        {
            get ;
            set ;
        }

		
        public string BWTTY
        {
            get ;
            set ;
        }

		
        public string ABSKZ
        {
            get ;
            set ;
        }

		
        public string ELIKZ
        {
            get ;
            set ;
        }

		
        public string EREKZ
        {
            get ;
            set ;
        }

		
        public string PSTYP
        {
            get ;
            set ;
        }

		
        public string KNTTP
        {
            get ;
            set ;
        }

		
        public string KZVBR
        {
            get ;
            set ;
        }

		
        public string REPOS
        {
            get ;
            set ;
        }

		
        public string KZABS
        {
            get ;
            set ;
        }

		
        public string LABNR
        {
            get ;
            set ;
        }

		
        public string KONNR
        {
            get ;
            set ;
        }

		
        public int? KTPNR
        {
            get ;
            set ;
        }

		
        public DateTime? ABDAT
        {
            get ;
            set ;
        }

		
        public decimal? ABFTZ
        {
            get ;
            set ;
        }

		
        public string BSTYP
        {
            get ;
            set ;
        }

		
        public string SKTOF
        {
            get ;
            set ;
        }

		
        public decimal? PLIFZ
        {
            get ;
            set ;
        }

		
        public string FPLNR
        {
            get ;
            set ;
        }

		
        public string ADDR
        {
            get ;
            set ;
        }

		
        public string BANFN
        {
            get ;
            set ;
        }

		
        public int? BNFPO
        {
            get ;
            set ;
        }

		
        public string RETPO
        {
            get ;
            set ;
        }

		
        public string BSGRU
        {
            get ;
            set ;
        }

		
        public string LFRET
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_PurVouchSub Create()
        {
            return EF.DataPortal.Create<MM_PurVouchSub>();
        }

		public static MM_PurVouchSub Fetch(System.Linq.Expressions.Expression<Func<MM_PurVouchSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_PurVouchSub>(exp,values);
            return EF.DataPortal.Fetch<MM_PurVouchSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_PurVouchSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_PurVouchSubs:ReadOnlyListBase<MM_PurVouchSubs,MM_PurVouchSub>
    {
        #region Factory Methods

        public static MM_PurVouchSubs Fetch()
        {
            return EF.DataPortal.Fetch<MM_PurVouchSubs>();
        }

		public static MM_PurVouchSubs Fetch(System.Linq.Expressions.Expression<Func<MM_PurVouchSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_PurVouchSub>(exp,values);
            return EF.DataPortal.Fetch<MM_PurVouchSubs>(lambda);
		}

		public static MM_PurVouchSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_PurVouchSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_PurVouchSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_PurVouchSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_PurVouchSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_PurVouchSub>(exp,values)});
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
