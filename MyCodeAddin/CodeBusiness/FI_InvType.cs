using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_InvType))]
#if Dev
    [RunLocal]
#endif

	public class FI_InvType:ReadOnlyBase<FI_InvType>
    {
        #region Business Methods

		
        public string InvTypCode
        {
            get ;
            set ;
        }

		
        public string InvTypeName
        {
            get ;
            set ;
        }

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public string TaxType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_InvType Create()
        {
            return EF.DataPortal.Create<FI_InvType>();
        }

		public static FI_InvType Fetch(System.Linq.Expressions.Expression<Func<FI_InvType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_InvType>(exp,values);
            return EF.DataPortal.Fetch<FI_InvType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_InvTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_InvTypes:ReadOnlyListBase<FI_InvTypes,FI_InvType>
    {
        #region Factory Methods

        public static FI_InvTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_InvTypes>();
        }

		public static FI_InvTypes Fetch(System.Linq.Expressions.Expression<Func<FI_InvType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_InvType>(exp,values);
            return EF.DataPortal.Fetch<FI_InvTypes>(lambda);
		}

		public static FI_InvTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_InvTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_InvTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_InvType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_InvTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_InvType>(exp,values)});
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
