using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_ExpEttItem))]
#if Dev
    [RunLocal]
#endif

	public class HR_ExpEttItem:ReadOnlyBase<HR_ExpEttItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EttItemCode
        {
            get ;
            set ;
        }

		
        public string EttItemName
        {
            get ;
            set ;
        }

		
        public string AccCode
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

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string ExpStatus
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public bool IsFund
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_ExpEttItem Create()
        {
            return EF.DataPortal.Create<HR_ExpEttItem>();
        }

		public static HR_ExpEttItem Fetch(System.Linq.Expressions.Expression<Func<HR_ExpEttItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpEttItem>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpEttItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_ExpEttItems))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_ExpEttItems:ReadOnlyListBase<HR_ExpEttItems,HR_ExpEttItem>
    {
        #region Factory Methods

        public static HR_ExpEttItems Fetch()
        {
            return EF.DataPortal.Fetch<HR_ExpEttItems>();
        }

		public static HR_ExpEttItems Fetch(System.Linq.Expressions.Expression<Func<HR_ExpEttItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpEttItem>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpEttItems>(lambda);
		}

		public static HR_ExpEttItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_ExpEttItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_ExpEttItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_ExpEttItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_ExpEttItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_ExpEttItem>(exp,values)});
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
