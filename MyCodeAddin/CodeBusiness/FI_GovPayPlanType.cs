using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanType))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayPlanType:ReadOnlyBase<FI_GovPayPlanType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string GovPayPlanType
        {
            get ;
            set ;
        }

		
        public string GovPayPlanName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GovPayPlanType Create()
        {
            return EF.DataPortal.Create<FI_GovPayPlanType>();
        }

		public static FI_GovPayPlanType Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanType>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayPlanTypes:ReadOnlyListBase<FI_GovPayPlanTypes,FI_GovPayPlanType>
    {
        #region Factory Methods

        public static FI_GovPayPlanTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanTypes>();
        }

		public static FI_GovPayPlanTypes Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanType>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanTypes>(lambda);
		}

		public static FI_GovPayPlanTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayPlanTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayPlanType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayPlanType>(exp,values)});
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
