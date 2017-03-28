using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_FeeItemType))]
#if Dev
    [RunLocal]
#endif

	public class CG_FeeItemType:ReadOnlyBase<CG_FeeItemType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FeeItemTypeCode
        {
            get ;
            set ;
        }

		
        public string FeeItemTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_FeeItemType Create()
        {
            return EF.DataPortal.Create<CG_FeeItemType>();
        }

		public static CG_FeeItemType Fetch(System.Linq.Expressions.Expression<Func<CG_FeeItemType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_FeeItemType>(exp,values);
            return EF.DataPortal.Fetch<CG_FeeItemType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_FeeItemTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_FeeItemTypes:ReadOnlyListBase<CG_FeeItemTypes,CG_FeeItemType>
    {
        #region Factory Methods

        public static CG_FeeItemTypes Fetch()
        {
            return EF.DataPortal.Fetch<CG_FeeItemTypes>();
        }

		public static CG_FeeItemTypes Fetch(System.Linq.Expressions.Expression<Func<CG_FeeItemType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_FeeItemType>(exp,values);
            return EF.DataPortal.Fetch<CG_FeeItemTypes>(lambda);
		}

		public static CG_FeeItemTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_FeeItemTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_FeeItemTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_FeeItemType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_FeeItemTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_FeeItemType>(exp,values)});
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
