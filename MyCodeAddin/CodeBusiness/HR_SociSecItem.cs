using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SociSecItem))]
#if Dev
    [RunLocal]
#endif

	public class HR_SociSecItem:ReadOnlyBase<HR_SociSecItem>
    {
        #region Business Methods

		
        public string Client
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

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SociSecItem Create()
        {
            return EF.DataPortal.Create<HR_SociSecItem>();
        }

		public static HR_SociSecItem Fetch(System.Linq.Expressions.Expression<Func<HR_SociSecItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSecItem>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSecItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SociSecItems))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SociSecItems:ReadOnlyListBase<HR_SociSecItems,HR_SociSecItem>
    {
        #region Factory Methods

        public static HR_SociSecItems Fetch()
        {
            return EF.DataPortal.Fetch<HR_SociSecItems>();
        }

		public static HR_SociSecItems Fetch(System.Linq.Expressions.Expression<Func<HR_SociSecItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SociSecItem>(exp,values);
            return EF.DataPortal.Fetch<HR_SociSecItems>(lambda);
		}

		public static HR_SociSecItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SociSecItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SociSecItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SociSecItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SociSecItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SociSecItem>(exp,values)});
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
