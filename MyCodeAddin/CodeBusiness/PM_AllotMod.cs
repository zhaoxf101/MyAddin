using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotMod))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotMod:ReadOnlyBase<PM_AllotMod>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotModCode
        {
            get ;
            set ;
        }

		
        public string AllotModName
        {
            get ;
            set ;
        }

		
        public string AllotTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsFixFee
        {
            get ;
            set ;
        }

		
        public decimal FixFeeAmt
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string CAccCode
        {
            get ;
            set ;
        }

		
        public string DAccCode
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static PM_AllotMod Create()
        {
            return EF.DataPortal.Create<PM_AllotMod>();
        }

		public static PM_AllotMod Fetch(System.Linq.Expressions.Expression<Func<PM_AllotMod, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotMod>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotMod>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotMods))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotMods:ReadOnlyListBase<PM_AllotMods,PM_AllotMod>
    {
        #region Factory Methods

        public static PM_AllotMods Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotMods>();
        }

		public static PM_AllotMods Fetch(System.Linq.Expressions.Expression<Func<PM_AllotMod, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotMod>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotMods>(lambda);
		}

		public static PM_AllotMods Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotMods>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotMods Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotMod, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotMods>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotMod>(exp,values)});
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
