using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_ISBTypeCLT))]
#if Dev
    [RunLocal]
#endif

	public class UP_ISBTypeCLT:ReadOnlyBase<UP_ISBTypeCLT>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ISBType
        {
            get ;
            set ;
        }

		
        public Guid AccountId
        {
            get ;
            set ;
        }

		
        public bool NSendApi
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_ISBTypeCLT Create()
        {
            return EF.DataPortal.Create<UP_ISBTypeCLT>();
        }

		public static UP_ISBTypeCLT Fetch(System.Linq.Expressions.Expression<Func<UP_ISBTypeCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_ISBTypeCLT>(exp,values);
            return EF.DataPortal.Fetch<UP_ISBTypeCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_ISBTypeCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_ISBTypeCLTs:ReadOnlyListBase<UP_ISBTypeCLTs,UP_ISBTypeCLT>
    {
        #region Factory Methods

        public static UP_ISBTypeCLTs Fetch()
        {
            return EF.DataPortal.Fetch<UP_ISBTypeCLTs>();
        }

		public static UP_ISBTypeCLTs Fetch(System.Linq.Expressions.Expression<Func<UP_ISBTypeCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_ISBTypeCLT>(exp,values);
            return EF.DataPortal.Fetch<UP_ISBTypeCLTs>(lambda);
		}

		public static UP_ISBTypeCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_ISBTypeCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_ISBTypeCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_ISBTypeCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_ISBTypeCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_ISBTypeCLT>(exp,values)});
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
