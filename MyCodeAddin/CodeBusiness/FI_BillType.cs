using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BillType))]
#if Dev
    [RunLocal]
#endif

	public class FI_BillType:ReadOnlyBase<FI_BillType>
    {
        #region Business Methods

		
        public string BillTypeCode
        {
            get ;
            set ;
        }

		
        public string BillTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BillType Create()
        {
            return EF.DataPortal.Create<FI_BillType>();
        }

		public static FI_BillType Fetch(System.Linq.Expressions.Expression<Func<FI_BillType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BillType>(exp,values);
            return EF.DataPortal.Fetch<FI_BillType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BillTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BillTypes:ReadOnlyListBase<FI_BillTypes,FI_BillType>
    {
        #region Factory Methods

        public static FI_BillTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_BillTypes>();
        }

		public static FI_BillTypes Fetch(System.Linq.Expressions.Expression<Func<FI_BillType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BillType>(exp,values);
            return EF.DataPortal.Fetch<FI_BillTypes>(lambda);
		}

		public static FI_BillTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BillTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BillTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BillType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BillTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BillType>(exp,values)});
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
