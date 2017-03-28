using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccBookType))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccBookType:ReadOnlyBase<FI_AccBookType>
    {
        #region Business Methods

		
        public string BookType
        {
            get ;
            set ;
        }

		
        public string BookName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_AccBookType Create()
        {
            return EF.DataPortal.Create<FI_AccBookType>();
        }

		public static FI_AccBookType Fetch(System.Linq.Expressions.Expression<Func<FI_AccBookType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccBookType>(exp,values);
            return EF.DataPortal.Fetch<FI_AccBookType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccBookTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccBookTypes:ReadOnlyListBase<FI_AccBookTypes,FI_AccBookType>
    {
        #region Factory Methods

        public static FI_AccBookTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccBookTypes>();
        }

		public static FI_AccBookTypes Fetch(System.Linq.Expressions.Expression<Func<FI_AccBookType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccBookType>(exp,values);
            return EF.DataPortal.Fetch<FI_AccBookTypes>(lambda);
		}

		public static FI_AccBookTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccBookTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccBookTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccBookType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccBookTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccBookType>(exp,values)});
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
