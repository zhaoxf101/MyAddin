using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SociSec))]
#if Dev
    [RunLocal]
#endif

	public class HR_SociSec:ReadOnlyBase<HR_SociSec>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SociSecCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string SociSecItemCode
        {
            get ;
            set ;
        }

		
        public string SociSecItemName
        {
            get ;
            set ;
        }

		
        public decimal SociSecAmt
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public bool IsIncrease
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public int TaxPeriod
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string Staff
        {
            get ;
            set ;
        }

		
        public string UType
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SociSec Create()
        {
            return EF.DataPortal.Create<HR_SociSec>();
        }

		public static HR_SociSec Fetch(System.Linq.Expressions.Expression<Func<HR_SociSec, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSec>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSec>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SociSecs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SociSecs:ReadOnlyListBase<HR_SociSecs,HR_SociSec>
    {
        #region Factory Methods

        public static HR_SociSecs Fetch()
        {
            return EF.DataPortal.Fetch<HR_SociSecs>();
        }

		public static HR_SociSecs Fetch(System.Linq.Expressions.Expression<Func<HR_SociSec, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSec>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSecs>(lambda);
		}

		public static HR_SociSecs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SociSecs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SociSecs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SociSec, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SociSecs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SociSec>(exp,values)});
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
