using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_BillType))]
#if Dev
    [RunLocal]
#endif

	public class CG_BillType:ReadOnlyBase<CG_BillType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
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

		public static CG_BillType Create()
        {
            return EF.DataPortal.Create<CG_BillType>();
        }

		public static CG_BillType Fetch(System.Linq.Expressions.Expression<Func<CG_BillType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_BillType>(exp,values);
            return EF.DataPortal.Fetch<CG_BillType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_BillTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_BillTypes:ReadOnlyListBase<CG_BillTypes,CG_BillType>
    {
        #region Factory Methods

        public static CG_BillTypes Fetch()
        {
            return EF.DataPortal.Fetch<CG_BillTypes>();
        }

		public static CG_BillTypes Fetch(System.Linq.Expressions.Expression<Func<CG_BillType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_BillType>(exp,values);
            return EF.DataPortal.Fetch<CG_BillTypes>(lambda);
		}

		public static CG_BillTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_BillTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_BillTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_BillType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_BillTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_BillType>(exp,values)});
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
