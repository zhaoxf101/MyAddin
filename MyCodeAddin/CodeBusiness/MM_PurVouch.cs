using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_PurVouch))]
#if Dev
    [RunLocal]
#endif

	public class MM_PurVouch:ReadOnlyBase<MM_PurVouch>
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

		
        public string BSTYP
        {
            get ;
            set ;
        }

		
        public string BSART
        {
            get ;
            set ;
        }

		
        public string BSAKZ
        {
            get ;
            set ;
        }

		
        public string LOEKZ
        {
            get ;
            set ;
        }

		
        public string STATU
        {
            get ;
            set ;
        }

		
        public int? LPONR
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string ZTERM
        {
            get ;
            set ;
        }

		
        public int? ZBD1T
        {
            get ;
            set ;
        }

		
        public int? ZBD2T
        {
            get ;
            set ;
        }

		
        public int? ZBD3T
        {
            get ;
            set ;
        }

		
        public decimal? ZBD1P
        {
            get ;
            set ;
        }

		
        public decimal? ZBD2P
        {
            get ;
            set ;
        }

		
        public string PurchaseGrp
        {
            get ;
            set ;
        }

		
        public string Curr
        {
            get ;
            set ;
        }

		
        public decimal? Rate
        {
            get ;
            set ;
        }

		
        public string KUFIX
        {
            get ;
            set ;
        }

		
        public DateTime? BEDAT
        {
            get ;
            set ;
        }

		
        public DateTime? KDATB
        {
            get ;
            set ;
        }

		
        public DateTime? KDATE
        {
            get ;
            set ;
        }

		
        public DateTime BWBDT
        {
            get ;
            set ;
        }

		
        public DateTime ANGDT
        {
            get ;
            set ;
        }

		
        public DateTime? BNDDT
        {
            get ;
            set ;
        }

		
        public DateTime? GWLDT
        {
            get ;
            set ;
        }

		
        public string AUSNR
        {
            get ;
            set ;
        }

		
        public string ANGNR
        {
            get ;
            set ;
        }

		
        public DateTime? IHRAN
        {
            get ;
            set ;
        }

		
        public string VERKF
        {
            get ;
            set ;
        }

		
        public string TELF1
        {
            get ;
            set ;
        }

		
        public string KONNR
        {
            get ;
            set ;
        }

		
        public string WEAKT
        {
            get ;
            set ;
        }

		
        public string STCEG
        {
            get ;
            set ;
        }

		
        public string ABSGR
        {
            get ;
            set ;
        }

		
        public string ADDNR
        {
            get ;
            set ;
        }

		
        public string PROCSTAT
        {
            get ;
            set ;
        }

		
        public decimal? RLWRT
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

		public static MM_PurVouch Create()
        {
            return EF.DataPortal.Create<MM_PurVouch>();
        }

		public static MM_PurVouch Fetch(System.Linq.Expressions.Expression<Func<MM_PurVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_PurVouch>(exp,values);
            return EF.DataPortal.Fetch<MM_PurVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_PurVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_PurVouchs:ReadOnlyListBase<MM_PurVouchs,MM_PurVouch>
    {
        #region Factory Methods

        public static MM_PurVouchs Fetch()
        {
            return EF.DataPortal.Fetch<MM_PurVouchs>();
        }

		public static MM_PurVouchs Fetch(System.Linq.Expressions.Expression<Func<MM_PurVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_PurVouch>(exp,values);
            return EF.DataPortal.Fetch<MM_PurVouchs>(lambda);
		}

		public static MM_PurVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_PurVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_PurVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_PurVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_PurVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_PurVouch>(exp,values)});
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
