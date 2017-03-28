using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_DebitItem))]
#if Dev
    [RunLocal]
#endif

	public class HR_DebitItem:ReadOnlyBase<HR_DebitItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DebitItemCode
        {
            get ;
            set ;
        }

		
        public string DebitItemName
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_DebitItem Create()
        {
            return EF.DataPortal.Create<HR_DebitItem>();
        }

		public static HR_DebitItem Fetch(System.Linq.Expressions.Expression<Func<HR_DebitItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_DebitItem>(exp,values);
            return EF.DataPortal.Fetch<HR_DebitItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_DebitItems))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_DebitItems:ReadOnlyListBase<HR_DebitItems,HR_DebitItem>
    {
        #region Factory Methods

        public static HR_DebitItems Fetch()
        {
            return EF.DataPortal.Fetch<HR_DebitItems>();
        }

		public static HR_DebitItems Fetch(System.Linq.Expressions.Expression<Func<HR_DebitItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_DebitItem>(exp,values);
            return EF.DataPortal.Fetch<HR_DebitItems>(lambda);
		}

		public static HR_DebitItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_DebitItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_DebitItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_DebitItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_DebitItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_DebitItem>(exp,values)});
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
