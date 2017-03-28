using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ProjCoCtrTypeAcc))]
#if Dev
    [RunLocal]
#endif

	public class FI_ProjCoCtrTypeAcc:ReadOnlyBase<FI_ProjCoCtrTypeAcc>
    {
        #region Business Methods

		
        public string Client
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

		
        public string CostCtrType
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ProjCoCtrTypeAcc Create()
        {
            return EF.DataPortal.Create<FI_ProjCoCtrTypeAcc>();
        }

		public static FI_ProjCoCtrTypeAcc Fetch(System.Linq.Expressions.Expression<Func<FI_ProjCoCtrTypeAcc, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ProjCoCtrTypeAcc>(exp,values);
            return EF.DataPortal.Fetch<FI_ProjCoCtrTypeAcc>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ProjCoCtrTypeAccs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ProjCoCtrTypeAccs:ReadOnlyListBase<FI_ProjCoCtrTypeAccs,FI_ProjCoCtrTypeAcc>
    {
        #region Factory Methods

        public static FI_ProjCoCtrTypeAccs Fetch()
        {
            return EF.DataPortal.Fetch<FI_ProjCoCtrTypeAccs>();
        }

		public static FI_ProjCoCtrTypeAccs Fetch(System.Linq.Expressions.Expression<Func<FI_ProjCoCtrTypeAcc, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ProjCoCtrTypeAcc>(exp,values);
            return EF.DataPortal.Fetch<FI_ProjCoCtrTypeAccs>(lambda);
		}

		public static FI_ProjCoCtrTypeAccs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ProjCoCtrTypeAccs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ProjCoCtrTypeAccs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ProjCoCtrTypeAcc, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ProjCoCtrTypeAccs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ProjCoCtrTypeAcc>(exp,values)});
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
